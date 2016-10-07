<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HtmlEncodeTest.aspx.cs" Inherits="HtmlEncodeTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

<h2>Properly encoded:</h2> 
      <div id="ctrl2" 
            runat="server"/>

<br><hr><br>
<h2>Incorrectly encoded:</h2> 
      <div id="ctrl1" 
            runat="server"/>

    </div>
    </form>
</body>
</html>
