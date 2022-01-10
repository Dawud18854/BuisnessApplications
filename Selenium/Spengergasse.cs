using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium
{
    class Spengergasse
    {
        static void Main(string[] args)
        {
            //NugetPackages Required
            new DriverManager().SetUpDriver(new OperaConfig());

            IWebDriver driver = new OperaDriver();

            driver.Url = "https://www.duckduckgo.com";

            IWebElement element = driver.FindElement(By.XPath("//*[@id='search_form_input_homepage']"));

            element.SendKeys("LambdaTest");

            /* Submit the Search */
            element.Submit();

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
        }
    }
}