using EaFramework.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace EaFramework.Driver
{
    public interface IDriverFixture
    {
        IWebDriver Driver { get; }
    }

    public class DriverFixture : IDriverFixture
    {
        public IWebDriver Driver { get; }

        public DriverFixture(TestSettings testSettings)
        {
            Driver = GetWebDriver(testSettings.BrowserType);
            Driver.Navigate().GoToUrl(testSettings.ApplicationUrl);
        }

        private IWebDriver GetWebDriver(BrowserType browserType)
        {
            return browserType switch
            {
                BrowserType.Chrome => new ChromeDriver(),
                BrowserType.Firefox => new FirefoxDriver(),
                BrowserType.Edge => new EdgeDriver(),
                BrowserType.Safari => new SafariDriver(),
                _ => new ChromeDriver()
            };

        }

        public enum BrowserType
        {
            Chrome,
            Firefox,
            Edge,
            Safari
        }
    }
}
