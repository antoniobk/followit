using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RandomNameGeneratorLibrary;

namespace FollowIT___Automation
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver("C:/ChromeDriver");


            //login
            driver.Navigate().GoToUrl("https://t4t-followit-uat.azurewebsites.net");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("Username")).SendKeys("srr//");
            driver.FindElement(By.Id("Password")).SendKeys("Test123!");
            
            driver.FindElement(By.XPath("//button[@value='login']")).Click();
            System.Threading.Thread.Sleep(10000);


           
            //Create candidate
            driver.FindElement(By.XPath("/html/body/div[4]/nav/div/ul/li[2]/a")).Click();
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//span[contains(text(),'Candidates')]")).Click();
            driver.FindElement(By.XPath("//button[@name='new'][contains(text(), 'Add')]")).Click();

            //Generate random first and last name with RandomNameGeneratorLibrary
            var personGenerator = new PersonNameGenerator();
            var firstName = personGenerator.GenerateRandomFirstName();
            var lastName = personGenerator.GenerateRandomLastName();


            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);





        }
    }
}
