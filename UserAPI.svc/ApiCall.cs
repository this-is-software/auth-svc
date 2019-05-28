using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace UserAPI.svc
{
    public static class ApiCall
    {
        [FunctionName("Status")]
        public static IActionResult GetStatus(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "status")]
            HttpRequest req, ILogger log)
        {
            log.LogInformation("Status - HTTP trigger");
            
            return new OkObjectResult("Connected to API, status ok");
        }
        
        [FunctionName("User")]
        public static IActionResult GetUser(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "user")]
            HttpRequest req, ILogger log)
        {
            log.LogInformation("Status - HTTP trigger");

            var user = new User()
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
            
            return new JsonResult(user);
        }
    }
}