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

   public  class VehicleSelection
    {
        public static IWebDriver _Driver;
        VehicleSelection _VehicleSelection = new VehicleSelection(TestSetup.Driver);
        [FindsBy(How = How.ClassName, Using = "txt_hdrPage")]
        public IWebElement VehicleSelect;
        public VehicleSelection(IWebDriver Driver)
        {
            _Driver = Driver;
            PageFactory.InitElements(_Driver, this);
        }
        public bool isVehicleSelectPage()
        {
            return (VehicleSelect.Displayed);
        }
    }
}
