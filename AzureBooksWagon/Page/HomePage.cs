using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace AzureBookWagon.Pages
{
    public class HomePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Homepage"/> class
        /// </summary>
        /// <param name="driver">to control browser</param>
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Web elements
        /// </summary>
        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        public IWebElement search;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_TopSearch1_Button1']")]
        public IWebElement searchIcon;

        [FindsBy(How = How.XPath, Using = "//img[@id='ctl00_imglogo']")]
        public IWebElement home;

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Showing results for')]")]
        public IWebElement validation;

        /// <summary>
        /// To search particular book
        /// </summary>
        public void SearchItem(String bookName)
        {
            home.Click();
            search.SendKeys(bookName);
            searchIcon.Click();
            Thread.Sleep(2000);
        }
        public IWebElement Validate()
        {
            return validation;
        }
    }
}
