<%@ Page language="c#" Inherits="WebControls.DynamicAdd" CodeFile="DynamicAdd.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>DynamicAdd</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form method="post" runat="server">
            <asp:Button ID="cmdAddControl" runat="server" OnClick="AddControl_ServerClick" Text="Add Control" />&nbsp;
		</form>
	</body>
</HTML>
