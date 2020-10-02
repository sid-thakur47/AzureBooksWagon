using AzureBookWagon.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace AzureBookWagon.Base
{
    public class BooksWagonBase
    {
        public IWebDriver driver;
        public static string title = ConfigurationManager.AppSettings["title"];
        public static string placeOrder = ConfigurationManager.AppSettings["placeOrder"];
        public static string logOut = ConfigurationManager.AppSettings["logout"];
        [OneTimeSetUp]
        public void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.bookswagon.com/login";
        }
        [TearDown]
        public void AddScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                string path = Utility.TakeScreenshot(driver, TestContext.CurrentContext.Test.Name);
                TestContext.AddTestAttachment(path, "failed");
                    
            }
            else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                string path = Utility.TakeScreenshot(driver, TestContext.CurrentContext.Test.Name);
                    TestContext.AddTestAttachment(path, "passed");
            }
        }


        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
