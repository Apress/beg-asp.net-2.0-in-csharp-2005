<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConcurrencyHandler.aspx.cs" Inherits="ConcurrencyHandler" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdTest" runat="server" Height="32px" OnClick="cmdTest_Click" Text="Test Concurrency Error"
            Width="168px" /><br />
        <br />
        <asp:Label ID="lblResult" runat="server" Font-Bold="True"></asp:Label>&nbsp;</div>
    </form>
</body>
</html>
