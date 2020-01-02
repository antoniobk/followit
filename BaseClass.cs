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
    class BaseClass
    {
        [SetUp]
        //Before Class
        public void SetupApplication(IWebDriver driver)
        {
            try
            {
                Console.WriteLine(" ===== Browser Session Started ===== ");

                driver.Navigate().GoToUrl("https://t4t-followit-uat.azurewebsites.net");
                driver.Manage().Window.Maximize();

                Console.WriteLine(" ===== Application Started ===== ");
            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to open url");
            }
        }

        //After Class

        public void CloseApplication(IWebDriver driver)
        {

            try
            {
                driver.Close();
                Console.WriteLine("=====Browser Session End=====");
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to close browser");
            }
        }

    }
}
