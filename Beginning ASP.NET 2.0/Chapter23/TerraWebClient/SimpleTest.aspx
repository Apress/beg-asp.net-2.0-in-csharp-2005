<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SimpleTest.aspx.cs" Inherits="SimpleTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>TerraService</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:Button id="cmdShow"  runat="server" Text="Show Seattle" OnClick="cmdShow_Click"/>
        <asp:Button ID="txtShowAll" runat="server" Text="Show All Kingston" OnClick="cmdShowAll_Click" />
        <asp:Button ID="cmdShowPic" runat="server" Text="Show Seattle Tile" OnClick="cmdShowPic_Click" /><br />
        <br />
    			<asp:label id="lblResult" runat="server"  EnableViewState="False"></asp:label></div>
    </form>
</body>
</html>
