using AutoService.Attributes;
using AutoService.Controllers;
using AutoService.Models.Service;

namespace AutoService.Services
{
    public interface IServiceService
    {
        [AuthRequired, AdminOnly] bool Create(ServiceDTO? serviceDTO);
        ServiceModel? Retrieve(int serviceID);
        List<ServiceModel> RetrieveAll();
        Dictionary<string, int> RetrieveAllNames();
        [AuthRequired, AdminOnly] bool Update(int serviceID, ServiceDTO? serviceDTO);
        [AuthRequired, AdminOnly] bool Delete(int serviceID);
    }

    public class ServiceService : IServiceService
    {
        private ServiceService() { }

        public static IServiceService Instance = AuthProxy<IServiceService>.Create(new ServiceService());

        public bool Create(ServiceDTO? serviceDTO)
        {
            if (serviceDTO == null) return false;

            if (String.IsNullOrEmpty(serviceDTO.Name) ||
                String.IsNullOrEmpty(serviceDTO.Description) ||
                serviceDTO.Duration == null ||
                serviceDTO.Price == null)
                return false;

            bool status = ServiceController.CreateService(serviceDTO);
            return status;
        }
        public ServiceModel? Retrieve(int serviceID) => ServiceController.RetrieveService(serviceID);
        public List<ServiceModel> RetrieveAll() => ServiceController.RetrieveServices();
        public Dictionary<string, int> RetrieveAllNames() => ServiceController.RetrieveServicesNames();
        public bool Update(int serviceID, ServiceDTO? serviceDTO)
        {
            if (serviceDTO == null) return false;

            if (String.IsNullOrEmpty(serviceDTO.Name) ||
                String.IsNullOrEmpty(serviceDTO.Description) ||
                serviceDTO.Duration == null ||
                serviceDTO.Price == null)
                return false;

            bool status = ServiceController.UpdateService(serviceID, serviceDTO);
            return status;
        }
        public bool Delete(int serviceID) => ServiceController.DeleteService(serviceID);
    }
}