using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace AzureBookWagon.Pages
{
    public class Logout
    {
        public IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class
        /// </summary>
        /// <param name="driver">to control browser</param>
        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@id='ctl00_lnkbtnLogout']")]
        public IWebElement logout;

        /// <summary>
        /// To logout from Bookwagon application
        /// </summary>
        public void LogOut()
        {
            logout.Click();
        }
    }
}
