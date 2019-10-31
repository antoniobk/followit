using System;
using System.Collections.Generic;
using System.Text;

namespace FollowIT___Automation
{
   public class DemandsRandomGenerator
    {
        public static string title = new Bogus.DataSets.Name("nl_BE").FirstName();
        public static string titlePostings = new Bogus.DataSets.Name("nl_BE").LastName();
        public static string supplier = new Bogus.DataSets.Address("nl_BE").City();
        public static string startingDate = new Bogus.DataSets.Date().Future(1).ToString("dd-MM-yyyy");
        public static string duration = new Bogus.DataSets.PhoneNumbers().PhoneNumber("### ## ## ##");
        public static string closingDate = new Bogus.DataSets.Address("nl_BE").StreetName();
        
        
    }
}
