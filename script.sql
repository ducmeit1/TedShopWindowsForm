CREATE DATABASE [TedShop]
GO
USE [TedShop]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 10/9/2017 11:46:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/9/2017 11:46:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone] [nchar](20) NULL,
	[Total] [real] NULL,
	[StaffID] [int] NULL,
	[DeliverDate] [date] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/9/2017 11:46:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductTypeID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Guide] [nvarchar](max) NULL,
	[Country] [nvarchar](50) NULL,
	[Price] [real] NOT NULL,
	[SellPrice] [real] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 10/9/2017 11:46:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[ProductTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ProductTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[ProductTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 10/9/2017 11:46:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [nchar](20) NULL,
	[IsManager] [bit] NOT NULL,
	[Account] [nchar](20) NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (1, 1, 1, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (2, 1, 2, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (3, 2, 2, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (4, 3, 3, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (5, 4, 2, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (6, 5, 2, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (7, 6, 2, 5)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (8, 7, 2, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (9, 8, 2, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10, 9, 2, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (11, 10, 2, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (12, 11, 2, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (13, 11, 3, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (14, 12, 2, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (15, 12, 3, 2)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (1, CAST(N'2017-02-24' AS Date), N'Hola City', N'Hola City', N'01542121212         ', 1600000, 3, CAST(N'2017-02-24' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (2, CAST(N'2017-02-24' AS Date), N'FPT Hòa Lạc', N'FPT Hòa Lạc', N'01659421121         ', 1050000, 3, CAST(N'2017-02-24' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (3, CAST(N'2017-02-24' AS Date), N'Hà Nôi', N'Hà Nôi', N'016415151211        ', 550000, 3, CAST(N'2017-02-24' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (4, CAST(N'2017-02-24' AS Date), N'Fu Hòa Lạc', N'Fu Hòa Lạc', N'123126456123        ', 350000, 3, CAST(N'2017-02-24' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (5, CAST(N'2017-02-24' AS Date), N'1321', N'1321', N'3214215215215       ', 350000, 3, CAST(N'2017-02-24' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (6, CAST(N'2017-02-24' AS Date), N'4214215', N'4214215', N'4214152152121       ', 1750000, 3, CAST(N'2017-02-24' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (7, CAST(N'2017-02-25' AS Date), N'teiwtehia', N'teiwtehia', N'123456123123        ', 350000, 3, CAST(N'2017-02-24' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (8, CAST(N'2017-02-25' AS Date), N'Hà Nội', N'Hà Nội', N'01666210190         ', 350000, 7, CAST(N'2017-02-25' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (9, CAST(N'2017-02-27' AS Date), N'FU HL', N'FU HL', N'12315641321         ', 350000, 7, CAST(N'2017-02-28' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (10, CAST(N'2017-03-13' AS Date), N'gdsate', N'tewayewa', N'32132141231         ', 350000, 7, CAST(N'2017-03-13' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (11, CAST(N'2017-09-20' AS Date), N'Ho Trong Duc', N'Viet Nam', N'841666210190        ', 1600000, 3, CAST(N'2017-09-20' AS Date))
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [Name], [Address], [Phone], [Total], [StaffID], [DeliverDate]) VALUES (12, CAST(N'2017-09-20' AS Date), N'bfdxhf', N'hfhzhdf', N'543253141241        ', 1800000, 7, CAST(N'2017-09-20' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductTypeID], [Name], [Description], [Guide], [Country], [Price], [SellPrice], [Quantity]) VALUES (1, 1, N'Sụn cá mập', NULL, NULL, N'Úc', 500000, 550000, 0)
INSERT [dbo].[Products] ([ProductID], [ProductTypeID], [Name], [Description], [Guide], [Country], [Price], [SellPrice], [Quantity]) VALUES (2, 1, N'Glucozamin', NULL, NULL, N'Úc', 300000, 350000, 78)
INSERT [dbo].[Products] ([ProductID], [ProductTypeID], [Name], [Description], [Guide], [Country], [Price], [SellPrice], [Quantity]) VALUES (3, 2, N'S26', NULL, NULL, N'Úc', 500000, 550000, 96)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[ProductTypes] ON 

INSERT [dbo].[ProductTypes] ([ProductTypeID], [ProductTypeName]) VALUES (1, N'Thực phẩm chức năng')
INSERT [dbo].[ProductTypes] ([ProductTypeID], [ProductTypeName]) VALUES (2, N'Sữa')
SET IDENTITY_INSERT [dbo].[ProductTypes] OFF
SET IDENTITY_INSERT [dbo].[Staffs] ON 

INSERT [dbo].[Staffs] ([StaffID], [Name], [Address], [Phone], [IsManager], [Account]) VALUES (3, N'Nguyễn Văn A', N'Trần Văn', N'123456789           ', 1, N'1234536             ')
INSERT [dbo].[Staffs] ([StaffID], [Name], [Address], [Phone], [IsManager], [Account]) VALUES (6, N'vai ni', N'thich', N'123456              ', 0, N'erawr               ')
INSERT [dbo].[Staffs] ([StaffID], [Name], [Address], [Phone], [IsManager], [Account]) VALUES (7, N'Hồ Trọng Đức', NULL, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[Staffs] OFF
ALTER TABLE [dbo].[OrderDetails]  WITH NOCHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH NOCHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staffs] ([StaffID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Staffs]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductTypes] FOREIGN KEY([ProductTypeID])
REFERENCES [dbo].[ProductTypes] ([ProductTypeID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductTypes]
GO
