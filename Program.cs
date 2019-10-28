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
            
            
            BaseClass.setupApplication(driver);

            login.loginUat(driver);

            Candidate.createCandidate(driver);
            //Organizations.CreateOrganization(driver);      
    
               
                     
          

            
            //BaseClass.closeApplication(driver);
        }
    }
}
