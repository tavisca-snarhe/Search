using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeRewardsStatsRepository
    {
        Task<EmployeeRewardsStats> GetEmployeeRewards(string employeeId);
        Task<List<EmployeeRewardsStats>> GetEmployeeRewards();
        Task<List<EmployeeRewardsStats>> GetRewardsByBadgeType(string badgeType);
        Task AddPoints(string employeeId,long points);
        Task UpdateBadgeCounter(string employeeId, string existingBadgeType, CounterOperation couterOperation,int numberOfBadges);
    }
}