using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Examen.API.Proveedores
{
    public class ProvedorFunction
    {
        private readonly ILogger<ProvedorFunction> _logger;

        public ProvedorFunction(ILogger<ProvedorFunction> logger)
        {
            _logger = logger;
        }

        [Function("ProvedorFunction")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
