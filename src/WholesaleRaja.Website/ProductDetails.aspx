<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="WholesaleRaja.Website.ProductDetails" %>

<%@ Register Src="~/UserControls/ProductDetailsControl.ascx" TagPrefix="uc1" TagName="ProductDetailsControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<uc1:ProductDetailsControl runat="server" id="ProductDetailsControl" ProductId="1" />

</asp:Content>
