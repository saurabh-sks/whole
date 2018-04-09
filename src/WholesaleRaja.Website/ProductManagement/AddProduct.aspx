<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="WholesaleRaja.Website.ProductManagement.AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Edit Profile</h1>
    <div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Product Name:</div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtProductName" runat="server" Width="200px" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6">Product Image Path:</div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtImagePath" runat="server" Width="200px" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6">Product SKU Id:</div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtSku" runat="server" Width="200px" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6">Show in Website:</div>
            <div class="col-sm-12 col-md-6">
                <asp:CheckBox ID="cbIsActive" runat="server" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6">Product Description:</div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtDescription" runat="server" Width="200px" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6">Base Price:</div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtBasePrice" runat="server" Width="200px" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6">Sale Price:</div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtSalePrice" runat="server" Width="200px" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6">Product SEO Title:</div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtSeoTitle" runat="server" Width="200px" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6">Product SEO Description:</div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtSeoDescription" runat="server" Rows="5" TextMode="MultiLine" Width="200px" />
            </div>

        </div>
        <div class="row">
            <div class="col-sm-12 col-md-6">Product SEO Meta Keywords:</div>
            <div class="col-sm-12 col-md-6">
                <asp:TextBox ID="txtSeoMeta" runat="server" Rows="3" TextMode="MultiLine" Width="200px" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6">Add Product:</div>
            <div class="col-sm-12 col-md-6">
                <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" />
            </div>
        </div>

    </div>
</asp:Content>
