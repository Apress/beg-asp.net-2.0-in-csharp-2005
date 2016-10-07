<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AuthorManager_Disconnected.aspx.cs" Inherits="AuthorManager_Disconnected" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:panel id="pnlSelect" style="Z-INDEX: 101; LEFT: 8px" runat="server" BackColor="#FFE0C0"
				Height="94px" Width="601px">
				<P><BR>
					&nbsp;&nbsp; &nbsp;
					<asp:Label id="Label1" runat="server" Width="99px" Height="19px">Select Author:</asp:Label>
					<asp:DropDownList id="lstAuthor" runat="server" Width="183px" Height="21px" AutoPostBack="True" onselectedindexchanged="lstAuthor_SelectedIndexChanged"></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </P>
				<P>&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:Label id="Label11" runat="server" Width="99px" Height="19px">Or:</asp:Label>
					<asp:Button id="cmdNew" runat="server" Width="91px" Height="24px" Text="Create New" onclick="cmdNew_Click"></asp:Button>&nbsp;
					<asp:Button id="cmdInsert" runat="server" Width="85px" Height="24px" Text="Insert New" onclick="cmdInsert_Click"></asp:Button></P>
			</asp:panel><BR>
			<asp:panel id="Panel2" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 124px" runat="server"
				BackColor="#E0E0E0" Height="392px" Width="603px">
				<P><BR>
					&nbsp;&nbsp;
					<asp:Label id="Label10" runat="server" Width="100px" Height="19px">Unique ID:</asp:Label>
					<asp:TextBox id="txtID" runat="server" Width="184px" Height="16px"></asp:TextBox>&nbsp; 
					(required:&nbsp;###-##-#### form)<BR>
					&nbsp;&nbsp;
					<asp:Label id="Label2" runat="server" Width="100px" Height="19px">First Name:</asp:Label>
					<asp:TextBox id="txtFirstName" runat="server" Width="184px" Height="16px"></asp:TextBox><BR>
					&nbsp;&nbsp;
					<asp:Label id="Label3" runat="server" Width="100px" Height="19px">Last Name:</asp:Label>
					<asp:TextBox id="txtLastName" runat="server" Width="183px" Height="16px"></asp:TextBox><BR>
					&nbsp;&nbsp;
					<asp:Label id="Label4" runat="server" Width="100px" Height="19px">Phone:</asp:Label>
					<asp:TextBox id="txtPhone" runat="server" Width="183px" Height="16px"></asp:TextBox><BR>
					&nbsp;&nbsp;
					<asp:Label id="Label5" runat="server" Width="100px" Height="19px">Address:</asp:Label>
					<asp:TextBox id="txtAddress" runat="server" Width="183px" Height="16px"></asp:TextBox><BR>
					&nbsp;&nbsp;
					<asp:Label id="Label6" runat="server" Width="100px" Height="19px">City:</asp:Label>
					<asp:TextBox id="txtCity" runat="server" Width="184px" Height="16px"></asp:TextBox><BR>
					&nbsp;&nbsp;
					<asp:Label id="Label7" runat="server" Width="100px" Height="19px">State:</asp:Label>
					<asp:TextBox id="txtState" runat="server" Width="184px" Height="16px"></asp:TextBox><BR>
					&nbsp;&nbsp;
					<asp:Label id="Label9" runat="server" Width="100px" Height="19px">Zip Code:</asp:Label>
					<asp:TextBox id="txtZip" runat="server" Width="184px" Height="16px"></asp:TextBox>&nbsp; 
					(required: any five&nbsp;digits)<BR>
					<BR>
					&nbsp;&nbsp;
					<asp:Label id="Label8" runat="server" Width="93px" Height="19px">Contract:</asp:Label>&nbsp;
					<asp:CheckBox id="chkContract" runat="server"></asp:CheckBox><BR>
					<BR>
					&nbsp;&nbsp;
					<asp:Label id="lblResults" runat="server" Width="575px" Height="121px" Font-Bold="True"></asp:Label></P>
			</asp:panel>
    </div>
    </form>
</body>
</html>
