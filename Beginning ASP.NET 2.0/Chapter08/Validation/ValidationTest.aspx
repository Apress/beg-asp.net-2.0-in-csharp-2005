﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationTest.aspx.cs" Inherits="ValidationTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Validation Test</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <P>
				A number (1 to 10):
				<asp:TextBox id="txtValidated" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RangeValidator id="RangeValidator" runat="server" ErrorMessage="This Number Is Not In The Range" ControlToValidate="txtValidated" MaximumValue="10" MinimumValue="1" Type="Integer" EnableClientScript="False"></asp:RangeValidator>&nbsp;
        &nbsp;<BR>
				<BR>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Not validated:&nbsp;
				<asp:TextBox id="txtNotValidated" runat="server"></asp:TextBox><BR>
			</P>
			<P><BR>
				<asp:Button id="cmdOK" runat="server" Text="OK" OnClick="cmdOK_Click" Width="46px"></asp:Button><BR>
				<BR>
				<asp:Label id="lblMessage" runat="server" EnableViewState="False" Font-Bold="True" ForeColor="Red"></asp:Label>&nbsp;</P>
        <p>
            Client script is disabled on this page so you can see how validation performs on
            down-level browsers. Even though they trigger a postback, your code should detect
            that the page is invalid. To switch back to the default behavior, set RangeValidation.EnableClientScript
            to true.</p>
    </div>
    </form>
</body>
</html>
