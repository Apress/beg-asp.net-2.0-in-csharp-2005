using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class CurrencyConverter : System.Web.UI.Page
{
	protected void Page_Load(Object sender, EventArgs e)
	{
		if (this.IsPostBack == false)
		{
			// The HtmlInputSelect control accepts text or ListItem objects.
			Currency.Items.Add(new ListItem("Euros", "0.85"));
			Currency.Items.Add(new ListItem("Japanese Yen", "110.33"));
			Currency.Items.Add(new ListItem("Canadian Dollars", "1.2"));
		}
		Graph.Visible = false;
	}
	protected void Convert_ServerClick(object sender, EventArgs e)
	{
		decimal amount = Decimal.Parse(US.Value);

		// Retrieve the select ListItem object by its index number.
		ListItem item = Currency.Items[Currency.SelectedIndex];

		decimal newAmount = amount * Decimal.Parse(item.Value);
		Result.InnerText = amount.ToString() + " U.S. dollars = ";
		Result.InnerText += newAmount.ToString() + " " + item.Text;
	}

	protected void ShowGraph_ServerClick(object sender, EventArgs e)
	{

    Graph.Src = "Pic" + Currency.SelectedIndex.ToString() + ".png";
    Graph.Alt = "Currency Graph";
    Graph.Visible = true;

	}
}
