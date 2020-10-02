using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;
using System.Threading;

namespace AzureBookWagon.pages
{
    public class Login
    {
        public IWebDriver driver;
        string email = ConfigurationManager.AppSettings["email"];
        string password = ConfigurationManager.AppSettings["password"];

        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class
        /// </summary>
        /// <param name="driver">to control browser</param>
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Web elements
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignIn_txtEmail']")]
        public IWebElement username;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtPassword")]
        public IWebElement pass;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_btnLogin")]
        public IWebElement loginbutton;

        [FindsBy(How = How.Id, Using = "ctl00_lnkbtnLogout")]
        public IWebElement logout;

        [FindsBy(How = How.XPath, Using = "//span[@class='login-bg sprite usermenu-bg']")]
        public IWebElement menu;


        /// <summary>
        /// To login into Bookwagon application
        /// </summary>
        public void BookwagonLogin()
        {
            username.SendKeys(email);
            pass.SendKeys(password);
            loginbutton.Click();
            Thread.Sleep(2000);
        }
    }
}
