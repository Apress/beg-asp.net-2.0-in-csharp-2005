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

public partial class FailedSessionTest : System.Web.UI.Page
{
	private localhost.StockQuote_SessionState ws =
 new localhost.StockQuote_SessionState();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void cmdGetCounter_Click(object sender, EventArgs e)
	{
		localhost.CounterInfo wsInfo;
		wsInfo = ws.GetStockUsage("MSFT");

		// Add usage information to the label.
		lblResult.Text += "<b>Global: " + wsInfo.GlobalRequests.ToString();
		lblResult.Text += "<br />Session: ";
		lblResult.Text += wsInfo.SessionRequests.ToString() + "<br /></b>";

	}
	protected void cmdCallService_Click(object sender, EventArgs e)
	{
		decimal result = ws.GetStockQuote("MSFT");

		// Add confirmation message to the label.
		lblResult.Text += "GetStockQuote With MSFT Returned ";
		lblResult.Text += result.ToString() + "<br />";

	}
}
