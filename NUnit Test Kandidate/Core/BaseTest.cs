using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestKandidate.Core
{

    [SetUpFixture]
    class BaseTest
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected Action action;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(@"C:\Users\user\source\repos\NUnit Test Kandidate\NUnit Test Kandidate\Driver\");
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            action = new Action(wait, driver);
            driver.Navigate().GoToUrl("https://app.kandidate.com/candidates/signup?medium=autotest&source=autotest&campaign=autotest&adgroup=autotest&placement=autotest&content=autotest&device=autotest");
        }

    }

}

