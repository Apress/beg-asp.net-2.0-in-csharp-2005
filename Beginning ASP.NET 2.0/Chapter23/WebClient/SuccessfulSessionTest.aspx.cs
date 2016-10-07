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

public partial class SuccessfulSessionTest : System.Web.UI.Page
{
	private localhost.StockQuote_SessionState ws =
 new localhost.StockQuote_SessionState();


    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void cmdCallService_Click(object sender, EventArgs e)
	{
		GetCookie();
		decimal result = ws.GetStockQuote("MSFT");
		SetCookie();

		// Add confirmation message to the label.
		lblResult.Text += "GetStockQuote With MSFT Returned ";
		lblResult.Text += result.ToString() + "<br />";

	}
	protected void cmdGetCounter_Click(object sender, EventArgs e)
	{
		localhost.CounterInfo wsInfo;
		GetCookie();
		wsInfo = ws.GetStockUsage("MSFT");
		SetCookie();

		// Add usage information to the label.
		lblResult.Text += "<b>Global: " + wsInfo.GlobalRequests.ToString();
		lblResult.Text += "<br />Session: ";
		lblResult.Text += wsInfo.SessionRequests.ToString() + "<br /></b>";

	}

	private void GetCookie()
	{
		// Initialize the proxy class CookieContainer so it can receive cookies.
		ws.CookieContainer = new CookieContainer();

		// If a cookie is found, place it in the proxy class.
		// The only reason it won't be found is if this is the first time the
		// button has been clicked.
		if (Session["WebServiceCookie"] != null)
		{
			// Create a cookie object, and try to retrieve it from session state.
			Cookie sessionCookie;
			sessionCookie = (Cookie)Session["WebServiceCookie"];
			ws.CookieContainer.Add(sessionCookie);
		}
	}

	private void SetCookie()
	{
		// Retrieve and store the current cookie for next time.
		// The session is always stored in a special cookie
		// called ASP.NET_SessionId.
		Uri wsUri = new Uri("http://localhost");

		CookieCollection cookies = ws.CookieContainer.GetCookies(wsUri);
		Session["WebServiceCookie"] = cookies["ASP.NET_SessionId"];
	}

}
