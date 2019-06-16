using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Hosting;
using Microsoft.AspNetCore.Http;

namespace ApiCallTests.TestUtilities
{
    public static class Http
    {
        public static HttpRequest CreateRequest(string json)
        {
            var uri = new Uri("https://localhost");
            var body = new StringContent(json, Encoding.UTF8, "application/json");
            var request = new MockHttpRequest
            {
                Method = "Post",
                ContentType = "application/json",
                Body = new MemoryStream(Encoding.UTF8.GetBytes(json)),
            };

            return request;
        }

        public static HttpRequest CreateRequest()
        {
            var uri = new Uri("https://localhost");
            var request = new MockHttpRequest
            {
                Method = "Get",
            };

            return request;
        }
    }
}