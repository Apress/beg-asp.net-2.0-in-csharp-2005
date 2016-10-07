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

public partial class ConcurrencyHandler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdTest_Click(object sender, EventArgs e)
    {
        lblResult.Text = "";

        // Define ADO.NET objects.
        string selectSQL = "SELECT * FROM Authors";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        // Create the CommandBuilder.
        SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
        // Retrieve an updated DataAdapter.
        adapter = cb.DataAdapter;

        // Connect the event handler.
        adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

        // Create two DataSets... perfect for conflicting data.
        DataSet dsPubs1 = new DataSet();
        DataSet dsPubs2 = new DataSet();

        try
        {
            con.Open();

            // Fill both DataSets with the same table.
            adapter.Fill(dsPubs1, "Authors");
            adapter.Fill(dsPubs2, "Authors");

            // "Flip" the contract field in the first row of dsPubs1.
            if ((bool)dsPubs1.Tables[0].Rows[0]["contract"] == true)
            {
                dsPubs1.Tables[0].Rows[0]["contract"] = false;
            }
            else
            {
                dsPubs1.Tables[0].Rows[0]["contract"] = true;
            }

            // Update the database
            adapter.Update(dsPubs1, "Authors");

            // Make a change in the second DataSet.
            dsPubs2.Tables[0].Rows[0]["au_fname"] = "Bill";
            dsPubs2.Tables[0].Rows[0]["au_lname"] = "Gates";

            // Try to update this row. Even though these changes don't conflict,
            // the update will fail because the row has been changed.
            adapter.Update(dsPubs2, "Authors");
        }
        catch (Exception err)
        {
            lblResult.Text += "Error reading schema. ";
            lblResult.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

    }

    public void OnRowUpdated(Object sender, SqlRowUpdatedEventArgs e)
    {
        // Check if any records were affected.
        if (e.RecordsAffected < 1)
        {
            // Find out the type of failed error.
            switch (e.StatementType)
            {
                case StatementType.Delete:
                    lblResult.Text += "<br>Not deleted: ";
                    break;
                case StatementType.Insert:
                    lblResult.Text += "<br>Not inserted: ";
                    break;
                case StatementType.Update:
                    lblResult.Text += "<br>Not updated: ";
                    break;
            }

            lblResult.Text += "(" + e.Row["au_id"] + " " + e.Row["au_lname"];
            lblResult.Text += ", " + e.Row["au_fname"] + ")";

            // Continue processing.
            e.Status = UpdateStatus.SkipCurrentRow;
        }
    }

    private string connectionString =
  WebConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;


}
