using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace _180automation.PageObjects
{
    public class HomePage
    {
        public static IWebDriver _Driver;
        //[FindsBy(How = How.Id, Using = "TestLogout")]
        //public IWebElement LogoutBtn;
        public string Title = "ONE-EIGHTY";
        [FindsBy(How = How.Id, Using = "celMenu41")]
        public IWebElement CustomerMenu;

        [FindsBy(How = How.Id, Using = "celMenu31")]
        public IWebElement InventoryMenu;

        [FindsBy(How = How.Id, Using = "HM_Item4_1")]
        public IWebElement Retail;

        [FindsBy(How = How.Id, Using = "HM_Item3_1")]
        public IWebElement findVehicle;
        



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


        public bool CheckForPasswordChange()
        {
            try
            {
                string URL = _Driver.Url;
                string exp = URL.Split(new[] { '?' })[1];
                int expVal = Convert.ToInt16(exp.Split(new[] { '=' })[1]);
                if (expVal > 45)
                {
                    _Driver.SwitchTo().Alert().Dismiss();
                    
                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }



        public bool IsHomePage()
        {
            if (_Driver.Title.Contains(Title))
                return true;
            else
                return false;
        }

        public void FindCustomerMenu()
        {
            Actions build = new Actions(_Driver);
            build.MoveToElement(CustomerMenu).Perform();

        }
        public void FindRetailMenu()
        {
            Actions build = new Actions(_Driver);
            build.MoveToElement(Retail).Perform();

        }
        public void AddCustomer()
        {
            _Driver.FindElement(By.Id("HM_Item4_1_2")).Click();
        }

        public void SearchCustomer()
        {
            _Driver.FindElement(By.Id("HM_Item4_1_1")).Click();
        }

        public void FindInventorylMenu()
        {
            Actions build = new Actions(_Driver);
            build.MoveToElement(InventoryMenu).Perform();

        }
        public void FindVehiclesMenu()
        {
            //_Driver.FindElement(By.TagName("html")).SendKeys(Keys.Control + "+");
            Actions build = new Actions(_Driver);
            build.MoveToElement(findVehicle).Perform();
            Thread.Sleep(2000);

            //IList<IWebElement> InventoryList = new List<IWebElement>();
            //InventoryList = findVehicle.FindElements(By.TagName("<div>"));
            //InventoryList[2].Click();
        }
        public void SearchInventory()
        {
            //IList<IWebElement> divs = _Driver.FindElements(By.TagName("div"));
            
            //foreach (IWebElement div in divs )
            //{
            //    if  (div.GetAttribute("id").Equals("HM_Item3_1_2"))
            //    {
            //        div.Click();
            //    }
            //}
        }


    }
}
