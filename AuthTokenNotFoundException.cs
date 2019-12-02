using System;

namespace Tavisca.Applause.Exceptions
{
    public class AuthTokenNotFoundException : Exception
    {
        public AuthTokenNotFoundException()
        {
        }

        public AuthTokenNotFoundException(string message) : base(message)
        {
        }

        public AuthTokenNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
