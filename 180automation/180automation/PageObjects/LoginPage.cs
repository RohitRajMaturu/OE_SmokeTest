using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using _180automation;

namespace _180automation.PageObjects
{
    public class LoginPage
    {
       public static IWebDriver _Driver;
        
        public IWebElement LoginBtn;
        

        public  LoginPage(IWebDriver Driver)
        {
            _Driver = Driver;
            PageFactory.InitElements(_Driver, this);
        }
        public void login()
        {
           
            
        }
        public void submit()
        {
            //LoginBtn.Submit();
            //starts-with[contains(@class, 'dislink')]
            LoginBtn =  _Driver.FindElement(By.XPath("/html/body/form/table/tbody/tr/td[1]/table[2]/tbody/tr/td/table/tbody/tr[3]/td[2]/input"));
           // LoginBtn = _Driver.FindElement(By.ClassName("dislink"));
            LoginBtn.Click();

        }

        public bool IsLoginBtnVisible()
        {
           if (LoginBtn.Displayed.CompareTo(true) == 1)
            //string tag = LoginBtn.TagName;
            //if (tag == "input")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }

}
