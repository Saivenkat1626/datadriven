using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datadriven.Pages
{
    public class Loginpage
    {
        public IWebDriver driver;
        public  Loginpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy (How=How.Id ,Using = "input-email")]
        [CacheLookup]
        public IWebElement _userName { get; set; }
        [FindsBy(How = How.Id, Using = "input-password")]
        [CacheLookup]
        public IWebElement _password { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//input[@class=\"btn btn-primary\"]")]
        [CacheLookup]
        public IWebElement _Login { get; set; }
        
        public void LoginWithValidDetails(string username,string password)
        {
            _userName.SendKeys(username);
            _password.SendKeys(password);
            
                }
        public void Login()
        {
            _Login.Click();
        }
        public void tittle()
        {
            string titt = driver.Title.ToString();
           Assert.True(titt.Contains("My Account"));
        }
    }
}
