using Holiday_Optimizer.APP.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Holiday_Optimizer.APP.ClientRequest
{
    public class HolidayClientRequest : HttpClientRequest, IHolidayClientRequest
    {
        private static readonly string[] countrys = { "AD", "AR", "AT", "AU", "AX",
            "BB", "BE", "BG", "BO", "BR", "BS", "BW", "BY", "BZ", "CA", "CH", "CL", "CN", "CO", "CR", "CU", "CY",
            "CZ", "DE", "DK", "DO", "EC", "EE", "EG", "ES", "FI", "FO", "FR", "GA", "GB", "GD", "GL", "GR", "GT",
            "GY", "HN", "HR", "HT", "HU", "IE", "IM", "IS", "IT", "JE", "JM", "LI", "LS", "LT", "LU", "LV", "MA",
            "MC", "MD", "MG", "MK", "MT", "MX", "MZ", "NA", "NI", "NL", "NO", "NZ", "PA", "PE", "PL", "PR",
            "PT", "PY", "RO", "RS", "RU", "SE", "SI", "SJ", "SK", "SM", "SR", "SV", "TN", "TR", "UA", "US", "UY",
            "VA", "VE", "ZA"};



        public HolidayClientRequest(HttpClient httpClient): base(httpClient)
        {
        }

        public List<HolidayResponse> GetCountryHolliday(string year, string country)
        {
            var holiday = JsonConvert.DeserializeObject<List<HolidayResponse>>(GetRequest($"publicholidays/{year}/{country}").Result);

            return holiday;
        }

        public CountryReponse GetCountryInfo(string code)
        {
            var country = JsonConvert.DeserializeObject<CountryReponse>(GetRequest($"CountryInfo/{code}").Result);

            return country;
        }

        public ICollection<HolidayResponse>[] GetAllCountryHolidays()
        {
            ICollection<HolidayResponse>[] holidays = new ICollection<HolidayResponse>[countrys.Length];
            var index = 0;
            foreach (string country in countrys)
            {
                holidays[index] = GetCountryHolliday("2021", country);
                index++;

                // Used to prevent ddos in real tests
                //Thread.Sleep(500);
            }
            return holidays;
        }
    }
}
