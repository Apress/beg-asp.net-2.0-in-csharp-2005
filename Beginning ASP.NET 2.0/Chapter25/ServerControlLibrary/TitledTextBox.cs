using System;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace CustomControls
{
	public class TitledTextBox : TextBox
	{
		private string title;
		public string Title
		{
			get
			{ return title; }
			set
			{ title = value; }
		}

		protected override void Render(HtmlTextWriter writer)
		{
			// Add new HTML.
			writer.Write("<h1>" + title + "</h1>");

			// Call the base method (so that the text box is rendered).
			base.Render(writer);
		}
	}
}	