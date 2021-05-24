using Holiday_Optimizer.APP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Optimizer.APP.Services
{
    public interface IHolidayService
    {
        Task<CountryReponse> GetCountryWithMostHolidays();
        MonthResponse GetMonthWithMostHolidays();
        Task<CountryReponse> GetCountryWithMostUniqueHolidays();
    }
}
