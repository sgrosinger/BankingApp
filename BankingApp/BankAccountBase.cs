using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SamWebForms.ExampleInteritance_v2
{
    public abstract class BankAccountBase
    {

        public float balance;
        public string accountHolder;

        public abstract string GetAccountType();

        public abstract float GetMinimumBalance();

        public abstract float GetMonthlyFee();
    }
}