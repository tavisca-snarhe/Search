using System.Collections.Generic;
using System.Net;

namespace Tavisca.Applause
{
    public class SessionExpiredException : BaseApplicationException
    {
        public SessionExpiredException(string message) : base(message)
        {
        }

        public SessionExpiredException(string errorMessage, HttpStatusCode httpStatusCode, List<Info> info = null) : base(errorMessage, httpStatusCode, info)
        {
        }
    }
}