using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController(ILoggerManager logger) : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            logger.LogInfo("Logger Message from controller: LogInfo");
            logger.LogDebug("Logger Message from controller: LogDebug");
            logger.LogWarn("Logger Message from controller: LogWarn");
            logger.LogError("Logger Message from controller: LogError");

            return ["Val 1", "Val2"];
        }
    }
}
