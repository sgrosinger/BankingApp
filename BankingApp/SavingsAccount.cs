using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SamWebForms.ExampleInteritance_v2
{
    public class SavingsAccount: BankAccountBase
    {
        public override string GetAccountType()
        {
            return "savings";
        }

        public override float GetMinimumBalance()
        {
            return 2000;
        }

        public override float GetMonthlyFee()
        {
            return 0.05F;
        }
    }
}