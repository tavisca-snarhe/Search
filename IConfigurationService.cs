using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IConfigurationService
    {
        Task<Configuration> GetConfiguration(string key);
        Task<Configuration> AddConfiguration(Configuration configuration);
        Task<Configuration> UpdateConfiguration(Configuration configuration);
        Task<bool> DeleteConfiguration(string key);
    }
}
