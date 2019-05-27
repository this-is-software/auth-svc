using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Hosting;
using Microsoft.Extensions.Logging;
using Xunit;
using Moq;
using SquadGoals.Api;
using ApiCallTests.TestUtilities;
using Microsoft.AspNetCore.Mvc;

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
                displayName = "Static Test User",
                id = 10001,
                pronouns = new Pronouns()
                {
                    Subject = "she",
                    Object = "her",
                    Possessive = "hers"
                }
            };
            var actual = ApiCall.GetUser(Http.CreateRequest(), mockLogger.Object) as JsonResult;
            
            Assert.Equal(expected, actual.Value);
        }
    }
}