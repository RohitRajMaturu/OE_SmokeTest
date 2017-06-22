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
    public class OE_CustomerAdd
    {
        public static IWebDriver _Driver;
         public OE_CustomerAdd(IWebDriver Driver)
        {
            _Driver = Driver;
            PageFactory.InitElements(_Driver, this);
        }

        public void NavigateToOE()
        {
            _Driver.FindElement(By.XPath("//a[contains(@href,'/webasp/oe/main.asp')]")).Click();

        }
        public bool IsOEhomapage()
        {
            _Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement Showroombtn =  _Driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/ul/li[1]/a"));
           return Showroombtn.Displayed;
        }
        public void Showroom()
        {
            //IWebElement Showroombtn = _Driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/ul/li[1]/a"));
            //Thread.Sleep(60000);
            //Showroombtn.Click();
            Thread.Sleep(5000);
            IWebElement navBar = _Driver.FindElements(By.ClassName("navbar-nav"))[0];
            navBar.FindElements(By.LinkText("Showroom"))[0].Click();
            Thread.Sleep(5000);
            IWebElement srchBox = _Driver.FindElement(By.ClassName("customerSearchField"));
            srchBox.SendKeys("abc");
            srchBox.Submit();
            Thread.Sleep(5000);
            IWebElement addNew = _Driver.FindElement(By.ClassName("addNewButton"));
            addNew.Click();
            Thread.Sleep(2000);
            var FormControls = _Driver.FindElements(By.ClassName("form-control"));
            IWebElement fname = _Driver.FindElement(By.XPath("//input[contains(@data-bind,'value: FirstName')]"));
            fname.SendKeys("fname");
            //FormControls[5].SendKeys("fname");
            FormControls[6].SendKeys("mname");
            FormControls[7].SendKeys("lname");
            FormControls[8].SendKeys("9983872821");
            _Driver.FindElements(By.ClassName("btn-primary"))[3].Click();

        }
        public bool AddCustomer()
        { 
           
            return true;
        }
    }


}
