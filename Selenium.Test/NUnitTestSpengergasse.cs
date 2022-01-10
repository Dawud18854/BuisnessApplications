using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using NUnit.Framework;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium.Tests
{
    class NUnitTestSpengergasse
    {
        IWebDriver driver;


        [SetUp]
        public void Initialize()
        {
           driver = new OperaDriver();
           new DriverManager().SetUpDriver(new OperaConfig());
        }

        [Test]
        public void OpenSiteTest()
        {
            driver.Url = "https://www.spengergasse.at";
        }

        [TearDown]
        public void CloseSiteTest()
        {
            driver.Close();
        }
    }
}