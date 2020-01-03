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
    

    public class Organizations : OrganizationLocators
    {

        Save save = new Save();
        public void AddOrganization(IWebDriver driver)
        {
       
                Console.WriteLine(" ===== Adding organization =====");
            try
            {
                Thread.Sleep(1000);
                driver.FindElement(By.XPath(BTN_ORGANIZATIONS)).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath(BUTTON_ADD_ORGANIZATION)).Click();
                driver.FindElement(By.XPath(INPUT_ORGANIZATION_NAME)).SendKeys(organizationName);
                driver.FindElement(By.XPath(BUTTON_CHECK_ORGANIZATION)).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(BUTTON_ADD_ORGANIZATION)).Click();
                Thread.Sleep(2000);
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add organization");
            }

         }




        public void AddOrganizationDetails(IWebDriver driver)
        {
            Console.WriteLine(" ===== Adding general information ===== ");
            try
            {

                driver.FindElement(By.XPath(RADIO_BTN_MANUALLY)).Click();
                driver.FindElement(By.XPath(RADIO_BTN_THIRDPARTY)).Click();
                driver.FindElement(By.XPath(INPUT_WEBSITE)).SendKeys($"https://www.{organizationWebsite}.be");
             //   driver.FindElement(By.XPath(INPUT_PHONE)).SendKeys("+32 " + organizationPhoneNumber);

                Console.WriteLine(" ===== Adding sales information ===== ");
                driver.FindElement(By.XPath(INPUT_SALESLEAD)).SendKeys($"{salesLeadFirstName} {salesLeadLastName}");
                save.SaveOnly(driver);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

        }
            

          
           
        

     
        public void AddOrganizationAddress(IWebDriver driver)
        {
            try
            {
                Random random = new Random();
                string[] addressTypeArray = new string[4] { "home", "business", "billing", "shipping" };
                int index = random.Next(addressTypeArray.Length);
                Console.WriteLine(" ===== Adding address =====");
                driver.FindElement(By.XPath(BTN_SHOWACTIONS)).Click();
                driver.FindElement(By.XPath(BTN_ADDADDRESS)).Click();
                driver.FindElement(By.XPath(INPUT_ADDRESSTYPE)).SendKeys(addressTypeArray[index]);
                driver.FindElement(By.XPath(INPUT_STREET)).SendKeys(organizationStreet);
                driver.FindElement(By.XPath(INPUT_CITY)).SendKeys(organizationCity);
                driver.FindElement(By.XPath(INPUT_ZIPCODE)).SendKeys(organizationZipCode);
                driver.FindElement(By.XPath(BTN_SAVEACTIONS)).Click();
                Thread.Sleep(2000);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add organization add");
            }
        }


        public void AddOrganizationContactPerson(IWebDriver driver)
        {

            try
            {
                Console.WriteLine(" ===== Adding contact person =====");
                driver.FindElement(By.XPath(BTN_ADD_CONTACTPERSON)).Click();
                driver.FindElement(By.XPath(INPUT_CONTACTPERSON_FIRSTNAME)).SendKeys(contactPersonFirstName);
                driver.FindElement(By.XPath(INPUT_CONTACTPERSON_LASTNAME)).SendKeys(contactPersonLastNaME);
                driver.FindElement(By.XPath(DROPDOWN_CONTACTPERSON_GENDER)).Click();
                Thread.Sleep(100);

                //select random male or female in gender dropdown
                Random random = new Random();
                int maleFemale = random.Next(0, 10);
                string male = "//span[@ng-bind='sex.value'][contains(text(), 'Male')]";
                string female = "//span[@ng-bind='sex.value'][contains(text(), 'Female')]";

                if (maleFemale > 5)
                {
                    driver.FindElement(By.XPath($"{male}")).Click();
                }

                else
                {
                    driver.FindElement(By.XPath($"{female}")).Click();
                }

                driver.FindElement(By.Name("saveAdress")).Click();
                Thread.Sleep(1000);
                save.SaveOnly(driver);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add contact person");
            }
           
        }

      



    }
}
