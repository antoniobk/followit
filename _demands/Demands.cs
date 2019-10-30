using System;
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
    public class Demands
    {
        public static void AddDemand(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//li[@data-testscript='Recruitment']")).Click();
            driver.FindElement(By.XPath("//li[@data-testscript='Demands']")).Click();
            driver.FindElement(By.XPath("//button[@ng-click='addDemand()']")).Click();


        }

        public static void AddDemandDetails(IWebDriver driver)
        {
            
            driver.FindElement(By.XPath("//input[@name='title']")).SendKeys("Title");
            driver.FindElement(By.XPath("//input[@name='PostingTitle']")).SendKeys("PostingTitle");


        }
    }
}
