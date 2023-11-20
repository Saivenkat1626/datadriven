using datadriven.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace datadriven.StepDefinitions
{
    [Binding]
    public sealed class RegisterStepDefinitions
    {
        public IWebDriver driver;
        public Registerpage rp;
        public RegisterStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"Open the url")]
        public void GivenOpenTheUrl()
        {
            driver.Url = "https://tutorialsninja.com/demo/index.php?route=account/register";
        }

        [Given(@"Click on Register")]
        public void GivenClickOnRegister()
        {
            
        }

        [Given(@"the user is on the registration page")]
        public void GivenTheUserIsOnTheRegistrationPage()
        {
            string tittle = driver.Title;
            Assert.True(tittle.Equals("Register Account"));
        }

        [When(@"the user enters valid registration details")]
        public void WhenTheUserEntersValidRegistrationDetails()
        {
            Registerpage rp = new Registerpage(driver);
            rp.ValidRegisterDetails();
        }

        [When(@"clicks on the submit button")]
        public void WhenClicksOnTheSubmitButton()
        {
            rp = new Registerpage(driver);
            rp.Submit();
            Thread.Sleep(2000);
        }

        [Then(@"the user should be successfully registered")]
        public void ThenTheUserShouldBeSuccessfullyRegistered()
        {
            string tit = driver.Title;
            Assert.True(tit.Equals(" Your Account Has Been Created!"));
           
        }

    }
}