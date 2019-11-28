using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeBadgeService
    {
        Task<Dictionary<string, List<EmployeeBadgeMapping>>> GetTopPerformersByBadgeType(int limit);
        Task<List<EmployeeBadgeMapping>> GetRecentWinners(int limit);
    }
}