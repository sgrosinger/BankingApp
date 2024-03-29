﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApp.MyProject
{
    public class CheckingAccount: BankAccountBase
    {
        public override string GetAccountType()
        {
            return "checking";
        }

        public override float GetMinimumBalance()
        {
            return 500;
        }

        public override float GetMonthlyFee()
        {
            return 1F;
        }
    }
}