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
   public class Contractdrafts : ContractDraftsRandomGenerator
    {
        public void AddNewContractDraft(IWebDriver driver)
        {
            Random random = new Random();
            
            driver.FindElement(By.XPath("//li[@data-testscript='Contractdrafts']")).Click();
            driver.FindElement(By.XPath("//button[@ng-click='newContractDraft()']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@ng-click='setStartProposal(false)']")).Click();
            driver.FindElement(By.XPath("//button[@ng-click='next();']")).Click();

            // Select random candidate for contractdraft
            string[] randomCharacter = new string[7] { "a", "b", "c", "d", "e", "i", "f" };
            int index = random.Next(randomCharacter.Length);
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(randomCharacter[index]);
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(Keys.Enter);

            // Select random organziation from contractdraft
            driver.FindElement(By.XPath("//button[@ng-click='next();']")).Click();
            

        }

    }
}
