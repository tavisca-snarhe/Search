using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IPlatformRepository
    {
        Task<Platform> AddPlatform(Platform platform);
        Task<Platform> GetPlatformByName(string name);
        Task<Platform> UpdatePlatform(Platform platform);
        Task<bool> DeletePlatform(string name);
        Task<List<Platform>> GetAllPlatforms();
    }
}
