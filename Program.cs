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
            Save save = new Save();
            Login login = new Login();
            BaseClass.setupApplication(driver);
            login.UAT(driver);

            candidate.AddNewCandidate(driver);
            candidate.AddCandidateDetails(driver);

            save.SaveOnly(driver);
            
            candidate.AddAction(driver);
            candidate.AddTags(driver);
            candidate.AddBillingInformation(driver);

            save.SaveOnly(driver);



            organization.AddOrganization(driver);
            organization.AddOrganizationDetails(driver);



                     
            //BaseClass.closeApplication(driver);
        }
    }
}
