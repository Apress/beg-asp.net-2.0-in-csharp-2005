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
using System.Web.Services.Protocols;

public partial class TestSoapHeaderService : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            // Create a test user.
            localhost.StockQuote_SoapSecurity ws = new localhost.StockQuote_SoapSecurity();
            ws.CreateTestUser("testUser", "openSesame_00");
        }        
    }

    protected void cmdAuthenticated_Click(object sender, EventArgs e)
    {
        // Create the web service proxy class.
        localhost.StockQuote_SoapSecurity ws = new localhost.StockQuote_SoapSecurity();

        try
        {
            ws.Login("testUser", "openSesame_00");

            decimal price = ws.GetStockQuote("MSFT");
            lblInfo.Text = "MSFT is at " + price.ToString();
        }
        catch (SoapException err)
        {            
            lblInfo.Text = err.Message;
        }
    }
    protected void cmdUnauthenticated_Click(object sender, EventArgs e)
    {
        // Create the web service proxy class.
        localhost.StockQuote_SoapSecurity ws = new localhost.StockQuote_SoapSecurity();

        try
        {
            decimal price = ws.GetStockQuote("MSFT");
            lblInfo.Text = "MSFT is at " + price.ToString();
        }
        catch (SoapException err)
        {
            // This error results because no header was provided.
            lblInfo.Text = err.Message;
        }
    }
}
