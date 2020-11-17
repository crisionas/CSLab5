using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Test
{
    public class UnitTest4
    {
        private IWebDriver driver;

        private readonly By _InstagramMediaButton = By.XPath("//div[@class='footer']/div/div/ul/li/a/div/i[@class='fa fa-facebook']");
        private readonly By _TwitterMediaButton = By.XPath("//div[@class='footer']/div/div/ul/li/a/div/i[@class='fa fa-twitter']");
        private readonly By _OKMediaButton = By.XPath("//div[@class='footer']/div/div/ul/li/a/div/i[@class='fa fa-instagram']");
        private readonly By _LinkMediaButton = By.XPath("//div[@class='footer']/div/div/ul/li/a/div/i[@class='fa fa-linkedin']");
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test4()
        {
            var link1 = driver.FindElement(_InstagramMediaButton);
            link1.Click();

            driver.Navigate().Back();
            var link2 = driver.FindElement(_TwitterMediaButton);
            link2.Click();

            driver.Navigate().Back();
            var link3 = driver.FindElement(_OKMediaButton);
            link3.Click();

            driver.Navigate().Back();
            var link4 = driver.FindElement(_LinkMediaButton);
            link4.Click();
        }
    }
}
