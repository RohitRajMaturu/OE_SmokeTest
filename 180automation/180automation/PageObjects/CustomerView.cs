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
   public class CustomerView
    {
        public static IWebDriver _Driver;

        public CustomerView(IWebDriver Driver)
        {
            _Driver = Driver;
            PageFactory.InitElements(_Driver, this);
        }

        [FindsBy(How = How.Id, Using = "cmdEdit")]
        public IWebElement cmdEdit;


        [FindsBy(How = How.Id, Using = "button2")]
        public IWebElement button2;

        public bool IsOnCustomerViewPage()
        {
            return (cmdEdit.Displayed && button2.Displayed);
        }




    }
}
