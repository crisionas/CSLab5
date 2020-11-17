using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab5Test
{
    public class UnitTest3
    {
        private IWebDriver driver;
        private readonly By _ContactButton = By.XPath("//a[text()='Contact' and @class]");
        private readonly By _InputNameButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Name']");
        private readonly By _InputEmailButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Email']");
        private readonly By _InputSubjectButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Subject']");
        private readonly By _InputMessageButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/textarea[@name='Message']");
        private readonly By _InputSendButton = By.XPath("//div[@class='col-md-6 contact-form']/form/input");
        

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {

            var contact = driver.FindElement(_ContactButton);
            contact.Click();
            Thread.Sleep(400);
            var nameInput = driver.FindElement(_InputNameButton);
            nameInput.Click();
            nameInput.SendKeys("Cristian");

            var emailInput = driver.FindElement(_InputEmailButton);
            emailInput.Click();
            emailInput.SendKeys("cris.ionas@gmail.com");

            var subjectInput = driver.FindElement(_InputSubjectButton);
            subjectInput.Click();
            subjectInput.SendKeys("Subject");

            var messageInput = driver.FindElement(_InputMessageButton);
            messageInput.Click();
            messageInput.SendKeys("Message");

            var sendButton = driver.FindElement(_InputSendButton);
            sendButton.Click();

        }

    }
}
