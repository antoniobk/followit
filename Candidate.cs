using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace FollowIT___Automation
{
    public class Candidate
    {
        public static void createCandidate(IWebDriver driver)
        {
            //generating random testdata
            var firstName = new Bogus.DataSets.Name("nl_BE").FirstName();
            var lastName = new Bogus.DataSets.Name("nl_BE").LastName();
            var placeOfBirth = new Bogus.DataSets.Address("nl_BE").City();
            var date = new Bogus.DataSets.Date().Past(20);
            var cellPhoneNumber = new Bogus.DataSets.PhoneNumbers().PhoneNumber("#### ### ###");
            var email = firstName + lastName + ("@gmail.com");
            var street = new Bogus.DataSets.Address("nl_BE").StreetName();
            var city = new Bogus.DataSets.Address("nl_BE").City();
            var zipCode = new Bogus.DataSets.Address("nl_BE").ZipCode();



            driver.FindElement(By.XPath("//span[@data-testscript='Recruitment']")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//span[contains(text(),'Candidates')]")).Click();
            driver.FindElement(By.XPath("//button[@name='new '][contains(text(), 'Add')]")).Click();


            
            //Add new candidate
            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);
            driver.FindElement(By.XPath("//button[@class='btn btn-default'][contains(text(),'Check')]")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@class='btn btn-primary pull-left ng-scope'][contains(text(),'Add candidate')]")).Click();
            System.Threading.Thread.Sleep(3000);

            //General
            Console.WriteLine(" ===== Adding general info ===== ");
            driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div/div/div[1]/form/fieldset[2]/div/div[2]/div/div[2]/div/div[2]/div/div[1]/span")).Click();
            driver.FindElement(By.XPath("//span[contains(text(), 'Belgian')][@ng-bind-html='nationality | highlight: $select.search']")).Click();
            driver.FindElement(By.Id("placeOfBirth")).SendKeys(placeOfBirth);
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div/div/div[1]/form/fieldset[2]/div/div[2]/div/div[3]/div/div[2]/div/div[1]/span")).Click();
            driver.FindElement(By.XPath("//span[@ng-bind-html='cType.value | highlight: $select.search'][contains(text(), 'Employee Consulant')]")).Click();

            //Contact
            Console.WriteLine(" ===== Adding contact info ===== ");
            driver.FindElement(By.Id("cellPhone")).SendKeys(cellPhoneNumber);
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/div/div[1]/form/fieldset[3]/div/div[1]/div/div[2]/mail-to/div/input")).SendKeys(email);

            //Address
            Console.WriteLine(" ===== Adding address info ===== ");
            driver.FindElement(By.Name("street")).SendKeys(street);
            driver.FindElement(By.Name("city")).SendKeys(city);
            driver.FindElement(By.Name("zipCode")).SendKeys(zipCode);
            driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/div/div[1]/form/fieldset[4]/div/div[1]/div/div[4]/div/div/div")).Click();
            driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div/div/div[1]/form/fieldset[4]/div/div[1]/div/div[4]/div/div/div/ul/li/div[3]/a")).Click();

            //Origin
            Console.WriteLine(" ===== Adding origin info ===== ");
            driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div/div/div[1]/form/fieldset[5]/div/div[1]/div/div/div/div[1]/span")).Click();
            driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div/div/div[1]/form/fieldset[5]/div/div[1]/div/div/div/ul/li/div[4]/a")).Click();

            //Work details

            //Extra info

            //LinkedIn info



            






        }
    }
}
