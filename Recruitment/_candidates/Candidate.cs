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
   

    public class Candidate : CandidateRandomGenerator
    {

        Save save = new Save();
        public void AddNewCandidate(IWebDriver driver)
        { 
            try {
                Console.WriteLine(" ===== Adding new candidate ===== ");

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
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add new candidate");
            
            }
               
        }


        public void AddGeneralInfo(IWebDriver driver)
        {
            try
            {
                Random random = new Random();
                Console.WriteLine(" ===== Adding general information ===== ");
                driver.FindElement(By.XPath("//input[@data-testscript='PlaceOfBirth']")).SendKeys(placeOfBirth);
                driver.FindElement(By.XPath("//input[@name='birthdate']")).SendKeys(date);
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//div[@data-testscript='Nationality']")).Click();

                string[] nationality = new string[5] { "Belgian", "German", "French", "Greek", "American" };
                int index = random.Next(nationality.Length);

                driver.FindElement(By.XPath($"//span[contains(text(),'{nationality[index]}')]")).Click();
                driver.FindElement(By.XPath("//div[@data-testscript='Type']")).Click();

                string[] type = new string[4] { "Freelance", "Employee Consulant", "College Student", "Unknown" };
                index = random.Next(type.Length);
                driver.FindElement(By.XPath($"//span[contains(text(),'{type[index]}')]")).Click();
               
                //driver.FindElement(By.XPath("")).SendKeys(email);

            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ===== Failed to add general information ===== ");
            }

        }

        public void AddContactDetails(IWebDriver driver)
        {
            try
            {                        
                driver.FindElement(By.XPath("//input[@data-testscript='Cellphone']")).SendKeys("+32 " + cellPhoneNumber);
                Thread.Sleep(3000);
                //driver.FindElement(By.XPath("")).SendKeys(email);
            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ===== Failed to add contact details ===== ");
            }

        }


        public void AddCandidateAddress(IWebDriver driver) {

            try
            {
                Random random = new Random();
                int index;
                Console.WriteLine(" ===== Adding address ===== ");
                driver.FindElement(By.Name("street")).SendKeys(street);
                driver.FindElement(By.Name("city")).SendKeys(city);
                driver.FindElement(By.Name("zipCode")).SendKeys(zipCode);
                driver.FindElement(By.XPath("//div[@data-testscript='Country']")).Click();
                driver.FindElement(By.XPath("//span[@class='ng-binding ng-scope'][contains(text(),'Belgium')]")).Click();


                Console.WriteLine(" ===== Adding origin =====");
                driver.FindElement(By.XPath("//div[@data-testscript='Origin']")).Click();

                string[] origin = new string[5] { "Linkedin", "Monster", "Stepstone", "Other", "Unknown" };
                index = random.Next(origin.Length);

                driver.FindElement(By.XPath($"//span[contains(text(),'{origin[index]}')]")).Click();



                string[] titleArray = new string[6] { "Tester", ".NET developer", "Architect", "Security analist", "Java developer", "Penetration tester" };
                index = random.Next(titleArray.Length);
                Console.WriteLine(" ===== Adding work details =====");
                driver.FindElement(By.XPath("//input[@data-testscript='WorkTitle']")).SendKeys(titleArray[index]);
                // driver.FindElement(By.XPath("//div[@data-testscript='ContactBeforeDate']")).Click();
                save.SaveOnly(driver);
            }
                        
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ===== Failed to add candidate address ===== ");
            }


        }


        public void AddAction(IWebDriver driver)
        {

            try {

                Random random = new Random();
                Console.WriteLine(" ===== Adding action ===== ");
                driver.FindElement(By.XPath("//li[@data-testscript='ActionsTab']")).Click();
                driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddAction']")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//div[@data-testscript='ActionType']")).Click();

                string[] actionType = new string[4] { "Email", "Mailing", "LinkedIn", "Interview bij ons" };
                int index = random.Next(actionType.Length);
                driver.FindElement(By.XPath($"//span[contains(text(),'{actionType[index]}')]")).Click();
                driver.FindElement(By.XPath("//button[@data-testscript='ButtonSaveAction']")).Click();
                Thread.Sleep(2000);
            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ==== Failed to add action ==== ");
            }

        }

        
        public void AddTags(IWebDriver driver)
        {
            try {

                Console.WriteLine(" ===== Adding tags ===== ");
                driver.FindElement(By.XPath("//li[@data-testscript='TagsTab']")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//input[@data-testscript='CheckBoxTag']")).Click();
                Thread.Sleep(4000);
            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ===== Failed to add candidate tags ===== ");
            }           

        }

        public static void AddProposal(IWebDriver driver)
        {
            try {

                Random random = new Random();
                driver.FindElement(By.XPath("//li[@data-testscript='ProposalTab']")).Click();
                driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddProposal']")).Click();
                
                int priceIn = random.Next(1, 100);
                driver.FindElement(By.XPath("//input[@name='PostingTitle']")).Clear();
                driver.FindElement(By.XPath("//input[@name='PostingTitle']")).SendKeys(priceIn.ToString());
                string[] source = new string[4] { "LinkedIn", "FollowIt", "Third Party", "Jobboards" };
                int index = random.Next(source.Length);

                driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div[4]/div/div/div[1]/div/div/div/form/div/fieldset[2]/div/div[6]/div[1]/div[1]/div/div[1]/span/span[2]/span")).Click();
                driver.FindElement(By.XPath($"//span[contains(text(),'{source[index]}')]")).Click();
                Thread.Sleep(1000);

                string[] action = new string[4] { "Email", "InMail", "Face To Face", "Other" };
                index = random.Next(action.Length);

                driver.FindElement(By.XPath("//div[@data-testscript='ProposalAction']")).Click();
                driver.FindElement(By.XPath($"//span[contains(text(),'{action[index]}')]")).Click(); 

            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ===== Failed to add proposal ===== ");
            }

           
        }


        public void AddBillingInformation(IWebDriver driver)
        {

            try
            {
                Random random = new Random();
                string[] juridicalFormsArray = new string[3] { "NV", "BVBA", "Eenmanszaak" };
                int index = random.Next(juridicalFormsArray.Length);

                Console.WriteLine(" ==== Adding billing information ===== ");
                driver.FindElement(By.XPath("//li[@data-testscript='BillingInformationTab']")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//input[@name='freelancer']")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//button[@data-bb-handler='confirm']")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//input[@name='name']")).SendKeys($"{firstName}Company name here");
                driver.FindElement(By.XPath("//input[@name='juridicalForm']")).SendKeys(juridicalFormsArray[index]);
                Thread.Sleep(1000);
                save.SaveOnly(driver);
                

            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ===== Failed to add billing information ===== ");
            }
          

        }
      

    }
}
