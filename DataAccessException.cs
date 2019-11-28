using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Tavisca.Applause
{
    public class DataAccessException : BaseApplicationException
    {
        public DataAccessException(string message) : base(message)
        {
        }

        public DataAccessException(string errorMessage, HttpStatusCode httpStatusCode, List<Info> info = null) : base(errorMessage, httpStatusCode, info)
        {
        }
    }
}
