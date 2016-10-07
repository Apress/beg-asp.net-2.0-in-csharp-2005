<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileBrowser.aspx.cs" Inherits="FileBrowser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>Current Directory: </strong>
        <asp:Label ID="lblCurrentDir" runat="server"></asp:Label><br />
        <br />
        <table style="border-right: 2px groove; border-top: 2px groove; border-left: 2px groove;
            width: 608px; border-bottom: 2px groove">
            <tr>
                <td style="padding-left: 15px; padding-bottom: 15px; width: 251px; padding-top: 15px;
                    height: 17px; vertical-align:top">
                    <strong>Subdirectories:<br />
                        <asp:ListBox ID="lstDirs" runat="server" AutoPostBack="True" Height="272px"
                            Width="248px"></asp:ListBox><br />
                        <br />
                        <asp:Button ID="cmdBrowse" runat="server" Text="Browse To Selected" Width="136px" OnClick="cmdBrowse_Click" />
                        &nbsp;<asp:Button ID="cmdParent" runat="server" Text="Up One Level" Width="104px" OnClick="cmdParent_Click" />
                    </strong></td>
                <td style="padding-left: 15px; padding-bottom: 15px; width: 246px; padding-top: 15px;
                    height: 17px; vertical-align:top">
                    <strong>Contained Files:<br />
                        <asp:ListBox ID="lstFiles" runat="server" AutoPostBack="True" Height="272px"
                            Width="248px"></asp:ListBox><br />
                        <br />
                        <asp:Button ID="cmdShowInfo" runat="server" Text="Show Info" Width="96px" OnClick="cmdShowInfo_Click" /><br />
                        <br />
        <asp:Label ID="lblFileInfo" runat="server" BorderColor="#E0E0E0" BorderStyle="None"
            BorderWidth="1px" Font-Size="Smaller" Height="48px" Width="248px"></asp:Label></strong></td>
            </tr>
        </table>
    
    </div>
        <br />
        &nbsp;
    </form>
</body>
</html>
