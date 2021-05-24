using Holiday_Optimizer.APP.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holiday_Optimizer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolidayController : ControllerBase
    {

        private readonly ILogger<HolidayController> _logger;
        private readonly IHolidayService _holidayService;

        public HolidayController(ILogger<HolidayController> logger, IHolidayService holidayService)
        {
            _logger = logger;
            _holidayService = holidayService;
        }


        /// <summary>
        /// Returns the country with most holidays this year
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [HttpGet]
        [Route("CountryWithMostHolidays")]
        public async Task<IActionResult> GetCountryWithMostHolidays()
        {
            try
            {
                var result = await _holidayService.GetCountryWithMostHolidays();

                return Ok(result);
            }
            catch(ArgumentException e)
            {
                return StatusCode(503, e.Message);
            }
        }

        /// <summary>
        /// Returns the month with most holidays this year
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [HttpGet]
        [Route("MonthWithMostHolidays")]
        public IActionResult GetMonthWithMostHolidays()
        {
            try
            {
                var result = _holidayService.GetMonthWithMostHolidays();

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode(503, e.Message);
            }
        }

        /// <summary>
        /// Returns the country with most unique holidays this year
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [HttpGet]
        [Route("CountryWithMostUniqueHolidays")]
        public async Task<IActionResult> GetCountryWithMostUniqueHolidays()
        {
            try
            {
                var result = await _holidayService.GetCountryWithMostUniqueHolidays();

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode(503, e.Message);
            }
        }
    }
}
