using Holiday_Optimizer.APP.ClientRequest;
using Holiday_Optimizer.APP.Services;
using Holiday_Optimizer.TEST.APP.ClientRequest;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Holiday_Optimizer.TEST.APP.Services
{
    public class HolidayServiceTest
    {
        [Fact]
        public void GetCountryWithMostHolidays_ReturnsCorrect()
        {
            var codeExpected = "NL";
            var holidayClientRequestMock = new Mock<IHolidayClientRequest>();
            holidayClientRequestMock.Setup(h => h.GetAllCountryHolidays()).Returns(HolidayClientRequestStub.AllCountryHolidaysStub());
            holidayClientRequestMock.Setup(h => h.GetCountryInfo(codeExpected)).Returns(HolidayClientRequestStub.CountryResponseNLStub());

            var service = new HolidayService(holidayClientRequestMock.Object);
            var result = service.GetCountryWithMostHolidays();

            Assert.Equal("Netherlands", result.Result.OfficialName);
        }

        [Fact]
        public void GetMonthWithMostHolidays_ReturnsCorrect()
        {
            var holidayClientRequestMock = new Mock<IHolidayClientRequest>();
            holidayClientRequestMock.Setup(h => h.GetAllCountryHolidays()).Returns(HolidayClientRequestStub.AllCountryHolidaysStub());

            var service = new HolidayService(holidayClientRequestMock.Object);
            var result = service.GetMonthWithMostHolidays();

            Assert.Equal("April", result.Month);
        }

        [Fact]
        public void GetCountryWithMostUniqueHolidays_ReturnsCorrect()
        {
            var codeExpected = "ES";
            var holidayClientRequestMock = new Mock<IHolidayClientRequest>();
            holidayClientRequestMock.Setup(h => h.GetAllCountryHolidays()).Returns(HolidayClientRequestStub.AllCountryHolidaysStub());
            holidayClientRequestMock.Setup(h => h.GetCountryInfo(codeExpected)).Returns(HolidayClientRequestStub.CountryResponseESStub());

            var service = new HolidayService(holidayClientRequestMock.Object);
            var result = service.GetCountryWithMostUniqueHolidays();

            Assert.Equal("Kingdom of Spain", result.Result.OfficialName);
        }
    }
}
