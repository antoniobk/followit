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
        public static string firstName = new Bogus.DataSets.Name("nl_BE").FirstName();
        public static string lastName = new Bogus.DataSets.Name("nl_BE").LastName();
    }
}
