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
            
            try {
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
                Thread.Sleep(2000);

                // Select random organziation from contractdraft
                driver.FindElement(By.XPath("//button[@ng-click='next();']")).Click();
                string[] randomCharacterClient = new string[7] { "a", "b", "c", "d", "e", "i", "f" };
                int indexClient = random.Next(randomCharacterClient.Length);

                driver.FindElement(By.XPath("//input[@type='text'][@placeholder='Please enter the name of the organization']")).SendKeys(randomCharacterClient[indexClient]);
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//input[@type='text'][@placeholder='Please enter the name of the organization']")).SendKeys(Keys.Enter);
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//button[@name='next']")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//button[@name='next']")).Click();

                // add price in and price out
                int priceIn = random.Next(200, 500);
                int priceOUT = random.Next(500, 800);


                driver.FindElement(By.XPath("//input[@ng-model='contractDraft.inRate']")).SendKeys(priceIn.ToString());
                driver.FindElement(By.XPath("//input[@ng-model='contractDraft.outRate']")).SendKeys(priceOUT.ToString());
                Thread.Sleep(1000);

                //add start and end date

                driver.FindElement(By.XPath("//button[@name='save']")).Click();

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to create contract draft");
            }






        }

    }
}
