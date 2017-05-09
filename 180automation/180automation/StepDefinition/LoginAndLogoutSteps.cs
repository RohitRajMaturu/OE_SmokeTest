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
        IWebDriver _driver = TestSetup.Driver;

        [Given(@"I have launched the application")]
        public void GivenIHaveLaunchedTheApplication()
        {
            _driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["App_URL"]);
        }

        [When(@"I have logged into the application")]
        public void WhenIHaveLoggedIntoTheApplication()
        {
            _loginPage.login();
        }

        [When(@"I agree to sell a car")]
        public void WhenIAgreeToSellACar()
        {
            _loginPage.submit();
        }

        [When(@"I should check for alertBox")]
        public void WhenIShouldCheckForAlertBox()
        {
            _homePage.checkAlert();
        }

        [Then(@"I should land on home page")]
        public void ThenIShouldLandOnHomePage()
        {
            Assert.IsTrue(_homePage.IsHomePage());
        }

        [When(@"I choose Customers Menu")]
        //public void WhenIChooseCustomersMenu()
        //{
        //    Assert.IsTrue(_homePage.FindCustomerMenu());
        //}

        //[Then(@"I should Land on AddCustomerPage")]
        //public void ThenIShouldLandOnAddCustomerPage()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        [Given(@"I hover on customer menu and then on Retail menu")]
        public void GivenIHoverOnCustomerMenuAndThenOnRetailMenu()
        {
            _homePage.FindCustomerMenu();
        }

            

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



    }
}
