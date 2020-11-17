using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Test
{
    public class UnitTest5
    {
        private IWebDriver driver;

        private readonly By _WearButton = By.XPath("//div[@class='bb-middle-agileits-w3layouts grid']/figure[@class='effect-roxy' and 1]/figcaption[1]/h3[1]");
        private readonly By _ItemButton = By.XPath("//div[2]/div[@class='men-pro-item simpleCart_shelfItem' and 1]/div[@class='item-info-product ' and 2]/h4[1]/a[1]");
        private readonly By _ReviewButton = By.XPath("//div[1]/ul[@class='resp-tabs-list' and 1]/li[@class='resp-tab-item' and 2]");
        private readonly By _InputName = By.XPath("//div[@class='add-review']/form[1]/input[1]");
        private readonly By _InputEmail = By.XPath("//div[@class='add-review']/form[1]/input[2]");
        private readonly By _InputMessage = By.XPath("//form/textarea[1]");
        private readonly By _SendButton = By.XPath("//div[@class='add-review']/form[1]/input[3]");

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test5()
        {
            var link1 = driver.FindElement(_WearButton);
            link1.Click();
            var link2 = driver.FindElement(_ItemButton);
            link2.Click();
            var link3 = driver.FindElement(_ReviewButton);
            link3.Click();
            var NameInput = driver.FindElement(_InputName);
            NameInput.Click();
            NameInput.SendKeys("Cristian");

            var emailInput = driver.FindElement(_InputEmail);
            emailInput.Click();
            emailInput.SendKeys("cris.ionas@gmail.com");

            var MessageInput = driver.FindElement(_InputMessage);
            MessageInput.Click();
            MessageInput.SendKeys("Test123");

            var link4 = driver.FindElement(_SendButton);
            link4.Click();
        }

    }
}
