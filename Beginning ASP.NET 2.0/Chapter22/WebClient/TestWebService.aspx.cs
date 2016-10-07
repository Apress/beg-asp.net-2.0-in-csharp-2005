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

public partial class TestWebService : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdCall_Click(object sender, EventArgs e)
    {
        localhost.StockInfo wsInfo;
        localhost.StockQuote_DataObject ws = new localhost.StockQuote_DataObject();

        // This timeout will apply to all WS method calls until it's changed.
        ws.Timeout = 3000;  // 3,000 milliseconds is 3 seconds.

        try
        {
            // Call the web service method.
            wsInfo = ws.GetStockQuote("MSFT");
            lblResult.Text = wsInfo.CompanyName + " is at: " + wsInfo.Price.ToString();
        }
        catch (System.Net.WebException err)
        {
            if (err.Status == WebExceptionStatus.Timeout)
            {
                lblResult.Text = "Web service timed out after 3 seconds.";
            }
            else
            {
                lblResult.Text = "Another type of problem occurred.";
            }
        }

    }
}
