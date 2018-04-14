<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManageCategories.ascx.cs" Inherits="WholesaleRaja.Products.UserControls.ManageCategories" %>

<span>Please Select one of the below options</span>
<asp:RadioButtonList ID="cbManageCategories" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbManageCategories_SelectedIndexChanged" RepeatDirection="Horizontal">
    <asp:ListItem Text="View Current Category Informantion" Value="ViewCategoryInfo" />
    <asp:ListItem Text="Add Category" Value="AddCategory" />
    <asp:ListItem Text="Add Subcategory" Value="AddSubcategory" />
</asp:RadioButtonList>

<asp:PlaceHolder ID="phCategoryInfo" runat="server" Visible="false">
    <div>
        Current Categories:
    </div>
    <div>
        <asp:GridView ID="grvCategoryDetails" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" EmptyDataText="No Data">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </div>
</asp:PlaceHolder>

<asp:PlaceHolder ID="phAddCategory" runat="server" Visible="false">
    <div>
        Add Category:
    </div>
    <div>
        <div>Category Name:
            <asp:TextBox ID="txtCategoryName" runat="server" /></div>
        <div>Category Seo Title:
            <asp:TextBox ID="txtCategorySeoTitle" runat="server" /></div>
        <div>Category Seo Description:
            <asp:TextBox ID="txtCategorySeoDescription" runat="server" /></div>
        <div>Category Seo Meta Keywords:
            <asp:TextBox ID="txtCategorySeoMetaKeywords" runat="server" /></div>
        <asp:Button ID="btnAddCategory" Text="Add Category" runat="server" OnClick="btnAddCategory_Click" />
        <div>
            <asp:Label ID="lblCategoryStatus" runat="server" /></div>
    </div>
</asp:PlaceHolder>

<asp:PlaceHolder ID="phAddSubcategory" runat="server" Visible="false">
    <div>
        Add Subcategory:
    </div>
    <div>
        Select Category:
        <asp:DropDownList ID="ddlCategory" runat="server" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" AutoPostBack="true" />
        <asp:Panel ID="panleSubcategoryList" runat="server">
            <div>Current sub categories in the Selected Category</div>
            <asp:GridView ID="grvSubcategory" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" EmptyDataText="No Data">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </asp:Panel>
    </div>
    <div>
        <div>Add Subcategory:</div>
        <div>Subcategory Name:
            <asp:TextBox ID="txtSubcategory" runat="server" /></div>
        <div>Subcategory Seo Title:
            <asp:TextBox ID="txtSubCategorySeoTitle" runat="server" /></div>
        <div>Subcategory Seo Description:
            <asp:TextBox ID="txtSubCategorySeoDescription" runat="server" /></div>
        <div>Subcategory Seo Meta Keywords:
            <asp:TextBox ID="txtSubCategorySeoMetaKeywords" runat="server" /></div>
        <asp:Button ID="btnAddSubcategory" runat="server" Text="Add Subcategory" OnClick="btnAddSubcategory_Click" />
        <div>
            <asp:Label ID="lblSubCategoryStatus" runat="server" /></div>
    </div>
</asp:PlaceHolder>
