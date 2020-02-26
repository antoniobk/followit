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

            Candidate candidate = new Candidate();
            Book book = new Book();
            Organizations organization = new Organizations();
            Demands demand = new Demands();
            Contractdrafts contractdaft = new Contractdrafts();
            Timesheets timesheet = new Timesheets();
            
            Login login = new Login();
            Save save = new Save();
            Helpers helper = new Helpers();
            BaseClass baseclass = new BaseClass();
            Console.Title = "Follow IT - automated tester";
            Console.ForegroundColor = ConsoleColor.Green;
            int answer;
       

            do
            {
                Console.WriteLine("Hey there, what do you want to test?\n");

                Console.WriteLine("[1] - Add a new candidate");
                Console.WriteLine("[2] - Add a new organization");
                Console.WriteLine("[3] - Add a new demand");
                Console.WriteLine("[4] - Add a new contract draft");
                Console.WriteLine("[5] - Add a new timesheet");
                Console.WriteLine("[6] - Add new book");
                Console.WriteLine("[8] - Test all\n");
                Console.Write("Type your choice: ");
                answer = int.Parse(Console.ReadLine());

            } while (answer < 0 || answer > 6);


            IWebDriver driver = new ChromeDriver("C:/chromedriver");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            

            switch (answer)
            {
                case 1:
                   
                    baseclass.SetupApplication(driver);                  
                    login.UAT(driver);
                    helper.OpenRecruitmentModule(driver);
                    candidate.AddNewCandidate(driver);
                    candidate.AddGeneralInfo(driver);
                    candidate.AddContactDetails(driver);
                    candidate.AddCandidateAddress(driver);                   
                    candidate.AddAction(driver);
                    candidate.AddTags(driver);
                    candidate.AddProposal(driver);
                    candidate.AddBillingInformation(driver);
                    save.SaveAndClose(driver);
                    break;


                case 2:
                    
                    baseclass.SetupApplication(driver);
                    login.UAT(driver);
                    helper.OpenRecruitmentModule(driver);
                    organization.AddOrganization(driver);
                    organization.AddOrganizationDetails(driver);
                    organization.AddOrganizationAddress(driver);
                    organization.AddOrganizationContactPerson(driver);
                    save.SaveAndClose(driver);                   
                    break;


                case 3:
                    
                    baseclass.SetupApplication(driver);
                    login.UAT(driver);
                    helper.OpenRecruitmentModule(driver);
                    demand.AddDemand(driver);
                    demand.AddDemandDetails(driver);
                    save.SaveAndClose(driver);
                    break;


                case 4:
                    baseclass.SetupApplication(driver);
                    login.UAT(driver);
                    helper.OpenFinanceModule(driver);
                    contractdaft.AddNewContractDraftFromCandidate(driver);
                    save.SaveAndClose(driver);
                    break;

                case 5:
                    baseclass.SetupApplication(driver);
                    login.UAT(driver);
                    helper.OpenFinanceModule(driver);
                    timesheet.AddTimesheet(driver);
                    break;

                case 6:
                    baseclass.SetupApplication(driver);
                    login.UAT(driver);
                    helper.OpenAssetsModule(driver);
                    book.createBook(driver);
                    break;


                case 7:

                    baseclass.SetupApplication(driver);
                    login.UAT(driver);
                    helper.OpenRecruitmentModule(driver);
                    candidate.AddNewCandidate(driver);
                    candidate.AddGeneralInfo(driver);
                    candidate.AddContactDetails(driver);
                    candidate.AddCandidateAddress(driver);                
                    candidate.AddAction(driver);
                    candidate.AddTags(driver);
                    candidate.AddProposal(driver);
                    candidate.AddBillingInformation(driver);
                    save.SaveAndClose(driver);

                  
                    organization.AddOrganization(driver);
                    organization.AddOrganizationDetails(driver);
                    organization.AddOrganizationAddress(driver);
                    organization.AddOrganizationContactPerson(driver);
                    save.SaveAndClose(driver);


                    
                    Console.WriteLine("Creating demand");
                    demand.AddDemand(driver);
                    demand.AddDemandDetails(driver);
                    save.SaveAndClose(driver);

                    helper.OpenFinanceModule(driver);
                    Console.WriteLine("Adding contract draft");                  
                    contractdaft.AddNewContractDraftFromCandidate(driver);

                    Console.WriteLine("Creating timesheet");                   
                    timesheet.AddTimesheet(driver);
                    break;
                
                    

            }

        }
    }
}
