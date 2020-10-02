using AzureBookWagon.Base;
using AzureBookWagon.pages;
using AzureBookWagon.Pages;
using NUnit.Framework;

namespace AzureBookWagon.Test
{
   public class Test : BooksWagonBase
    {
        [Test, Order(1)]
        public void LoginTest()
        {
            Login login = new Login(driver);
            login.BookwagonLogin();
            Assert.AreEqual(driver.Title, title);
        }
        [Test, Order(2)]
        public void HomePageTest()
        {
            HomePage home = new HomePage(driver);
            home.SearchItem("cobain");
            Assert.IsTrue(home.Validate().Displayed);
        }

        [Test, Order(3)]
        public void PlaceOrderTest()
        {
            PlaceOrder order = new PlaceOrder(driver);
            order.OrderBook();
            Assert.AreEqual(driver.Url, placeOrder);
        }

        [Test, Order(4)]
        public void CartCheckoutTest()

        {
            ShippingAddress cart = new ShippingAddress(driver);
            cart.AddShippingDetails();
        }

        [Test, Order(5)]
        public void LogoutTest()
        {
            Logout logout = new Logout(driver);
            logout.LogOut();
            Assert.AreEqual(driver.Url, logOut);
        }
    }
}
