using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;


namespace FollowIT___Automation
{
    [TestFixture]
   public class Login
    {
        [Test]
        public void UAT(IWebDriver driver)
        {
                
            try {
                driver.FindElement(By.Id("Username")).SendKeys("antoniobuzbuchi");
                driver.FindElement(By.Id("Password")).SendKeys("Test123!");

                driver.FindElement(By.XPath("//button[@value='login']")).Click();
                Thread.Sleep(8000);
            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Login failed");
            }

           
          

        }
    }
}
