<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormattedCalendarHost.aspx.cs" Inherits="FormattedCalendarHost" %>
<%@ Register Assembly="ServerControlLibrary" Namespace="CustomControls" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 406px">
            <tr>
                <td style="height: 21px">
                    <strong style="border-bottom-style: none">Calendar</strong></td>
                <td style="height: 21px">
                    <strong>FormattedCalendar</strong></td>
            </tr>
            <tr>
                <td style="padding-right: 30px; vertical-align: top; border-top-style: none;">
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </td>
                <td>
                    <cc1:FormattedCalendar ID="FormattedCalendar1" runat="server">
                    </cc1:FormattedCalendar>
                </td>
            </tr>
        </table>
        &nbsp; &nbsp; &nbsp;
    </div>
    </form>
</body>
</html>
