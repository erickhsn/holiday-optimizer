using Holiday_Optimizer.APP.ClientRequest;
using Holiday_Optimizer.APP.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Holiday_Optimizer.APP.Services
{
    public class HolidayService : IHolidayService
    {
        private readonly IHolidayClientRequest _holidayClientRequest;

        private static readonly string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" } ;

        public HolidayService(IHolidayClientRequest holidayClientRequest)
        {
            _holidayClientRequest = holidayClientRequest;
        }

        public async Task<CountryReponse> GetCountryWithMostHolidays()
        {

            var holidays = _holidayClientRequest.GetAllCountryHolidays();
            var biggest = holidays.OrderByDescending(x => x.Count);

            var countryInfo = _holidayClientRequest.GetCountryInfo(biggest.FirstOrDefault().FirstOrDefault().CountryCode);

            return countryInfo;
        }

        public MonthResponse GetMonthWithMostHolidays()
        {
            var holidays = _holidayClientRequest.GetAllCountryHolidays();
            int max = 0;
            int month = 0;
            foreach (var holiday in holidays)
            {
                var biggest = from x in holiday
                              group x by x.Date.Month into g
                              let count = g.Count()
                              orderby count descending
                              select new { Value = g.Key, Count = count };
                if (biggest.FirstOrDefault().Count > max)
                {
                    max = biggest.FirstOrDefault().Count;
                    month = biggest.FirstOrDefault().Value;
                }
            }
            var result = new MonthResponse() { Month = months[month - 1] };
            return result;
        }

        public async Task<CountryReponse> GetCountryWithMostUniqueHolidays()
        {
            var holidays = _holidayClientRequest.GetAllCountryHolidays();

            holidays = (from a in holidays
                        let x = a.Where(x => x.Global == false)
                        select x.ToList()).ToArray();
            var biggest = holidays.OrderByDescending(x => x.Count);

            var countryInfo = _holidayClientRequest.GetCountryInfo(biggest.FirstOrDefault().FirstOrDefault().CountryCode);

            return countryInfo;
        }

    }
}
