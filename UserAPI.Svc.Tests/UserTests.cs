using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Hosting;
using ApiCallTests.TestUtilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using UserAPI.Svc;
using Xunit;

namespace ApiCallTests
{
    public class UserTests
    {
        private Mock<ILogger> mockLogger;

        public UserTests()
        {
            mockLogger = new Mock<ILogger>();
        }

        [Fact]
        public void UserTest()
        {
            var expected = new User()
            {
                DisplayName = "Static Test User",
                Id = 10001,
                Pronouns = new Pronouns()
                {
                    Subject = "she",
                    Object = "her",
                    Possessive = "hers",
                },
            };
            var actual = ApiCall.GetUser(Http.CreateRequest(), mockLogger.Object) as JsonResult;

            Assert.Equal(expected, actual.Value);
        }
    }
}
