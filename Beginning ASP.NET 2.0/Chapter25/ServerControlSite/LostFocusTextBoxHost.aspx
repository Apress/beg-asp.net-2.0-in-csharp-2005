<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LostFocusTextBoxHost.aspx.cs" Inherits="LostFocusTextBoxHost" %>

<%@ Register Assembly="ServerControlLibrary" Namespace="CustomControls" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Text Box 1:
        <cc1:lostfocustextbox id="LostFocusTextBox1" runat="server" Alert="You Lost Focus"></cc1:lostfocustextbox>
        <br />
        Text Box 2:
        <cc1:lostfocustextbox id="LostFocusTextBox2" runat="server" Alert="You Lost Focus AGAIN"></cc1:lostfocustextbox>
    
    </div>
    </form>
</body>
</html>
