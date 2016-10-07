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

public partial class NameTextBoxHost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdGetNames_Click(Object sender, EventArgs e)
    {
        lblNames.Text = "<b>First name:</b> ";
        lblNames.Text += NameTextBox1.GetFirstName();
        lblNames.Text += "<br /><b>Last name:</b> ";
        lblNames.Text += NameTextBox1.GetLastName();
    }

}
