<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestSoapHeaderService.aspx.cs" Inherits="TestSoapHeaderService" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdAuthenticated" runat="server" OnClick="cmdAuthenticated_Click"
            Text="Authenticated Call" Width="168px" />&nbsp;<asp:Button ID="cmdUnauthenticated"
                runat="server" OnClick="cmdUnauthenticated_Click" Text="Unauthenticated Call"
                Width="168px" /><br />
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label></div>
    </form>
</body>
</html>
