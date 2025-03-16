using AutoService.Services;
using System.Reflection;

namespace AutoService.Attributes
{
    public class AuthProxy<T> : DispatchProxy
    {
        private T? _target;

        public static T Create(T target)
        {
            object? proxy = Create<T, AuthProxy<T>>();
            if (proxy == null) throw new Exception();
            ((AuthProxy<T>)proxy)._target = target;
            return (T)proxy;
        }

        private void ValidateAuth(MethodInfo? targetMethod)
        {
            var authAttribute = targetMethod?.GetCustomAttribute<AuthRequiredAttribute>();
            if (authAttribute == null) return;

            if (UserService.IsAuthenticated) return;
            string error = $"Access denied: {targetMethod?.Name} requires authorization privileges!";
            Console.WriteLine(error);
            throw new Exception(error);
        }

        private void ValidateAdmin(MethodInfo? targetMethod)
        {
            var adminAttribute = targetMethod?.GetCustomAttribute<AdminOnlyAttribute>();
            if (adminAttribute == null) return;

            if (UserService.IsAdmin) return;
            string error = $"Access denied: {targetMethod?.Name} requires admin privileges!";
            Console.WriteLine(error);
            throw new Exception(error);
        }

        private void ValidateSelf(MethodInfo? targetMethod, object?[]? args)
        {
            var selfAttribute = targetMethod?.GetCustomAttribute<SelfOnlyAttribute>();
            if (selfAttribute == null) return;

            string idKey = selfAttribute.idKey;
            bool orAdmin = selfAttribute.orAdmin;

            if (orAdmin && UserService.IsAdmin) return;

            ParameterInfo[] parameters = targetMethod?.GetParameters() ?? [];

            int paramIndex = Array.FindIndex(parameters, p => p.Name == idKey);
            if (paramIndex == -1 || args == null || args.Length <= paramIndex)
                throw new ArgumentException($"Invalid self-check: Parameter '{idKey}' not found in method {targetMethod?.Name}.");

            object? argumentValue = args[paramIndex];

            if (argumentValue == null || !argumentValue.Equals(UserService.User?.ID))
            {
                string error = $"Access denied: {targetMethod?.Name} can only be accessed by the owner (ID: {UserService.User?.ID}).";
                Console.WriteLine(error);
                throw new UnauthorizedAccessException(error);
            }
        }

        protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
        {
            if (targetMethod == null) return false;

            if (targetMethod.GetCustomAttribute<AuthRequiredAttribute>() != null)
                ValidateAuth(targetMethod);


            ValidateAdmin(targetMethod);
            ValidateSelf(targetMethod, args);

            return targetMethod.Invoke(_target, args);
        }
    }
}
