using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace FollowIT___Automation
{
    class BaseClass
    {

        //Before Class
        public static void setupApplication(IWebDriver driver)
        {
            Console.WriteLine(" ===== Browser Session Started ===== ");
            
            driver.Navigate().GoToUrl("https://t4t-followit-uat.azurewebsites.net");
            driver.Manage().Window.Maximize();

            Console.WriteLine(" ===== Application Started ===== ");
        }

        //After Class

        public static void closeApplication(IWebDriver driver)
        {
            driver.Close();
           Console.WriteLine("=====Browser Session End=====");

        }

    }
}
