using System;

namespace WebApplication
{
    public class MyHttpException : Exception
    {
        public MyHttpException(int statusCode)
            : base($"Status code set to {statusCode}")
        {
            HttpStatusCode = statusCode;
        }

        public int HttpStatusCode { get; }
    }
}