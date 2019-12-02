using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Tavisca.Applause
{
    public class BaseApplicationException : Exception
    {
        public string ErrorMessage { get; }
        public HttpStatusCode HttpStatusCode { get; }

        public List<Info> Info = new List<Info>();

        public BaseApplicationException(string errorMessage, HttpStatusCode httpStatusCode, List<Info> info = null) : base(errorMessage)
        {
            ErrorMessage = errorMessage;
            HttpStatusCode = httpStatusCode;
            if (info != null)
                Info.AddRange(info);
        }

        public BaseApplicationException(string message) : base(message)
        {
            ErrorMessage = message;
        }

    }
}
