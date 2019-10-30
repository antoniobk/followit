using System;
using System.Collections.Generic;
using System.Text;

namespace FollowIT___Automation
{
    public class CandidateRandomGenerator 
    {
        public static string firstName = new Bogus.DataSets.Name("nl_BE").FirstName();
        public static string lastName = new Bogus.DataSets.Name("nl_BE").LastName();
        public static string placeOfBirth = new Bogus.DataSets.Address("nl_BE").City();
        public static string date = new Bogus.DataSets.Date().Past(20).ToString("dd-MM-yyyy");
        public static string cellPhoneNumber = new Bogus.DataSets.PhoneNumbers().PhoneNumber("### ## ## ##");
        public static string street = new Bogus.DataSets.Address("nl_BE").StreetName();
        public static string city = new Bogus.DataSets.Address("nl_BE").City();
        public static string zipCode = new Bogus.DataSets.Address("nl_BE").ZipCode();
    }
}
