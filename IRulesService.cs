using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IRulesService
    {
        Task<List<PlatformRule>> GetPlatformRules();
        Task<List<BadgesRule>> GetBadgeRules();

    }
}
