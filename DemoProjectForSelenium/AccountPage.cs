using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectForSelenium
{
    public class AccountPage
    {
        [Obsolete("Use newMethod instead", false)]
        public AccountPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        //identify the search text box element by the id value as search_query_top
        [FindsBy(How = How.Id, Using = "search_query_top")]
        public IWebElement txtSearch { get; set; }
        //identify the search button with name value as submit_search
        [FindsBy(How = How.Name, Using = "submit_search")]
        public IWebElement btnClick { get; set; }

        /*
        //shopping cart
        [FindsBy(How = How.ClassName, Using = "shopping_cart")]
        public IWebElement shpCart { get; set; }

        //women tab
        [FindsBy(How = How.ClassName, Using = "sf-with-ul")]
        public IWebElement vmenTab { get; set; }
        //dresses
        [FindsBy(How = How.ClassName, Using = "sf-with-ul")]
        public IWebElement dressTab { get; set; }
        //T-shirts
        [FindsBy(How = How.LinkText, Using = "http://automationpractice.com/index.php?id_category=5&amp;controller=category")]
        public IWebElement tshirtTab { get; set; }
        */

        //method to enter a search text in the search box and click search
        public void EnterSearchText(string searchTxt)
        {
            txtSearch.SendKeys(searchTxt);
            btnClick.Click();
        }
    }
}
