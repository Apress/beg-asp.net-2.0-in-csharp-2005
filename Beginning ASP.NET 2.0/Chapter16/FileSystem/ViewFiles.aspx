<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewFiles.aspx.cs" Inherits="ViewFiles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border-right: 2px groove; border-top: 2px groove;
            border-left: 2px groove; width: 584px; border-bottom: 2px groove">
            <tr>
                <td style="width: 251px; height: 17px; padding-left: 15px; padding-bottom: 15px; padding-top: 15px">
                    <strong>Files in the FTP Directory</strong></td>
                <td style="width: 242px; height: 17px; padding-left: 15px; padding-bottom: 15px; padding-top: 15px">
                    <strong>Selected File Information</strong></td>
            </tr>
            <tr>
                <td style="width: 251px; height: 18px; vertical-align:top; padding-left: 15px; padding-bottom: 15px; padding-top: 15px">
                    <asp:ListBox ID="lstFiles" runat="server" Height="272px" Width="248px" AutoPostBack="True" OnSelectedIndexChanged="lstFiles_SelectedIndexChanged"></asp:ListBox><br />
                    <br />
                    <asp:Button ID="cmdRefresh" runat="server" Text="Refresh" OnClick="cmdRefresh_Click" /></td>
                <td style="width: 242px; height: 18px; vertical-align:top; padding-left: 15px; padding-bottom: 15px; padding-top: 15px">
                    <asp:Label ID="lblFileInfo" runat="server" Height="264px" Width="248px" BorderColor="#E0E0E0" BorderStyle="Solid" BorderWidth="1px" Font-Size="Smaller"></asp:Label><br />
                    <br />
                    <asp:Button ID="cmdDelete" runat="server" Text="Delete" OnClick="cmdDelete_Click" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
