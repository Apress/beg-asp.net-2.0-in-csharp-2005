<%@ Page language="c#" Inherits="WebControls.TablePictures" CodeFile="TablePictures.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
<head id="Head1" runat="server">
  <title>Table Test</title>
</head>
<body>
  <form id="Form1" method="post" runat="server">
    Rows:
    <asp:TextBox id="txtRows" runat="server" />&nbsp;
    Cols:
    <asp:TextBox id="txtCols" runat="server" /><br /><br />
    <asp:CheckBox id="chkBorder" runat="server"
         Text="Put Border Around Cells" />
    <br /><br />
    <asp:Button id="cmdCreate" OnClick="cmdCreate_Click" runat="server"
     Text="Create" /><br /><br />
    <asp:Table id="tbl" runat="server" />
  </form>
</body>
</html>

