using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using System.Collections.ObjectModel;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium.NUnitTest
{
    public class Tests
    {

        IWebDriver driver = null;

        [Test, Order(1)]
        public void InitTest()
        {
            new DriverManager().SetUpDriver(new OperaConfig());

            driver = new OperaDriver();
            
            Assert.True(driver != null);
        }
        [Test, Order(2)]
        public void SpengergasseTest()
        {

            driver.Url = "https://spengergasse.at";

            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.Id("page"));

            Assert.True(elements != null);
        }



    }
}