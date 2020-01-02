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
    
    public class Demands : DemandsLocators
    {
        public void AddDemand(IWebDriver driver)
        {

            try
            {
                Console.WriteLine("Adding new demand");
                driver.FindElement(By.XPath(BTN_DEMANDS)).Click();
                driver.FindElement(By.XPath(BTN_ADD_DEMAND)).Click();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add demand");
            }
        }
        
        public void AddDemandDetails(IWebDriver driver)
        {

            try
            {
                Random random = new Random();

                Console.WriteLine("Adding general information");
                string[] titleArray = new string[5] { "PHP developer", "Security Analist", "Java developer", "Automation tester", "React developer" };
                int index = random.Next(titleArray.Length);
                var title = titleArray[index];

                driver.FindElement(By.XPath("//input[@name='title']")).SendKeys(titleArray[index]);



                switch (index)
                {
                    case 0:
                        driver.FindElement(By.XPath(INPUT_POSTING_TITLE)).SendKeys("We are looking for a php developer.");
                        break;

                    case 1:
                        driver.FindElement(By.XPath(INPUT_POSTING_TITLE)).SendKeys("We are looking for a Security Analist");
                        break;

                    case 2:
                        driver.FindElement(By.XPath(INPUT_POSTING_TITLE)).SendKeys("We are looking for a Java developer");
                        break;

                    case 3:
                        driver.FindElement(By.XPath(INPUT_POSTING_TITLE)).SendKeys("We are looking for an Automation Tester");
                        break;

                    case 4:
                        driver.FindElement(By.XPath(INPUT_POSTING_TITLE)).SendKeys("We are looking for a React developer");
                        break;
                }

                string[] client = new string[3] { "a", "w", "y" };
                int clientCharacter = random.Next(client.Length);

                driver.FindElement(By.XPath(INPUT_CLIENT_PROSPECT)).SendKeys(client[clientCharacter]);
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div[2]/div/div/div/div/div/div[1]/div/form/fieldset[2]/div/div/div[6]/div/div/ul/li[1]/a")).SendKeys(Keys.Enter);

                driver.FindElement(By.XPath(INPUT_START_DATE)).SendKeys(startingDate);
                driver.FindElement(By.XPath(INPUT_END_DATE)).SendKeys(closingDate);


                int maxDayPrice = random.Next(100, 300);
                driver.FindElement(By.XPath(INPUT_MAX_DAYPRICE)).SendKeys($"€ {maxDayPrice}");

                var duration = random.Next(2, 8);
                driver.FindElement(By.XPath(DURATION)).SendKeys($"{duration} months");
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add demand details");
            }

          }

      
    }
}
