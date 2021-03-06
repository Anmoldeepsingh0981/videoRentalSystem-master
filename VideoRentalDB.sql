USE [master]
GO
/****** Object:  Database [VideoRentalDB]    Script Date: 2/14/2020 11:40:18 AM ******/
CREATE DATABASE [VideoRentalDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'videoRental', FILENAME = N'C:\Users\Asus\Desktop\videoRentalSystem\bin\Debug\videoRental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'videoRental_log', FILENAME = N'C:\Users\Asus\Desktop\videoRentalSystem\bin\Debug\videoRental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VideoRentalDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRentalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRentalDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRentalDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRentalDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRentalDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRentalDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRentalDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VideoRentalDB] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [VideoRentalDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRentalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRentalDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRentalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRentalDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRentalDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRentalDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRentalDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoRentalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRentalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRentalDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRentalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRentalDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRentalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRentalDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRentalDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoRentalDB] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRentalDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRentalDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRentalDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRentalDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoRentalDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoRentalDB] SET QUERY_STORE = OFF
GO
USE [VideoRentalDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [VideoRentalDB]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 2/14/2020 11:40:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[CusID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[Phone] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[CusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movies]    Script Date: 2/14/2020 11:40:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movies](
	[mid] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Rating] [float] NULL,
	[Year] [datetime] NULL,
	[RentalCost] [float] NULL,
	[Genre] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[mid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rentals]    Script Date: 2/14/2020 11:40:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rentals](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MID] [int] NULL,
	[CusID] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([CusID], [FirstName], [LastName], [Address], [Phone]) VALUES (5, N'love', N'cheema', N'batala', N'0226928780')
INSERT [dbo].[customer] ([CusID], [FirstName], [LastName], [Address], [Phone]) VALUES (6, N'Akash', N'Athwal', N'Dera Baba Nanak', N'9779935181')
INSERT [dbo].[customer] ([CusID], [FirstName], [LastName], [Address], [Phone]) VALUES (7, N'anmol', N'athwal', N'Amritsar', N'0220163308')
INSERT [dbo].[customer] ([CusID], [FirstName], [LastName], [Address], [Phone]) VALUES (8, N'jashan', N'Athwal', N'Papatoetoe', N'9814309902')
INSERT [dbo].[customer] ([CusID], [FirstName], [LastName], [Address], [Phone]) VALUES (9, N'nishant', N'singh', N'Auckalnd', N'9855904350')
SET IDENTITY_INSERT [dbo].[customer] OFF
SET IDENTITY_INSERT [dbo].[movies] ON 

INSERT [dbo].[movies] ([mid], [Title], [Rating], [Year], [RentalCost], [Genre]) VALUES (1, N'THREE IDOTS', 4.5, CAST(N'2015-12-01T09:44:51.000' AS DateTime), 5, N'COMADY')
INSERT [dbo].[movies] ([mid], [Title], [Rating], [Year], [RentalCost], [Genre]) VALUES (2, N'DABAANG', 4, CAST(N'2013-10-05T00:00:00.000' AS DateTime), 6, N'ACTION')
INSERT [dbo].[movies] ([mid], [Title], [Rating], [Year], [RentalCost], [Genre]) VALUES (3, N'KRISH', 4, CAST(N'2013-06-10T00:00:00.000' AS DateTime), 4, N'ACTION')
INSERT [dbo].[movies] ([mid], [Title], [Rating], [Year], [RentalCost], [Genre]) VALUES (4, N'DON', 3.5, CAST(N'2007-02-06T00:00:00.000' AS DateTime), 7, N'ACTION')
INSERT [dbo].[movies] ([mid], [Title], [Rating], [Year], [RentalCost], [Genre]) VALUES (5, N'GOLMAAL', 4.5, CAST(N'2011-01-10T00:00:00.000' AS DateTime), 4, N'COMADY')
SET IDENTITY_INSERT [dbo].[movies] OFF
SET IDENTITY_INSERT [dbo].[rentals] ON 

INSERT [dbo].[rentals] ([RMID], [MID], [CusID], [DateRented], [DateReturned]) VALUES (1, 1, 6, CAST(N'2019-12-04T09:45:40.000' AS DateTime), CAST(N'2019-11-27T09:45:40.000' AS DateTime))
INSERT [dbo].[rentals] ([RMID], [MID], [CusID], [DateRented], [DateReturned]) VALUES (2, 2, 8, CAST(N'2020-02-11T00:00:00.000' AS DateTime), CAST(N'2020-01-20T00:00:00.000' AS DateTime))
INSERT [dbo].[rentals] ([RMID], [MID], [CusID], [DateRented], [DateReturned]) VALUES (3, 3, 6, CAST(N'2020-02-13T00:00:00.000' AS DateTime), CAST(N'2020-01-19T00:00:00.000' AS DateTime))
INSERT [dbo].[rentals] ([RMID], [MID], [CusID], [DateRented], [DateReturned]) VALUES (4, 4, 9, CAST(N'2020-02-07T00:00:00.000' AS DateTime), CAST(N'2020-01-15T00:00:00.000' AS DateTime))
INSERT [dbo].[rentals] ([RMID], [MID], [CusID], [DateRented], [DateReturned]) VALUES (5, 5, NULL, CAST(N'2020-02-05T00:00:00.000' AS DateTime), CAST(N'2020-01-11T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[rentals] OFF
ALTER TABLE [dbo].[rentals]  WITH CHECK ADD  CONSTRAINT [customer_ToRented] FOREIGN KEY([MID])
REFERENCES [dbo].[movies] ([mid])
GO
ALTER TABLE [dbo].[rentals] CHECK CONSTRAINT [customer_ToRented]
GO
ALTER TABLE [dbo].[rentals]  WITH CHECK ADD  CONSTRAINT [customer_ToRentedMovies] FOREIGN KEY([CusID])
REFERENCES [dbo].[customer] ([CusID])
GO
ALTER TABLE [dbo].[rentals] CHECK CONSTRAINT [customer_ToRentedMovies]
GO
USE [master]
GO
ALTER DATABASE [VideoRentalDB] SET  READ_WRITE 
GO
