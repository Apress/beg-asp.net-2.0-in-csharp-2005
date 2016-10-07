using System;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.ComponentModel;

namespace CustomControls
{
	public class ConfigurableRepeaterControl : WebControl
	{
		public ConfigurableRepeaterControl()
		{
			ViewState["RepeatTimes"] = 3;
			ViewState["Text"] = "";
		}

        [Description("The number of times Text will be repeated"), Category("Layout")] 
		public int RepeatTimes
		{
			get
			{ return (int)ViewState["RepeatTimes"]; }
			set
			{ ViewState["RepeatTimes"] = value; }
		}

		public string Text
		{
			get
			{ return (string)ViewState["Text"]; }
			set
			{ ViewState["Text"] = value; }
		}

		protected override void RenderContents(HtmlTextWriter writer)
		{
			base.RenderContents(writer);
			for (int i = 0; i < RepeatTimes; i++)
			{
				writer.Write(Text + "<br>");
			}
		}
	}

}
