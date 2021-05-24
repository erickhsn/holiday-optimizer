using Holiday_Optimizer.APP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holiday_Optimizer.TEST.APP.ClientRequest
{
    public static class HolidayClientRequestStub
    {
        public static string CountryInfoStringNLStub()
        {
            return "{\"commonName\":\"Netherlands\",\"officialName\":\"Netherlands\",\"countryCode\":\"NL\",\"region\":\"Europe\"}";
        }
        public static string CountryHolidayStringNLStub()
        {
            return "[{\"date\":\"2021-01-01\",\"localName\":\"Nieuwjaarsdag\",\"name\":\"New Year's Day\",\"countryCode\":\"NL\",\"fixed\":true,\"global\":true,\"counties\":null,\"launchYear\":1967,\"types\":[\"Public\"]},{\"date\":\"2021-04-02\",\"localName\":\"Eerste Paasdag\",\"name\":\"Good Friday\",\"countryCode\":\"NL\",\"fixed\":false,\"global\":true,\"counties\":null,\"launchYear\":null,\"types\":[\"School\",\"Authorities\"]},{\"date\":\"2021-04-04\",\"localName\":\"Eerste Paasdag\",\"name\":\"Easter Sunday\",\"countryCode\":\"NL\",\"fixed\":false,\"global\":true,\"counties\":null,\"launchYear\":null,\"types\":[\"Public\"]},{\"date\":\"2021-04-05\",\"localName\":\"Tweede Paasdag\",\"name\":\"Easter Monday\",\"countryCode\":\"NL\",\"fixed\":false,\"global\":true,\"counties\":null,\"launchYear\":1642,\"types\":[\"Public\"]},{\"date\":\"2021-04-27\",\"localName\":\"Koningsdag\",\"name\":\"King's Day\",\"countryCode\":\"NL\",\"fixed\":true,\"global\":true,\"counties\":null,\"launchYear\":null,\"types\":[\"Public\"]},{\"date\":\"2021-05-05\",\"localName\":\"Bevrijdingsdag\",\"name\":\"Liberation Day\",\"countryCode\":\"NL\",\"fixed\":true,\"global\":true,\"counties\":null,\"launchYear\":1945,\"types\":[\"School\",\"Authorities\"]},{\"date\":\"2021-05-13\",\"localName\":\"Hemelvaartsdag\",\"name\":\"Ascension Day\",\"countryCode\":\"NL\",\"fixed\":false,\"global\":true,\"counties\":null,\"launchYear\":null,\"types\":[\"Public\"]},{\"date\":\"2021-05-24\",\"localName\":\"Pinksteren\",\"name\":\"Whit Monday\",\"countryCode\":\"NL\",\"fixed\":false,\"global\":true,\"counties\":null,\"launchYear\":null,\"types\":[\"Public\"]},{\"date\":\"2021-12-25\",\"localName\":\"Eerste Kerstdag\",\"name\":\"Christmas Day\",\"countryCode\":\"NL\",\"fixed\":true,\"global\":true,\"counties\":null,\"launchYear\":null,\"types\":[\"Public\"]},{\"date\":\"2021-12-26\",\"localName\":\"Tweede Kerstdag\",\"name\":\"St. Stephen's Day\",\"countryCode\":\"NL\",\"fixed\":true,\"global\":true,\"counties\":null,\"launchYear\":null,\"types\":[\"Public\"]}]";
        }
        public static ICollection<HolidayResponse>[] AllCountryHolidaysStub()
        {
            return new ICollection<HolidayResponse>[]
            {
                new List<HolidayResponse>()
                {
                    new HolidayResponse()
                    {
                        Date = new DateTime(2021,01,01),
                        LocalName = "Año Nuevo",
                        Name = "New Year's Day",
                        CountryCode = "AR",
                        Fixed = true,
                        Global = true,
                        Counties = null,
                        LaunchYear = null,
                        Types = new List<string>() { "Public" }
                    }
                },
                new List<HolidayResponse>()
                {
                    new HolidayResponse()
                    {
                        Date = new DateTime(2021,01,01),
                        LocalName = "Año Nuevo",
                        Name = "New Year's Day",
                        CountryCode = "ES",
                        Fixed = true,
                        Global = true,
                        Counties = null,
                        LaunchYear = 1967,
                        Types = new List<string>() { "Public" }
                    },
                    new HolidayResponse()
                    {
                        Date = new DateTime(2021,02,28),
                        LocalName = "Día de Andalucía",
                        Name = "Regional Holiday",
                        CountryCode = "ES",
                        Fixed = true,
                        Global = false,
                        Counties = new List<string>() { "ES-AN" },
                        LaunchYear = null,
                        Types = new List<string>() { "Public" }
                    }
                },
                new List<HolidayResponse>()
                {
                    new HolidayResponse()
                    {
                        Date = new DateTime(2021,01,01),
                        LocalName = "Confraternização Universal",
                        Name = "New Year's Day",
                        CountryCode = "BR",
                        Fixed = true,
                        Global = true,
                        Counties = null,
                        LaunchYear = null,
                        Types = new List<string>() { "Public" }
                    },
                    new HolidayResponse()
                    {
                        Date = new DateTime(2021,04,02),
                        LocalName = "Sexta feira Santa",
                        Name = "Good Friday",
                        CountryCode = "BR",
                        Fixed = false,
                        Global = true,
                        Counties = null,
                        LaunchYear = null,
                        Types = new List<string>() { "Public" }
                    }
                },
                new List<HolidayResponse>()
            {
                new HolidayResponse()
                {
                    Date = new DateTime(2021,01,01),
                    LocalName = "Nieuwjaarsdag",
                    Name = "New Year's Day",
                    CountryCode = "NL",
                    Fixed = true,
                    Global = true,
                    Counties = null,
                    LaunchYear = null,
                    Types = new List<string>() { "Public" }
                },
                new HolidayResponse()
                {
                        Date = new DateTime(2021,04,02),
                        LocalName = "Eerste Paasdag",
                        Name = "Good Friday",
                        CountryCode = "NL",
                        Fixed = false,
                        Global = true,
                        Counties = null,
                        LaunchYear = null,
                        Types = new List<string>() { "Public" }
                    },
                    new HolidayResponse()
                    {
                        Date = new DateTime(2021,04,02),
                        LocalName = "Eerste Paasdag",
                        Name = "Easter Sunday",
                        CountryCode = "NL",
                        Fixed = false,
                        Global = true,
                        Counties = null,
                        LaunchYear = null,
                        Types = new List<string>() { "Public" }
                    }
                }
            };
        }
        
        public static CountryReponse CountryResponseNLStub()
        {
            return new CountryReponse()
            {
                CommonName = "Netherlands",
                OfficialName = "Netherlands",
                CountryCode = "NL",
                Region = "Europe"
            };
        }

        public static CountryReponse CountryResponseESStub()
        {
            return new CountryReponse()
            {
                CommonName = "Spain",
                OfficialName = "Kingdom of Spain",
                CountryCode = "ES",
                Region = "Europe"
            };
        }
    }
}
