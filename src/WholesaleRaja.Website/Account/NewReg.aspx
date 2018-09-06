<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewReg.aspx.cs" Inherits="WholesaleRaja.Website.Account.NewReg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        If you already have an account then goto <a href="/account/Login">Login Page</a>.
    </div>
    <div>
        <div>Select a registration type below:</div>
        <asp:RadioButtonList ID="rblRegistrationType" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" OnSelectedIndexChanged="rblRegistrationType_SelectedIndexChanged">
            <asp:ListItem Value="buyer" Text="Register as Buyer" />
            <asp:ListItem Value="vendor" Text="Register as Seller" />
        </asp:RadioButtonList>
    </div>

    <div class="basicInfoWrapper">
        <h3>Basic Information</h3>
        <div>
            User Name<sup class="mandatoryMark">*</sup>:<asp:TextBox ID="txtUserName" runat="server" />
            <asp:RequiredFieldValidator ID="rfvUserName" ControlToValidate="txtUserName" runat="server" ErrorMessage="Username is Required" Display="Dynamic" />
        </div>
        <div>
            Password<sup class="mandatoryMark">*</sup>:
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfvPassword" ControlToValidate="txtPassword" runat="server" ErrorMessage="Password is Required" Display="Dynamic" />

        </div>
        <div>
            Confirm Password<sup class="mandatoryMark">*</sup>:
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfvConfirmPassword" ControlToValidate="txtConfirmPassword" runat="server" ErrorMessage="Confirm Password is Required" Display="Dynamic" />
            <asp:CompareValidator ID="cvConfirmPassword" runat="server" ErrorMessage="Passwords do not match" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" Display="Dynamic" />
        </div>

        <div>
            Email<sup class="mandatoryMark">*</sup>:
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" />
            <asp:RequiredFieldValidator ID="rfvEmailId" ControlToValidate="txtEmail" runat="server" ErrorMessage="Email is Required" Display="Dynamic" />
            <asp:RegularExpressionValidator ID="revEmail" ControlToValidate="txtEmail" runat="server" ErrorMessage="Please enter a valid Email Id" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
        </div>

        <asp:Button ID="btnCreateUser" runat="server" Text="Register" OnClick="btnCreateUser_Click" />
        <div>
            <asp:Label ID="lblStatus" runat="server" />
        </div>
    </div>
    <h3>Business Details</h3>
    <div>
        Name of Business<sup class="mandatoryMark">*</sup>:
        <asp:TextBox ID="txtBusinessName" runat="server" />
        <asp:RequiredFieldValidator ID="rfvBusinessName" ControlToValidate="txtBusinessName" runat="server" ErrorMessage="Please Provide Business Name" Display="Dynamic" />

    </div>

    <asp:Panel ID="pnlBusinessType" runat="server">
        Type of Establishment<sup class="mandatoryMark">*</sup>:
        <asp:DropDownList ID="ddlBusinessType" runat="server" OnSelectedIndexChanged="ddlBusinessType_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Text="--Select--" Value="--Select--" />
            <asp:ListItem Text="Registered" Value="Registered" />
            <asp:ListItem Text="Unregistered" Value="Unregistered" />
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvBusinessType" ControlToValidate="ddlBusinessType" runat="server" ErrorMessage="Please Select Establishment Type" Display="Dynamic"  InitialValue="--Select--"/>
    </asp:Panel>

    <asp:Panel ID="pnlGstnWrapper" runat="server">
        GSTN Number<sup class="mandatoryMark">*</sup>:
        <asp:TextBox ID="txtGstn" runat="server" />
        <asp:RequiredFieldValidator ID="rfvGstn" ControlToValidate="txtGstn" runat="server" ErrorMessage="Please Provide GSTN Number" Display="Dynamic" />

    </asp:Panel>

    <div>
        Name of the Directors/Owner/Proprietor/Partners:
        <div>
            <asp:TextBox ID="txtOwnerName1" runat="server" placeholder="Name*" />&nbsp;&nbsp;<asp:TextBox ID="txtEmailOwner1" runat="server" placeholder="Email*" />
            <asp:RegularExpressionValidator ID="revEmailOwner1" ControlToValidate="txtEmailOwner1" runat="server" ErrorMessage="Please enter a valid Email Id" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
        </div>

        <div>
            <asp:TextBox ID="txtOwnerName2" runat="server" placeholder="Name" />&nbsp;&nbsp;<asp:TextBox ID="txtEmailOwner2" runat="server" placeholder="Email" />
            <asp:RegularExpressionValidator ID="revEmailOwner2" ControlToValidate="txtEmailOwner2" runat="server" ErrorMessage="Please enter a valid Email Id" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
        </div>

        <div>
            <asp:TextBox ID="txtOwnerName3" runat="server" placeholder="Name" />&nbsp;&nbsp;<asp:TextBox ID="txtEmailOwner3" runat="server" placeholder="Email" />
            <asp:RegularExpressionValidator ID="revEmailOwner3" ControlToValidate="txtEmailOwner3" runat="server" ErrorMessage="Please enter a valid Email Id" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
        </div>

        <div>
            <asp:TextBox ID="txtOwnerName4" runat="server" placeholder="Name" />&nbsp;&nbsp;<asp:TextBox ID="txtEmailOwner4" runat="server" placeholder="Email" />
            <asp:RegularExpressionValidator ID="revEmailOwner4" ControlToValidate="txtEmailOwner4" runat="server" ErrorMessage="Please enter a valid Email Id" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
        </div>

        <div>
            <asp:TextBox ID="txtOwnerName5" runat="server" placeholder="Name" />&nbsp;&nbsp;<asp:TextBox ID="txtEmailOwner5" runat="server" placeholder="Email" />
            <asp:RegularExpressionValidator ID="revEmailOwner5" ControlToValidate="txtEmailOwner5" runat="server" ErrorMessage="Please enter a valid Email Id" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
        </div>
    </div>

    <div>
        <div>
            Name of Accountant:
            <asp:TextBox ID="txtAccountantName" runat="server" />
        </div>
        <div>
            Accounts Department Email Id:
            <asp:TextBox ID="txtAccountDeptEmailId" runat="server" />
            <asp:RegularExpressionValidator ID="revAccDeptEmail" ControlToValidate="txtAccountDeptEmailId" runat="server" ErrorMessage="Please enter a valid Email Id" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
        </div>
        <div>Name of Category Head:<asp:TextBox ID="txtCategoryHeadName" runat="server" /></div>
        <div>
            Category Department Email Id:<asp:TextBox ID="txtCategoryDeptEmailId" runat="server" />
            <asp:RegularExpressionValidator ID="revCategoryDeptEmail" ControlToValidate="txtCategoryDeptEmailId" runat="server" ErrorMessage="Please enter a valid Email Id" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
        </div>
        <div>
            <div>
                Registered Address:
                <asp:TextBox ID="txtRegisteredAddress" runat="server" Rows="5" TextMode="MultiLine" /> 
                <asp:RequiredFieldValidator ID="rfvRegisteredAddress" runat="server" ControlToValidate="txtRegisteredAddress" ErrorMessage="Please input address" Display="Dynamic" />
            </div>
            <div>
                City:
                <asp:TextBox ID="txtRegisteredCity" runat="server" Text="Bengaluru" ReadOnly="true" />
            </div>
            <div>
                State:
                <asp:TextBox ID="txtRegisteredState" runat="server" Text="Karnataka" ReadOnly="true" />
            </div>
        </div>
    </div>

















</asp:Content>
