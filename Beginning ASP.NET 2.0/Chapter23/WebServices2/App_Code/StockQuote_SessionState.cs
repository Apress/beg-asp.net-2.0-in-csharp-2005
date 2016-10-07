using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;


[WebService(Description = "Methods to get stock information.",
 Namespace = "http://www.prosetech.com/Stocks")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class StockQuote_SessionState : WebService
{
	[WebMethod(EnableSession = true)]
	public decimal GetStockQuote(string ticker)
	{
		// Increment counters. This function locks the application
		// collection to prevent synchronization errors.
		Application.Lock();
		if (Application[ticker] == null)
		{
			Application[ticker] = 1;
		}
		else
		{
			Application[ticker] = (int)Application[ticker] + 1;
		}
		Application.UnLock();

		if (Session[ticker] == null)
		{
			Session[ticker] = 1;
		}
		else
		{
			Session[ticker] = (int)Session[ticker] + 1;
		}

		// Return a value representing the length of the ticker.
		return ticker.Length;
	}

	[WebMethod(EnableSession = true)]
	public CounterInfo GetStockUsage(string ticker)
	{
		CounterInfo result = new CounterInfo();
		if (Application[ticker] != null) result.GlobalRequests = (int)Application[ticker];
		if (Session[ticker] != null) result.SessionRequests = (int)Session[ticker];
		return result;
	}
}

public class CounterInfo
{
	public int GlobalRequests;
	public int SessionRequests;
}
