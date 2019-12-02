using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Tavisca.Applause
{
    public class ErrorInfo
    {
        public HttpStatusCode HttpStatusCode { get; }
        public string ErrorMessage { get; set; }
        public List<Info> Info { get; private set; }

        public ErrorInfo(string message, HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentNullException(nameof(message));
            ErrorMessage = message;
            HttpStatusCode = httpStatusCode;
            Info = new List<Info>();
        }

    }
}


