using Holiday_Optimizer.APP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Optimizer.APP.ClientRequest
{
    public interface IHolidayClientRequest
    {
        public List<HolidayResponse> GetCountryHolliday(string year, string country);
        public CountryReponse GetCountryInfo(string code);
        public ICollection<HolidayResponse>[] GetAllCountryHolidays();
    }
}
