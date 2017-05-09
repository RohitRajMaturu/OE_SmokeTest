using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _180automation.PageObjects
{
    public class CustomerAdd
    {
        public static IWebDriver _Driver;

        public CustomerAdd(IWebDriver Driver)
        {
            _Driver = Driver;
            PageFactory.InitElements(_Driver, this);
        }


        [FindsBy(How = How.Id, Using = "cmdSave")]
        public IWebElement btnSave;


        [FindsBy(How = How.Id, Using = "txtLastName")]
        public IWebElement txtLastName;

        [FindsBy(How = How.Name, Using = "txtFirstName")]
        public IWebElement txtFirstName;

        [FindsBy(How = How.Id, Using = "txtAreaCode")]
        public IWebElement txtAreaCode;

        [FindsBy(How = How.Id, Using = "txtHPhone1")]
        public IWebElement txtHPhone1;

        [FindsBy(How = How.Id, Using = "txtHPhone2")]
        public IWebElement txtHPhone2;

        [FindsBy(How = How.Id, Using = "txtEMail")]
        public IWebElement txtEMail;
        

        public bool IsOnCustomerAddPage()
        {
            return btnSave.Displayed;
        }


        public void FillForm()
        {
            //txtLastName.Clear();
            txtLastName.Clear();
            txtLastName.SendKeys("Morgan");
            txtFirstName.SendKeys("Likitha");
            txtAreaCode.SendKeys("123");
            txtHPhone1.SendKeys("456");
            txtHPhone2.SendKeys("7890");
            txtEMail.SendKeys("abc@smoketest.com");
        }

        public void SaveCustomer()
        {
            btnSave.Click();
        }


    }
}
