﻿using System;
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
    public class Organizations : Candidate
    {
        public static void CreateOrganization(IWebDriver driver)
        {
            var organizationName = new Bogus.DataSets.Company("nl_BE").CompanyName();
            var organizationWebsite = new Bogus.DataSets.Lorem().Word();
            var organizationPhoneNumber = new Bogus.DataSets.PhoneNumbers().PhoneNumber("# ### ## ##");
            
            

            driver.FindElement(By.XPath("//li[@data-testscript='Recruitment']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//li[@data-testscript='Organizations']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@name='new'][contains(text(),'Add')]")).Click();
            

            driver.FindElement(By.Name("name")).SendKeys(organizationName);
            driver.FindElement(By.XPath("//button[@ng-click='check()']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@ng-click='addOrganization(organization)']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='checkbox'][@ng-model='organization.isManuallyValidated']")).Click();
            driver.FindElement(By.XPath("//input[@type='checkbox'][@ng-model='organization.isPartner']")).Click();
            driver.FindElement(By.XPath("//input[@name='website']")).SendKeys($"https://www.{organizationWebsite}.be");
            driver.FindElement(By.XPath("//input[@name='tradeName']")).SendKeys($"{organizationWebsite}");
            driver.FindElement(By.XPath("//input[@name='phone']")).SendKeys("+32 "+organizationPhoneNumber);


           // driver.FindElement(By.XPath("//button[@data-testscript='SaveButton']")).Click();
            
        }

    }
}
