<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="WholesaleRaja.Website.Account.EditProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Edit Profile</h1>
    <div>
        <div class="row">
            <div class="col-sm-12 col-md-6">UserName: </div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtUserName" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">First Name: </div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtFirstName" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Middle Name: </div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtMiddleName" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Last Name: </div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtLastName" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Email: </div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtEmail" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Mobile Number: </div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtMobile" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Address Line 1: </div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtAddressLine1" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Address Line 2: </div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtAddressLine2" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">City: </div>
            <div class="col-sm-12 col-md-6">
                <asp:DropDownList ID="ddlCity" runat="server" DataTextField="CityName" DataValueField="CityCode">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvCity" runat="server" ErrorMessage="Please select City" ControlToValidate="ddlCity" Display="Dynamic" InitialValue="--Select--"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">State: </div>
            <div class="col-sm-12 col-md-6">
                <asp:DropDownList ID="ddlState" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataTextField="StateName" DataValueField="StateCode" OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvState" runat="server" ErrorMessage="Please Select State" ControlToValidate="ddlState" Display="Dynamic" InitialValue="--Select--"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Country: </div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtCountry" ReadOnly="true" runat="server" /></div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Postal Code: </div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtPostalCode" runat="server" /></div>
        </div>
    </div>
</asp:Content>
