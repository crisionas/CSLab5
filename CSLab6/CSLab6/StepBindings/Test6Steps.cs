using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CSLab6.StepBindings
{
    [Binding]
    public class Test6Steps
    {
        private IWebDriver driver;

        private readonly By _InputSearch = By.XPath("//div[@class='col-md-4 header-middle']/form[1]/input[1]");
        private readonly By _SearchButton = By.XPath("//div[@class='col-md-4 header-middle']/form[1]/input[2]");

        public Test6Steps()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }

        [Given(@"I have entered Searched item")]
        public void GivenIHaveEnteredSearchedItem()
        {
            var searchInput = driver.FindElement(_InputSearch);
            searchInput.Click();
            searchInput.SendKeys("shoes");
        }
        
        [When(@"I press Search button")]
        public void WhenIPressSearchButton()
        {
            var link1 = driver.FindElement(_SearchButton);
            link1.Click();
        }
        
        [Then(@"The searched item appears\.")]
        public void ThenTheSearchedItemAppears_()
        {
            string mainUrl = "https://loving-hermann-e2094b.netlify.app/";
            if (driver.Url != mainUrl)
                Assert.Fail();
            else
                Assert.Pass();
        }
    }
}
