using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Web.Security;
using System.Security;


[WebServiceBinding(ConformsTo = WsiProfiles.None)]
[WebService(Description = "Methods to get stock information.",
 Namespace = "http://www.prosetech.com/Stocks")]
public class StockQuote_SoapSecurity : WebService
{
	public LicenseKeyHeader KeyHeader;

	[WebMethod]
	[SoapHeader("KeyHeader", Direction = SoapHeaderDirection.Out)]
	public void Login(string userName, string password)
	{
		if (Membership.ValidateUser(userName, password))
		{
			// Generate a license key and store it in the SOAP header.
			KeyHeader = new LicenseKeyHeader();

			// Add this ticket to Application state.
			Application[KeyHeader.Ticket] = KeyHeader;
		}
		else
		{
			// Cause an error that will be returned to the client.
			throw new SecurityException("Unauthorized.");
		}
	}

	[WebMethod]
	[SoapHeader("KeyHeader", Direction = SoapHeaderDirection.In)]
	public int GetStockQuote(string ticker)
	{
		// Get the key from the SOAP header.
		if (!VerifyKey(KeyHeader.Ticket))
		{
			throw new System.Security.SecurityException("Unauthorized.");
		}
		else
		{
			// Normal GetStockQuote code goes here.
			return ticker.Length;
		}
	}

	private bool VerifyKey(string ticket)
    {
        // Look up this key to make sure it's valid.
        LicenseKeyHeader key = Application[ticket] as LicenseKeyHeader;
        return (ticket != null);
    }

    [WebMethod()]
    public void CreateTestUser(string name, string password)
    {
        if (Membership.GetUser(name) == null)
        {
            MembershipCreateStatus status;
            Membership.CreateUser(name, password, "email@none.com", "Question goes here", "Answer goes here", true, out status);
            if (status != MembershipCreateStatus.Success) throw new ApplicationException(status.ToString());
        }
    }
}

public class LicenseKeyHeader : System.Web.Services.Protocols.SoapHeader
{
	public string Ticket;

	public LicenseKeyHeader(string ticket)
	{
		Ticket = ticket;
	}

	public LicenseKeyHeader()
    {
		Ticket = Guid.NewGuid().ToString();
    }
}



