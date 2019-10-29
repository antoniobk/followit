using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
namespace FollowIT___Automation
{
    class Save
    {
        public void SaveOnly(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//button[@data-testscript='SaveButton']")).Click();
            Thread.Sleep(3000);
        }

        public void SaveAndClose(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//button[@data-testscript='SaveCloseButton']")).Click();
        }
        
    }
}
