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
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
           
            //navigate to automationpractice.com
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //maximize window
            driver.Manage().Window.Maximize();

            //Find the sign-in text box element
            driver.FindElement(By.ClassName("login")).Click();

            Console.WriteLine("Opened URL and clicked Login Page");
 
        }

        [Test]
        public void ExecuteTest()
        {
            //login using email address 
            SeleniumSetMethods.EnterText(driver, "email", "asangeethu@yahoo.com", "id");

            //password
            SeleniumSetMethods.EnterText(driver, "passwd", "@nuK1978", "id");

            //click Sign-in
            SeleniumSetMethods.Click(driver, "SubmitLogin", "id");

            //enter a search text
            SeleniumSetMethods.EnterText(driver, "search_query_top", "summer printed dress", "id");
            //click the search text box
            SeleniumSetMethods.Click(driver, "submit_search", "name");

            //hover over a search result
            SeleniumSetMethods.HoverOnElement(driver, "product_img_link", "class");

            //search result of a dress item
            SeleniumSetMethods.Click(driver, "ajax_add_to_cart_button", "class");

            //to solve element not visible error
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            System.Threading.Thread.Sleep(5000);
            //proceed to checkout
            SeleniumSetMethods.Click(driver, "//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a", "xpath");
            Console.WriteLine("Executed Test");

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

