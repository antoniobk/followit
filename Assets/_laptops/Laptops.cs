using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;


namespace FollowIT___Automation
{
    public class Laptops:LaptopsRandomGenerator
    {
        public void AddLaptop(IWebDriver driver)
        {
            try {
                driver.FindElement(By.XPath("//li[@data-testscript='Laptops']")).Click();
                driver.FindElement(By.XPath("//button[@name='new'")).Click();
                driver.FindElement(By.XPath("//input[@type='name']")).SendKeys(name);
                driver.FindElement(By.XPath("//span[@tabindex='-1']")).Click();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add laptop");
            } 
            
        }
    }
}
