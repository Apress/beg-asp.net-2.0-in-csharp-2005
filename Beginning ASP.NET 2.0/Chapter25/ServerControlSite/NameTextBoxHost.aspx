<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NameTextBoxHost.aspx.cs" Inherits="NameTextBoxHost" %>
<%@ Register TagPrefix="apress" Namespace="ServerControlLibrary" Assembly="ServerControlLibrary"  %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <apress:NameTextBox runat="server" ID="NameTextBox1">Joe Test</apress:NameTextBox>
        <asp:Button ID="cmdGetNames" runat="server" OnClick="cmdGetNames_Click" Text="Get Names" /><br />
        <br />
        <asp:Label ID="lblNames" runat="server"></asp:Label></div>
    </form>
</body>
</html>
