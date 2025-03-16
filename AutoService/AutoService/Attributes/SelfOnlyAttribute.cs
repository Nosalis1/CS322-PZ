namespace AutoService.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class SelfOnlyAttribute : Attribute
    {
        public readonly string idKey;
        public readonly bool orAdmin;

        public SelfOnlyAttribute(string idKey = "id", bool orAdmin = false)
        {
            this.idKey = idKey;
            this.orAdmin = orAdmin;
        }
    }
}