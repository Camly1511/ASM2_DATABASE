USE [master]
GO
/****** Object:  Database [BTEC_CMS]    Script Date: 4/9/2024 8:30:21 AM ******/
CREATE DATABASE [BTEC_CMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BTEC_CMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BTEC_CMS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BTEC_CMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BTEC_CMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BTEC_CMS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BTEC_CMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BTEC_CMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BTEC_CMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BTEC_CMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BTEC_CMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BTEC_CMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [BTEC_CMS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BTEC_CMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BTEC_CMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BTEC_CMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BTEC_CMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BTEC_CMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BTEC_CMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BTEC_CMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BTEC_CMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BTEC_CMS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BTEC_CMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BTEC_CMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BTEC_CMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BTEC_CMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BTEC_CMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BTEC_CMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BTEC_CMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BTEC_CMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BTEC_CMS] SET  MULTI_USER 
GO
ALTER DATABASE [BTEC_CMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BTEC_CMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BTEC_CMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BTEC_CMS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BTEC_CMS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BTEC_CMS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BTEC_CMS] SET QUERY_STORE = ON
GO
ALTER DATABASE [BTEC_CMS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BTEC_CMS]
GO
/****** Object:  Table [dbo].[assignment]    Script Date: 4/9/2024 8:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assignment](
	[id] [bigint] NOT NULL,
	[course_id] [bigint] NULL,
	[assignment_name] [nvarchar](50) NOT NULL,
	[assignment_content] [nvarchar](max) NOT NULL,
	[student_id] [bigint] NULL,
	[due_date] [date] NOT NULL,
	[grade] [nvarchar](10) NULL,
	[status] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[course]    Script Date: 4/9/2024 8:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[course](
	[id] [bigint] NOT NULL,
	[teacher_id] [bigint] NULL,
	[courses_name] [nvarchar](50) NULL,
	[status] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[score]    Script Date: 4/9/2024 8:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[score](
	[id] [bigint] NOT NULL,
	[student_id] [bigint] NULL,
	[teacher_id] [bigint] NULL,
	[grading_day] [datetime] NOT NULL,
	[score] [nvarchar](10) NULL,
	[submit_id] [bigint] NOT NULL,
	[status] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 4/9/2024 8:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[id] [bigint] NOT NULL,
	[course_id] [bigint] NULL,
	[role_id] [bigint] NULL,
	[code] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[phone] [nvarchar](20) NULL,
	[address] [nvarchar](100) NULL,
	[fullname] [nvarchar](30) NULL,
	[birthday] [nvarchar](50) NULL,
	[gender] [tinyint] NULL,
	[status] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[submit]    Script Date: 4/9/2024 8:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[submit](
	[id] [bigint] NOT NULL,
	[student_id] [bigint] NULL,
	[submission_name] [nvarchar](50) NULL,
	[grading_status] [nvarchar](50) NULL,
	[due_date] [nvarchar](50) NULL,
	[submission_file] [nvarchar](100) NULL,
	[status] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 4/9/2024 8:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[id] [bigint] NOT NULL,
	[teacher_id] [bigint] NULL,
	[name] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[gender] [tinyint] NULL,
	[phone] [nvarchar](50) NULL,
	[status] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[assignment]  WITH CHECK ADD FOREIGN KEY([course_id])
REFERENCES [dbo].[course] ([id])
GO
ALTER TABLE [dbo].[assignment]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[student] ([id])
GO
ALTER TABLE [dbo].[course]  WITH CHECK ADD FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teacher] ([id])
GO
ALTER TABLE [dbo].[score]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[student] ([id])
GO
ALTER TABLE [dbo].[score]  WITH CHECK ADD FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teacher] ([id])
GO
ALTER TABLE [dbo].[student]  WITH CHECK ADD FOREIGN KEY([course_id])
REFERENCES [dbo].[course] ([id])
GO
ALTER TABLE [dbo].[submit]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[student] ([id])
GO
USE [master]
GO
ALTER DATABASE [BTEC_CMS] SET  READ_WRITE 
GO
