using System;
using System.Web;
using System.Web.Services;


[WebService(Description="Retrieve information about a stock.",
 Namespace="http://www.prosetech.com/Stocks")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class StockQuote : System.Web.Services.WebService
{
	[WebMethod(Description = "Gets a quote for a NASDAQ stock.")]
	public decimal GetStockQuote(string ticker)
	{
		// A real example would perform a database lookup. This function just
		// returns a hard-coded number for testing purposes.
		return ticker.Length;
	}
	
}

