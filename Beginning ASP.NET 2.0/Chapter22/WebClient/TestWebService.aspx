<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestWebService.aspx.cs" Inherits="TestWebService" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdCall" runat="server" OnClick="cmdCall_Click" Text="Call Service" /><br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>&nbsp;</div>
    </form>
</body>
</html>
