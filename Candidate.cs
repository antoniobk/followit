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
    public class Candidate : RandomDataGenerator
    {

        string firstName = new Bogus.DataSets.Name("nl_BE").FirstName();
        string lastName = new Bogus.DataSets.Name("nl_BE").LastName();

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

        public void AddGeneralInfo(IWebDriver driver)
        {
            var placeOfBirth = new Bogus.DataSets.Address("nl_BE").City();
            var date = new Bogus.DataSets.Date().Past(20).ToString("dd-MM-yyyy");
            Console.WriteLine(" ===== Adding general info ===== ");
            driver.FindElement(By.XPath("//input[@data-testscript='PlaceOfBirth']")).SendKeys(placeOfBirth);
            driver.FindElement(By.XPath("//input[@name='birthdate']")).SendKeys(date);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@data-testscript='Nationality']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'American')]")).Click();
            driver.FindElement(By.XPath("//div[@data-testscript='Type']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Employee Consulant')]")).Click();
        }

        public void AddContactInformation(IWebDriver driver)
        {
            var cellPhoneNumber = new Bogus.DataSets.PhoneNumbers().PhoneNumber("### ## ## ##");

            Console.WriteLine(" ===== Adding contact info ===== ");
            driver.FindElement(By.XPath("//input[@data-testscript='Cellphone']")).SendKeys("+32 " + cellPhoneNumber);

            Thread.Sleep(3000);
            //driver.FindElement(By.XPath("")).SendKeys(email);
        }

        public void AddAddress(IWebDriver driver)
        {
            var street = new Bogus.DataSets.Address("nl_BE").StreetName();
            var city = new Bogus.DataSets.Address("nl_BE").City();
            var zipCode = new Bogus.DataSets.Address("nl_BE").ZipCode();

            Console.WriteLine(" ===== Adding address info ===== ");
            driver.FindElement(By.Name("street")).SendKeys(street);
            driver.FindElement(By.Name("city")).SendKeys(city);
            driver.FindElement(By.Name("zipCode")).SendKeys(zipCode);
            driver.FindElement(By.XPath("//div[@data-testscript='Country']")).Click();
            driver.FindElement(By.XPath("//span[@class='ng-binding ng-scope'][contains(text(),'Belgium')]")).Click();
        }

        public void AddOrigin(IWebDriver driver)
        {
            Console.WriteLine(" ===== Adding origin info ===== ");
            driver.FindElement(By.XPath("//div[@data-testscript='Origin']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Stepstone')]")).Click();

        }

        public void AddWorkDetails(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//input[@data-testscript='WorkTitle']")).SendKeys("Ontwikkelaar");
            // only use if availability date is entered
            //driver.FindElement(By.XPath("//div[@data-testscript='ContactBeforeDate']")).Click();
        }
        public void Save(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//button[@data-testscript='SaveButton']")).Click();
            Thread.Sleep(3000);
        }

        public void AddAction(IWebDriver driver)
        {
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
                       
            driver.FindElement(By.XPath("//li[@data-testscript='TagsTab']")).Click();
            driver.FindElement(By.XPath("//input[@data-testscript='CheckBoxTag']")).Click();
            Thread.Sleep(1000);
        }

        public void AddBillingInformation(IWebDriver driver)
        {
            Random random = new Random();
            string[] juridicalFormsArray = new string[3] { "NV", "BVBA", "Eenmanszaak" };
            int index = random.Next(juridicalFormsArray.Length);

            driver.FindElement(By.XPath("//li[@data-testscript='BillingInformationTab']")).Click();
            driver.FindElement(By.XPath("//input[@name='freelancer']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@data-bb-handler='confirm']")).Click();
            driver.FindElement(By.XPath("//input[@name='name']")).SendKeys($"{firstName}Company name here");
            driver.FindElement(By.XPath("//input[@name='juridicalForm']")).SendKeys(juridicalFormsArray[index]);
            driver.FindElement(By.XPath("//button[@data-testscript='SaveCloseButton']")).Click();
        }



    }
}
