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
   public class Contractdrafts : ContractdraftsLocators
    {
        public void AddNewContractDraft(IWebDriver driver)
        {
            Random random = new Random();
            
           
                driver.FindElement(By.XPath(BTN_CONTRACTDRAFTS)).Click();
                driver.FindElement(By.XPath(BTN_NEW_CONTRACTDRAFTS)).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath(RADIOBTN_STARTFROM)).Click();
                driver.FindElement(By.XPath(BTN_NEXT)).Click();

                // Select random candidate for contractdraft
                string[] randomCharacter = new string[7] { "a", "b", "c", "d", "e", "i", "f" };
                int index = random.Next(randomCharacter.Length);
                driver.FindElement(By.XPath(INPUT_CANDIDATE_OR_CLIENT_NAME)).SendKeys(randomCharacter[index]);
                Thread.Sleep(4000);
                driver.FindElement(By.XPath(INPUT_CANDIDATE_OR_CLIENT_NAME)).SendKeys(Keys.Enter);
                Thread.Sleep(2000);
                driver.FindElement(By.XPath(BTN_NEXT)).Click();
                
                // Select random organziation from contractdraft
                driver.FindElement(By.XPath(INPUT_CANDIDATE_OR_CLIENT_NAME)).Click();
                string[] randomCharacterClient = new string[7] { "a", "b", "c", "d", "e", "i", "f" };
                int indexClient = random.Next(randomCharacterClient.Length);

                driver.FindElement(By.XPath(INPUT_CANDIDATE_OR_CLIENT_NAME)).SendKeys(randomCharacterClient[indexClient]);
                Thread.Sleep(4000);
                driver.FindElement(By.XPath(INPUT_CANDIDATE_OR_CLIENT_NAME)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);
                driver.FindElement(By.XPath(BTN_NEXT)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath(BTN_NEXT)).Click();

                // add price in and price out
                int priceIn = random.Next(200, 500);
                int priceOUT = random.Next(500, 800);


                driver.FindElement(By.XPath(PRICE_IN)).SendKeys(priceIn.ToString());
                driver.FindElement(By.XPath(PRICE_OUT)).SendKeys(priceOUT.ToString());
                Thread.Sleep(1000);

            //add start and end date

            driver.FindElement(By.XPath(SAVE)).Click();


        }

    }
}
