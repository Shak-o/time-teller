using Microsoft.AspNetCore.Mvc;
using TimeApi.Services;

namespace TimeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly ILogger<TimeController> _logger;
        private readonly ITimeService _timeService;

        public TimeController(ILogger<TimeController> logger, ITimeService timeService)
        {
            _logger = logger;
            _timeService = timeService;
        }

        [HttpGet("TbilisiTime")]
        public string GetTime()
        {
            return _timeService.GetTime();
        }
    }
}