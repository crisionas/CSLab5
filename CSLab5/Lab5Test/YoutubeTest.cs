using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Test
{
    class YoutubeTest
    {
        private IWebDriver driver;

        private readonly By _searchInput = By.XPath("//input[@id='search']");
        private readonly By _searchButton = By.XPath("//button[@id='search-icon-legacy']");

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var link = driver.FindElement(_searchInput);

            link.Click();
            link.SendKeys("computer");

            var search_btn = driver.FindElement(_searchButton);
            search_btn.Click();
        }
    }
}
