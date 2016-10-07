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
using System.Net;

public partial class TestSecureService : System.Web.UI.Page
{
    protected void cmdUnauthenticated_Click(Object sender, EventArgs e)
    {
        localhost.SecureService ws = new localhost.SecureService();
        lblInfo.Text = ws.TestAuthenticated();
    }

    protected void cmdAuthenticated_Click(Object sender, EventArgs e)
    {
        localhost.SecureService ws = new localhost.SecureService();

        // Specity some user credentials for the web service.
        // This example uses the user account "GuestAccount" with the password
        // "Guest".
        NetworkCredential credentials = new NetworkCredential(
          "GuestAccount", "Guest");
        ws.Credentials = credentials;

        lblInfo.Text = ws.TestAuthenticated();
    }
}

