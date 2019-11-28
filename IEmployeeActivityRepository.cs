using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeActivityRepository
    {
        Task<EmployeeActivity> AddActivity(EmployeeActivity employeeActivity);
        Task<PagedResult<EmployeeActivity>> GetActivities(string employeeId, int pageSize, PaginationState<MonthYearAdditionalParameters> paginationParameters);
    }
}
