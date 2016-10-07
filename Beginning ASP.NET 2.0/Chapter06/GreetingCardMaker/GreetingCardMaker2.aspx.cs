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

namespace GreetingCardMaker
{
	/// <summary>
	/// Summary description for GreetingCardMaker2.
	/// </summary>
	public partial class GreetingCardMaker2 : System.Web.UI.Page
	{
	
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

		protected void Page_Load(object sender, System.EventArgs e)
		{
			if (this.IsPostBack == false)
			{
				// Get the list of colors.
				string[] colorArray = Enum.GetNames(typeof(System.Drawing.KnownColor));
				lstBackColor.DataSource = colorArray;
				lstBackColor.DataBind();

				lstForeColor.DataSource = colorArray;
				lstForeColor.DataBind();
				lstForeColor.SelectedIndex = 34;
				lstBackColor.SelectedIndex = 163;

				// Get the list of available fonts and add them to the font list.
				System.Drawing.Text.InstalledFontCollection fonts;
				fonts = new System.Drawing.Text.InstalledFontCollection();
				foreach (FontFamily family in fonts.Families)
				{
					lstFontName.Items.Add(family.Name);
				}				

				// Set border style options.
				string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));
				lstBorder.DataSource = borderStyleArray;
				lstBorder.DataBind();
				
				// Select the first border option.
				lstBorder.SelectedIndex = 0;

				// Set the picture.
				imgDefault.ImageUrl = "defaultpic.png";

			}
		}

		protected void cmdUpdate_Click(object sender, System.EventArgs e)
		{
			// Update the color.
			pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);
			lblGreeting.ForeColor = Color.FromName(lstForeColor.SelectedItem.Text);

			// Update the font.
			lblGreeting.Font.Name = lstFontName.SelectedItem.Text;
			try
			{
				if (Int32.Parse(txtFontSize.Text) > 0)
				{
					lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(txtFontSize.Text));
				}
			}
			catch
			{
				// Ignore invalid value.
			}

			try
			{
				if (Int32.Parse(txtFontSize.Text) > 0)
				{
					lblGreeting.Font.Size =
						FontUnit.Point(Int32.Parse(txtFontSize.Text));
				}
			}
			catch
			{
				// Ignore invalid value.
			}

			// Find the appropriate TypeConverter for the BorderStyle enumeration.
			TypeConverter cnvrt = TypeDescriptor.GetConverter(typeof(BorderStyle));

			// Update the border style using the value from the converter.
			pnlCard.BorderStyle = (BorderStyle)cnvrt.ConvertFromString(
				lstBorder.SelectedItem.Text);


			// Update the picture.
			if (chkPicture.Checked == true)
			{
				imgDefault.Visible = true;
			}
			else
			{
				imgDefault.Visible = false;
			}

			// Set the text.
			lblGreeting.Text = txtGreeting.Text;
		}

		protected void ControlChanged(Object sender, EventArgs e)
		{
			// Call the button event handler to refresh the greeting card.
			cmdUpdate_Click(null, null);
		}

	}

}
