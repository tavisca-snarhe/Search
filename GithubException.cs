using System;

namespace Tavisca.Applause
{
    public class GithubException : Exception
    {
        public GithubException()
        {
        }

        public GithubException(string message) : base(message)
        {
        }

        public GithubException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}