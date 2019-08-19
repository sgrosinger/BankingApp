<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BankDisplay.aspx.cs" Inherits="BankingApp.MyProject.BankDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">

            <div>
                <h1>Please enter account info</h1>
            </div>
            <div class="form-group col-sm-4">
                <asp:Label runat="server">   Please select account type:</asp:Label>
                <asp:DropDownList runat="server" CssClass="form-control" ID="ddlAccountType">
                    <asp:ListItem Selected="True" Text="(Account Type)"></asp:ListItem>
                    <asp:ListItem Text="Checking"></asp:ListItem>
                    <asp:ListItem Text="Savings"></asp:ListItem>
                    <asp:ListItem Text="Money Market"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group col-sm-4">
                <asp:Label runat="server">  Name:    </asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtboxAccountHolder"></asp:TextBox>
            </div>

            <div class="form-group col-sm-4">
                <asp:Label runat="server">  Balance:    </asp:Label>
                <asp:TextBox TextMode="Number" CssClass="form-control" runat="server" ID="txtboxBalance"></asp:TextBox>
            </div>

            <asp:Button runat="server" Text="Create Account" CssClass="btn btn-primary ml-4" OnClick="CreateAccount_Click" />
        </form>

        <div class="account-rules">
            <h1>Account Rules</h1>
            <div class="form-group col-sm-4">
                Minimum Balance:               
            <asp:Label runat="server" ID="lblMinimumBalance"></asp:Label>
            </div>

            <div class="form-group col-sm-4">
                Account Type:                
            <asp:Label runat="server" ID="lblAccountType"></asp:Label>
            </div>
            <div class="form-group col-sm-4">
                Account Fee:                
            <asp:Label runat="server" ID="lblAccountFee"></asp:Label>
            </div>
        </div>

        <div class="account-status">
            <h1>Account status</h1>

            <asp:Label runat="server" ID="lblErrorMessage"></asp:Label>
            <asp:Label runat="server" ID="lblAccountStatus"></asp:Label>
        </div>
    </div>
</body>
</html>
