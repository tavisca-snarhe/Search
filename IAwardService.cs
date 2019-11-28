using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IAwardService
    {
        Task<Award> AddAward(Award award);
        Task<Award> GetAward(string name);
        Task<List<Award>> GetAllAwards();
        Task<bool> DeleteAward(string name);
        Task<Award> UpdateAward(Award award);
    }
}
