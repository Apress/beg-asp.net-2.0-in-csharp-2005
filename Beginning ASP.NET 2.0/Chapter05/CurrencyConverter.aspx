<%@ Page Language="C#" AutoEventWireup="true"
    CodeFile="CurrencyConverter.aspx.cs" Inherits="CurrencyConverter" %>
<html>
  <head>
    <title>Currency Converter</title>
  </head>
  <body>
    <form id="Form1" method="post" runat="server">

        <div style="border-right: thin ridge; padding-right: 20px; border-top: thin ridge;
            padding-left: 20px; padding-bottom: 20px; border-left: thin ridge; width: 531px;
            padding-top: 20px; border-bottom: thin ridge; font-family: Verdana; height: 211px;
            background-color: lightyellow">

        Convert: &nbsp;
        <input type="text" id="US" runat="server" style="width: 102px">&nbsp; U.S. dollars to &nbsp;
        <select id="Currency" runat="server"></select>
        <br /><br />
        <input type="submit" value="OK" id="Convert" runat="server" onserverclick="Convert_ServerClick">
                <input type="submit" value="Show Graph" id="ShowGraph" runat="server" onserverclick="ShowGraph_ServerClick">
        <br /><br />
        <img id="Graph" runat="server">

        <br /><br />
        <div style="font-weight: bold" id="Result" runat="server"></div>
      </div>
    </form>
  </body>
</html>
