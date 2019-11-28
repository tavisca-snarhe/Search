using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeActivityService
    {
        Task<PagedResult<EmployeeActivity>> GetActivityByEmployeeId(string id, string pageState, int pageSize);

    }
}
