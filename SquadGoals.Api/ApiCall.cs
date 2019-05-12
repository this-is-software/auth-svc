using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace SquadGoals.Api
{
    public static class ApiCall
    {
        [FunctionName("Status")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "status")]
            HttpRequest req, ILogger log)
        {
            log.LogInformation("Status - HTTP trigger");
            
            return new OkObjectResult("Connected to API, status ok");
        }
    }
}