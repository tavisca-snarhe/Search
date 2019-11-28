using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> GetEmployee(string employeeId);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(string employeeId);
        Task<List<Employee>> GetEmployeeByFirstName(string firstName);
        Task<List<Employee>> GetEmployeeByLastName(string lastName);
        Task<List<Employee>> GetEmployeesByTribe(string tribeName);
        Task<List<Employee>> GetAllEmployees();
        Task<PagedResult<Employee>> GetPaginatedEmployee(int number, string pageStatus);
        Task<List<Employee>> GetTopPerformerByPoint(int limit);
    }
}
