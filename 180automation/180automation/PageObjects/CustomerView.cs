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
        CustomerAdd _CustomerAdd = new CustomerAdd(TestSetup.Driver);
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

      

        //[FindsBy(How = How.ClassName, Using = "txt_table lastnametxt")]
        //public IWebElement LastNameVerify;


        public bool IsOnCustomerViewPage()
        {
            //return (_CustomerAdd.txtLastName.Text == "Morgan");
            return (cmdEdit.Displayed && button2.Displayed);
        }
        //public void CreateQuote()
        //{
        //  IList<IWebElement>   Quote = _Driver.FindElements(By.CssSelector(".btn_input"));
        //    //foreach (IWebElement Q in Quote)
        //    //{
        //    //    if (Q.va.Contains("Create a Quote"))
        //    //    {
        //    //        Q.Click();
        //    //    }
        //    //}

        //}




    }
}
