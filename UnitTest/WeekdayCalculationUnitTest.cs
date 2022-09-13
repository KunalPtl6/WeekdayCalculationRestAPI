using Microsoft.AspNetCore.Mvc;
using WeekdayCalculationRestAPI.Controllers;
using WeekdayCalculationRestAPI.Modal;
using Xunit;

namespace WeekdayCalculationRestAPI.UnitTest
{
    public class WeekdayCalculationUnitTest
    {
        private readonly WeekdayCalculationController _controller;
        public WeekdayCalculationUnitTest()
        {
            _controller = new WeekdayCalculationController();
        }

        [Fact]
        public async Task GetWeekdayFromCurrentDate()
        {
            // Act
            var okResult = await _controller.GetWeekdayFromCurrentDate();
            // Assert
            Assert.NotNull(okResult);
        }

        [Fact]
        public async Task GetWeekdayFromInputDate()
        {
            //input
            string inputDate = "09/17/2022";
            // Act
            var okResult = await _controller.GetWeekdayFromInputDate(inputDate);
            // Assert
            Assert.NotNull(okResult);
        }
    }
}