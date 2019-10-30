using System;
using System.Collections.Generic;
using System.Text;

namespace FollowIT___Automation
{
    public class CandidateRandomGenerator 
    {
        public string firstName = new Bogus.DataSets.Name("nl_BE").FirstName();
        public  string lastName = new Bogus.DataSets.Name("nl_BE").LastName();
        public string placeOfBirth = new Bogus.DataSets.Address("nl_BE").City();
        public string date = new Bogus.DataSets.Date().Past(20).ToString("dd-MM-yyyy");
        public string cellPhoneNumber = new Bogus.DataSets.PhoneNumbers().PhoneNumber("### ## ## ##");
        public string street = new Bogus.DataSets.Address("nl_BE").StreetName();
        public string city = new Bogus.DataSets.Address("nl_BE").City();
        public string zipCode = new Bogus.DataSets.Address("nl_BE").ZipCode();
    }
}
