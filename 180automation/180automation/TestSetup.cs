using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;
using System.Diagnostics;
using OpenQA.Selenium.Support.PageObjects;

namespace _180automation
{
    [Binding]
    public static class TestSetup
    {
        public static IWebDriver Driver;


        [BeforeTestRun]
        public static void initialise()
        {

            //InternetExplorerOptions caps = new InternetExplorerOptions();
            Driver = new InternetExplorerDriver();
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["App_URL"]);
            //Setting the broweser to 100%

            IWebElement username = Driver.FindElement(By.Id("txtUser"));
            IWebElement Password = Driver.FindElement(By.Id("txtPassword"));
           
            username.SendKeys("LXPsupport1");
            Password.Clear();
            Password.SendKeys("MOMdad12*");
            //IWebElement OELoginBtn = Driver.FindElement(By.Id("chkMobile"));
            //OELoginBtn.Click();
            IWebElement LoginBtn = Driver.FindElement(By.XPath("//table/tbody/tr[3]/td[2]/input"));
            LoginBtn.Click();
        }
        
    }
}
