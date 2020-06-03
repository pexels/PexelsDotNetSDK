using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class ErrorResponse : Exception
    {
        public HttpStatusCode statusCode { get; set; }

        public ErrorResponse() { }

        public ErrorResponse(HttpStatusCode statusCode, string message) : base(message)
        {
            this.statusCode = statusCode;
        }
    }
}
