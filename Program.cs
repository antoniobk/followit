using System;
using System.Threading;
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

            BaseClass.setupApplication(driver);

            login.loginWithTestUser(driver);

            Candidate.createCandidate(driver);


            //BaseClass.closeApplication(driver);
        }
    }
}
