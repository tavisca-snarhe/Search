using Newtonsoft.Json;

namespace Tavisca.Applause
{
    public class GitHubUser
    {
        [JsonProperty(PropertyName = "login")]
        public string Username { get; set; }
    }
}