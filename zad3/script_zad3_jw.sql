USE [JakubWoszczynaZad3]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[City] [nchar](20) NOT NULL,
	[Street] [nchar](20) NOT NULL,
	[HouseNumber] [smallint] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[IdLaptop] [int] NULL,
	[IdMp3] [int] NULL,
	[IdSmartphone] [int] NULL,
	[IdTablet] [int] NULL,
	[IdTv] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAddress] [int] NOT NULL,
	[IdContact] [int] NOT NULL,
	[Name] [nchar](20) NOT NULL,
	[Surname] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contact]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[Mail] [char](20) NOT NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Laptop]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laptop](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CameraMpix] [smallint] NOT NULL,
	[ProcessorModel] [nchar](30) NOT NULL,
	[Ram] [smallint] NOT NULL,
	[DiskSizeGb] [int] NOT NULL,
 CONSTRAINT [PK_Laptop] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mp3]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mp3](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DiskSizeGb] [int] NOT NULL,
	[NumberOfFormats] [smallint] NOT NULL,
	[HeadphoneJack] [bit] NOT NULL,
	[TimeOfPlayingMusic] [int] NOT NULL,
	[FmRadio] [bit] NOT NULL,
 CONSTRAINT [PK_Mp3] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdClient] [int] NOT NULL,
	[IdProduct] [int] NOT NULL,
	[DateOfOrder] [date] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCategory] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Description] [nchar](100) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Smartphone]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Smartphone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OperatingSystem] [nchar](20) NOT NULL,
	[Ram] [int] NOT NULL,
	[CameraMpix] [smallint] NOT NULL,
	[DualSim] [bit] NOT NULL,
	[TechnologyNfc] [bit] NOT NULL,
	[HeadphoneJack] [bit] NOT NULL,
 CONSTRAINT [PK_Smartphone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tablet]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tablet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SimCard] [bit] NOT NULL,
	[Ram] [smallint] NOT NULL,
	[DiskSizeGb] [int] NOT NULL,
	[OperatingSystem] [char](20) NOT NULL,
	[CameraMpix] [smallint] NOT NULL,
 CONSTRAINT [PK_Tablet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tv]    Script Date: 2017-11-29 21:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tv](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SmartTv] [bit] NOT NULL,
	[HdmiNumber] [smallint] NOT NULL,
	[Technology3d] [bit] NOT NULL,
	[EnergyClass] [char](5) NOT NULL,
 CONSTRAINT [PK_Tv] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (7, N'sdgsg               ', N'fsfsd               ', 33)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (8, N'trte                ', N'etert               ', 4)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (9, N'fdsfs               ', N'fsfsd               ', 3)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (10, N'sffsd               ', N'fsf                 ', 4)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (11, N'reewr               ', N'rwrw                ', 5)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (12, N'gdg                 ', N'sffds               ', 2)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (13, N'4243                ', N'2443                ', 2)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (14, N'asd                 ', N'asd                 ', 232)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (15, N'gdg                 ', N'dfgfd               ', 3)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (16, N'44fg                ', N'dfdg                ', 54)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (17, N'ety35               ', N'rete                ', 4)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (18, N'sfdsf               ', N'fsdf                ', 3)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (19, N'sfdsf               ', N'fsdf                ', 3)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (20, N'sfdsf               ', N'fsdf                ', 3)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (21, N'dgf                 ', N'gfdg                ', 44)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (22, N'teye                ', N'tree                ', 4)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (23, N'rere                ', N're                  ', 3)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (24, N'ostrów              ', N'prosta              ', 3)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (25, N'ostrów              ', N'prosta              ', 3)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (26, N'poznan              ', N'szeska              ', 55)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (27, N'poznan              ', N'szewska             ', 55)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (28, N'wroclav             ', N'ffd                 ', 5)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (29, N'wroclav             ', N'ffd                 ', 5)
