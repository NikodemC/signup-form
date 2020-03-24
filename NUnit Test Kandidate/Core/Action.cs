using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;


namespace NUnitTestKandidate.Core
{
    class Action
    {
        private WebDriverWait wait;
        private IWebDriver driver;
        int threadWaitTime = 800;

        public Action(WebDriverWait wait, IWebDriver driver)
        {
            this.wait = wait;
            this.driver = driver;
        }

        public void Click(By element, String elementName)
        {
            try
            {
                Thread.Sleep(threadWaitTime);
                wait.Until(ExpectedConditions.ElementToBeClickable((element)));
                driver.FindElement(element).Click();
            }
            catch (Exception)
            {
                Assert.IsTrue(false, "Element '" + elementName + "' is not clickable");
                return;
            }
            Console.WriteLine("Element '" + elementName + "' has been succesfully clicked");
        }


        public void Type(By element, String text, String elementName)
        {
            try
            {
                Thread.Sleep(threadWaitTime);
                wait.Until(ExpectedConditions.ElementToBeClickable((element)));
                driver.FindElement(element).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(element).Clear();
                driver.FindElement(element).SendKeys(text);
            }
            catch (Exception)
            {
                Assert.IsTrue(false, "Couldn't type text in element '" + elementName + "'");
                return;
            }
            Console.WriteLine("Text succesfully typed into element '" + elementName + "'");
        }

        public void compareTexts(By element, String text, String name)
        {
            try
            {
                Thread.Sleep(2000);
                wait.Until(ExpectedConditions.TextToBePresentInElementLocated(element, text));
            }
            catch (Exception)
            {
                Assert.IsTrue(false, "Text of " + name + " buła");
                return;
            }
            Console.WriteLine("Text succesfully compared: '" + name + "'");
        }

        public void Enter(By element)
        {
            driver.FindElement(element).SendKeys(Keys.Return);
        }
}
}