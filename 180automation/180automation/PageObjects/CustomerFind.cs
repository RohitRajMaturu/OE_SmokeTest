using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _180automation.PageObjects
{
    public class CustomerFind
    {
        [FindsBy(How = How.Id, Using = "txtLastName")]
        public IWebElement CustLastName;
        public static IWebDriver _Driver;

        [FindsBy(How = How.Id, Using = "cmdFind")]
        public IWebElement btnSearch;
        [FindsBy(How = How.Id, Using = "cmdAdd")]
        public IWebElement btnAdd;





        public CustomerFind(IWebDriver Driver)
        {
            _Driver = Driver;
            PageFactory.InitElements(_Driver, this);
        }
        public bool IsCustomerFindPage()
        {
            return CustLastName.Displayed;
        }
        public void SeacrhCriteria()
        {
            CustLastName.SendKeys("mor");
            btnSearch.Click();
        }
        public void FindAddandClick()
        {
            btnAdd.Click();
        }
        

    }
}
