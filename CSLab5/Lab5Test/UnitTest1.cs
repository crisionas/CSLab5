using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Lab5Test
{
    public class Tests
    {
        private IWebDriver driver;


        private readonly By _signUpButton = By.XPath("//a[text()=' Sign Up ']");
        private readonly By _inputButtonName = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Name']");
        private readonly By _inputButtonEmail = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Email']");
        private readonly By _inputButtonPassword = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='password']");
        private readonly By _inputButtonConfirmPassword = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Confirm Password']");
        private readonly By _inputButtonSignup = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/input");

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

            var signUp = driver.FindElement(_signUpButton);
            signUp.Click();

            var login = driver.FindElement(_inputButtonName);

            Thread.Sleep(400);
            login.Click();
            Thread.Sleep(400);
            login.SendKeys("Cristian");

            var email = driver.FindElement(_inputButtonEmail);
            var password = driver.FindElement(_inputButtonPassword);
            var confpass = driver.FindElement(_inputButtonConfirmPassword);
            var signupbutton = driver.FindElement(_inputButtonSignup);

            email.Click();
            email.SendKeys("crisionas@gmail.com");
            password.Click();
            password.SendKeys("test123");
            confpass.Click();
            confpass.SendKeys("uter123@");
            signupbutton.Click();
            Assert.Pass();

        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}