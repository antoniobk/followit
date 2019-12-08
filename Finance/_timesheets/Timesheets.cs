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
   public class Timesheets : TimesheetsRandomGenerator
    {
        public void AddTimesheet(IWebDriver driver) 
        {
            Random random = new Random();
            try
            {
                driver.FindElement(By.XPath("//li[@data-testscript='Timesheets']")).Click();
                driver.FindElement(By.XPath("//button[@ng-click='createNewTimesheet()']")).Click();
                int contractId = random.Next(0,10000);
                driver.FindElement(By.Name("contractId")).SendKeys(contractId.ToString());

                
                
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
    }
}
