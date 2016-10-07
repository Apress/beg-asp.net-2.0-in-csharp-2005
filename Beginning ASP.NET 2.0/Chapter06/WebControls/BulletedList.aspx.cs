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

public partial class BulletedList_aspx : System.Web.UI.Page
{
    // Page events are wired up automatically to methods 
    // with the following names:
    // Page_Load, Page_AbortTransaction, Page_CommitTransaction,
    // Page_DataBinding, Page_Disposed, Page_Error, Page_Init, 
    // Page_Init Complete, Page_Load, Page_LoadComplete, Page_PreInit
    // Page_PreLoad, Page_PreRender, Page_PreRenderComplete, 
    // Page_SaveStateComplete, Page_Unload
     
    protected void Page_Load(object sender, EventArgs e)
    {
		if (!Page.IsPostBack)
		{
			foreach (string style in
				Enum.GetNames(typeof(BulletStyle)))
			{
				BulletedList1.Items.Add(style);
			}
		}
    }
	protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
	{
		string styleName = BulletedList1.Items[e.Index].Text;
		BulletStyle style = (BulletStyle)Enum.Parse(typeof(BulletStyle), styleName);
		BulletedList1.BulletStyle = style;
	}
}
