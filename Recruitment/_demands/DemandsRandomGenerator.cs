using System;
using System.Collections.Generic;
using System.Text;

namespace FollowIT___Automation
{
   public class DemandsRandomGenerator
    {
        public string title = new Bogus.DataSets.Name("nl_BE").FirstName();
        public string titlePostings = new Bogus.DataSets.Name("nl_BE").LastName();
        public string supplier = new Bogus.DataSets.Address("nl_BE").City();
        public string startingDate = new Bogus.DataSets.Date().Future(1).ToString("dd-MM-yyyy");
        public string closingDate = new Bogus.DataSets.Date().Future(2).ToString("dd-MM-yyyy");
        
      
        
        
    }
}
