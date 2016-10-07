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
using System.Web.Configuration;

public partial class ShowSettings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		lblTest.Text = "This app will connect with";
		lblTest.Text += "the connection string:<br><b>";
		lblTest.Text +=
		  WebConfigurationManager.AppSettings["ConnectionString"];
		lblTest.Text += "</b><br><br>";
		lblTest.Text += "And will execute the SQL Statement:<br>";
		lblTest.Text += "<b>";
		lblTest.Text += WebConfigurationManager.AppSettings["SelectSales"];
		lblTest.Text += "</b>";

        //// Get the configuration information for this web application.
        //Configuration config =
        //  WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);

        //// Make the change.
        //config.AppSettings.Settings["SelectSales"].Value = "SELECT Price FROM Sales";
        //config.Save();

    }
}
