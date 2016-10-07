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
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class MultipleViews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            Cache.Remove("Titles");

            DataSet dsPubs = GetDataSet();
            
            chkColumns.DataSource = dsPubs.Tables[0].Columns;
            chkColumns.DataMember = "Item";
            chkColumns.DataBind();
        }
    }

    // This method checks the cache for the DataSet,
    // and re-caches it if needed.
    private DataSet GetDataSet()
    {
        DataSet dsPubs;
        if (Cache["Titles"] == null)
        {
            dsPubs = RetrieveData();
            Cache.Insert("Titles", dsPubs, null, DateTime.MaxValue, TimeSpan.FromMinutes(2));
            lblCacheStatus.Text = "Created and added to cache.";
        }
        else
        {
            dsPubs = (DataSet)Cache["Titles"];
            lblCacheStatus.Text = "Retrieved from cache.";
        }
        return dsPubs;
    }

    // This method performs the database query, if the 
    // DataSet object isn't available in the cache.
    private DataSet RetrieveData()
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        string SQLSelect = "SELECT * FROM Customers";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(SQLSelect, con);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        try
        {
            con.Open();
            adapter.Fill(ds, "Customers");
        }
        finally
        {
            con.Close();
        }

        return ds;
    }

    protected void cmdApply_Click(object sender, EventArgs e)
    {
        DataSet ds = GetDataSet();

        // Copy the DataSet so the cached item isn't affected
        // when we remove columns.
        ds = ds.Copy();
        
        foreach (ListItem item in chkColumns.Items)
        {
            if (item.Selected)
            {
                ds.Tables[0].Columns.Remove(item.Text);
            }
        }

        gridPubs.DataSource = ds.Tables[0];
        gridPubs.DataBind();

    }
}
