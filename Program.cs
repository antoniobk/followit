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
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            /*
            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("1. Create candidate");
            Console.WriteLine("2. Create organization");
            int answer = int.Parse(Console.ReadLine());*/



            BaseClass.setupApplication(driver);
            login.loginUat(driver);
            Candidate.createCandidate(driver);
                
    
               
            


            

           

            
            //BaseClass.closeApplication(driver);
        }
    }
}
