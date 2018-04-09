<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductDetailsControl.ascx.cs" Inherits="WholesaleRaja.Products.UserControls.ProductDetailsControl" %>

<div style="margin-top:200px">
    <asp:HiddenField ID="productId" runat="server" />
    <div class="col-sm-12 col-md-6">
        <img src=<%: productDetails.Image %> />
    </div>
    <div class="col-sm-12 col-md-6">
        <h1><%: productDetails.Name %></h1>
        <div class="priceWrapper">
            <p class="basePrice" style="text-decoration:line-through"><%: productDetails.BasePriceString %></p>
            <p class="salePrice"><%: productDetails.SalePriceString %></p>
            <p class="savings">You Save <%: productDetails.SavingsAmountString %> (<%: productDetails.SavingsPercentage.ToString() %>%)</p>
        </div>
        <div>
            <div>
                <span>Quantity:</span>
            </div>
            <div>
                <asp:TextBox ID="txtQuantity" runat="server"/>
            </div>
        </div>
        <div>
            <asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" OnClick="btnAddToCart_Click" />
        </div>
        <div class="productDescription">

        </div>
    </div>



</div>
