<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cookieless1.aspx.cs" Inherits="Cookieless1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:HyperLink id="lnkRedirect" style="Z-INDEX: 100; LEFT: 31px; POSITION: absolute; TOP: 32px" runat="server" Width="172px" Height="32px" NavigateUrl="Cookieless2.aspx">Link with Relative Path</asp:HyperLink>
			<asp:Button id="cmdLinkAbsolute" style="Z-INDEX: 104; LEFT: 32px; POSITION: absolute; TOP: 180px" runat="server" Width="188px" Text="Redirect wtih Absolute Path" OnClick="cmdLinkAbsolute_Click"></asp:Button>
			<asp:Button id="cmdLink" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 104px" runat="server" Width="188px" Text="Redirect with Relative Path" OnClick="cmdLink_Click"></asp:Button>
			<asp:Label id="lblInfo" style="Z-INDEX: 103; LEFT: 235px; POSITION: absolute; TOP: 32px" runat="server" Width="292px" Height="188px" Font-Names="Verdana" Font-Size="Small">Hyperlink.NavigateUrl is set to <b>
					"Cookieless1.aspx"</b> in code.<br><br><br>The relative path uses<br><b>Response.Redirect("Cookieless1.aspx")</b><br><br><br>The absolute path uses <b>
					Response.Redirect("http://localhost/.../Cookieless2.aspx)"</b></asp:Label>

    </div>
    </form>
</body>
</html>
