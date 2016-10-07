<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormViewTest.aspx.cs" Inherits="FormView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="lstProducts" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1"
            DataTextField="ProductName" DataValueField="ProductID" Width="184px">
        </asp:DropDownList><br />
        <br />
        <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource2"
            Width="184px" BackColor="#FFE0C0" BorderStyle="Solid" BorderWidth="2px" CellPadding="5">
            <ItemTemplate>
               
                <b>In Stock:</b>
                    <%# Eval("UnitsInStock") %>
                    <br />
                    <b>On Order:</b>
                    <%# Eval("UnitsOnOrder") %>
                    <br />
                    <b>Reorder:</b>
                    <%# Eval("ReorderLevel") %>
                    <br />
                    <br />
                
            </ItemTemplate>
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="SELECT * FROM Products"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="SELECT * FROM Products WHERE ProductID=@ProductID">
            <SelectParameters>
            <asp:ControlParameter Name="ProductID" ControlID="lstProducts" PropertyName="SelectedValue" />
            </SelectParameters>
            </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
