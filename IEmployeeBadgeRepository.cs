using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeBadgeRepository
    {
        Task<EmployeeBadge> AddAsync(EmployeeBadge employeeBadge);
        Task<List<EmployeeBadge>> GetAsync(string employeeId);
        Task<bool> DeleteAsync(EmployeeBadge employeeBadge);
        Task<EmployeeBadge> UpdateAsync(EmployeeBadge employeeBadge);
        Task<List<EmployeeBadge>> GetAsync(string badgeType, int limit);
    }
}