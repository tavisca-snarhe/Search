using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IGithubStatisticsService
    {
        Task<GithubStatistics> GetPRStatiticsAsync(string date);
    }
}
