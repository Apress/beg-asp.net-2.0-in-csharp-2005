<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TitledTextBoxHost.aspx.cs" Inherits="TitledTextBoxHost" %>

<%@ Register Assembly="ServerControlLibrary" Namespace="CustomControls" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:TitledTextBox ID="TitledTextBox1" runat="server" Title="Sample Title"></cc1:TitledTextBox>&nbsp;</div>
    </form>
</body>
</html>
