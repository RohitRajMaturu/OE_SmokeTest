using System;
using System.Collections.Generic;
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

namespace _180automation
{
    [Binding]
    public static class TestSetup
    {
        public static IWebDriver Driver;


        [BeforeTestRun]
        public static void initialise()
        {
            //DesiredCapabilities caps = DesiredCapabilities.InternetExplorer();
            //caps.SetCapability("EnableNativeEvents", false);
            //caps.SetCapability("ignoreZoomSetting", true);
            InternetExplorerOptions caps = new InternetExplorerOptions { IgnoreZoomLevel = true };

            Driver = new InternetExplorerDriver(caps);

            // @"C:\Users\pullurul\Documents\180 test projects\180automation\packages\Selenium.WebDriver.IEDriver.3.3.0\driver\"
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));

            // Driver.Navigate().GoToUrl("http://localhost/webasp/login.asp");
        }


        //     [AfterTestRun]
        //public static void CleanUp()
        //{
        //    Driver.Close();
        //}

        //}
    }
}
