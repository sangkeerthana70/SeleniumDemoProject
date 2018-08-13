using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectForSelenium
{
    public class Authentication
    {
        [Obsolete("Use newMethod instead", false)]//modify the code to use the Obsolete atrribute as PageFactory was deprecated
        //initialize page object using constructor
        public Authentication()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);

        }
        //identify the email text box element by the id value as email
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail1 { get; set; }

        //identify the password text box element by the id value as passwd
        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement txtPassword { get; set; }

        //identify the Sign in button element by the name value as SubmitLogin
        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement btnClick { get; set; }

        //method to fill the sign in form
        public AccountPage SignIn(string email, string password)
        {
            txtEmail1.SendKeys(email);
            txtPassword.SendKeys(password);
            btnClick.Click();

            return new AccountPage();
        }

    }
}
