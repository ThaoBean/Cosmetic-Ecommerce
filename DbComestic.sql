USE [DbComestic]
GO
/****** Object:  Table [dbo].[tbBrands]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBrands](
	[Id_Brand] [bigint] IDENTITY(1,1) NOT NULL,
	[Name_Brand] [nvarchar](250) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[Id_Brand] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCarts]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCarts](
	[Id_Cart] [bigint] IDENTITY(1,1) NOT NULL,
	[Id_Customer] [bigint] NULL,
	[Image_Product] [nvarchar](max) NULL,
	[Name_Product] [nvarchar](max) NULL,
	[Id_Product] [bigint] NULL,
	[UnitPrice] [decimal](18, 0) NULL,
	[Quantity] [int] NULL,
	[UnitsTotal] [decimal](18, 0) NULL,
 CONSTRAINT [PK_tbCarts] PRIMARY KEY CLUSTERED 
(
	[Id_Cart] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCategories]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCategories](
	[Id_Category] [bigint] IDENTITY(1,1) NOT NULL,
	[Name_Category] [nvarchar](250) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id_Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbContacts]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbContacts](
	[Id_Contact] [bigint] NOT NULL,
	[Name_Contact] [nvarchar](250) NULL,
	[Email_Contact] [nvarchar](250) NULL,
	[Subject_Contact] [nvarchar](250) NULL,
	[Content_Contatc] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbContacts] PRIMARY KEY CLUSTERED 
(
	[Id_Contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCustomers]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCustomers](
	[Id_Customer] [bigint] IDENTITY(1,1) NOT NULL,
	[Name_Customer] [nvarchar](250) NULL,
	[Email_Customer] [nvarchar](250) NULL,
	[Addr_Customer] [nvarchar](max) NULL,
	[Phone_Customer] [nvarchar](50) NULL,
	[Password_Customer] [nvarchar](max) NULL,
	[Date_Created] [datetime] NULL,
 CONSTRAINT [PK_tbCustomers] PRIMARY KEY CLUSTERED 
(
	[Id_Customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbNations]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbNations](
	[Id_Nation] [bigint] IDENTITY(1,1) NOT NULL,
	[Name_Nation] [nvarchar](250) NULL,
 CONSTRAINT [PK_Nations] PRIMARY KEY CLUSTERED 
(
	[Id_Nation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbOrderDetails]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbOrderDetails](
	[Id_OrderDetail] [bigint] IDENTITY(1,1) NOT NULL,
	[Id_Order] [bigint] NULL,
	[Id_Product] [bigint] NULL,
	[Quantity] [int] NULL,
	[Price_OrderDetail] [decimal](18, 0) NULL,
 CONSTRAINT [PK_tbOrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id_OrderDetail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbOrders]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbOrders](
	[Id_Order] [bigint] IDENTITY(1,1) NOT NULL,
	[Id_Customer] [bigint] NULL,
	[Shipping_Addr] [nvarchar](max) NULL,
	[Phone_Reciever] [nvarchar](50) NULL,
	[Name_Reciever] [nvarchar](50) NULL,
	[Date] [datetime] NULL,
	[Price_Total] [decimal](18, 0) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_tbOrders] PRIMARY KEY CLUSTERED 
(
	[Id_Order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProducts]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProducts](
	[Id_Product] [bigint] IDENTITY(1,1) NOT NULL,
	[Id_Brand] [bigint] NULL,
	[Id_Nation] [bigint] NULL,
	[Id_Category] [bigint] NULL,
	[Name_Product] [nvarchar](250) NULL,
	[Description_Product] [nvarchar](max) NULL,
	[Detail_Product] [nvarchar](max) NULL,
	[Image_Product] [nvarchar](max) NULL,
	[Quality_Product] [int] NULL,
	[Price_Product] [decimal](18, 0) NULL,
	[Sale_Product] [decimal](18, 0) NULL,
	[Hot_Product] [bit] NULL,
	[Rate_Total_Product] [int] NULL,
 CONSTRAINT [PK_tbProducts] PRIMARY KEY CLUSTERED 
(
	[Id_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbReviewers]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbReviewers](
	[Id_Reviewer] [bigint] IDENTITY(1,1) NOT NULL,
	[Id_Product] [bigint] NULL,
	[Id_Customer] [bigint] NULL,
	[Content] [nvarchar](max) NULL,
	[Date_Created_Reviewer] [datetime] NULL,
	[Rate_Reviewer] [int] NULL,
 CONSTRAINT [PK_tbReviewers] PRIMARY KEY CLUSTERED 
(
	[Id_Reviewer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUsers]    Script Date: 05/05/2021 9:54:54 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsers](
	[Id_User] [bigint] IDENTITY(1,1) NOT NULL,
	[Name_User] [nvarchar](250) NULL,
	[Email_User] [nvarchar](250) NULL,
	[Password_User] [nvarchar](250) NULL,
	[Date_Created_User] [datetime] NULL,
	[Status_User] [bit] NULL,
 CONSTRAINT [PK_tbUsers] PRIMARY KEY CLUSTERED 
(
	[Id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbCustomers] ADD  CONSTRAINT [DF_tbCustomers_Date_Created]  DEFAULT (getdate()) FOR [Date_Created]
GO
ALTER TABLE [dbo].[tbOrders] ADD  CONSTRAINT [DF_tbOrders_Date]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[tbOrders] ADD  CONSTRAINT [DF_tbOrders_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[tbProducts] ADD  CONSTRAINT [DF_tbProducts_Hot]  DEFAULT ((1)) FOR [Hot_Product]
GO
ALTER TABLE [dbo].[tbProducts] ADD  CONSTRAINT [DF_tbProducts_Rate]  DEFAULT ((0)) FOR [Rate_Total_Product]
GO
ALTER TABLE [dbo].[tbReviewers] ADD  CONSTRAINT [DF_Reviewers_Date_Created_Reviewer]  DEFAULT (getdate()) FOR [Date_Created_Reviewer]
GO
ALTER TABLE [dbo].[tbUsers] ADD  CONSTRAINT [DF_tbUsers_Date_Created_User]  DEFAULT (getdate()) FOR [Date_Created_User]
GO
ALTER TABLE [dbo].[tbUsers] ADD  CONSTRAINT [DF_tbUsers_Status_User]  DEFAULT ((1)) FOR [Status_User]
GO
ALTER TABLE [dbo].[tbCarts]  WITH CHECK ADD  CONSTRAINT [FK_tbCarts_tbCustomers] FOREIGN KEY([Id_Customer])
REFERENCES [dbo].[tbCustomers] ([Id_Customer])
GO
ALTER TABLE [dbo].[tbCarts] CHECK CONSTRAINT [FK_tbCarts_tbCustomers]
GO
ALTER TABLE [dbo].[tbCarts]  WITH CHECK ADD  CONSTRAINT [FK_tbCarts_tbProducts] FOREIGN KEY([Id_Product])
REFERENCES [dbo].[tbProducts] ([Id_Product])
GO
ALTER TABLE [dbo].[tbCarts] CHECK CONSTRAINT [FK_tbCarts_tbProducts]
GO
ALTER TABLE [dbo].[tbOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_tbOrderDetails_tbOrders] FOREIGN KEY([Id_Order])
REFERENCES [dbo].[tbOrders] ([Id_Order])
GO
ALTER TABLE [dbo].[tbOrderDetails] CHECK CONSTRAINT [FK_tbOrderDetails_tbOrders]
GO
ALTER TABLE [dbo].[tbOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_tbOrderDetails_tbProducts] FOREIGN KEY([Id_Product])
REFERENCES [dbo].[tbProducts] ([Id_Product])
GO
ALTER TABLE [dbo].[tbOrderDetails] CHECK CONSTRAINT [FK_tbOrderDetails_tbProducts]
GO
ALTER TABLE [dbo].[tbOrders]  WITH CHECK ADD  CONSTRAINT [FK_tbOrders_tbCustomers] FOREIGN KEY([Id_Customer])
REFERENCES [dbo].[tbCustomers] ([Id_Customer])
GO
ALTER TABLE [dbo].[tbOrders] CHECK CONSTRAINT [FK_tbOrders_tbCustomers]
GO
ALTER TABLE [dbo].[tbProducts]  WITH CHECK ADD  CONSTRAINT [FK_tbProducts_tbBrands] FOREIGN KEY([Id_Brand])
REFERENCES [dbo].[tbBrands] ([Id_Brand])
GO
ALTER TABLE [dbo].[tbProducts] CHECK CONSTRAINT [FK_tbProducts_tbBrands]
GO
ALTER TABLE [dbo].[tbProducts]  WITH CHECK ADD  CONSTRAINT [FK_tbProducts_tbCategories] FOREIGN KEY([Id_Category])
REFERENCES [dbo].[tbCategories] ([Id_Category])
GO
ALTER TABLE [dbo].[tbProducts] CHECK CONSTRAINT [FK_tbProducts_tbCategories]
GO
ALTER TABLE [dbo].[tbProducts]  WITH CHECK ADD  CONSTRAINT [FK_tbProducts_tbNations] FOREIGN KEY([Id_Nation])
REFERENCES [dbo].[tbNations] ([Id_Nation])
GO
ALTER TABLE [dbo].[tbProducts] CHECK CONSTRAINT [FK_tbProducts_tbNations]
GO
ALTER TABLE [dbo].[tbReviewers]  WITH CHECK ADD  CONSTRAINT [FK_tbReviewers_tbCustomers] FOREIGN KEY([Id_Customer])
REFERENCES [dbo].[tbCustomers] ([Id_Customer])
GO
ALTER TABLE [dbo].[tbReviewers] CHECK CONSTRAINT [FK_tbReviewers_tbCustomers]
GO
ALTER TABLE [dbo].[tbReviewers]  WITH CHECK ADD  CONSTRAINT [FK_tbReviewers_tbProducts] FOREIGN KEY([Id_Product])
REFERENCES [dbo].[tbProducts] ([Id_Product])
GO
ALTER TABLE [dbo].[tbReviewers] CHECK CONSTRAINT [FK_tbReviewers_tbProducts]
GO
