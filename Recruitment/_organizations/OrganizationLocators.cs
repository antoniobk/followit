using System;
using System.Collections.Generic;
using System.Text;

namespace FollowIT___Automation
{
   public class OrganizationLocators
    {

        //overview

        public string BTN_ORGANIZATIONS = "//li[@data-testscript='Organizations']";
        public string BUTTON_ADD_ORGANIZATION = "//button[@data-testscript='ButtonAddOrganization']";
        public string INPUT_ORGANIZATION_NAME = "//input[@data-testscript='Name']";
        public string BUTTON_CHECK_ORGANIZATION = "//button[@data-testscript='ButtonCheckOrganization']";

        //organization details
       


        public string organizationName = new Bogus.DataSets.Company("nl_BE").CompanyName();
        public string organizationWebsite = new Bogus.DataSets.Lorem().Word();
        public string organizationPhoneNumber = new Bogus.DataSets.PhoneNumbers().PhoneNumber("# ### ## ##");
        public string salesLeadFirstName = new Bogus.DataSets.Name("nl_BE").FirstName();
        public string salesLeadLastName = new Bogus.DataSets.Name("nl_BE").LastName();
        public string organizationStreet = new Bogus.DataSets.Address("nl_BE").StreetName();
        public string organizationCity = new Bogus.DataSets.Address("nl_BE").City();
        public string organizationZipCode = new Bogus.DataSets.Address("nl_BE").ZipCode();

        public string contactPersonFirstName = new Bogus.DataSets.Name("nl_BE").FirstName();
        public string contactPersonLastNaME = new Bogus.DataSets.Name("nl_BE").LastName();

    }
}
