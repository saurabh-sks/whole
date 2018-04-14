<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="WholesaleRaja.Website.Account.Manage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Your Account</h1>
    <div>
        <div><a href="/Account/ViewProfile" title="View Profile">View Profile</a></div>
        <div><a href="/Account/EditProfile" title="Edit Profile">Edit Profile</a></div>
        <div><a href="/Account/PastOrders" title="Past Orders">Past Orders</a></div>
    </div>

    <asp:PlaceHolder ID="AdminAccountManager" runat="server">
        <div><a href="/ProductManagement/AddProduct" title="Add Products">Add Products</a></div>
        <div><a href="/ProductDetails" title="Add Products">Product Details</a></div>
        <div><a href="/Account/AddRolesToUser" title="Add Roles to User">Add Roles to User</a></div>
        <div><a href="/ProductManagement/ManageProductCategories" title="Manage Product Categories">Manage Product Categories</a></div>
    </asp:PlaceHolder>

</asp:Content>
