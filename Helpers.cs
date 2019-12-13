using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace FollowIT___Automation
{
    public class Helpers
    {
        public void OpenRecruitmentModule(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//li[@data-testscript='Recruitment']")).Click();
            Thread.Sleep(2000);
        }

        public void OpenFinanceModule(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//li[@data-testscript='Finance']")).Click();
            Thread.Sleep(1000);
        }

        public void OpenListsModule(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//li[@data-testscript='Lists']")).Click();
            Thread.Sleep(1000);
        }

        public void OpenAssetsModule(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//li[@data-testscript='Assets']")).Click();
            Thread.Sleep(1000);
        }
    }
}
