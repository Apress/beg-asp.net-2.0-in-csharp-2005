<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ButtonGridHost.aspx.cs" Inherits="ButtonGridHost" %>

<%@ Register Assembly="ServerControlLibrary" Namespace="CustomControls" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Rows:
        <asp:TextBox ID="txtRows" runat="server">2</asp:TextBox><br />
        &nbsp; Cols:
        <asp:TextBox ID="txtCols" runat="server">2</asp:TextBox>&nbsp; &nbsp;<asp:Button
            ID="cmdUpdate" runat="server" OnClick="cmdUpdate_Click" Text="Update" /><br />
        <br />
        <cc1:ButtonGrid ID="ButtonGrid1" runat="server" OnGridClick="ButtonGrid1_GridClick" />
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server" EnableViewState="False"></asp:Label></div>
    </form>
</body>
</html>
