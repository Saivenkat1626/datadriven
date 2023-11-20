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
    public class Registerpage
    {
        public IWebDriver driver;
        public  Registerpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy (How=How.Id ,Using = "input-firstname")]
        [CacheLookup]
        public IWebElement _firstName { get; set; }
        [FindsBy(How = How.Id, Using = "input-lastname")]
        [CacheLookup]
        public IWebElement _lastName { get; set; }
        [FindsBy(How = How.Id, Using = "input-email")]
        [CacheLookup]
        public IWebElement _email { get; set; }
        [FindsBy(How = How.Id, Using = "input-telephone")]
        [CacheLookup]
        public IWebElement _telephone { get; set; }
        [FindsBy(How = How.Id, Using = "input-password")]
        [CacheLookup]
        public IWebElement _password { get; set; }
        [FindsBy(How = How.Id, Using = "input-confirm")]
        [CacheLookup]
        public IWebElement _confir { get; set; }
        [FindsBy(How = How.Name, Using = "agree")]
        [CacheLookup]
        public IWebElement _agree { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/form/div/div/input[2]")]
        [CacheLookup]
        public IWebElement _continue { get; set; }
    
        public void ValidRegisterDetails()
        {
            _firstName.SendKeys("sai");
            _lastName.SendKeys("venkatesh");
            _email.SendKeys("sai5@gmail.com");
            _telephone.SendKeys("123456");
            _password.SendKeys("Saivenkat");
            _confir.SendKeys("Saivenkat");
            _agree.Click();
            
                }
        public void Submit()
        {
            _continue.Click();
        }
        public void tittle()
        {
            string titt = driver.Title;
            Assert.True(titt.Contains("My Account"));
        }
    }
}
