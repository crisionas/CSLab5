using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace CSLab6.StepBindings
{
    [Binding]
    public class Test2Steps
    {
        private IWebDriver driver;
        private readonly By _signUpButton = By.XPath("//a[text()=' Sign In ']");
        private readonly By _inputButtonName = By.XPath("//div[@id='myModal']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Name']");
        private readonly By _inputButtonEmail = By.XPath("//div[@id='myModal']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Email']");
        private readonly By _inputButtonSignIn = By.XPath("//div[@id='myModal']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/input");

        public Test2Steps()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }

        [Given(@"I have clicked on Sign In button")]
        public void GivenIHaveClickedOnSignInButton()
        {
            var signIn = driver.FindElement(_signUpButton);
            signIn.Click();
        }
        
        [Given(@"I have entered my Name\.")]
        public void GivenIHaveEnteredMyName_()
        {
            var login = driver.FindElement(_inputButtonName);

            Thread.Sleep(400);
            login.Click();
            Thread.Sleep(400);
            login.SendKeys("Cristian");
        }
        
        [Given(@"I have entered my Email\.")]
        public void GivenIHaveEnteredMyEmail_()
        {
            var email = driver.FindElement(_inputButtonEmail);
            email.Click();
            email.SendKeys("cris.ionas@gmail.com");
        }
        
        [When(@"I press Sign In button\.")]
        public void WhenIPressSignInButton_()
        {
            var signinbutton = driver.FindElement(_inputButtonSignIn);
            signinbutton.Click();
        }
        
        [Then(@"My account should be successful logged\.")]
        public void ThenMyAccountShouldBeSuccessfulLogged_()
        {
            string mainUrl = "https://loving-hermann-e2094b.netlify.app/";
            if (driver.Url != mainUrl)
                Assert.Fail();
            else
                Assert.Pass();
        }
    }
}
