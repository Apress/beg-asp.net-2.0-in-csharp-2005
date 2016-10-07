<%@ Page Language="C#" AutoEventWireup="true"
    CodeFile="MenuHost.aspx.cs" Inherits="MenuHost"%>
<%@ Register TagPrefix="apress" TagName="LinkMenu" Src="LinkMenu.ascx" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Menu Host</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table >
            <tr>
                <td style="width: 100px">
    <apress:LinkMenu id="Menu1" runat="server" />
                </td>
                <td>
    &nbsp;&nbsp;<asp:Label id="lblSelection" runat="server" /></td>
            </tr>
        </table>
        <br />
        &nbsp;
    </div>
    </form>
</body>
</html>
