using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DemoProjectForSelenium
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

        }
        //global variable
        //create reference for our browser
        //IWebDriver driver = new ChromeDriver();

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
            /*
            //login using email address 
            SeleniumSetMethods.EnterText(PropertiesCollection.driver, "email", "asangeethu@yahoo.com", "id");

            //password
            SeleniumSetMethods.EnterText(PropertiesCollection.driver, "passwd", "@nuK1978", "id");

            //click Sign-in
            SeleniumSetMethods.Click(PropertiesCollection.driver, "SubmitLogin", "id");

            //enter a search text
            SeleniumSetMethods.EnterText(PropertiesCollection.driver, "search_query_top", "summer printed dress", "id");
            //click the search text box
            SeleniumSetMethods.Click(PropertiesCollection.driver, "submit_search", "name");

            //hover over a search result
            SeleniumSetMethods.HoverOnElement(PropertiesCollection.driver, "product_img_link", "class");

            //search result of a dress item
            SeleniumSetMethods.Click(PropertiesCollection.driver, "ajax_add_to_cart_button", "class");

            //to solve element not visible error
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            System.Threading.Thread.Sleep(5000);
            //proceed to checkout
            SeleniumSetMethods.Click(PropertiesCollection.driver, "//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a", "xpath");
            Console.WriteLine("Executed Test");
            */

            //login to application by creating an instance of Authentication class
            Authentication authentication = new Authentication();
            authentication.SignIn("asangeethu@yahoo.com", "@nuK1978");
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

