using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyTestDateTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateTimeController : ControllerBase
    {

        [HttpGet("day/{start}/{end}/{timeFrame?}")]
        public int days(DateTimeOffset start, DateTimeOffset end, TimeFrame? timeFrame = null)
        {
            return DateTimeUtility.days(start, end, timeFrame);
        }

        [HttpGet("weekdays/{start}/{end}")]
        public int WeekDays(DateTimeOffset start, DateTimeOffset end)
        {
            return DateTimeUtility.WeekDays(start, end);
        }

        [HttpGet("weeks/{start}/{end}")]
        public int Weeks(DateTimeOffset start, DateTimeOffset end)
        {
            return DateTimeUtility.Weeks(start, end);
        }
    }
}