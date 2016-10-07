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
using System.IO;
using System.Text;

public partial class ViewFiles : System.Web.UI.Page
{
    private string ftpDirectory = @"c:\Inetpub\wwwroot";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            CreateFileList();
        }
    }

    private void CreateFileList()
    {
        // Retrieve the list of files, and display it in the page.
        // This code also disables the delete button, ensuring the
        // user must view the file information before deleting it.
        string[] fileList = Directory.GetFiles(ftpDirectory);
        lstFiles.DataSource = fileList;
        lstFiles.DataBind();
        lblFileInfo.Text = "";
        cmdDelete.Enabled = false;
    }

    protected void cmdRefresh_Click(object sender, EventArgs e)
    {
        CreateFileList();
    }
    protected void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Display the selected file information.
        // Use the StringBuilder for the fastest way to build the string
        // that will be displayed.
        StringBuilder displayText = new StringBuilder();
        string fileName = lstFiles.SelectedItem.Text;
        displayText.Append("<b>");
        displayText.Append(fileName);
        displayText.Append("</b><br />Created : ");
        displayText.Append(File.GetCreationTime(fileName).ToString());
        displayText.Append("<br />Last Accessed : ");
        displayText.Append(File.GetLastAccessTime(fileName).ToString());
        displayText.Append("<br />");

        // Show attribute information. GetAttributes() can return a combination
        // of enumerated values, so you need to evaluate it with the
        // bitwise and (&) operator.
        FileAttributes attributes = File.GetAttributes(fileName);
        if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
        {
            displayText.Append("This is a hidden file.<br />");
        }
        if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
        {
            displayText.Append("This is a read-only file.<br />");
            cmdDelete.Enabled = false;
        }
        else
        {
            cmdDelete.Enabled = true;
        }

        // Show the generated text in a label.
        lblFileInfo.Text = displayText.ToString();

    }


    protected void cmdDelete_Click(object sender, EventArgs e)
    {
        File.Delete(lstFiles.SelectedItem.Text);
        CreateFileList();
    }
}
