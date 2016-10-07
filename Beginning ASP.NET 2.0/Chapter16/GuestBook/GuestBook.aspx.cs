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
using System.Collections.Generic;
using System.IO;

public partial class GuestBook : System.Web.UI.Page
{
    private string guestBookName;

    protected void Page_Load(object sender, EventArgs e)
    {
        guestBookName = Server.MapPath("GuestBook");

        if (!this.IsPostBack)
        {
            GuestBookList.DataSource = GetAllEntries();
            GuestBookList.DataBind();
        }
    }

    private List<BookEntry> GetAllEntries()
    {
        // Return an ArrayList that contains BookEntry objects
        // for each file in the GuestBook directory.
        // This function relies on the GetEntryFromFile function.
        List<BookEntry> entries = new List<BookEntry>();
        DirectoryInfo guestBookDir = new DirectoryInfo(guestBookName);

        foreach (FileInfo fileItem in guestBookDir.GetFiles())
        {
            entries.Add(GetEntryFromFile(fileItem));
        }
        return entries;
    }

    private BookEntry GetEntryFromFile(FileInfo entryFile)
    {
        // Turn the file information into a Book Entry object.
        BookEntry newEntry = new BookEntry();
        StreamReader r = entryFile.OpenText();
        newEntry.Author = r.ReadLine();
        newEntry.Submitted = DateTime.Parse(r.ReadLine());
        newEntry.Message = r.ReadLine();
        r.Close();

        return newEntry;
    }

    private void SaveEntry(BookEntry entry)
    {
        // Create a new file for this entry, with a file name that should
        // be statistically unique.
        Random random = new Random();
        string fileName = guestBookName + @"\";
        fileName += DateTime.Now.Ticks.ToString() + random.Next(100).ToString();
        FileInfo newFile = new FileInfo(fileName);
        StreamWriter w = newFile.CreateText();

        // Write the information to the file.
        w.WriteLine(entry.Author);
        w.WriteLine(entry.Submitted.ToString());
        w.WriteLine(entry.Message);
        w.Flush();
        w.Close();
    }


    protected void cmdSubmit_Click(object sender, EventArgs e)
    {
        // Create a new BookEntry object.
        BookEntry newEntry = new BookEntry();
        newEntry.Author = txtName.Text;
        newEntry.Submitted = DateTime.Now;
        newEntry.Message = txtMessage.Text;

        // Let the SaveEntry procedure create the corresponding file.
        SaveEntry(newEntry);

        // Refresh the display.
        GuestBookList.DataSource = GetAllEntries();
        GuestBookList.DataBind();

        txtName.Text = "";
        txtMessage.Text = "";
    }
}
