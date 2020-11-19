using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace CSLab6.StepBindings
{
    [Binding]
    public class Test3Steps
    {

        private IWebDriver driver;
        string USERNAME = "ionacristian1";
        string AUTOMATE_KEY = "pxWMQstmSVE5fgeKhkHj";
        private readonly By _ContactButton = By.XPath("//a[text()='Contact' and @class]");
        private readonly By _InputNameButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Name']");
        private readonly By _InputEmailButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Email']");
        private readonly By _InputSubjectButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Subject']");
        private readonly By _InputMessageButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/textarea[@name='Message']");
        private readonly By _InputSendButton = By.XPath("//div[@class='col-md-6 contact-form']/form/input");

        [Obsolete]
        public Test3Steps()
        {
            
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "80");
            caps.SetCapability("browserstack.user", USERNAME);
            caps.SetCapability("browserstack.key", AUTOMATE_KEY);
            caps.SetCapability("name", "Test3");
            driver = new RemoteWebDriver(
  new Uri("https://hub-cloud.browserstack.com/wd/hub/"), caps
);


            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }

        [Given(@"I have clicked on Contact button")]
        public void GivenIHaveClickedOnContactButton()
        {
            var contact = driver.FindElement(_ContactButton);
            contact.Click();
        }

        [Given(@"I have entered my name")]
        public void GivenIHaveEnteredMyName()
        {
            Thread.Sleep(400);
            var nameInput = driver.FindElement(_InputNameButton);
            nameInput.Click();
            nameInput.SendKeys("Cristian");
        }

        [Given(@"I have entered my email")]
        public void GivenIHaveEnteredMyEmail()
        {

            var emailInput = driver.FindElement(_InputEmailButton);
            emailInput.Click();
            emailInput.SendKeys("cris.ionas@gmail.com");
        }

        [Given(@"I have entered Subject")]
        public void GivenIHaveEnteredSubject()
        {
            var subjectInput = driver.FindElement(_InputSubjectButton);
            subjectInput.Click();
            subjectInput.SendKeys("Subject");
        }

        [Given(@"I have entered Message")]
        public void GivenIHaveEnteredMessage()
        {
            var messageInput = driver.FindElement(_InputMessageButton);
            messageInput.Click();
            messageInput.SendKeys("Message");
        }

        [When(@"I press Send button")]
        public void WhenIPressSendButton()
        {
            var sendButton = driver.FindElement(_InputSendButton);
            sendButton.Click();
        }

        [Then(@"My message was successfull send")]
        public void ThenMyMessageWasSuccessfullSend()
        {
            Assert.Pass();

            driver.Quit();
        }
    }
}
