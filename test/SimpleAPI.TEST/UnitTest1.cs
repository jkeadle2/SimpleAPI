using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();
        
        [Fact]
        public void Test1()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Way to Hot", returnValue.Value);

        }
    }
}
