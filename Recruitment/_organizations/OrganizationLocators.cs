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

        public string RADIO_BTN_MANUALLY = "//input[@data-testscript='ManuallyValidated']";
        public string RADIO_BTN_THIRDPARTY = "//input[@data-testscript='ThirdParty']";
        public string INPUT_WEBSITE = "//input[@data-testscript='Website']";
        public string INPUT_PHONE = "//input[@data-testscript='Phone']";
        public string INPUT_SALESLEAD = "//input[@data-testscript='SalesLead']";

        //organization address

        public string BTN_SHOWACTIONS = "//button[@data-testscript='ButtonShowActions']";
        public string BTN_ADDADDRESS = "//button[@data-testscript='ButtonAddAddress']";
        public string INPUT_ADDRESSTYPE = "//input[@name='addressType']";
        public string INPUT_STREET = "//input[@data-testscript='Street']";
        public string INPUT_CITY = "//input[@data-testscript='City']";
        public string INPUT_ZIPCODE = "//input[@data-testscript='ZipCode']";
        public string BTN_SAVEACTIONS = "//button[@data-testscript='ButtonSaveActions']";

        //organization contact person

        public string BTN_ADD_CONTACTPERSON = "//button[@data-testscript='ButtonAddContactPerson']";
        public string INPUT_CONTACTPERSON_FIRSTNAME = "//input[@data-testscript='ContactPersonFirstName']";
        public string INPUT_CONTACTPERSON_LASTNAME = "//input[@data-testscript='ContactPersonLastName']";
        public string DROPDOWN_CONTACTPERSON_GENDER = "//div[@data-testscript='ContactPersonGender']";






        // data generators

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
