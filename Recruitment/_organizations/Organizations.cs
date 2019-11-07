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
                driver.FindElement(By.XPath("//button[@name='new'][contains(text(),'Add')]")).Click();
                driver.FindElement(By.Name("name")).SendKeys(organizationName);
                driver.FindElement(By.XPath("//button[@ng-click='check()']")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//button[@ng-click='addOrganization(organization)']")).Click();
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
                driver.FindElement(By.XPath("//input[@type='checkbox'][@ng-model='organization.isManuallyValidated']")).Click();
                driver.FindElement(By.XPath("//input[@type='checkbox'][@ng-model='organization.isPartner']")).Click();
                driver.FindElement(By.XPath("//input[@name='website']")).SendKeys($"https://www.{organizationWebsite}.be");
                driver.FindElement(By.XPath("//input[@name='tradeName']")).SendKeys($"{organizationWebsite}");
                driver.FindElement(By.XPath("//input[@name='phone']")).SendKeys("+32 " + organizationPhoneNumber);

                Console.WriteLine(" ===== Adding sales information ===== ");
                driver.FindElement(By.XPath("//input[@name='salesLead']")).SendKeys($"{salesLeadFirstName} {salesLeadLastName}");
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
                driver.FindElement(By.XPath("//button[@ng-click='showLeftFooterButtonsClicked()']")).Click();
                driver.FindElement(By.XPath("//button[@name='addAddress']")).Click();
                driver.FindElement(By.XPath("//input[@name='addressType']")).SendKeys(addressTypeArray[index]);
                driver.FindElement(By.XPath("//input[@name='street']")).SendKeys(organizationStreet);
                driver.FindElement(By.XPath("//input[@name='city']")).SendKeys(organizationCity);
                driver.FindElement(By.XPath("//input[@name='zipCode']")).SendKeys(organizationZipCode);
                driver.FindElement(By.XPath("//textarea[@ng-model='address.extraInfo']")).SendKeys("Extra info here..");
                driver.FindElement(By.XPath("//button[@name='saveAdress']")).Click();
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
                driver.FindElement(By.XPath("//button[@name='addContactperson']")).Click();
                driver.FindElement(By.XPath("//input[@ng-model='cp.firstName']")).SendKeys(contactPersonFirstName);
                driver.FindElement(By.XPath("//input[@ng-model='cp.lastName']")).SendKeys(contactPersonLastNaME);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/form/div/div[2]/div[4]/div/div/div/div[1]/span")).Click();

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

                driver.FindElement(By.XPath("//button[@name='saveAdress']")).Click();
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
