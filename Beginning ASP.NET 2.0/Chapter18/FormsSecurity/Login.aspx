<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <DIV style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; BORDER-LEFT: 2px groove; WIDTH: 421px; BORDER-BOTTOM: 2px groove; HEIGHT: 184px">
        <br />
        &nbsp;
				<asp:Label id="Label1"  runat="server" Width="104px">Name:</asp:Label>
        <asp:TextBox id="txtName"  runat="server" Width="152px"></asp:TextBox>
        &nbsp;<br />
        &nbsp;
				<asp:Label id="Label2"  runat="server" Width="104px">Password:</asp:Label>
        <asp:TextBox id="txtPassword"  runat="server" Width="152px" TextMode="Password"></asp:TextBox><br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
				<asp:Button id="cmdLogin" runat="server" Width="113px" Text="Login" onclick="cmdLogin_Click"></asp:Button><br />
        <br />
        <br />
        &nbsp;
				<asp:Label id="lblStatus" runat="server" Width="248px" Height="24px" ForeColor="#C00000"></asp:Label></DIV>
        <br />
			<asp:Label id="Label3"  runat="server" Width="256px" Font-Bold="True">Password must be "secret"</asp:Label>
    </div>
    </form>
</body>
</html>