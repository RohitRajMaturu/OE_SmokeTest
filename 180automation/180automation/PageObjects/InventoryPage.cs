using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class InventoryPage
    {
        public static IWebDriver _Driver;

        public InventoryPage(IWebDriver Driver)
        {
            _Driver = Driver;
            PageFactory.InitElements(_Driver, this);
        }

        [FindsBy(How = How.Id, Using = "cmbStatus")] public IWebElement DdlStatus;
        [FindsBy(How = How.Id, Using = "cmbMake")] public IWebElement Ddlmake;
        [FindsBy(How = How.Name, Using = "button")] public IWebElement Btnfindvehicles;
        [FindsBy(How = How.Id, Using = "btnExpUpdate")] public IWebElement btnExpUpdate;
        [FindsBy(How = How.Id, Using = "button1")] public IWebElement btnSearch;

        public bool IsInventoryPage()
        {
            if (DdlStatus.Displayed && Ddlmake.Displayed && Btnfindvehicles.Displayed)
                return true;
            else
                return false;
        }

        public void SearchCriteria()
        {
            var selectStatus = new SelectElement(DdlStatus);
            var selectMake=new SelectElement(Ddlmake);
            selectStatus.SelectByIndex(1);
            selectMake.SelectByIndex(1);
            Btnfindvehicles.Click();
        }

        public bool IsResultAvailable()
        {
            if (btnExpUpdate.Displayed && btnSearch.Displayed)
                return true;
            else
                return false;
        }

    }
}
