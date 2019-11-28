using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IBadgeService
    {
        Task<Badge> AddBadge(Badge badge);
        Task<Badge> UpdateBadge(Badge badge);
        Task<Badge> GetBadge(string type);
        Task<List<Badge>> GetAllBadges();
        Task<bool> DeleteBadge(string type);
    }
}
