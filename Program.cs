using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace FollowIT___Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:/ChromeDriver");
            Candidate candidate = new Candidate();

            BaseClass.setupApplication(driver);
            Login.loginUat(driver);
            candidate.AddNewCandidate(driver);
            candidate.AddGeneralInfo(driver);
            //candidate.
           

            //Organizations.CreateOrganization(driver);

            
          
            
            //BaseClass.closeApplication(driver);
        }
    }
}
