using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;



namespace FollowIT___Automation
{

    
    public class Candidate : CandidateRandomGenerator

    {
       
       

        public void AddNewCandidate(IWebDriver driver)
        { 
            
            Console.WriteLine(" ===== Adding new candidate ===== ");
            driver.FindElement(By.XPath("//li[@data-testscript='Recruitment']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//li[@data-testscript='Candidates']")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddCandidate']")).Click();
            driver.FindElement(By.XPath("//input[@data-testscript='Firstname']")).SendKeys(firstName);
            driver.FindElement(By.XPath("//input[@data-testscript='Lastname']")).SendKeys(lastName);
            driver.FindElement(By.XPath("//button[@data-testscript='ButtonCheckCandidate']")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddCandidate']")).Click();
            Thread.Sleep(3000);

        }

        public void AddCandidateDetails(IWebDriver driver)
        {


            Console.WriteLine(" ===== Adding general info ===== ");
            driver.FindElement(By.XPath("//input[@data-testscript='PlaceOfBirth']")).SendKeys(placeOfBirth);
            driver.FindElement(By.XPath("//input[@name='birthdate']")).SendKeys(date);
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//div[@data-testscript='Nationality']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'American')]")).Click();
            driver.FindElement(By.XPath("//div[@data-testscript='Type']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Employee Consulant')]")).Click();

            driver.FindElement(By.XPath("//input[@data-testscript='Cellphone']")).SendKeys("+32 " + cellPhoneNumber);

            Thread.Sleep(3000);
            //driver.FindElement(By.XPath("")).SendKeys(email);

            Console.WriteLine(" ===== Adding address info ===== ");
            driver.FindElement(By.Name("street")).SendKeys(street);
            driver.FindElement(By.Name("city")).SendKeys(city);
            driver.FindElement(By.Name("zipCode")).SendKeys(zipCode);
            driver.FindElement(By.XPath("//div[@data-testscript='Country']")).Click();
            driver.FindElement(By.XPath("//span[@class='ng-binding ng-scope'][contains(text(),'Belgium')]")).Click();

            driver.FindElement(By.XPath("//div[@data-testscript='Origin']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Stepstone')]")).Click();




            driver.FindElement(By.XPath("//input[@data-testscript='WorkTitle']")).SendKeys("Ontwikkelaar");
            // only use if availability date is entered
            //driver.FindElement(By.XPath("//div[@data-testscript='ContactBeforeDate']")).Click();

        }



        public void Save(IWebDriver driver)
        {
            Console.WriteLine(" ===== Saving ===== ");
            driver.FindElement(By.XPath("//button[@data-testscript='SaveButton']")).Click();
            Thread.Sleep(5000);
        }

        public void AddAction(IWebDriver driver)
        {
            Console.WriteLine(" ===== Adding action ===== ");
            driver.FindElement(By.XPath("//li[@data-testscript='ActionsTab']")).Click();
            driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddAction']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@data-testscript='ActionType']")).Click();

            driver.FindElement(By.XPath("//span[contains(text(),'Email')]")).Click();
            driver.FindElement(By.XPath("//button[@data-testscript='ButtonSaveAction']")).Click();
            Thread.Sleep(2000);
        }

        public void AddTags(IWebDriver driver)
        {
            Console.WriteLine(" ===== Adding tags ===== ");           
            driver.FindElement(By.XPath("//li[@data-testscript='TagsTab']")).Click();
            driver.FindElement(By.XPath("//input[@data-testscript='CheckBoxTag']")).Click();
            Thread.Sleep(4000);
        }

        public void AddBillingInformation(IWebDriver driver)
        {
            Random random = new Random();
            string[] juridicalFormsArray = new string[3] { "NV", "BVBA", "Eenmanszaak" };
            int index = random.Next(juridicalFormsArray.Length);
            
            Console.WriteLine(" ==== Adding billing information ===== ");
            driver.FindElement(By.XPath("//li[@data-testscript='BillingInformationTab']")).Click();
            driver.FindElement(By.XPath("//input[@name='freelancer']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@data-bb-handler='confirm']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@name='name']")).SendKeys($"{firstName}Company name here");
            driver.FindElement(By.XPath("//input[@name='juridicalForm']")).SendKeys(juridicalFormsArray[index]);
            Thread.Sleep(1000);
            


        }



    }
}
