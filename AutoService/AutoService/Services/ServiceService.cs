using AutoService.Controllers;
using AutoService.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Services
{
    internal static class ServiceService
    {
        public static bool Create(ServiceDTO? serviceDTO)
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

        public static ServiceModel? Retrieve(int serviceID) => ServiceController.RetrieveService(serviceID);
        public static List<ServiceModel> RetrieveAll() => ServiceController.RetrieveServices();

        public static bool Update(int serviceID, ServiceDTO? serviceDTO)
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

        public static bool Delete(int serviceID) => ServiceController.DeleteService(serviceID);
    }
}
