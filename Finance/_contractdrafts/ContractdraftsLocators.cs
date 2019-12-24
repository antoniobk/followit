using System;
using System.Collections.Generic;
using System.Text;

namespace FollowIT___Automation
{
    public class ContractdraftsLocators
    {
        public string BTN_CONTRACTDRAFTS = "//li[@data-testscript='Contractdrafts']";
        public string BTN_NEW_CONTRACTDRAFTS = "//button[@name='new']";
        public string RADIOBTN_STARTFROM = "//input[@ng-click='setStartProposal(false)']";
        public string BTN_NEXT = "//button[@ng-click='next();']";

        public string INPUT_CANDIDATE_OR_CLIENT_NAME = "//input[@type='text']";
        public string PRICE_IN = "//input[@ng-model='contractDraft.inRate']";
        public string PRICE_OUT = "//input[@ng-model='contractDraft.outRate']";
        public string SAVE = "//button[@name='save']";


    }
}


