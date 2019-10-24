using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RandomNameGeneratorLibrary;

namespace FollowIT___Automation
{
    class Candidate
    {
        public static void createCandidate(IWebDriver driver)
        {
            var firstName = new Bogus.DataSets.Name("nl_BE").FirstName();
            var lastName = new Bogus.DataSets.Name("nl_BE").LastName();
            var placeOfBirth = new Bogus.DataSets.Address("nl_BE").City();
            string cellPhoneNumber = new Bogus.DataSets.PhoneNumbers("nl_BE").PhoneNumber();
            string email = firstName + lastName + ("@gmail.com");
            
            //Create candidate
            driver.FindElement(By.XPath("/html/body/div[4]/nav/div/ul/li[2]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//span[contains(text(),'Candidates')]")).Click();
            driver.FindElement(By.XPath("//button[@name='new'][contains(text(), 'Add')]")).Click();

            //Generate random first and last name with RandomNameGeneratorLibrary
           

            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);
            driver.FindElement(By.XPath("//button[@class='btn btn-default'][contains(text(),'Check')]")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@class='btn btn-primary pull-left ng-scope'][contains(text(),'Add candidate')]")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div/div/div[1]/form/fieldset[2]/div/div[2]/div/div[2]/div/div[2]/div/div[1]/span")).Click();
            driver.FindElement(By.XPath("//span[contains(text(), 'Belgian')][@ng-bind-html='nationality | highlight: $select.search']")).Click();


            driver.FindElement(By.Id("placeOfBirth")).SendKeys(placeOfBirth);
            driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div/div/div[1]/form/fieldset[2]/div/div[2]/div/div[3]/div/div[2]/div/div[1]/span")).Click();
            driver.FindElement(By.XPath("//span[@ng-bind-html='cType.value | highlight: $select.search'][contains(text(), 'Employee Consulant')]")).Click();
            driver.FindElement(By.Id("cellPhone")).SendKeys(cellPhoneNumber);
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.XPath("/html/body/div[4]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/div/div[1]/form/fieldset[3]/div/div[1]/div/div[2]/mail-to/div/input")).SendKeys(email);






        }
    }
}
