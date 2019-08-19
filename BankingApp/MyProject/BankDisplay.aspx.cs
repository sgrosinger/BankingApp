using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApp.MyProject
{
    public partial class BankDisplay : System.Web.UI.Page
    {
        public BankAccountBase userAccount;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool AccountInit()
        {
            lblMinimumBalance.Text = string.Empty;
            lblAccountType.Text = string.Empty;
            lblAccountFee.Text = string.Empty;
            lblErrorMessage.Text = string.Empty;
            lblAccountStatus.Text = string.Empty;

            if (ddlAccountType.SelectedItem.Text == "Checking")
            {
                userAccount = new CheckingAccount();
            }
            else if (ddlAccountType.SelectedItem.Text == "Savings")
            {
                userAccount = new SavingsAccount();
            }
            else if (ddlAccountType.SelectedItem.Text == "(Account Type)")
            {
                lblErrorMessage.Text = "Please select an account type.";
            }

            if (userAccount != null)
            {
                lblMinimumBalance.Text = userAccount.GetMinimumBalance().ToString();
                lblAccountType.Text = userAccount.GetAccountType().ToString();
                lblAccountFee.Text = userAccount.GetMonthlyFee().ToString();

                userAccount.accountHolder = txtboxAccountHolder.Text;


                if (int.TryParse(txtboxBalance.Text, out int balance))
                {
                    userAccount.balance = balance;
                }
            }

            return lblErrorMessage.Text.Length == 0;
        }

        private bool AccountValidation()
        {
            lblErrorMessage.Text += (userAccount.balance <= userAccount.GetMinimumBalance())
                ? "Insufficient Funds:  " + (userAccount.GetMinimumBalance() - userAccount.balance)
                : "";

            lblErrorMessage.Text += (userAccount.accountHolder.Length == 0)
                ? "Please enter the account holder's name. "
                : "";

            return lblErrorMessage.Text.Length == 0;
        }

        protected void CreateAccount_Click(object sender, EventArgs e)
        {
            if (AccountInit())
            {
                if (AccountValidation())
                    lblAccountStatus.Text = "Account Created Successfully";
            }
        }
    }
}
