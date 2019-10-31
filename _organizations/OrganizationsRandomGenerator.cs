using System;
using System.Collections.Generic;
using System.Text;

namespace FollowIT___Automation
{
    public class OrganizationsRandomGenerator
    {
        public static string organizationName = new Bogus.DataSets.Company("nl_BE").CompanyName();
        public static string organizationWebsite = new Bogus.DataSets.Lorem().Word();
        public static string organizationPhoneNumber = new Bogus.DataSets.PhoneNumbers().PhoneNumber("# ### ## ##");
        public static string salesLeadFirstName = new Bogus.DataSets.Name("nl_BE").FirstName();
        public static string salesLeadLastName = new Bogus.DataSets.Name("nl_BE").LastName();
        public static string organizationStreet = new Bogus.DataSets.Address("nl_BE").StreetName();
        public static string organizationCity = new Bogus.DataSets.Address("nl_BE").City();
        public static string organizationZipCode = new Bogus.DataSets.Address("nl_BE").ZipCode();

        public static string contactPersonFirstName = new Bogus.DataSets.Name("nl_BE").FirstName();
        public static string contactPersonLastNaME = new Bogus.DataSets.Name("nl_BE").LastName();


    }
}
