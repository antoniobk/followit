using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace FollowIT___Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] - Create candidate");
            Console.WriteLine("[2] - Create organization");
            Console.WriteLine("[3] - Create demand");
            Console.WriteLine("[5] - Test all");
            Console.WriteLine("");
            Console.WriteLine("What do you want to do?");
            int answer = int.Parse(Console.ReadLine());


            IWebDriver driver = new ChromeDriver("C:/ChromeDriver");
            Candidate candidate = new Candidate();
            Organizations organization = new Organizations();
            Demands demands = new Demands();
            Save save = new Save();
            Login login = new Login();


           

            if (answer == 1)
            {
                Console.WriteLine("Creating candidate");
                BaseClass.setupApplication(driver);
                login.UAT(driver);

                candidate.AddNewCandidate(driver);
                candidate.AddCandidateDetails(driver);
                save.SaveOnly(driver);
                candidate.AddAction(driver);
                candidate.AddTags(driver);
                candidate.AddBillingInformation(driver);
                save.SaveOnly(driver);

            }

            else if (answer == 2)
            {
                Console.WriteLine("Creating organization");
                BaseClass.setupApplication(driver);
                login.UAT(driver);
                organization.AddOrganization(driver);
                organization.AddOrganizationDetails(driver);
                save.SaveOnly(driver);
            }

            else if (answer == 3)
            {
                Console.WriteLine("Creating demand");
                BaseClass.setupApplication(driver);
                login.UAT(driver);
                demands.AddDemand(driver);
                save.SaveOnly(driver);
            }

            else if (answer == 5)
            {
                Console.WriteLine("Testing all");
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
                save.SaveOnly(driver);

                demands.AddDemand(driver);
                save.SaveOnly(driver);

            }

            else
            {
                Console.WriteLine("Closing");
            }

            
                 
                     
            //BaseClass.closeApplication(driver);
        }
    }
}
