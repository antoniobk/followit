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
    public class Book
    {
        public void createBook(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//li[@data-testscript='Assets']")).Click();
            driver.FindElement(By.XPath("//span[@class='ng-binding'][contains(text(),'Books')]")).Click();
            Random random = new Random();
            string[] naam = new string[3] { "Boek1", "Boek2", "Boek3" };
            int index = random.Next(naam.Length);
            Thread.Sleep(2000);

           

            try
            {
                if (driver.FindElement(By.XPath("//button[@name='new']")).Displayed)
                {
                    Console.WriteLine("Add button is displayed");
                    driver.FindElement(By.XPath("//button[@name='new']")).Click();
                   
                  
                }
            }
            
            catch(Exception)
            {

                Console.WriteLine("Button is not displayed");
                driver.FindElement(By.XPath("//span[@class='ng-binding'][contains(text(),'Cars')]")).Click();
            }
           
            

               driver.FindElement(By.XPath("//input[@name='name']")).SendKeys(naam[index]);


           

           


        }
    }
}
