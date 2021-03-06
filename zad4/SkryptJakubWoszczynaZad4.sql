USE [JakubWoszczynaZad4]
GO
/****** Object:  Table [dbo].[ClientAddresses]    Script Date: 2017-12-07 21:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientAddresses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](50) NULL,
	[Street] [nvarchar](50) NULL,
	[BuildingNumber] [int] NULL,
 CONSTRAINT [PK_ClientAddresses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2017-12-07 21:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ContactID] [int] NULL,
	[AddressID] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 2017-12-07 21:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PhoneNumber] [int] NULL,
	[Mail] [nchar](30) NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2017-12-07 21:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PlaceToGetProductID] [int] NULL,
	[ClientID] [int] NULL,
	[DateToGetProduct] [date] NULL,
	[OrderNumber] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PlacesToGetProduct]    Script Date: 2017-12-07 21:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlacesToGetProduct](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](50) NULL,
	[Street] [nvarchar](50) NULL,
	[BuildingNumber] [int] NULL,
 CONSTRAINT [PK_PlacesToGetProduct] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ClientAddresses] ON 

INSERT [dbo].[ClientAddresses] ([ID], [City], [Street], [BuildingNumber]) VALUES (5, N'ret', N'ytry', 5646)
INSERT [dbo].[ClientAddresses] ([ID], [City], [Street], [BuildingNumber]) VALUES (18, N'sdfds', N'fsfds', 34)
INSERT [dbo].[ClientAddresses] ([ID], [City], [Street], [BuildingNumber]) VALUES (19, N'dfgd', N'df', 5435)
INSERT [dbo].[ClientAddresses] ([ID], [City], [Street], [BuildingNumber]) VALUES (20, N'hgf', N'adz', 67)
INSERT [dbo].[ClientAddresses] ([ID], [City], [Street], [BuildingNumber]) VALUES (21, N'adsa', N'hfh', 464)
INSERT [dbo].[ClientAddresses] ([ID], [City], [Street], [BuildingNumber]) VALUES (22, N'Kalisz', N'ostrowska', 23)
INSERT [dbo].[ClientAddresses] ([ID], [City], [Street], [BuildingNumber]) VALUES (23, N'TurekŻ', N'grabieniec', 64)
INSERT [dbo].[ClientAddresses] ([ID], [City], [Street], [BuildingNumber]) VALUES (24, N'TurekŻ', N'grabieniec', 64)
SET IDENTITY_INSERT [dbo].[ClientAddresses] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ID], [ContactID], [AddressID], [Name], [Surname]) VALUES (5, 6, 5, NULL, NULL)
INSERT [dbo].[Clients] ([ID], [ContactID], [AddressID], [Name], [Surname]) VALUES (18, 21, 18, N'adsaf', N'fsfd')
INSERT [dbo].[Clients] ([ID], [ContactID], [AddressID], [Name], [Surname]) VALUES (19, 22, 19, N'śśśćęą', N'dfg')
INSERT [dbo].[Clients] ([ID], [ContactID], [AddressID], [Name], [Surname]) VALUES (20, 23, 20, N'gdhg', N'fhgf')
INSERT [dbo].[Clients] ([ID], [ContactID], [AddressID], [Name], [Surname]) VALUES (21, 24, 21, N'tomasz', N'adf')
INSERT [dbo].[Clients] ([ID], [ContactID], [AddressID], [Name], [Surname]) VALUES (22, 25, 22, N'Janek', N'Nowak')
INSERT [dbo].[Clients] ([ID], [ContactID], [AddressID], [Name], [Surname]) VALUES (23, 26, 23, N'Olgaś', N'Drzewieckać')
INSERT [dbo].[Clients] ([ID], [ContactID], [AddressID], [Name], [Surname]) VALUES (24, 27, 24, N'Olgaś', N'Drzewieckać')
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (1, 234567234, N'andrzej@konon.net             ')
INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (6, 332, N'hffgh                         ')
INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (12, 4334, N'gdfd                          ')
INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (13, 4334, N'gdfd                          ')
INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (21, 314134, N'fdda                          ')
INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (22, 34534, N'43                            ')
INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (23, 87675, N'sdvvs                         ')
INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (24, 57544, N'dgh@net                       ')
INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (25, 425252, N'kasd@gmail.com                ')
INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (26, 665978778, N'dolga@vp.pl                   ')
INSERT [dbo].[Contacts] ([ID], [PhoneNumber], [Mail]) VALUES (27, 665978778, N'dolga@vp.pl                   ')
SET IDENTITY_INSERT [dbo].[Contacts] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [PlaceToGetProductID], [ClientID], [DateToGetProduct], [OrderNumber]) VALUES (18, 18, 18, CAST(N'2017-12-02' AS Date), 21)
INSERT [dbo].[Orders] ([ID], [PlaceToGetProductID], [ClientID], [DateToGetProduct], [OrderNumber]) VALUES (19, 19, 19, CAST(N'2017-12-13' AS Date), 23)
INSERT [dbo].[Orders] ([ID], [PlaceToGetProductID], [ClientID], [DateToGetProduct], [OrderNumber]) VALUES (20, 20, 20, CAST(N'2018-01-10' AS Date), 73)
INSERT [dbo].[Orders] ([ID], [PlaceToGetProductID], [ClientID], [DateToGetProduct], [OrderNumber]) VALUES (21, 21, 21, CAST(N'2018-01-10' AS Date), 87)
INSERT [dbo].[Orders] ([ID], [PlaceToGetProductID], [ClientID], [DateToGetProduct], [OrderNumber]) VALUES (22, 22, 22, CAST(N'2017-12-14' AS Date), 55)
INSERT [dbo].[Orders] ([ID], [PlaceToGetProductID], [ClientID], [DateToGetProduct], [OrderNumber]) VALUES (23, 23, 24, CAST(N'2017-12-15' AS Date), 10)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[PlacesToGetProduct] ON 

INSERT [dbo].[PlacesToGetProduct] ([ID], [City], [Street], [BuildingNumber]) VALUES (5, N'fgh', N'fghf', 7)
INSERT [dbo].[PlacesToGetProduct] ([ID], [City], [Street], [BuildingNumber]) VALUES (18, N'ffss', N'fds', 43)
INSERT [dbo].[PlacesToGetProduct] ([ID], [City], [Street], [BuildingNumber]) VALUES (19, N'fs', N'gg', 43)
INSERT [dbo].[PlacesToGetProduct] ([ID], [City], [Street], [BuildingNumber]) VALUES (20, N'hghh', N'kjh', 1)
INSERT [dbo].[PlacesToGetProduct] ([ID], [City], [Street], [BuildingNumber]) VALUES (21, N'as', N'dad', 4)
INSERT [dbo].[PlacesToGetProduct] ([ID], [City], [Street], [BuildingNumber]) VALUES (22, N'Torun', N'armi', 2)
INSERT [dbo].[PlacesToGetProduct] ([ID], [City], [Street], [BuildingNumber]) VALUES (23, N'Wrocław', N'SŁowiAŃska', 37)
SET IDENTITY_INSERT [dbo].[PlacesToGetProduct] OFF
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_ClientAddresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[ClientAddresses] ([ID])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_ClientAddresses]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_Contacts] FOREIGN KEY([ContactID])
REFERENCES [dbo].[Contacts] ([ID])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_Contacts]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Clients]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_PlacesToGetProduct] FOREIGN KEY([PlaceToGetProductID])
REFERENCES [dbo].[PlacesToGetProduct] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_PlacesToGetProduct]
GO
