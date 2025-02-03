using EaFramework.Driver;
using EaFramework.Extensions;
using OpenQA.Selenium;


namespace EaApplicationTest.Pages
{
    public class ProductPage
    {
        private IDriverFixture _driverFixture;

        public ProductPage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;   
        }

        private IWebElement lnkCreate => _driverFixture.Driver.FindElement(By.LinkText("Create"));
        private IWebElement txtName => _driverFixture.Driver.FindElement(By.Id("Name"));
        private IWebElement txtDescription => _driverFixture.Driver.FindElement(By.Id("Description"));
        private IWebElement txtPrice => _driverFixture.Driver.FindElement(By.Id("Price"));
        private IWebElement ddlProductType => _driverFixture.Driver.FindElement(By.Id("ProductType"));
        private IWebElement btnCreate => _driverFixture.Driver.FindElement(By.Id("Create"));
        private IWebElement tblList => _driverFixture.Driver.FindElement(By.XPath("//table[@class='table']"));
        private IWebElement btnDelete => _driverFixture.Driver.FindElement(By.XPath("//input[@class='btn btn-danger']"));
        private IWebElement btnBackToList => _driverFixture.Driver.FindElement(By.LinkText("Back to List"));

        public void ClickCreateLink() => lnkCreate.Click();

        public void CreateProduct(string prodName, string prodDesc, string prodPrice, ProductType prodType)
        {
            txtName.SendKeys(prodName);
            txtDescription.SendKeys(prodDesc);
            txtPrice.SendKeys(prodPrice.ToString());
            ddlProductType.SelectDropDownByText(prodType.ToString());
            btnCreate.Click();
        }

        public enum ProductType
        {
            CPU, 
            MONITOR,
            PERIPHERALS,
            EXTERNAL,           
            KEYBOARD,
        }
        
    }
}
