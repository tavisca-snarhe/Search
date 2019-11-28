using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IGitHubService
    {
        Task<GitHubActivity> AddActivityAsync(GitHubActivity githubActivity);
    }
}