INSERT [dbo].[Address] ([Id], [City], [Street], [HouseNumber]) VALUES (30, N'wroclav             ', N'ffd                 ', 5)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [IdLaptop], [IdMp3], [IdSmartphone], [IdTablet], [IdTv]) VALUES (1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Category] ([Id], [IdLaptop], [IdMp3], [IdSmartphone], [IdTablet], [IdTv]) VALUES (2, NULL, 2, NULL, NULL, NULL)
INSERT [dbo].[Category] ([Id], [IdLaptop], [IdMp3], [IdSmartphone], [IdTablet], [IdTv]) VALUES (3, NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[Category] ([Id], [IdLaptop], [IdMp3], [IdSmartphone], [IdTablet], [IdTv]) VALUES (4, NULL, NULL, NULL, 1, NULL)
INSERT [dbo].[Category] ([Id], [IdLaptop], [IdMp3], [IdSmartphone], [IdTablet], [IdTv]) VALUES (5, NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (13, 17, 9, N'dfgfdg              ', N'fgdfg               ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (14, 18, 9, N'sdfsdf              ', N'fsdsdf              ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (15, 19, 11, N'sdfsdf              ', N'fsdsdf              ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (16, 20, 12, N'sdfsdf              ', N'fsdsdf              ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (17, 21, 9, N'fdgfd               ', N'dfgdf               ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (18, 23, 22, N'sdfsd               ', N'sdfs                ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (19, 24, 23, N'jakub               ', N'woszczyna           ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (20, 25, 24, N'jakub               ', N'woszczyna           ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (21, 26, 25, N'andrzej             ', N'piaseczny           ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (22, 27, 26, N'andrzej             ', N'piaseczny           ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (23, 28, 27, N'jka                 ', N'wos                 ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (24, 29, 28, N'jka                 ', N'wos                 ')
INSERT [dbo].[Client] ([Id], [IdAddress], [IdContact], [Name], [Surname]) VALUES (25, 30, 29, N'jka                 ', N'wos                 ')
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[Contact] ON 

INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (7, 3343, N'sdf@                ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (8, 3242, N'sdf                 ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (9, 2442, N'fsdf                ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (10, 434, N'tsts                ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (11, 33, N'eae                 ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (12, 44, N'ada                 ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (13, 232, N'asd                 ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (14, 434, N'sdfgsd              ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (15, 45534, N'dfsf                ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (16, 535, N'dg                  ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (17, 424, N'fsf                 ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (18, 424, N'fsf                 ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (19, 424, N'fsf                 ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (20, 53534543, N'gddg                ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (21, 534534, N'dgg                 ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (22, 434, N'fsddsf              ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (23, 43434321, N'kub@ww              ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (24, 43434321, N'kub@ww              ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (25, 325252525, N'kk@gg.bo            ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (26, 252562626, N'kutk@fgh.com        ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (27, 34535344, N',sd@ss              ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (28, 34535344, N',sd@ss              ')
INSERT [dbo].[Contact] ([Id], [PhoneNumber], [Mail]) VALUES (29, 34535344, N',sd@ss              ')
SET IDENTITY_INSERT [dbo].[Contact] OFF
SET IDENTITY_INSERT [dbo].[Laptop] ON 

INSERT [dbo].[Laptop] ([Id], [CameraMpix], [ProcessorModel], [Ram], [DiskSizeGb]) VALUES (1, 2, N'Intel Core i3 8100            ', 8, 256)
INSERT [dbo].[Laptop] ([Id], [CameraMpix], [ProcessorModel], [Ram], [DiskSizeGb]) VALUES (2, 3, N'Intel Core i3 6100            ', 4, 500)
INSERT [dbo].[Laptop] ([Id], [CameraMpix], [ProcessorModel], [Ram], [DiskSizeGb]) VALUES (3, 2, N'Intel Core i5 8400            ', 4, 128)
INSERT [dbo].[Laptop] ([Id], [CameraMpix], [ProcessorModel], [Ram], [DiskSizeGb]) VALUES (6, 4, N'Intel Core i5 7600T           ', 3, 1000)
INSERT [dbo].[Laptop] ([Id], [CameraMpix], [ProcessorModel], [Ram], [DiskSizeGb]) VALUES (7, 6, N'Intel Core i9-7940X           ', 16, 500)
SET IDENTITY_INSERT [dbo].[Laptop] OFF
SET IDENTITY_INSERT [dbo].[Mp3] ON 

INSERT [dbo].[Mp3] ([Id], [DiskSizeGb], [NumberOfFormats], [HeadphoneJack], [TimeOfPlayingMusic], [FmRadio]) VALUES (1, 2, 2, 1, 80, 1)
INSERT [dbo].[Mp3] ([Id], [DiskSizeGb], [NumberOfFormats], [HeadphoneJack], [TimeOfPlayingMusic], [FmRadio]) VALUES (2, 32, 4, 0, 120, 1)
INSERT [dbo].[Mp3] ([Id], [DiskSizeGb], [NumberOfFormats], [HeadphoneJack], [TimeOfPlayingMusic], [FmRadio]) VALUES (3, 16, 3, 1, 60, 0)
SET IDENTITY_INSERT [dbo].[Mp3] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [IdClient], [IdProduct], [DateOfOrder]) VALUES (11, 13, 3, CAST(N'2017-09-17' AS Date))
INSERT [dbo].[Orders] ([Id], [IdClient], [IdProduct], [DateOfOrder]) VALUES (12, 14, 4, CAST(N'2017-08-23' AS Date))
INSERT [dbo].[Orders] ([Id], [IdClient], [IdProduct], [DateOfOrder]) VALUES (13, 15, 5, CAST(N'2017-08-20' AS Date))
INSERT [dbo].[Orders] ([Id], [IdClient], [IdProduct], [DateOfOrder]) VALUES (14, 16, 4, CAST(N'2017-08-20' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [IdCategory], [Price], [Description]) VALUES (1, 1, 250.5, N'blabla                                                                                              ')
INSERT [dbo].[Product] ([Id], [IdCategory], [Price], [Description]) VALUES (3, 3, 45.5, N'blablasmartphone                                                                                    ')
INSERT [dbo].[Product] ([Id], [IdCategory], [Price], [Description]) VALUES (4, 2, 30.1, N'mp3blablaa                                                                                          ')
INSERT [dbo].[Product] ([Id], [IdCategory], [Price], [Description]) VALUES (5, 5, 20.4, N'Tvblabalbla                                                                                         ')
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Smartphone] ON 

INSERT [dbo].[Smartphone] ([Id], [OperatingSystem], [Ram], [CameraMpix], [DualSim], [TechnologyNfc], [HeadphoneJack]) VALUES (1, N'android             ', 2, 16, 1, 1, 1)
INSERT [dbo].[Smartphone] ([Id], [OperatingSystem], [Ram], [CameraMpix], [DualSim], [TechnologyNfc], [HeadphoneJack]) VALUES (2, N'iOS                 ', 3, 18, 0, 0, 0)
INSERT [dbo].[Smartphone] ([Id], [OperatingSystem], [Ram], [CameraMpix], [DualSim], [TechnologyNfc], [HeadphoneJack]) VALUES (3, N'windowsPhone        ', 2, 12, 1, 0, 1)
SET IDENTITY_INSERT [dbo].[Smartphone] OFF
SET IDENTITY_INSERT [dbo].[Tablet] ON 

INSERT [dbo].[Tablet] ([Id], [SimCard], [Ram], [DiskSizeGb], [OperatingSystem], [CameraMpix]) VALUES (1, 1, 3, 64, N'android             ', 8)
INSERT [dbo].[Tablet] ([Id], [SimCard], [Ram], [DiskSizeGb], [OperatingSystem], [CameraMpix]) VALUES (2, 0, 3, 32, N'android             ', 6)
INSERT [dbo].[Tablet] ([Id], [SimCard], [Ram], [DiskSizeGb], [OperatingSystem], [CameraMpix]) VALUES (3, 1, 4, 128, N'android             ', 12)
INSERT [dbo].[Tablet] ([Id], [SimCard], [Ram], [DiskSizeGb], [OperatingSystem], [CameraMpix]) VALUES (4, 1, 4, 64, N'iOS                 ', 16)
SET IDENTITY_INSERT [dbo].[Tablet] OFF
SET IDENTITY_INSERT [dbo].[Tv] ON 

INSERT [dbo].[Tv] ([Id], [SmartTv], [HdmiNumber], [Technology3d], [EnergyClass]) VALUES (1, 1, 2, 1, N'a    ')
INSERT [dbo].[Tv] ([Id], [SmartTv], [HdmiNumber], [Technology3d], [EnergyClass]) VALUES (2, 1, 3, 1, N'B    ')
INSERT [dbo].[Tv] ([Id], [SmartTv], [HdmiNumber], [Technology3d], [EnergyClass]) VALUES (3, 1, 4, 1, N'A    ')
INSERT [dbo].[Tv] ([Id], [SmartTv], [HdmiNumber], [Technology3d], [EnergyClass]) VALUES (4, 0, 2, 0, N'A    ')
SET IDENTITY_INSERT [dbo].[Tv] OFF
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Laptop] FOREIGN KEY([IdLaptop])
REFERENCES [dbo].[Laptop] ([Id])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Laptop]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Mp3] FOREIGN KEY([IdMp3])
REFERENCES [dbo].[Mp3] ([Id])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Mp3]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Smartphone] FOREIGN KEY([IdSmartphone])
REFERENCES [dbo].[Smartphone] ([Id])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Smartphone]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Tablet] FOREIGN KEY([IdTablet])
REFERENCES [dbo].[Tablet] ([Id])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Tablet]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Tv] FOREIGN KEY([IdTv])
REFERENCES [dbo].[Tv] ([Id])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Tv]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Address] FOREIGN KEY([IdAddress])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Address]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Contact] FOREIGN KEY([IdContact])
REFERENCES [dbo].[Contact] ([Id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Contact]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Client] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Client]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Product] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
