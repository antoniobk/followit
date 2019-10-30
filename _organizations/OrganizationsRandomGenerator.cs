using System;
using System.Collections.Generic;
using System.Text;

namespace FollowIT___Automation
{
    public class OrganizationsRandomGenerator
    {
        public string organizationName = new Bogus.DataSets.Company("nl_BE").CompanyName();
        public string organizationWebsite = new Bogus.DataSets.Lorem().Word();
        public string organizationPhoneNumber = new Bogus.DataSets.PhoneNumbers().PhoneNumber("# ### ## ##");
        public string firstName = new Bogus.DataSets.Name("nl_BE").FirstName();
        public string lastName = new Bogus.DataSets.Name("nl_BE").LastName();
    }
}
