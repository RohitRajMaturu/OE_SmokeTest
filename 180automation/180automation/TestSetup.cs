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

            InternetExplorerOptions caps = new InternetExplorerOptions { IgnoreZoomLevel = true,EnableNativeEvents = false};
            Driver = new InternetExplorerDriver(caps);
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["App_URL"]);
            //Setting the broweser to 100%

            IWebElement username = Driver.FindElement(By.Id("txtUser"));
            IWebElement Password = Driver.FindElement(By.Id("txtPassword"));
           
            username.SendKeys("RRMsupport43");
            Password.Clear();
            Password.SendKeys("1qaz@WSX");
            IWebElement LoginBtn = Driver.FindElement(By.XPath("//table/tbody/tr[3]/td[2]/input"));
            LoginBtn.Click();
        }
        
    }
}
