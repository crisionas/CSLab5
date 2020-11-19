using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace CSLab6.StepBindings
{
    [Binding]
    public class Test1Steps
    {
        private IWebDriver driver;
        private readonly By _signUpButton = By.XPath("//a[text()=' Sign Up ']");
        private readonly By _inputButtonName = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Name']");
        private readonly By _inputButtonEmail = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Email']");
        private readonly By _inputButtonPassword = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='password']");
        private readonly By _inputButtonConfirmPassword = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Confirm Password']");
        private readonly By _inputButtonSignup = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/input");

        public Test1Steps()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }

        [Given(@"I have clicked on Sign Up button")]
        public void GivenIHaveClickedOnSignUpButton()
        {
            var signUp = driver.FindElement(_signUpButton);
            signUp.Click();
        }

        [Given(@"I have entered my Name")]
        public void GivenIHaveEnteredMyName()
        {
            var login = driver.FindElement(_inputButtonName);
            Thread.Sleep(400);
            login.Click();
            Thread.Sleep(400);
            login.SendKeys("Cristian");
        }

        [Given(@"I have entered my Email")]
        public void GivenIHaveEnteredMyEmail()
        {
            var email = driver.FindElement(_inputButtonEmail);
            email.Click();
            email.SendKeys("crisionas@gmail.com");
        }

        [Given(@"I have entered my Password")]
        public void GivenIHaveEnteredMyPassword()
        {
            var password = driver.FindElement(_inputButtonPassword);
            var confpass = driver.FindElement(_inputButtonConfirmPassword);
            password.Click();
            password.SendKeys("test123");
            confpass.Click();
            confpass.SendKeys("test123");
        }

        [When(@"I press Sign Up button")]
        public void WhenIPressSignUpButton()
        {

            var signupbutton = driver.FindElement(_inputButtonSignup);
            signupbutton.Click();
        }

        [Then(@"My account should be successful registered\.")]
        public void ThenMyAccountShouldBeSuccessfulRegistered_()
        {
            string mainUrl = "https://loving-hermann-e2094b.netlify.app/";
            if (driver.Url != mainUrl)
                Assert.Fail();
            else
                Assert.Pass();
        }
    }
}
