using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _180automation.PageObjects
{
    public class CustomerSearch
    {
        public static IWebDriver _Driver;
        public CustomerSearch(IWebDriver Driver)
        {
            _Driver = Driver;
            PageFactory.InitElements(_Driver, this);
        }

        [FindsBy(How = How.Id, Using = "txtFName")]
        public IWebElement txtFName;

        [FindsBy(How = How.Id, Using = "txtLName")]
        public IWebElement txtLname;


        [FindsBy(How = How.Id, Using = "cmdFind")] public IWebElement btnFind;

        public bool IsCustomerSearchPage()
        {
            if (txtFName.Displayed && txtLname.Displayed)
                return true;
            else
                return false;
        }

        public void EnterAndSearch()
        {
            txtLname.SendKeys("morgan");
            btnFind.Click();
        }


    }
}
