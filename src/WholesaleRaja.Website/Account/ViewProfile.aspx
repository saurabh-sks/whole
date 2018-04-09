<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="WholesaleRaja.Website.Account.ViewProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Profile</h1>
    <div>
        <div class="row">
            <div class="col-sm-12 col-md-6">UserName: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtUserName" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">First Name: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtFirstName" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Middle Name: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtMiddleName" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Last Name: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtLastName" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Email: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtEmail" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Mobile Number: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtMobile" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Address Line 1: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtAddressLine1" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Address Line 2: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtAddressLine2" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">City: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtCity" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">State: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtState" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Country: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtCountry" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Postal Code: </div>
            <div class="col-sm-12 col-md-6"><asp:TextBox ID="txtPostalCode" ReadOnly="true" runat="server" /></div>
        </div>
    </div>
</asp:Content>
