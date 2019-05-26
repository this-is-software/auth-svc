using System.Collections.Generic;
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
            
            var pronouns = new Dictionary<string, string>();
            pronouns.Add("subject", "she");
            pronouns.Add("object", "her");
            pronouns.Add("possesive", "hers");

            var user = new User()
            {
                displayName = "Static Test User",
                id = 10001,
                pronouns = pronouns
            };
            
            return new JsonResult(user);
        }
    }

    public struct User
    {
        public int id;
        public string displayName;
        public Dictionary<string, string> pronouns;
    }
}