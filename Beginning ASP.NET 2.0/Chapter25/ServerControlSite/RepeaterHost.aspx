<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RepeaterHost.aspx.cs" Inherits="RepeaterHost" %>

<%@ Register Assembly="ServerControlLibrary" Namespace="CustomControls" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:configurablerepeatercontrol id="ConfigurableRepeaterControl1" runat="server"
            backcolor="#FFE0C0" borderstyle="Groove" borderwidth="2px" font-bold="True" font-names="Palatino Linotype"
            font-size="X-Large" height="191px" text="Repeated Text" width="273px"></cc1:configurablerepeatercontrol>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Set Repeat = 5" />
        <asp:Button ID="Button2" runat="server" Text="Post Back Page" /></div>
    </form>
</body>
</html>
