using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180automation.PageObjects
{
    public class HomePage
    {
        public static IWebDriver _Driver;
        //[FindsBy(How = How.Id, Using = "TestLogout")]
        //public IWebElement LogoutBtn;

        //[FindsBy(How = How.ClassName, Using = "link_yellow")]
        LoginPage _loginPage = new LoginPage(_Driver);


        public HomePage(IWebDriver Driver)
        {
            _Driver = Driver;
            PageFactory.InitElements(_Driver, this);
        }

        public bool checkAlert()
        {
            try
            {
                _Driver.SwitchTo().Alert().Dismiss();
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public bool IsLogoutBtnVisible()
        {
            return checkAlert();
        }

        public void logout()
        {
            var logout = _Driver.FindElement(By.ClassName("dislink_yellow"));
            logout.Click();
            _loginPage.IsLoginBtnVisible();
        }
    }
}
