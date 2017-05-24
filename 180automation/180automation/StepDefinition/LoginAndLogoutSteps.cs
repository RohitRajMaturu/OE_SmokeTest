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
        InventoryPage _inventoryPage=new InventoryPage(TestSetup.Driver);
        IWebDriver _driver = TestSetup.Driver;

        //Scenario I (check for the alert)
        [Then(@"I should check for alertBox")]
        public void WhenIShouldCheckForAlertBox()
        {
            _homePage.checkAlert();
        }


        [Then(@"I should check for Passwordchange box")]
        public void WhenIShouldCheckForPasswordchangeBox()
        {
            _homePage.CheckForPasswordChange();
        }

        [Then(@"I should land on home page")]
        public void ThenIShouldLandOnHomePage()
        {
            Assert.IsTrue(_homePage.IsHomePage());
        }




        //Scenario II (adding a customer)
        [Given(@"I am on Homepage")]
        public void GivenIAmOnHomepage()
        {
            Assert.IsTrue(_homePage.IsHomePage());
        }

        [When(@"I hover on customer menu")]
        public void WhenIHoverOnCustomerMenu()
        {
            _homePage.FindCustomerMenu();
        }

        [When(@"I hover on Retail Menu")]
        public void WhenIHoverOnRetailMenu()
        {
            _homePage.FindRetailMenu();
        }

        [When(@"I click on Add customer")]
        public void WhenIClickOnAddCustomer()
        {
            _homePage.AddCustomer();
        }
        [Then(@"I should land on customerFind page")]
        public void ThenIShouldLandOnCustomerFindPage()
        {
            Assert.IsTrue(_CustomerFind.IsCustomerFindPage());
        }


        [When(@"I can search for a customer by lastname")]
        public void WhenICanSearchForACustomerByLastname()
        {
            _CustomerFind.SeacrhCriteria();
        }

        [Then(@"I should click on AddNew button")]
        public void ThenIShouldClickOnAddNewButton()
        {
            _CustomerFind.FindAddandClick();
        }

        [Then(@"I should land on CustomerAdd screen")]
        public void ThenIShouldLandOnCustomerAddScreen()
        {
            Assert.IsTrue(_customerAdd.IsOnCustomerAddPage());   
        }

        [Given(@"I should fill the form with basic info")]
        public void GivenIShouldFillTheFormWithBasicInfo()
        {
            _customerAdd.FillForm();
        }

        [When(@"I click on Save Customer Info")]
        public void WhenIClickOnSaveCustomerInfo()
        {
            _customerAdd.SaveCustomer();
        }

        [Then(@"I should redirect to Customer View Screen")]
        public void ThenIShouldRedirectToCustomerViewScreen()
        {
           Assert.IsTrue(_customerView.IsOnCustomerViewPage());
        }
        [Then(@"I should validate the added customer")]
        public void ThenIShouldValidateTheAddedCustomer()
        {
           Assert.IsTrue(_customerView.validateAddedCustomer());
        }


        //Scenario III (finding a customer)
        [When(@"I click on Find customer")]
        public void WhenIClickOnFindCustomer()
        {
            _homePage.SearchCustomer();
        }

        [Then(@"I should land on customersearch page")]
        public void ThenIShouldLandOnCustomersearchPage()
        {
            Assert.IsTrue(_customerSearch.IsCustomerSearchPage());
        }

        [Then(@"I can search for a customer by lastname or firstname or company name or phone Number")]
        public void WhenICanSearchForACustomerByLastnameOrFirstnameOrCompanyNameOrPhoneNumber()
        {
            _customerSearch.EnterAndSearch();
        }

        [Then(@"I should check for the selected record")]
        public void ThenIShouldCheckForTheSelectedRecord()
        {
            _customerSearch.IsresultAvailable();
        }




        //Scenario IV Inventory Search
        [When(@"I hover on Inventory menu")]
        public void WhenIHoverOnInventoryMenu()
        {
            _homePage.FindInventorylMenu();
        }

        [When(@"I hover on FindVehicles")]
        public void WhenIHoverOnFindVehicles()
        {
            _homePage.FindVehiclesMenu();
        }


        [When(@"I will click on All Vehicles")]
        public void WhenIWillClickOnAllVehicles()
        {
            _homePage.SearchInventory();
        }

        [Then(@"I should land on inventory page for selecting vehicles")]
        public void ThenIShouldLandOnInventoryPageForSelectingVehicles()
        {
            Assert.IsTrue(_inventoryPage.IsInventoryPage());
        }


        [Then(@"I should enter any search criteria and click on Find Vehicles")]
        public void ThenIShouldEnterAnySearchCriteriaAndClickOnFindVehicles()
        {
            _inventoryPage.SearchCriteria();
        }

        [Then(@"I should see records for that search criteria")]
        public void ThenIShouldSeeRecordsForThatSearchCriteria()
        {
            _inventoryPage.IsResultAvailable();
        }




    }
}
