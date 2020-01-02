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
   
    public class Save
    {

        
        public void SaveOnly(IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.XPath("//button[@data-testscript='SaveButton']")).Click();
                Thread.Sleep(3000);

            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ===== Failed to save ===== ");
            }


        }


        public void SaveAndClose(IWebDriver driver)
        {

            try
            {
                driver.FindElement(By.XPath("//button[@data-testscript='SaveCloseButton']")).Click();
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ===== Failed to save ==== ");
            }


        }

    }
}
