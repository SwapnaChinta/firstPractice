using EaFramework.Config;
using EaFramework.Driver;
using OpenQA.Selenium;

namespace EaApplicationTest
{
    public class UnitTest1
    {
        private IDriverFixture _driverFixture;
        

        public UnitTest1()
        {
            var _testSettings = new TestSettings()
            { 
                BrowserType = DriverFixture.BrowserType.Chrome,
                ApplicationUrl = new Uri("http://localhost:8000"),
            };

            _driverFixture = new DriverFixture(_testSettings);   
        }

        [Fact]
        public void Test1()
        {

        }
    }
}