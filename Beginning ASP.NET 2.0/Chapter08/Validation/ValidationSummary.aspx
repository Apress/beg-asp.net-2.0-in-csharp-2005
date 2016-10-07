<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationSummary.aspx.cs" Inherits="ValidationSummary" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Validation Summary</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <P>A number (1 to 10):
				<asp:textbox id="txtValidated" runat="server"></asp:textbox>&nbsp;
				<asp:rangevalidator id="RangeValidator" runat="server" Display="None" Type="Integer" MinimumValue="1" MaximumValue="10" ControlToValidate="txtValidated" ErrorMessage="The First Number Is Not In The Range"></asp:rangevalidator><BR>
				<BR>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Not validated:&nbsp;
				<asp:textbox id="txtNotValidated" runat="server"></asp:textbox><BR>
			</P>
			<P><BR>
				<asp:button id="cmdOK" runat="server" Text="OK" OnClick="cmdOK_Click" Width="44px"></asp:button><BR>
				<BR>
				<asp:label id="lblMessage" runat="server" EnableViewState="False"></asp:label><BR>
				<BR>
				<asp:ValidationSummary id="ValidationSummary1" runat="server" ShowMessageBox="True"></asp:ValidationSummary></P>
    </div>
    </form>
</body>
</html>
