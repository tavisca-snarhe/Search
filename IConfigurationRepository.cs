using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IConfigurationRepository
    {
        Task<Configuration> AddConfiguration(Configuration configuration);
        Task<Configuration> GetConfiguration(string key);
        Task<Configuration> UpdateConfiguration(Configuration configuration);
        Task<bool> DeleteConfiguration(string key);
        Task<List<Configuration>> GetAllConfigurations();
    }
}
