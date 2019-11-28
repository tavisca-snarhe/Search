namespace Tavisca.Applause
{
    public abstract class GitHubActivity
    {
        public abstract string ActivityName { get; }
        public abstract GitHubUser User { get; set; }
    }
}