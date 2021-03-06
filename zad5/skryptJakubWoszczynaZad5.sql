USE [JakubWoszczynaZad5]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2017-12-12 16:36:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NumberOfOrder] [int] NULL,
	[ClientName] [nvarchar](50) NULL,
	[ClientSurname] [nvarchar](50) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 2017-12-12 16:36:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](50) NULL,
	[Cost] [int] NULL,
	[Weight] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (1, 100, N'Jakub', N'Woszczyna')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (2, 101, N'Andrzej', N'Gagatek')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (3, 102, N'Michał', N'Nowak')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (4, 103, N'Mateusz', N'Kowalski')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (5, 104, N'Andrzej', N'Kowal')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (6, 104, N'Szumon', N'Czajson')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (7, 104, N'Rachwal', N'Paweł')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (9, 104, N'Kuba', N'Sienkiewicz')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (10, 105, N'Adam', N'Mickiewicz')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (11, 106, N'Henryk', N'Sienkiewicz')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (12, 200, N'Bolesław', N'Prus')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (13, 151, N'Jaro', N'Sław')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (14, 151, N'Joseph', N'Conrad')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (15, 161, N'Andrzej', N'Kwach')
INSERT [dbo].[Orders] ([ID], [NumberOfOrder], [ClientName], [ClientSurname]) VALUES (16, 222, N'Roman', N'Romana')
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ID], [Category], [Cost], [Weight]) VALUES (1, N'TV', 1500, 3000)
INSERT [dbo].[Products] ([ID], [Category], [Cost], [Weight]) VALUES (2, N'Radio', 200, 700)
INSERT [dbo].[Products] ([ID], [Category], [Cost], [Weight]) VALUES (3, N'Mp3', 400, 200)
INSERT [dbo].[Products] ([ID], [Category], [Cost], [Weight]) VALUES (4, N'Laptop', 3500, 2100)
INSERT [dbo].[Products] ([ID], [Category], [Cost], [Weight]) VALUES (5, N'Mp3', 300, 300)
INSERT [dbo].[Products] ([ID], [Category], [Cost], [Weight]) VALUES (6, N'Tablet', 700, 400)
SET IDENTITY_INSERT [dbo].[Products] OFF
