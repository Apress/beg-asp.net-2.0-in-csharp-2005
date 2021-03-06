IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'AdBoard')
	DROP DATABASE [AdBoard]
GO

CREATE DATABASE [AdBoard] 
GO


use [AdBoard]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Items_Categories]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Items] DROP CONSTRAINT FK_Items_Categories
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Items]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Items]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Categories]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Categories]
GO

CREATE TABLE [dbo].[Categories] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

INSERT Categories (Name) VALUES ('Books and Music')
INSERT Categories (Name) VALUES ('Clothing')
INSERT Categories (Name) VALUES ('Electronics')
INSERT Categories (Name) VALUES ('Food and Beverage')
INSERT Categories (Name) VALUES ('Help Wanted')
INSERT Categories (Name) VALUES ('Real Estate')
GO

CREATE TABLE [dbo].[Items] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Title] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Price] [smallmoney] NOT NULL ,
	[Description] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Category_ID] [int] NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Categories] WITH NOCHECK ADD 
	CONSTRAINT [PK_Categories] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Items] WITH NOCHECK ADD 
	CONSTRAINT [PK_Items] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Items] ADD 
	CONSTRAINT [FK_Items_Categories] FOREIGN KEY 
	(
		[Category_ID]
	) REFERENCES [dbo].[Categories] (
		[ID]
	)
GO

