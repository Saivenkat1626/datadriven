using datadriven.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace datadriven.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        public IWebDriver driver;
        public Loginpage lp;
        public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"open the url")]
        public void GivenOpenTheUrl()
        {
            driver.Url = "https://tutorialsninja.com/demo/index.php?route=account/login";
        }
        
       
        [Given(@"Enter the valid details")]
        public void GivenEnterTheValidDetails()
        {
            lp = new Loginpage(driver);
            lp.LoginWithValidDetails("sai4@gmail.com", "Saivenkat");
        }

        [When(@"Click Login")]
        public void WhenClickLogin()
        {
            lp.Login();
            Thread.Sleep(1000);
        }

        [Then(@"Verify that User Sucessfully Navigate My Account Page")]
        public void ThenVerifyThatUserSucessfullyNavigateMyAccountPage()
        {
            lp.tittle();
        }

        [Given(@"entered ""([^""]*)"" and ""([^""]*)"" present at signin page")]
        public void GivenEnteredAndPresentAtSigninPage(string username, string password)
        {
            lp = new Loginpage(driver);
            lp.LoginWithValidDetails(username, password);
            
        }




    }
}