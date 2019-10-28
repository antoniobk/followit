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
            Organizations organization = new Organizations();
            Login login = new Login();
            BaseClass.setupApplication(driver);
            login.UAT(driver);

            candidate.AddNewCandidate(driver);
            candidate.AddGeneralInfo(driver);
            candidate.AddContactInformation(driver);
            candidate.AddAddress(driver);
            candidate.AddOrigin(driver);
            candidate.AddWorkDetails(driver);
            candidate.Save(driver);
            candidate.AddAction(driver);
            candidate.AddTags(driver);
            candidate.AddBillingInformation(driver); 

            organization.AddOrganization(driver);
            organization.AddGeneralInfo(driver);


          
          
            
            //BaseClass.closeApplication(driver);
        }
    }
}
