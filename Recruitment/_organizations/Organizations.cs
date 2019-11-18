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
    

    public class Organizations : OrganizationsRandomGenerator
    {

        Save save = new Save();
        public void AddOrganization(IWebDriver driver)
        {

           try
            {
                Console.WriteLine(" ===== Adding organization =====");
               
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//li[@data-testscript='Organizations']")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddOrganization']")).Click();
                driver.FindElement(By.XPath("//input[@data-testscript='Name']")).SendKeys(organizationName);
                driver.FindElement(By.XPath("//button[@data-testscript='ButtonCheckOrganization']")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddOrganization']")).Click();
                Thread.Sleep(2000);
            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add new organization");             
            }         

        }


        public void AddOrganizationDetails(IWebDriver driver)
        {

            try
            {
                Console.WriteLine(" ===== Adding general information ===== ");
                driver.FindElement(By.XPath("//input[@data-testscript='ManuallyValidated']")).Click();
                driver.FindElement(By.XPath("//input[@data-testscript='ThirdParty']")).Click();
                driver.FindElement(By.XPath("//input[@name='website']")).SendKeys($"https://www.{organizationWebsite}.be");
                driver.FindElement(By.XPath("//input[@data-testscript='Website']")).SendKeys($"{organizationWebsite}");
                driver.FindElement(By.XPath("//input[@data-testscript='Phone']")).SendKeys("+32 " + organizationPhoneNumber);

                Console.WriteLine(" ===== Adding sales information ===== ");
                driver.FindElement(By.XPath("//input[@data-testscript='SalesLead']")).SendKeys($"{salesLeadFirstName} {salesLeadLastName}");
                save.SaveOnly(driver);

            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add organization details");
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
                driver.FindElement(By.XPath("//button[@data-testscript='ButtonShowActions']")).Click();
                driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddAddress']")).Click();
                driver.FindElement(By.XPath("//input[@name='addressType']")).SendKeys(addressTypeArray[index]);
                driver.FindElement(By.XPath("//input[@data-testscript='Street']")).SendKeys(organizationStreet);
                driver.FindElement(By.XPath("//input[@data-testscript='City']")).SendKeys(organizationCity);
                driver.FindElement(By.XPath("//input[@data-testscript='ZipCode']")).SendKeys(organizationZipCode);
                driver.FindElement(By.XPath("//button[@data-testscript='ButtonSaveActions']")).Click();
                Thread.Sleep(2000);

            }
                
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add organization address");
            }
            
        }


        public void AddOrganizationContactPerson(IWebDriver driver)
        {

            try
            {
                Console.WriteLine(" ===== Adding contact person =====");
                driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddContactPerson']")).Click();
                driver.FindElement(By.XPath("//input[@data-testscript='ContactPersonFirstName']")).SendKeys(contactPersonFirstName);
                driver.FindElement(By.XPath("//input[@data-testscript='ContactPersonLastName']")).SendKeys(contactPersonLastNaME);
                driver.FindElement(By.XPath("//div[@data-testscript='ContactPersonGender']")).Click();
                Thread.Sleep(10000);

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

                driver.FindElement(By.XPath("//button[@data-testscript='ButtonSaveActions']")).Click();
                Thread.Sleep(1000);
                

            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add organization contact person");
               
            }

            save.SaveOnly(driver);
           
           
        }


    }
}
