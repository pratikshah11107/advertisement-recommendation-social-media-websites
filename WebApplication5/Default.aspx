<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebApplication5._Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Advertising</title>
    <style type="text/css">
        .txtbox
        {
            font-family: verdana, arial, snas-serif;
            font-size: 11px;
            color: #000000;
            padding: 3px;
            background: #f0f0f0;
            border-top-left-radius: 5px;
            border-top-right-radius: 5px;
            border-bottom-left-radius: 5px;
            border-bottom-right-radius: 5px;
        }
        .fileUpload
        {
            position: relative;
            text-align: right;
            -moz-opacity: 0;
            z-index: 2;
            top: 0px;
            left: -2px;
            width: 217px;
        }
        .label
        {
            color: Black;
        }
        .labelHeading
        {
            color: GrayText;
        }
        .drop
        {
            padding: 0.25em;
            background: #f0f0f0;
            font: bold 90% times new roman, serif;
            border: Gray 1px solid;
        }
        .check
        {
            background-position: 3px 2px;
            display: block;
            clear: left;
            margin: 0;
            padding: 0;
        }
        .checkListBox
        {
            background-image: none !important;
            background-color: #CEF0F9 !important;
        }
        .checkListBoxItemSelected
        {
            font-family: verdana, arial, snas-serif;
            font-size: 11px;
            color: #000000;
            padding: 3px;
            background: #f0f0f0;
            border-top-left-radius: 20px;
            border-top-right-radius: 20px;
            border-bottom-left-radius: 20px;
            border-bottom-right-radius: 20px;
        }
        .rdioButton
        {
            color: #3E3928;
            padding-left: 6px;
            padding-right: 6px;
            padding-top: 2px;
            padding-bottom: 2px;
            margin: 0px 0px 0px 0px;
            white-space: nowrap;
            clear: left;
            margin-right: 5px;
        }
        .button
        {
	        background-color:#f0f0f0;
	        color:#3E3928;
	        font-family:'Helvetica Neue',sans-serif;
	        font-size:18px;
	        line-height:30px;
	        border-radius:20px;
	        -webkit-border-radius:20px;
	        -moz-border-radius:20px;
	        border:0;
	        text-shadow:#C17C3A 0 -1px 0;
	        width:120px;
	        height:32px
        }
    </style>
</head>
<body style="width: 583px; height: 680px;">
    <form id="frmAdvertising" runat="server" title="oka">
    <div style="height: 887px; margin-bottom: 117px; background-color: #FFFFFF; width: 959px;
        top: 20px; left: 8px; position: absolute;">
        <br />
        <asp:Label ID="lblHeader" runat="server" CssClass="labelHeading" Font-Bold="True"
            Font-Names="Calibri" Text="What do you want to advertise?"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblURL" runat="server" CssClass="label" Font-Names="Calibri" Text="URL"></asp:Label>
        <asp:TextBox ID="txtURL" runat="server" CssClass="txtbox" Style="margin-left: 38px"
            Width="520px"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="lblTitle" runat="server" CssClass="label" Font-Names="Calibri" Text="Title"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" CssClass="txtbox" Style="margin-left: 36px"
            Width="518px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblImage" runat="server" CssClass="label" Text="Image"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="fuImage" CssClass="fileUpload" runat="server" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="lblDescription" runat="server" CssClass="label" Font-Names="Calibri"
            Text="Text"></asp:Label>
        <textarea id="txtDescription" name="S1" rows="1" cols="10" runat="server" class="txtbox" style="width: 517px; height: 30px;
            margin-left: 38px;"></textarea>
        <br />
        <br />
        <asp:Label ID="lblAdiance" runat="server" CssClass="labelHeading" Font-Bold="True"
            Font-Names="Calibri" Font-Size="Medium" Text="Choose Audiance"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblCountries" runat="server" CssClass="label" Font-Names="calibiri"
            Text="Country"></asp:Label>
        &nbsp;&nbsp;
        <asp:DropDownList ID="cmbCountries" runat="server" CssClass="drop">
            <asp:ListItem Selected="True" Value="Canada">Canada</asp:ListItem>
            <asp:ListItem Value="India">India</asp:ListItem>
            <asp:ListItem Value="Saudi Arabia">Saudi Arabia</asp:ListItem>
            <asp:ListItem Value="United State">United State</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblAge" runat="server" CssClass="label" Font-Names="Calibri" Text="Age"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chk1" runat="server" Font-Names="calibiri" Text="13-24" />
        &nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chk2" runat="server" Font-Names="calibiri" Text="25-44" />
        &nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chk3" runat="server" Font-Names="calibiri" Text="45-64" />
        &nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chk4" runat="server" Font-Names="calibiri" Text="65+" />
        <br />
        <br />
        <asp:Label ID="lblGender" runat="server" CssClass="label" Font-Names="Calibri" Text="Gender"></asp:Label>
        &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton4" runat="server" Text="Male" />
         &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton5" runat="server" Text="Female" />
          &nbsp; &nbsp;
        <asp:RadioButton ID="RadioButton6" runat="server" Text="Both" />
        <br />
        <br />
        <asp:Label ID="lblCategories" runat="server" CssClass="label" Font-Names="Calibri"
            Font-Size="Medium" Text="Interests"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstCategories" runat="server" Height="99px" Width="119px" CssClass="checkListBoxItemSelected">
            <asp:ListItem Value="Food">Food</asp:ListItem>
            <asp:ListItem Value="Movie">Movie</asp:ListItem>
            <asp:ListItem Value="Music">Music</asp:ListItem>
            <asp:ListItem Value="Shopping">Shopping</asp:ListItem>
            <asp:ListItem Value="Sport">Sport</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Label ID="lblPricing" runat="server" CssClass="label" Text="Pricing"></asp:Label>
        &nbsp;
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Cost Per Click (CPC)" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton3" runat="server" Text="Cost Per Thousend Impression (CPM)" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <center>
        <asp:Button ID="btnSubmit" runat="server"  Text="Ad Prrview"></asp:Button>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server"  Text="Optimal Decision" Width="133px" />&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server"  Text="Clear" Width="85px"></asp:Button>
        </center>
    </div>

    <div style="height: 657px; margin-bottom: 117px; background-color: #FFFFFF; width: 342px; top: 35px; left: 675px; position: absolute; margin-right: 0px;">
        <asp:Label ID="lbPreHeader" runat="server" CssClass="labelHeading" Font-Bold="True" ForeColor="Green" 
            Font-Names="Calibri"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" CssClass="labelHeading" Font-Bold="False" ForeColor="Gray" 
            Font-Names="Calibri"></asp:Label>
         <br />
        &nbsp;
        <asp:Image ID="Image1" runat="server" width="100 px" Height="100 px"/> 
        <asp:Label ID="Label1" runat="server" style="height: 97px; width: 211px; top: 60px; left: 119px; position: absolute; margin-right: 0px; margin-bottom: 117px; background-color: #FFFFFF; "></asp:Label>
       
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>

    </form>
</body>
</html>
