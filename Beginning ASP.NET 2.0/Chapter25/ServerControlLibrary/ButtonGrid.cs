using System;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace CustomControls
{
	public class ButtonGrid : Control,IPostBackEventHandler
	{
		public event GridClickEventHandler GridClick;
 
		public ButtonGrid()
		{
			Rows = 2;
			Cols = 2;
		}

		public int Cols
		{
			get { return (int)ViewState["Cols"]; }
			set { ViewState["Cols"] = value; }
		}

		public int Rows
		{
			get { return (int)ViewState["Rows"]; }
			set { ViewState["Rows"] = value; }
		}


		public void RaisePostBackEvent(string eventArgument) 
		{
            // This is a workaroudn for a bug that makes
            // the eventArgument null (when it should contain the
            // button text).
            string evtArg = null;
            if (eventArgument == null)
            {
                if (Page.Request.Form["__EVENTTARGET"] == this.UniqueID)
                {
                    evtArg = Page.Request.Form["__EVENTARGUMENT"];
                }
            }

			if (GridClick != null)
			{
				GridClick(this, new GridClickEventArgs(evtArg));
			}
		}

		protected override void CreateChildControls()
		{
            base.CreateChildControls();
            int k = 0;
			for (int i = 0; i < Rows; i++)
			{
				for (int j = 0; j < Cols; j++)
				{
					k++;

					// Create and configure a button.
					Button ctrlB = new Button();
					ctrlB.Width = Unit.Pixel(60);
					ctrlB.Text = k.ToString();
 
					ctrlB.Attributes["onClick"] = 
						Page.ClientScript.GetPostBackEventReference(this, ctrlB.Text);

					// Add the button.
                    this.Controls.Add(ctrlB);
				}

				// Add a line break.
				LiteralControl ctrlL = new LiteralControl("<br />");
				this.Controls.Add(ctrlL);
			}           
		}

        protected override void OnInit(EventArgs e)
        {            
            Page.RegisterRequiresRaiseEvent(this);
            base.OnInit(e);
        }
    }

    
	public class GridClickEventArgs : EventArgs
	{
		public string ButtonName;
		public GridClickEventArgs(string buttonName)
		{
			ButtonName = buttonName;
		}

	}

	public delegate void GridClickEventHandler(object sender, 
	GridClickEventArgs e);


}