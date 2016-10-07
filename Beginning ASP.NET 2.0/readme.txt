----------
Readme.txt
----------

The examples are arranged by chapter.

You can use most of the examples without any additional configuration.
Just open the application folder as a website in Visual Studio.

The following setup instructions will help you configure the projects
that use databases and web services.



--------------------------------
Connecting to SQL Server
(Chapter 13, 14, 15, 24, and 26)
--------------------------------

These examples require SQL Server 7, SQL Server 2000, or SQL Server 2005.

You may need to modify the connection strings for your database server.
The connection strings are in the web.config file of each application.

By default, the connection strings assume you are using SQL Server 2005
Express Edition. Here's an example:

  <connectionStrings>   
    <add name="Pubs" connectionString=
"Data Source=localhost\SQLEXPRESS;Initial Catalog=Pubs;Integrated Security=SSPI"/>
  </connectionStrings>

If you're using a full version of SQL Server, you'll need a connection
string like this instead:

  <connectionStrings>   
    <add name="Pubs" connectionString=
"Data Source=localhost;Initial Catalog=Pubs;Integrated Security=SSPI"/>
  </connectionStrings>

If you're using a SQL Server instance on another computer, you'll need
to use the server name instead of localhost. Read Chapter 13 for more
information.



--------------------------------
Using a SQL Server Database
(Chapter 13, 14, 15, 24, and 26)
--------------------------------

These examples use several sample databases, which may or not be installed
in your database server. (For example, SQL Server 2005 does not include
the Northwind and Pubs databases by default, unlike earlier versions.
And no matter what version of SQL Server you're using, you won't have the
AdBoard database that's used in Chapter 24.)

You can install the databases you need (complete with sample data) using
the included SQL scripts.

* Use InstNwnd.sql to install the Northwind database.
* Use InstPubs.sql to install the Pubs database.
* Use InstAdboard.sql to install the AdBoard database.

If you're using a full version of SQL Server, you can open these scripts
and run them using a graphical tool like Query Analyzer.

If you're using SQL Server 2005 Express Edition, you'll need to use the
sqlcmd.exe command-line tool.

If you're using SQL Server 2005 Express Edition, you need a command like
this to install Northwind:

  sqlcmd -S localhost\SQLEXPRESS -i InstNwnd.sql

If you're using a full version of SQL Server 2005 on the local computer,
you need a command like this:

  sqlcmd -i InstNwnd.sql



-----------------------------
Using Membership and Profiles
(Chapter 19 and 20)
-----------------------------

These examples in these chapters use the automatic file-creation option in
SQL Server 2005. As long as you have SQL Server 2005 installed, the required
database will be generated automatically in the App_Data subdirectory.

If you're using SQL Server 2005 Express Edition, no changes are needed.
If you're using the full edition of SQL Server 2005, you will need to change
the connection string, by adding this code to the configuration file
(as described on page 744):

    <connectionStrings>
        <clear />
        <add name="LocalSqlServer" providerName="System.Data.SqlClient" 
connectionString=
"Data Source=localhost;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|aspnetdb.mdf;User Instance=true" />
    </connectionStrings>

If you are using SQL Server 2000 or SQL Server 7, you'll need to change
the connection string and manually create the databases using the
aspnet_regsql.exe command-line tool, as described on page 748.



-------------------
Using Web Services
(Chapter 22 and 23)
-------------------

As described in Chapter 22, you must create a virtual directory for every
web service. Otherwise, the client won't be able to locate it.

In order for the web services in Chapter 22 to work, you must follow these
steps:

1. Select Settings --> Control Panel --> Administrative Tools -->
 Internet Services Manager from the Start menu to launch IIS Manager. 
2. Right-click the Default Website item in the IIS tree, and choose
 New --> Virtual Directory. 
3. Specify the alias WebServices and click Next. 
4. Specify the Chapter22\WebServices directory (wherever it is on your
 computer) and click Next.
5. Click Next to accept the default permissions, and then Finish to
 create the virtual directory. 


In order for the web services in Chapter 23 to work, you must follow these
steps:

1. Select Settings --> Control Panel --> Administrative Tools -->
 Internet Services Manager from the Start menu to launch IIS Manager. 
2. Right-click the Default Website item in the IIS tree, and choose
 New --> Virtual Directory. 
3. Specify the alias WebServices2 and click Next. 
4. Specify the Chapter23\WebServices2 directory (wherever it is on your
 computer) and click Next.
5. Click Next to accept the default permissions, and then Finish to
 create the virtual directory. 



----------------------------
Using Solutions
(Chapter 23, 23, 24, and 25)
----------------------------

Solution files allow you to open more than one project at once. Look for the
following solution files:

Chapter22\WebServicesSolution.sln  --> opens web service and client
Chapter23\WebServicesSolution.sln  --> opens web service and client
Chapter24\ComponentTest.sln        --> opens component and client
Chapter25\ServerControls.sln       --> opens control library and client

