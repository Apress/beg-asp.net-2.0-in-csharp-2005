using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WebControls
{
	/// <summary>
	/// Summary description for EventTracker.
	/// </summary>
	public partial class EventTracker : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			 Log("<< Page_Load >>");
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion

		private void Log(string entry)
		{
			lstEvents.Items.Add(entry);

			// Select the last item to scroll the list so the most recent
			// entries are visible.
			lstEvents.SelectedIndex = lstEvents.Items.Count - 1;
		}

		protected void EventTracker_PreRender(object sender, System.EventArgs e)
		{
			// When the Page.UnLoad event occurs it is too late
			// to change the list.
			Log("Page_PreRender");

		}

		protected void CtrlChanged(Object sender, EventArgs e)
		{
			// Find the control ID of the sender.
			// This requires converting the Object type into a Control class.
			string ctrlName = ((Control)sender).ID;
			Log(ctrlName + " Changed");
		}

	}
}
