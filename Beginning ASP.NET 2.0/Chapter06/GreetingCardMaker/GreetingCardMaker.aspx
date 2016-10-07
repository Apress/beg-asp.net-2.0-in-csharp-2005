<%@ Page language="cs" Inherits="GreetingCardMaker.GreetingCardMaker" CodeFile="GreetingCardMaker.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
</HEAD>
	<BODY>
		<FORM id="Form1" method="post" runat="server">
			<DIV style="BORDER-RIGHT: thin ridge; PADDING-RIGHT: 20px; BORDER-TOP: thin ridge; PADDING-LEFT: 20px; FONT-SIZE: x-small; PADDING-BOTTOM: 20px; BORDER-LEFT: thin ridge; WIDTH: 293px; PADDING-TOP: 20px; BORDER-BOTTOM: thin ridge; FONT-FAMILY: Verdana; HEIGHT: 486px; BACKGROUND-COLOR: lightyellow">Choose 
				a background color:<BR>
				<asp:dropdownlist id="lstBackColor" runat="server" Height="22px" Width="194px"></asp:dropdownlist><BR>
				<BR>
				Choose a font:<BR>
				<asp:dropdownlist id="lstFontName" runat="server" Height="22px" Width="194px"></asp:dropdownlist><BR>
				<BR>
				Specify&nbsp;a numeric font size:<BR>
				<asp:textbox id="txtFontSize" runat="server"></asp:textbox><BR>
				<BR>
				Choose a border style:<BR>
				<asp:radiobuttonlist id="lstBorder" runat="server" Height="59px" Width="177px" Font-Size="X-Small"></asp:radiobuttonlist><BR>
				<BR>
				<asp:checkbox id="chkPicture" runat="server" Text="Add the Default Picture"></asp:checkbox><BR>
				<BR>
				Enter the greeting text below:<BR>
				<asp:textbox id="txtGreeting" runat="server" Height="85px" Width="240px" TextMode="MultiLine"></asp:textbox><BR>
				<BR>
				<asp:button id="cmdUpdate" runat="server" Height="24px" Width="71px" Text="Update" onclick="cmdUpdate_Click"></asp:button></DIV>
			<asp:panel id="pnlCard" style="Z-INDEX: 101; LEFT: 313px; POSITION: absolute; TOP: 16px" runat="server" Height="507px" Width="339px" HorizontalAlign="Center"><BR>&nbsp; 
<asp:Label id="lblGreeting" runat="server" Height="150px" Width="256px"></asp:Label><BR><BR><BR>
<asp:Image id="imgDefault" runat="server" Height="160px" Width="212px" Visible="False"></asp:Image></asp:panel></FORM>
	</BODY>
</HTML>
