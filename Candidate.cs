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
    public class Candidate
    {

        public static void createCandidate(IWebDriver driver)
        {
            //press enter
           Actions pressEnter = new Actions(driver);
           pressEnter.SendKeys(Keys.Enter); 

            //generating random testdata
            var firstName = new Bogus.DataSets.Name("nl_BE").FirstName();
            var lastName = new Bogus.DataSets.Name("nl_BE").LastName();
            var placeOfBirth = new Bogus.DataSets.Address("nl_BE").City();
            //convert date to string!!
            var date = new Bogus.DataSets.Date().Past(20).ToString("dd-MM-yyyy");
            var cellPhoneNumber = new Bogus.DataSets.PhoneNumbers().PhoneNumber("### ## ## ##");
            var email = firstName + lastName + ("@gmail.com");
            var street = new Bogus.DataSets.Address("nl_BE").StreetName();
            var city = new Bogus.DataSets.Address("nl_BE").City();
            var zipCode = new Bogus.DataSets.Address("nl_BE").ZipCode();
            



            driver.FindElement(By.XPath("//li[@data-testscript='Recruitment']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[@data-testscript='Candidates']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddCandidate']")).Click();


            
            //Add new candidate
            driver.FindElement(By.XPath("//input[@data-testscript='Firstname']")).SendKeys(firstName);
            driver.FindElement(By.XPath("//input[@data-testscript='Lastname']")).SendKeys(lastName);
            driver.FindElement(By.XPath("//button[@data-testscript='ButtonCheckCandidate']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddCandidate']")).Click();
            Thread.Sleep(3000);

            
            //General
            Console.WriteLine(" ===== Adding general info ===== ");
            driver.FindElement(By.XPath("//input[@data-testscript='PlaceOfBirth']")).SendKeys(placeOfBirth);

            //driver.FindElement(By.XPath("//div[@data-testscript='BirthDate']")).SendKeys(date);
            
            
            //driver.FindElement(By.XPath("//div[@data-testscript='BirthDate']")).SendKeys("hello");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@data-testscript='Nationality']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'American')]")).Click();
            driver.FindElement(By.XPath("//div[@data-testscript='Type']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Employee Consulant')]")).Click();
         

            //Contact
            Console.WriteLine(" ===== Adding contact info ===== ");
            driver.FindElement(By.XPath("//input[@data-testscript='Cellphone']")).SendKeys("+32 "+cellPhoneNumber);
            Thread.Sleep(3000);
            //driver.FindElement(By.XPath("")).SendKeys(email);
            
            //Address
            Console.WriteLine(" ===== Adding address info ===== ");
            driver.FindElement(By.Name("street")).SendKeys(street);
            driver.FindElement(By.Name("city")).SendKeys(city);
            driver.FindElement(By.Name("zipCode")).SendKeys(zipCode);
            driver.FindElement(By.XPath("//div[@data-testscript='Country']")).Click();
            driver.FindElement(By.XPath("//span[@class='ng-binding ng-scope'][contains(text(),'Belgium')]")).Click();
          

            //Origin
            Console.WriteLine(" ===== Adding origin info ===== ");
            driver.FindElement(By.XPath("//div[@data-testscript='Origin']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Stepstone')]")).Click();

            
            driver.FindElement(By.XPath("//input[@data-testscript='WorkTitle']")).SendKeys("Ontwikkelaar");
            // only use if availability date is entered
            //driver.FindElement(By.XPath("//div[@data-testscript='ContactBeforeDate']")).Click();


            //Save
            driver.FindElement(By.XPath("//button[@data-testscript='SaveButton']")).Click();
            Thread.Sleep(3000);

            //driver.FindElement(By.XPath("//button[@data-testscript='SaveCloseButton']")).Click();


            //Adding actions
            driver.FindElement(By.XPath("//li[@data-testscript='ActionsTab']")).Click();
            driver.FindElement(By.XPath("//button[@data-testscript='ButtonAddAction']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@data-testscript='ActionType']")).Click();
            
            driver.FindElement(By.XPath("//span[contains(text(),'Email')]")).Click();
            driver.FindElement(By.XPath("//button[@data-testscript='ButtonSaveAction']")).Click();
            Thread.Sleep(2000);


            //Adding tags           
            driver.FindElement(By.XPath("//li[@data-testscript='TagsTab']")).Click();
            driver.FindElement(By.XPath("//input[@data-testscript='CheckBoxTag']")).Click();

            













        }
    }
}
