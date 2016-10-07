using System;
using System.Web;
using System.Web.Services;

[WebService(Description = "Methods to get stock information.",
 Namespace = "http://www.prosetech.com/Stocks")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class StockQuote_DataObject : WebService
{
	[WebMethod(Description = "Gets a price quote for a stock.")]
	public StockInfo GetStockQuote(string ticker)
	{
		StockInfo quote = new StockInfo();
		quote.Symbol = ticker;
		quote = FillQuoteFromDB(quote);
		return quote;
	}

	private StockInfo FillQuoteFromDB(StockInfo lookup)
	{
		// You can add the appropriate database code here.
		// For test purposes this function hard-codes
		// some sample information.
		lookup.CompanyName = "Trapezoid";
		lookup.Price = 400;
		lookup.High_52Week = 410;
		lookup.Low_52Week = 20;
		return lookup;
	}
}

public class StockInfo
{
	public decimal Price;
	public string Symbol;
	public decimal High_52Week;
	public decimal Low_52Week;
	public string CompanyName;
}
