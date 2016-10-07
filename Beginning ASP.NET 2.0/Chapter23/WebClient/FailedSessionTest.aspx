<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FailedSessionTest.aspx.cs" Inherits="FailedSessionTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Failed Session State</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    		<asp:Button id="cmdGetCounter" runat="server" Text="Get Usage Info" OnClick="cmdGetCounter_Click" />
			<asp:Button id="cmdCallService" runat="server" Text="Call Service" OnClick="cmdCallService_Click" /><br />
        <br />
			<asp:Label id="lblResult" runat="server" />
    </div>
    </form>
</body>
</html>
