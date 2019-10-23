using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FollowIT___Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:/ChromeDriver");

            driver.Navigate().GoToUrl("https://t4t-followit-uat.azurewebsites.net");

            driver.FindElement(By.Id("Username")).SendKeys("antoniobuzbuchi");
            driver.FindElement(By.Id("Password")).SendKeys("Test123!");




        }
    }
}
