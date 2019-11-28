using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IBadgeRulesRepository
    {
        Task<List<BadgesRule>> GetAllBadgeRules();
        Task<BadgesRule> GetBadgeRule(string id);
        Task<BadgesRule> UpdateBadgeRule(BadgesRule employee);
        Task<BadgesRule> AddBadgeRule(BadgesRule employee);

    }
}