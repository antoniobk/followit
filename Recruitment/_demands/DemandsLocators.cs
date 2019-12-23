using System;
using System.Collections.Generic;
using System.Text;

namespace FollowIT___Automation
{
    public class DemandsLocators
    {

        //overview

        public string BTN_DEMANDS = "//li[@data-testscript='Demands']";
        public string BTN_ADD_DEMAND = "//button[@ng-click='addDemand()']";
        public string INPUT_POSTING_TITLE = "//input[@name='PostingTitle']";
        public string INPUT_CLIENT_PROSPECT = "//input[@ng-model='demand.selectedOrganization']";
        public string INPUT_START_DATE = "//input[@name='startDate']";
        public string INPUT_END_DATE = "//input[@name='closingDate']";
        public string INPUT_MAX_DAYPRICE = "//input[@name='maximumDayprice']";
        public string DURATION = "//input[@name='runTime']";



        // Test data
        public string title = new Bogus.DataSets.Name("nl_BE").FirstName();
        public string titlePostings = new Bogus.DataSets.Name("nl_BE").LastName();
        public string supplier = new Bogus.DataSets.Address("nl_BE").City();
        public string startingDate = new Bogus.DataSets.Date().Future(1).ToString("dd-MM-yyyy");
        public string closingDate = new Bogus.DataSets.Date().Future(2).ToString("dd-MM-yyyy");

    }
}
