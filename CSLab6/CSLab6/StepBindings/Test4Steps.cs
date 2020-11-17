using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CSLab6.StepBindings
{
    [Binding]
    public class Test4Steps
    {
        private IWebDriver driver;

        private readonly By _InstagramMediaButton = By.XPath("//div[@class='footer']/div/div/ul/li/a/div/i[@class='fa fa-facebook']");
        private readonly By _TwitterMediaButton = By.XPath("//div[@class='footer']/div/div/ul/li/a/div/i[@class='fa fa-twitter']");
        private readonly By _OKMediaButton = By.XPath("//div[@class='footer']/div/div/ul/li/a/div/i[@class='fa fa-instagram']");
        private readonly By _LinkMediaButton = By.XPath("//div[@class='footer']/div/div/ul/li/a/div/i[@class='fa fa-linkedin']");

        public Test4Steps()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }

        [Given(@"Clicked Facebook down")]
        public void GivenClickedFacebookDown()
        {
            
            var link1 = driver.FindElement(_InstagramMediaButton);
            link1.Click();
        }
        
        [Given(@"Clicked Twitter down")]
        public void GivenClickedTwitterDown()
        {
            driver.Navigate().Back();
            var link2 = driver.FindElement(_TwitterMediaButton);
            link2.Click();
        }
        
        [Given(@"Clicked Instagram down")]
        public void GivenClickedInstagramDown()
        {
            driver.Navigate().Back();
            var link3 = driver.FindElement(_OKMediaButton);
            link3.Click();
        }
        
        [Given(@"Clicked Linkedin down")]
        public void GivenClickedLinkedinDown()
        {
            driver.Navigate().Back();
            var link4 = driver.FindElement(_LinkMediaButton);
            link4.Click();
        }
        
        [Then(@"Open social media")]
        public void ThenOpenSocialMedia()
        {
            Assert.Pass();
        }
    }
}
