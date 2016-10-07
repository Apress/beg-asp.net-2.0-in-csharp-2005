<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FooterHost.aspx.cs" Inherits="FooterHost" %>
<%@ Register TagPrefix="apress" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Footer Host</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <h2>A Page With a Configurable Footer</h2>
			<P>
			<P></P>
			
				<hr />
			
			<P>
				<asp:RadioButton id="optShort" runat="server" GroupName="Format" Text="Short Format"></asp:RadioButton><br />
				<asp:RadioButton id="optLong" runat="server" GroupName="Format" Text="Long Format"></asp:RadioButton></P>
			<P>
				<asp:Button id="cmdRefresh" runat="server" Text="Refresh"></asp:Button></P>
			<hr />
			<P>
				<apress:Footer id="Footer1" runat="server"></apress:Footer></P>

    </div>
    </form>
</body>
</html>
