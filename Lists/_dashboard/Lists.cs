using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;


namespace FollowIT___Automation
{
    public class Lists
    {
       
        public void CreateList(IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.XPath("/html/body/div[4]/nav/div/ul/li[5]/ul/li/a")).Click();
                driver.FindElement(By.XPath("//button[@name='new']")).Click();
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/div/div/div/div[1]/div/div[1]/span")).Click();

                string[] type = new string[5] { "Candidate", "Organization", "Field Staff", "Office Staff", "Contact Person" };
                Random random = new Random();
                int index = random.Next(type.Length);

                string listName = new Bogus.DataSets.Lorem().Word();
                driver.FindElement(By.XPath($"//span[contains(text(),'{type[index]}')]")).Click();
                driver.FindElement(By.XPath("//input[@name='listType']")).SendKeys(listName);
                driver.FindElement(By.XPath("//button[@name='save']")).Click();

            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to create list");

            }
            
        }
    }
}
