<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddRolesToUser.aspx.cs" Inherits="WholesaleRaja.Website.Account.AddRolesToUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top:200px">
        <div class="row">
            <div class="col-sm-12 col-md-6">
                Select User:
            </div>
            <div class="col-sm-12 col-md-6">
                <asp:DropDownList ID="ddlUserList" runat="server" OnSelectedIndexChanged="ddlUserList_SelectedIndexChanged" AutoPostBack="True" DataTextField="Text" DataValueField="Value"></asp:DropDownList>
            </div>
        </div>

<%--        <div class="row">
            <div class="col-sm-12 col-md-6">
                Available User Roles:
            </div>
            <div class="col-sm-12 col-md-6">
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </div>
        </div>--%>

        <div class="row">
            <div class="col-sm-12 col-md-6">
                Select Roles:
            </div>
            <div class="col-sm-12 col-md-6">
                <asp:CheckBoxList ID="cblRolesList" runat="server" DataTextField="Text" DataValueField="Value">
                </asp:CheckBoxList>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6">
                
            </div>
            <div class="col-sm-12 col-md-6">
                <asp:Button ID="btnAddRole" runat="server" Text="Add Role to User" OnClick="btnAddRole_Click" />
            </div>
        </div>
    </div>
</asp:Content>
