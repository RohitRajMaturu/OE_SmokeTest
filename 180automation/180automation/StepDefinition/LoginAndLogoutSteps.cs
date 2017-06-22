using System;
using System.Configuration;
using TechTalk.SpecFlow;
using _180automation.PageObjects;
using _180automation;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _180automation.StepDefinition
{
    [Binding]
    public class LoginAndLogoutSteps
    {
        LoginPage _loginPage = new LoginPage(TestSetup.Driver);
        CustomerFind _CustomerFind = new CustomerFind(TestSetup.Driver);
        HomePage _homePage = new HomePage(TestSetup.Driver);
        CustomerAdd _customerAdd = new CustomerAdd(TestSetup.Driver);
        CustomerView _customerView = new CustomerView(TestSetup.Driver);
        CustomerSearch _customerSearch=new CustomerSearch(TestSetup.Driver);
        OE_CustomerAdd _OEcustomerAdd = new OE_CustomerAdd(TestSetup.Driver);
        InventoryPage _inventoryPage=new InventoryPage(TestSetup.Driver);
        IWebDriver _driver = TestSetup.Driver;
        [Given(@"I am on Homepage")]
        public void GivenIAmOnHomepage()
        {
            _homePage.IsHomePage();
        }

        [When(@"I click on OE button")]
        public void WhenIClickOnOEButton()
        {
            _OEcustomerAdd.NavigateToOE();
        }

        [Then(@"I should see OE home page")]
        public void ThenIShouldSeeOEHomePage()
        {
            Assert.IsTrue(_OEcustomerAdd.IsOEhomapage());

        }
        [When(@"I click on Showroom Btn")]
        public void WhenIClickOnShowroomBtn()
        {
            _OEcustomerAdd.Showroom();
        }

        [Then(@"I can Add customer")]
        public void ThenICanAddCustomer()
        {
            Assert.IsTrue(_OEcustomerAdd.AddCustomer());
        }


    }
}
