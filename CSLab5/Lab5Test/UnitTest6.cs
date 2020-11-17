using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Test
{
    class UnitTest6
    {
        private IWebDriver driver;

        private readonly By _InputSearch = By.XPath("//div[@class='col-md-4 header-middle']/form[1]/input[1]");
        private readonly By _SearchButton = By.XPath("//div[@class='col-md-4 header-middle']/form[1]/input[2]");
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test6()
        {
            var searchInput = driver.FindElement(_InputSearch);
            searchInput.Click();
            searchInput.SendKeys("shoes");

            var link1 = driver.FindElement(_SearchButton);
            link1.Click();
        }
    }
}
