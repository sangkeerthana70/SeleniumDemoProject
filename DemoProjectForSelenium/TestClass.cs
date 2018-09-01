using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectForSelenium
{
    class TestClass
    {
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //navigate to automationpractice.com
            PropertiesCollection.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //maximize window
            PropertiesCollection.driver.Manage().Window.Maximize();

            //Find the sign-in text box element
            PropertiesCollection.driver.FindElement(By.ClassName("login")).Click();

            Console.WriteLine("Opened URL and clicked Login Page");

        }

        [Test]
        public void ExecuteTest()
        {

            //login to application by creating an instance of Authentication class
            Authentication authentication = new Authentication();


            AccountPage accountPage = authentication.SignIn("asangeethu@yahoo.com", "@nuK1978");
            SearchResultsPage searchResults = accountPage.EnterSearchText("printed summer dress");

            Console.WriteLine("Executed Login page and did a search query in the next POM");

            searchResults.AddToCart();
            Console.WriteLine("Hover on search result and added item to cart");


        }

             
        [Test]
        public void IncorrectUserIdOrPassword()
        {
            //login to application by creating an instance of Authentication class
            Authentication authentication = new Authentication();
            AccountPage accountPage = authentication.SignIn("asanhu@yahoo.com", "qwertop8");
            //AccountPage accountPage = authentication.SignIn("asangeethu@yahoo.com", "@nuK1978");
            
            IWebElement loginMessage = PropertiesCollection.driver.FindElement(By.XPath("//*[@id=\"center_column\"]/div[1]/ol/li"));
            Console.WriteLine(loginMessage.Text);
            Boolean loginError = loginMessage.Text.Contains("Authentication failed");
            Console.WriteLine(loginError);
            Assert.IsTrue(loginError);
        }




        [TearDown]
        public void CleanUp()
        {
            //close window
            //driver.Close();

            Console.WriteLine("Closed the browser");
        }
    }

}

