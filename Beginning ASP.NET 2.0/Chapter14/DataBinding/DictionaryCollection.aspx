<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DictionaryCollection.aspx.cs" Inherits="DictionaryCollection" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="MyListBox" runat="server" AutoPostBack="True" Height="192px" OnSelectedIndexChanged="MyListBox_SelectedIndexChanged"
            Width="200px"></asp:ListBox><br />
        <br />
        <asp:Label ID="lblMessage" runat="server" Font-Bold="True"></asp:Label>&nbsp;</div>
    </form>
</body>
</html>
