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
   
    class Save
    {

        
        public static void SaveOnly(IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.XPath("//button[@data-testscript='SaveButton']")).Click();
                Thread.Sleep(3000);

            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to save only");
            }


        }


        public static void SaveAndClose(IWebDriver driver)
        {

            try
            {
                driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div[6]/div/div[2]/footer-action-buttons/div/button[2]")).Click();
            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to save and close");
            }


        }

    }
}
