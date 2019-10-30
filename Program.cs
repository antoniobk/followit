using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace FollowIT___Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Follow IT - automated tester";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hey there, what do you want to test?");
            Console.WriteLine("");
            Console.WriteLine("[1] - Create candidate");
            Console.WriteLine("[2] - Create organization");
            Console.WriteLine("[3] - Create demand");
            Console.WriteLine("[5] - Test all");
            int answer = int.Parse(Console.ReadLine());


            IWebDriver driver = new ChromeDriver("C:/ChromeDriver");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
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
                save.SaveAndClose(driver);

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

            else
            {
                Console.WriteLine("Closing");
                Environment.Exit(0);
               
            }

            
               
                     
            //BaseClass.closeApplication(driver);
        }
    }
}
