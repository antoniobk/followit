﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;



namespace FollowIT___Automation
{
    class Login
    {

        public static void loginUat(IWebDriver driver)

        {
            driver.FindElement(By.Id("Username")).SendKeys("antoniobuzbuchi");
            driver.FindElement(By.Id("Password")).SendKeys("Test123!");

            driver.FindElement(By.XPath("//button[@value='login']")).Click();
            System.Threading.Thread.Sleep(10000);
        }
    }
}
