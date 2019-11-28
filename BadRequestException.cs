using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Tavisca.Applause
{
    public class BadRequestException : BaseApplicationException
    {
        public BadRequestException(string message) : base(message)
        {
        }

        public BadRequestException(string errorMessage, HttpStatusCode httpStatusCode=HttpStatusCode.BadRequest, List<Info> info = null) : base(errorMessage, httpStatusCode, info)
        {
        }
    }
}
