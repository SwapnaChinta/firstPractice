using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EaFramework.Driver;
using EaFramework.Config;
using OpenQA.Selenium;

namespace EaApplicationTest.Pages
{

    public class HomePage
    {
        private IDriverFixture _driverFixture;

        public HomePage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }

        private IWebElement lnkHome => _driverFixture.Driver.FindElement(By.LinkText("Home"));
        private IWebElement lnkAPrivacy => _driverFixture.Driver.FindElement(By.LinkText("Privacy"));
        private IWebElement lnkProduct => _driverFixture.Driver.FindElement(By.LinkText("Product"));

        public ProductPage ClickProduct()
        {
            lnkProduct.Click();
            return new ProductPage(_driverFixture);
        }

        }
    }
