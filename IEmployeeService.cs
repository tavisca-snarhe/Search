using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeService
    {
        Task<PagedResult<Employee>> GetPaginatedEmployees(string pageIdentifier,int pageSize);
        Task<Employee> GetEmployeeById(string id);
        Task<PagedResult<Employee>> GetEmployeeByName(string input);
        Task<List<Employee>> GetTopPerformersByPoint(int limit);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);

    }
}
