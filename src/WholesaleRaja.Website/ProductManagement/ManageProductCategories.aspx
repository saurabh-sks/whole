<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageProductCategories.aspx.cs" Inherits="WholesaleRaja.Website.ProductManagement.ManageProductCategories" %>

<%@ Register Src="~/UserControls/ManageCategories.ascx" TagPrefix="uc1" TagName="ManageCategories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:managecategories runat="server" id="ManageCategories" />
</asp:Content>

