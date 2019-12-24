using System;
using System.Collections.Generic;
using System.Text;

namespace FollowIT___Automation
{
    public class CandidateLocators
    {
        //overview
        public string BTN_CANDIDATES = "//li[@data-testscript='Candidates']";
        public string BUTTON_ADD_CANDIDATE = "//button[@data-testscript='ButtonAddCandidate']";
        public string INPUT_CANDIDATE_FIRSTNAME = "//input[@data-testscript='Firstname']";
        public string INPUT_CANDIDATE_LASTNAME = "//input[@data-testscript='Lastname']";
        public string BUTTON_CHECK = "//button[@data-testscript='ButtonCheckCandidate']";
        


        //general info
        public string INPUT_PLACEOFBIRTH = "//input[@data-testscript='PlaceOfBirth']";
        public string INPUT_BIRTHDATE = "//input[@name='birthdate']";
        public string NATIONALITY_DROPDWON = "//div[@data-testscript='Nationality']";
        public string TYPE_ = "//div[@data-testscript='Type']";

        //contact details
        public string INPUT_CELLPHONE = "//input[@data-testscript='Cellphone']";

        //address
        public string INPUT_STREET = "street";
        public string INPUT_CITY = "city";
        public string INPUT_ZIPCODE = "zipCode";
        public string DROPDOWN_COUNTRY = "//div[@data-testscript='Country']";
        public string DROPDOWN_ORIGIN = "//div[@data-testscript='Origin']";
        public string DROPDOWN_WORKTITLE = "//input[@data-testscript='WorkTitle']";

        //action
        public string ACTIONS_TAB = "//li[@data-testscript='ActionsTab']";
        public string BUTTON_ADD_ACTION = "//button[@data-testscript='ButtonAddAction']";
        public string DROPDOWN_ACTION_TYPE = "//div[@data-testscript='ActionType']";
        public string BUTTON_SAVE_ACTION = "//button[@data-testscript='ButtonSaveAction']";

        //tags
        public string TAGS_TAB = "//li[@data-testscript='TagsTab']";
        public string CHECKBOX = "//input[@data-testscript='CheckBoxTag']";

        //proposals
        public string PROPOSALS_TAB = "//li[@data-testscript='ProposalTab']";
        public string BUTTON_ADD_PROPOSAL = "//button[@data-testscript='ButtonAddProposal']";
        public string INPUT_PRICE_IN = "//input[@data-testscript='ProposalPriceIn']";
        public string PROPOSAL_SOURCE = "//span[@data-testscript='ProposalSource']";
        public string DROPDOWN_PROPOSAL_ACTION = "//span[@data-testscript='ProposalAction']";

        //billing information
        public string BILLING_INFORMATION_TAB = "//li[@data-testscript='BillingInformationTab']";
        public string RADIOBTN_FREELANCER = "//input[@name='freelancer']";
        public string RESET_VALUES_POPUP_YES = "//button[@data-bb-handler='confirm']";
        public string INPUT_NAME = "//button[@data-bb-handler='confirm']";
        public string INPUT_JURIDICALFORM = "//input[@name='juridicalForm']";









        // Data generators
        public string firstName = new Bogus.DataSets.Name("nl_BE").FirstName();
        public string lastName = new Bogus.DataSets.Name("nl_BE").LastName();
        public string placeOfBirth = new Bogus.DataSets.Address("nl").City();
        public string date = new Bogus.DataSets.Date().Past(20).ToString("dd-MM-yyyy");
        public string cellPhoneNumber = new Bogus.DataSets.PhoneNumbers().PhoneNumber("### ## ## ##");
        public string street = new Bogus.DataSets.Address("nl_BE").StreetName();
        public string city = new Bogus.DataSets.Address("nl_BE").City();
        public string zipCode = new Bogus.DataSets.Address("nl_BE").ZipCode();
    }
}

