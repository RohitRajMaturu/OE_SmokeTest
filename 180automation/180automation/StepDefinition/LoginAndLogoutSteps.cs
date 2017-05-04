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
        HomePage _homePage = new HomePage(TestSetup.Driver);
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
            Assert.IsTrue(_homePage.IsLogoutBtnVisible());
        }

        [Then(@"I should logout")]
        public void ThenIShouldLogout()
        {
            _homePage.logout();
        }



    }
}
