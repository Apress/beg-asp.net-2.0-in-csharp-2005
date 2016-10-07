using System;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace CustomControls
{
	public class LostFocusTextBox : TextBox
	{
		private string alert;
		public string Alert
		{
			get
			{ return alert; }
			set
			{ alert = value; }
		}

		protected override void AddAttributesToRender( 
			HtmlTextWriter writer)
		{
			base.AddAttributesToRender(writer);
			writer.AddAttribute("OnBlur", 
				"javascript:alert('" + alert + "')");
		}

	}

}
