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
using System.Configuration;

namespace _180automation
{
    [Binding]
    public static class TestSetup
    {
       
       public static IWebDriver Driver;


        [BeforeTestRun]
        // @"C:\Users\pullurul\Documents\180 test projects\180automation\packages\Selenium.
        public static void initialise()
        {
            if (ConfigurationManager.AppSettings["ExecutionType"].Equals("remote", StringComparison.InvariantCultureIgnoreCase))
            {
                Driver = BringMyRemoteDriver();


                //DesiredCapabilities caps = DesiredCapabilities.InternetExplorer();
                //Driver = new RemoteWebDriver(new Uri(ConfigurationManager.AppSettings["SaucelabsURL"]), caps);
            }
           else 
                {
                Driver = new InternetExplorerDriver();
            }                

    //DesiredCapabilities caps = DesiredCapabilities.InternetExplorer();
    //caps.SetCapability("EnableNativeEvents", false);
    //caps.SetCapability("ignoreZoomSetting", true);
            //InternetExplorerOptions caps = new InternetExplorerOptions { IgnoreZoomLevel = true };

          

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));

            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Local_Server"]);
           IWebElement username =  Driver.FindElement(By.Id("txtUser"));
           IWebElement Password = Driver.FindElement(By.Id("txtPassword"));
            username.SendKeys("PZLsupport1");
            Password.Clear();
            Password.SendKeys("Hpy2017!");
            //IWebElement  LoginBtn = Driver.FindElement(By.XPath("/html/body/form/table/tbody/tr/td[1]/table[2]/tbody/tr/td/table/tbody/tr[3]/td[2]/input"));
            IWebElement LoginBtn = Driver.FindElement(By.XPath("//table/tbody/tr[3]/td[2]/input"));
            LoginBtn.Click();
        }
        private static IWebDriver BringMyRemoteDriver()
        {
            try
            {
                var capabilities = new DesiredCapabilities();
                capabilities.SetCapability("name", ConfigurationManager.AppSettings["ApplicationName"]);
                capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["Browser"]);
                capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["BrowserVersion"]);
                capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["OS"]);
                capabilities.SetCapability("screen-resolution", ConfigurationManager.AppSettings["ScreenResolution"]);
                capabilities.SetCapability("username", ConfigurationManager.AppSettings["SaucelabsUserName"]);
                capabilities.SetCapability("accessKey", ConfigurationManager.AppSettings["SaucelabsAccessKey"]);
                return new RemoteWebDriver(new Uri(ConfigurationManager.AppSettings["SaucelabsURL"]), capabilities);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to get remote driver");
                Debug.WriteLine(e);
                return null;
            }

        }

        //     [AfterTestRun]
        //public static void CleanUp()
        //{
        //    Driver.Close();
        //}

        //}
    }
}
