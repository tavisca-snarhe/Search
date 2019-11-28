using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeePlatformMappingRepository
    {
        Task<EmployeePlatformMapping> AddMapping(EmployeePlatformMapping employeePlatformMapping);
        Task<List<EmployeePlatformMapping>> AddMappings(List<EmployeePlatformMapping> employeePlatformMappings);
        Task<EmployeePlatformMapping> GetMapping(string employeeId);
        Task<bool> DeleteMapping(string employeeId);
        Task<EmployeePlatformMapping> UpdateMapping(EmployeePlatformMapping employeePlatformMapping);
        Task<List<EmployeePlatformMapping>> GetAllMappings(string platform);
        Task<EmployeePlatformMapping> GetMapping(string platform, string platformIdentifier);
        Task<List<EmployeePlatformMapping>> GetAllMappings();
    }
}