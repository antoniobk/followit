using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;


namespace FollowIT___Automation
{

    [TestFixture]
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.Title = "Follow IT - automated tester";
            Console.ForegroundColor = ConsoleColor.Green;
            int answer;
       

            do
            {
                Console.WriteLine("Hey there, what do you want to test?\n");
                Console.WriteLine("[1] - Create candidate");
                Console.WriteLine("[2] - Create organization");
                Console.WriteLine("[3] - Create demand");
                Console.WriteLine("[5] - Test all\n");
                Console.Write("Type your choice: ");
                answer = int.Parse(Console.ReadLine());

            } while (answer < 0 || answer > 5);


            IWebDriver driver = new ChromeDriver("C:/chromedriver");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            

            switch (answer)
            {
                case 1:

                    BaseClass.setupApplication(driver);
                    Console.WriteLine(" ***** Creating Candidate ***** ");
                    Login.UAT(driver);
                    Helpers.OpenRecruitmentModule(driver);
                    Candidate.AddNewCandidate(driver);
                    Candidate.AddGeneralInfo(driver);
                    Candidate.AddContactDetails(driver);
                    Candidate.AddCandidateAddress(driver);                   
                    Candidate.AddAction(driver);
                    Candidate.AddTags(driver);
                   // Candidate.AddProposal(driver);
                    Candidate.AddBillingInformation(driver);
                    Save.SaveAndClose(driver);
                    break;


                case 2:
                    Console.WriteLine(" ***** Creating organization ***** \n");
                    BaseClass.setupApplication(driver);
                    Login.UAT(driver);
                    Helpers.OpenRecruitmentModule(driver);
                    Organizations.AddOrganization(driver);
                    Organizations.AddOrganizationDetails(driver);
                    Organizations.AddOrganizationAddress(driver);
                    Organizations.AddOrganizationContactPerson(driver);
                    Save.SaveAndClose(driver);
                    break;


                case 3:
                    Console.WriteLine(" ***** Creating demand ***** \n");
                    BaseClass.setupApplication(driver);
                    Login.UAT(driver);
                    Helpers.OpenRecruitmentModule(driver);
                    Demands.AddDemand(driver);
                    Demands.AddDemandDetails(driver);
                   // Save.SaveOnly(driver);
                    break;
                   
                case 5:

                    //candidate
                    Console.WriteLine("Creating candidate");
                    BaseClass.setupApplication(driver);
                    Login.UAT(driver);
                    Helpers.OpenRecruitmentModule(driver);
                    Candidate.AddNewCandidate(driver);
                    Candidate.AddGeneralInfo(driver);
                    Candidate.AddContactDetails(driver);
                    Candidate.AddCandidateAddress(driver);                
                    Candidate.AddAction(driver);
                    Candidate.AddTags(driver);
                    //Candidate.AddProposal(driver);
                    Candidate.AddBillingInformation(driver);
                    Save.SaveAndClose(driver);


                    //organization
                    Console.WriteLine("Creating organization");
                    Organizations.AddOrganization(driver);
                    Organizations.AddOrganizationDetails(driver);
                    Organizations.AddOrganizationAddress(driver);
                    Organizations.AddOrganizationContactPerson(driver);
                    Save.SaveAndClose(driver);

                    
                    //demand
                    Console.WriteLine("Creating demand");
                    Demands.AddDemand(driver);
                    Demands.AddDemandDetails(driver);
                    break;
                
                    

            }

            //BaseClass.closeApplication(driver);
        }
    }
}
