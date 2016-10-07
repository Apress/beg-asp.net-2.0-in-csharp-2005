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
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class AuthorManager_Disconnected : System.Web.UI.Page
{
    private string connectionString =
  WebConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            FillAuthorList();
        }
    }

    private void FillAuthorList()
    {
        lstAuthor.Items.Clear();

        // Define the Select statement.
        // Three pieces of information are needed: the unique id,
        // and the first and last name.
        string selectSQL = "SELECT au_lname, au_fname, au_id FROM Authors";

        // Define the ADO.NET objects.
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader reader;

        // Try to open database and read information.
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();

            // For each item, add the author name to the displayed
            // list box text, and store the unique ID in the Value property.
            while (reader.Read())
            {
                ListItem newItem = new ListItem();
                newItem.Text = reader["au_lname"] + ", " + reader["au_fname"];
                newItem.Value = reader["au_id"].ToString();
                lstAuthor.Items.Add(newItem);
            }
            reader.Close();
        }
        catch (Exception err)
        {
            lblResults.Text = "Error reading list of names. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }

    protected void lstAuthor_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Define ADO.NET objects.
        string selectSQL;
        selectSQL = "SELECT * FROM Authors ";
        selectSQL += "WHERE au_id='" + lstAuthor.SelectedItem.Value + "'";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader reader;

        // Try to open database and read information.
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();

            // Fill the controls.
            txtID.Text = reader["au_id"].ToString();
            txtFirstName.Text = reader["au_fname"].ToString();
            txtLastName.Text = reader["au_lname"].ToString();
            txtPhone.Text = reader["phone"].ToString();
            txtAddress.Text = reader["address"].ToString();
            txtCity.Text = reader["city"].ToString();
            txtState.Text = reader["state"].ToString();
            txtZip.Text = reader["zip"].ToString();
            chkContract.Checked = (bool)reader["contract"];
            reader.Close();
            lblResults.Text = "";
        }
        catch (Exception err)
        {
            lblResults.Text = "Error getting author. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

    }
    protected void cmdNew_Click(object sender, EventArgs e)
    {
        txtID.Text = "";
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtPhone.Text = "";
        txtAddress.Text = "";
        txtCity.Text = "";
        txtState.Text = "";
        txtZip.Text = "";
        chkContract.Checked = false;

        lblResults.Text = "Click Insert New to add the completed record.";


    }
    protected void cmdInsert_Click(object sender, EventArgs e)
    {
        // Define ADO.NET objects.
        string selectSQL;
        selectSQL = "SELECT * FROM Authors";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet dsPubs = new DataSet();

        // Get the schema information.
        try
        {
            con.Open();
            adapter.FillSchema(dsPubs, SchemaType.Mapped, "Authors");
        }
        catch (Exception err)
        {
            lblResults.Text = "Error reading schema. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        DataRow rowNew;
        rowNew = dsPubs.Tables["Authors"].NewRow();
        rowNew["au_id"] = txtID.Text;
        rowNew["au_fname"] = txtFirstName.Text;
        rowNew["au_lname"] = txtLastName.Text;
        rowNew["phone"] = txtPhone.Text;
        rowNew["address"] = txtAddress.Text;
        rowNew["city"] = txtCity.Text;
        rowNew["state"] = txtState.Text;
        rowNew["zip"] = txtZip.Text;
        rowNew["contract"] = Convert.ToInt16(chkContract.Checked);
        dsPubs.Tables["Authors"].Rows.Add(rowNew);

        // Insert the new record.
        int added = 0;
        try
        {
            // Create the CommandBuilder.
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            // Retrieve an updated DataAdapter.
            adapter = cb.DataAdapter;

            // Update the database using the DataSet.
            con.Open();
            added = adapter.Update(dsPubs, "Authors");
        }
        catch (Exception err)
        {
            lblResults.Text = "Error inserting record. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        // If the insert succeeded, refresh the author list.
        if (added > 0)
        {
            FillAuthorList();
        }
    }
}
