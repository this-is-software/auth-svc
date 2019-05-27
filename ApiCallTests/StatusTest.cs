using System.Web.Http.Results;
using ApiCallTests.TestUtilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using SquadGoals.Api;

namespace ApiCallTests
{
    public class StatusTest
    {
        private Mock<ILogger> mockLogger;
        
        public StatusTest()
        {
            mockLogger = new Mock<ILogger>();
        }
        
        [Fact]
        public void GetStatusTest()
        {
            Assert.Equal("Connected to API, status ok", ((OkObjectResult)ApiCall.GetStatus(Http.CreateRequest(), mockLogger.Object)).Value);
        }
    }
}