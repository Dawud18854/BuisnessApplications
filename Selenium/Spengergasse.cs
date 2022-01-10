using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;
using System.Collections.ObjectModel;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium
{
    class Spengergasse
    {
        static void Main(string[] args)
        {
            new DriverManager().SetUpDriver(new OperaConfig());

            IWebDriver driver = new OperaDriver();

            driver.Url = "https://spengergasse.at";

            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.Id("page"));

        }
    }
}