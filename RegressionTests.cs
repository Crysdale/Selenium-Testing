using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTest.Tests
{
    internal class RegressionTests
    {
        static void ScrollToBottom(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }
        [Test]

        public void HomePageReached()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://bucstop.tylerburleson.work/");
            Assert.That(driver.Title, Is.EqualTo("Home Page - BucStop"));
            driver.Quit();
        }
        [Test]
        public void UserLoginHappyPath()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://bucstop.tylerburleson.work/");
            driver.Manage().Window.Size = new System.Drawing.Size(790, 824);
            driver.FindElement(By.Id("login")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test@etsu.edu");
            driver.FindElement(By.CssSelector(".col-12:nth-child(2) > .btn")).Click();
            Assert.That(driver.Title, Is.EqualTo("Home Page - BucStop"));
            driver.FindElement(By.Id("logout")).Click();
            driver.Quit();
        }
        [Test]
        public void LinkVerification()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://bucstop.tylerburleson.work/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 806);
            driver.FindElement(By.LinkText("Home")).Click();
            Assert.That(driver.Title, Is.EqualTo("Home Page - BucStop"));
            driver.FindElement(By.LinkText("Games")).Click();
            Assert.That(driver.Title, Is.EqualTo("- BucStop"));
            driver.FindElement(By.LinkText("Privacy")).Click();
            Assert.That(driver.Title, Is.EqualTo("Privacy Policy - BucStop"));
            driver.FindElement(By.LinkText("FAQ")).Click();
            Assert.That(driver.Title, Is.EqualTo("Frequently Asked Questions - BucStop"));
            driver.FindElement(By.LinkText("Admin")).Click();
            Assert.That(driver.Title, Is.EqualTo("Admin Page - BucStop"));
            driver.FindElement(By.LinkText("Add Your Game!")).Click();
            Assert.That(driver.Title, Is.EqualTo("Game Criteria - BucStop"));
            driver.Quit();
        }
        [Test]
        public void UserLoginBadPath()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://bucstop.tylerburleson.work/");
            driver.Manage().Window.Size = new System.Drawing.Size(790, 824);
            driver.FindElement(By.Id("login")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test@icloud.com");
            driver.FindElement(By.CssSelector(".col-12:nth-child(2) > .btn")).Click();
            Assert.That(driver.Title, Is.EqualTo("- BucStop"));
            driver.Quit();
        }
        [Test]
        public void GuestLogin()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://bucstop.tylerburleson.work/");
            driver.Manage().Window.Size = new System.Drawing.Size(1056, 808);
            driver.FindElement(By.Id("login")).Click();
            driver.FindElement(By.CssSelector(".col-12:nth-child(1) > .btn")).Click();
            Assert.That(driver.Title, Is.EqualTo("- BucStop"));
            driver.FindElement(By.Id("logout")).Click();
            Assert.That(driver.Title, Is.EqualTo("- BucStop"));
            driver.Quit();
        }
        [Test]
        public void GoToSnake()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://bucstop.tylerburleson.work/");
            driver.Manage().Window.Size = new System.Drawing.Size(1054, 808);
            driver.FindElement(By.Id("login")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test@etsu.edu");
            driver.FindElement(By.CssSelector(".col-12:nth-child(2) > .btn")).Click();
            driver.FindElement(By.LinkText("Games")).Click();
            Assert.That(driver.Title, Is.EqualTo("- BucStop"));
            driver.FindElement(By.CssSelector(".col-sm-3:nth-child(1) .card-title")).Click();
            Assert.That(driver.Title, Is.EqualTo("- BucStop"));
            driver.FindElement(By.CssSelector(".nav-item > .active")).Click();
            Assert.That(driver.Title, Is.EqualTo("- BucStop"));
            driver.FindElement(By.CssSelector(".active:nth-child(1)")).Click();
            Assert.That(driver.Title, Is.EqualTo("- BucStop"));
            driver.FindElement(By.CssSelector(".active:nth-child(1)")).Click();
            Assert.That(driver.Title, Is.EqualTo("- BucStop"));
            driver.FindElement(By.Id("logout")).Click();
            Assert.That(driver.Title, Is.EqualTo("- BucStop"));
            driver.Quit();
        }
        [Test]
        public void GoToTetris()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://bucstop.tylerburleson.work/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            driver.FindElement(By.Id("login")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test@etsu.edu");
            driver.FindElement(By.CssSelector(".col-12:nth-child(2) > .btn")).Click();
            driver.FindElement(By.LinkText("Games")).Click();
            driver.FindElement(By.CssSelector(".col-sm-3:nth-child(2) .card-title")).Click();
            //ScrollToBottom(driver);
            //driver.FindElement(By.CssSelector(".nav-item > .active")).Click();
            //driver.FindElement(By.CssSelector(".active:nth-child(1)")).Click();
            //driver.FindElement(By.CssSelector(".active:nth-child(1)")).Click();
            //driver.FindElement(By.Id("logout")).Click();
            driver.Quit();
        }
    }
}
