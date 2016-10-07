using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ButtonGridHost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        ButtonGrid1.Rows = Int32.Parse(txtRows.Text);
        ButtonGrid1.Cols = Int32.Parse(txtCols.Text);
    }
    protected void ButtonGrid1_GridClick(object sender, CustomControls.GridClickEventArgs e)
    {
        lblInfo.Text = "You clicked: " + e.ButtonName;
    }
}
