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


    public class Candidate : CandidateLocators
    {

        Save save = new Save();
        public void AddNewCandidate(IWebDriver driver)
        {
            try
            {
                Console.WriteLine(" ===== Adding new candidate ===== ");

                driver.FindElement(By.XPath(BTN_CANDIDATES)).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.XPath(BUTTON_ADD_CANDIDATE)).Click();
                driver.FindElement(By.XPath(INPUT_CANDIDATE_FIRSTNAME)).SendKeys(firstName);
                driver.FindElement(By.XPath(INPUT_CANDIDATE_LASTNAME)).SendKeys(lastName);
                driver.FindElement(By.XPath(BUTTON_CHECK)).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(BUTTON_ADD_CANDIDATE)).Click();
                Thread.Sleep(3000);

            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add candidate");
            }




        }


        public void AddGeneralInfo(IWebDriver driver)
        {

            try
            {
                Random random = new Random();
                Console.WriteLine(" ===== Adding general information ===== ");
                driver.FindElement(By.XPath(INPUT_PLACEOFBIRTH)).SendKeys(placeOfBirth);
                driver.FindElement(By.XPath(INPUT_BIRTHDATE)).SendKeys(date);
                Thread.Sleep(2000);
                driver.FindElement(By.XPath(NATIONALITY_DROPDWON)).Click();

                string[] nationality = new string[5] { "Belgian", "German", "French", "Greek", "American" };
                int index = random.Next(nationality.Length);

                driver.FindElement(By.XPath($"//span[contains(text(),'{nationality[index]}')]")).Click();
                driver.FindElement(By.XPath(TYPE_)).Click();

                string[] type = new string[4] { "Freelance", "Employee Consulant", "College Student", "Unknown" };
                index = random.Next(type.Length);
                driver.FindElement(By.XPath($"//span[contains(text(),'{type[index]}')]")).Click();

            }

            //driver.FindElement(By.XPath("")).SendKeys(email);


            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add general information");
            }
        }


        public void AddContactDetails(IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.XPath(INPUT_CELLPHONE)).SendKeys($"+32 {cellPhoneNumber}");
                Thread.Sleep(3000);
            }
            //driver.FindElement(By.XPath("")).SendKeys(email);

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add phone number (contact details)");
            }

        }


        public void AddCandidateAddress(IWebDriver driver)
        {

            try
            {
                Random random = new Random();
                int index;
                Console.WriteLine(" ===== Adding address ===== ");
                driver.FindElement(By.Name(INPUT_STREET)).SendKeys(street);
                driver.FindElement(By.Name(INPUT_CITY)).SendKeys(city);
                driver.FindElement(By.Name(INPUT_ZIPCODE)).SendKeys(zipCode);
                driver.FindElement(By.XPath(DROPDOWN_COUNTRY)).Click();
                driver.FindElement(By.XPath("//span[@class='ng-binding ng-scope'][contains(text(),'Belgium')]")).Click();


                Console.WriteLine(" ===== Adding origin =====");
                driver.FindElement(By.XPath(DROPDOWN_ORIGIN)).Click();

                string[] origin = new string[5] { "Linkedin", "Monster", "Stepstone", "Other", "Unknown" };
                index = random.Next(origin.Length);

                driver.FindElement(By.XPath($"//span[contains(text(),'{origin[index]}')]")).Click();



                string[] titleArray = new string[6] { "Tester", ".NET developer", "Architect", "Security analist", "Java developer", "Penetration tester" };
                index = random.Next(titleArray.Length);
                Console.WriteLine(" ===== Adding work details =====");
                driver.FindElement(By.XPath(DROPDOWN_WORKTITLE)).SendKeys(titleArray[index]);
                // driver.FindElement(By.XPath("//div[@data-testscript='ContactBeforeDate']")).Click();
                save.SaveOnly(driver);
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add candidate address");
            }

            
         
        }





        public void AddAction(IWebDriver driver)
        {
            try
            {
                Random random = new Random();
                Console.WriteLine(" ===== Adding action ===== ");
                driver.FindElement(By.XPath(ACTIONS_TAB)).Click();
                driver.FindElement(By.XPath(BUTTON_ADD_ACTION)).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath(DROPDOWN_ACTION_TYPE)).Click();

                string[] actionType = new string[4] { "Email", "Mailing", "LinkedIn", "Interview bij ons" };
                int index = random.Next(actionType.Length);
                driver.FindElement(By.XPath($"//span[contains(text(),'{actionType[index]}')]")).Click();
                driver.FindElement(By.XPath(BUTTON_SAVE_ACTION)).Click();
                Thread.Sleep(2000);

            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add action");
            }
        }




        public void AddTags(IWebDriver driver)

        {
            try
            {
                Console.WriteLine(" ===== Adding tags ===== ");
                driver.FindElement(By.XPath(TAGS_TAB)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath(CHECKBOX)).Click();
                Thread.Sleep(6000);

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add tag");
            }
        }



        public void AddProposal(IWebDriver driver)
        {

            try
            {
                Random random = new Random();
                driver.FindElement(By.XPath(PROPOSALS_TAB)).Click();
                driver.FindElement(By.XPath(BUTTON_ADD_PROPOSAL)).Click();

                int priceIn = random.Next(1, 100);
                driver.FindElement(By.XPath(INPUT_PRICE_IN)).Clear();
                driver.FindElement(By.XPath(INPUT_PRICE_IN)).SendKeys(priceIn.ToString());
                string[] source = new string[4] { "LinkedIn", "FollowIt", "Third Party", "Jobboards" };
                int index = random.Next(source.Length);

                driver.FindElement(By.XPath(PROPOSAL_SOURCE)).Click();
                driver.FindElement(By.XPath($"//span[contains(text(),'{source[index]}')]")).Click();
                Thread.Sleep(1000);

                string[] action = new string[4] { "Email", "InMail", "Face To Face", "Other" };
                index = random.Next(action.Length);

                driver.FindElement(By.XPath(DROPDOWN_PROPOSAL_ACTION)).Click();
                driver.FindElement(By.XPath($"//span[contains(text(),'{action[index]}')]")).Click();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add proposal"); 
                
            }
        }



        public void AddBillingInformation(IWebDriver driver)
        {
            try {
                Random random = new Random();
                string[] juridicalFormsArray = new string[3] { "NV", "BVBA", "Eenmanszaak" };
                int index = random.Next(juridicalFormsArray.Length);

                Console.WriteLine(" ==== Adding billing information ===== ");
                driver.FindElement(By.XPath(BILLING_INFORMATION_TAB)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath(RADIOBTN_FREELANCER)).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath(RESET_VALUES_POPUP_YES)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath(INPUT_NAME)).SendKeys($"{firstName}Company name here");
                driver.FindElement(By.XPath(INPUT_JURIDICALFORM)).SendKeys(juridicalFormsArray[index]);
                Thread.Sleep(1000);
                save.SaveOnly(driver);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to add billing information");
            }    
           


        }



    }

}

