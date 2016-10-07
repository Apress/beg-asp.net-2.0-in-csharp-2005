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

public partial class SimpleTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	private net.terraservice.TerraService ts = new net.terraservice.TerraService();

	protected void cmdShow_Click(object sender, EventArgs e)
	{
		// Create the Place object for Seattle.
		net.terraservice.Place searchPlace = new net.terraservice.Place();
		searchPlace.City = "Seattle";
		searchPlace.State = "Washington";
		searchPlace.Country = "US";

		// Define the PlaceFacts objects to retrieve your information.
		net.terraservice.PlaceFacts facts;

		// Call the web service method.
		facts = ts.GetPlaceFacts(searchPlace);

		// Display the results with the help of a subroutine.
		ShowPlaceFacts(facts);

	}

	private void ShowPlaceFacts(net.terraservice.PlaceFacts facts)
	{
		lblResult.Text += "<b>Place: " + facts.Place.City + "</b><br /><br />";
		lblResult.Text += facts.Place.State + ", " + facts.Place.Country;
		lblResult.Text += "<br /> Lat: " + facts.Center.Lat.ToString();
		lblResult.Text += "<br /> Long: " + facts.Center.Lon.ToString();
		lblResult.Text += "<br /><br />";
	}

	protected void cmdShowAll_Click(object sender, EventArgs e)
	{
		// Retrieve the matching list (for the city "Kingston").
		net.terraservice.PlaceFacts[] factsArray;
		factsArray = ts.GetPlaceList("Kingston", 100, false);

		// Loop through all the results, and display them.
		foreach (net.terraservice.PlaceFacts facts in factsArray)
		{
			ShowPlaceFacts(facts);
		}

	}
	protected void cmdShowPic_Click(object sender, EventArgs e)
	{
		// Define the search.
		net.terraservice.Place searchPlace = new net.terraservice.Place();
		searchPlace.City = "Seattle";
		searchPlace.State = "Washington";
		searchPlace.Country = "US";

		// Get the PlaceFacts for Seattle.
		net.terraservice.PlaceFacts facts;
		facts = ts.GetPlaceFacts(searchPlace);

		// Retrieve information about the tile at the center of Seattle, using
		// the Scale and Theme enumerations from the terraservice namespace.
		net.terraservice.TileMeta tileData;
		tileData = ts.GetTileMetaFromLonLatPt(facts.Center,
		 net.terraservice.Theme.Photo, net.terraservice.Scale.Scale16m);

		// Retrieve the image.
		byte[] image = ts.GetTile(tileData.Id);

		// Display the image.
		Response.BinaryWrite(image);

	}
}
