USE [master]
GO
/****** Object:  Database [usersawards]    Script Date: 17.02.2019 20:12:10 ******/
CREATE DATABASE [usersawards]
 CONTAINMENT = NONE
 
ALTER DATABASE [usersawards] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [usersawards].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [usersawards] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [usersawards] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [usersawards] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [usersawards] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [usersawards] SET ARITHABORT OFF 
GO
ALTER DATABASE [usersawards] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [usersawards] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [usersawards] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [usersawards] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [usersawards] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [usersawards] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [usersawards] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [usersawards] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [usersawards] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [usersawards] SET  DISABLE_BROKER 
GO
ALTER DATABASE [usersawards] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [usersawards] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [usersawards] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [usersawards] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [usersawards] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [usersawards] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [usersawards] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [usersawards] SET RECOVERY FULL 
GO
ALTER DATABASE [usersawards] SET  MULTI_USER 
GO
ALTER DATABASE [usersawards] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [usersawards] SET DB_CHAINING OFF 
GO
ALTER DATABASE [usersawards] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [usersawards] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [usersawards] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [usersawards] SET QUERY_STORE = OFF
GO
USE [usersawards]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [usersawards]
GO
/****** Object:  Table [dbo].[award]    Script Date: 17.02.2019 20:12:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[award](
	[id_award] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](200) NULL,
 CONSTRAINT [PK_award] PRIMARY KEY CLUSTERED 
(
	[id_award] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[logins]    Script Date: 17.02.2019 20:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logins](
	[login] [nvarchar](100) NOT NULL,
	[pasword] [nvarchar](50) NULL,
	[role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_logins] PRIMARY KEY CLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[useraward]    Script Date: 17.02.2019 20:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[useraward](
	[id_user] [int] NULL,
	[id_award] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 17.02.2019 20:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[birth] [date] NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[award] ON 

INSERT [dbo].[award] ([id_award], [title]) VALUES (1, N'Biology Award')
INSERT [dbo].[award] ([id_award], [title]) VALUES (2, N'Information Security Award for Bears')
INSERT [dbo].[award] ([id_award], [title]) VALUES (3, N'Igor Award')
INSERT [dbo].[award] ([id_award], [title]) VALUES (4, N'Gosurunya Award')
INSERT [dbo].[award] ([id_award], [title]) VALUES (5, N'Nauchnaya aptechka')
INSERT [dbo].[award] ([id_award], [title]) VALUES (7, N'HATE award')
INSERT [dbo].[award] ([id_award], [title]) VALUES (9, N'Herecy')
INSERT [dbo].[award] ([id_award], [title]) VALUES (11, N'Raven Award')
SET IDENTITY_INSERT [dbo].[award] OFF
INSERT [dbo].[logins] ([login], [pasword], [role]) VALUES (N'admin', N'admin', N'admin')
INSERT [dbo].[logins] ([login], [pasword], [role]) VALUES (N'anechka', N'', N'user')
INSERT [dbo].[logins] ([login], [pasword], [role]) VALUES (N'god', NULL, N'user')
INSERT [dbo].[logins] ([login], [pasword], [role]) VALUES (N'spacemarine', N'imperor', N'admin')
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (1, 1)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (1, 2)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (1, 4)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (2, 2)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (4, 7)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (5, 5)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (6, NULL)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (2, 7)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (14, 9)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (8, 2)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (6, 3)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (8, 11)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (4, 2)
INSERT [dbo].[useraward] ([id_user], [id_award]) VALUES (4, 3)
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id_user], [name], [birth]) VALUES (1, N'Dasha', CAST(N'1996-03-20' AS Date))
INSERT [dbo].[users] ([id_user], [name], [birth]) VALUES (2, N'Alan', CAST(N'1996-11-30' AS Date))
INSERT [dbo].[users] ([id_user], [name], [birth]) VALUES (4, N'Jerk228', CAST(N'1988-08-22' AS Date))
INSERT [dbo].[users] ([id_user], [name], [birth]) VALUES (5, N'Ulenka2004', CAST(N'2004-09-11' AS Date))
INSERT [dbo].[users] ([id_user], [name], [birth]) VALUES (6, N'Igor', CAST(N'1997-12-25' AS Date))
INSERT [dbo].[users] ([id_user], [name], [birth]) VALUES (8, N'Corvus Corax', CAST(N'1925-05-12' AS Date))
INSERT [dbo].[users] ([id_user], [name], [birth]) VALUES (14, N'Horus', CAST(N'1966-06-06' AS Date))
SET IDENTITY_INSERT [dbo].[users] OFF
ALTER TABLE [dbo].[useraward]  WITH CHECK ADD  CONSTRAINT [FK_useraward_award] FOREIGN KEY([id_award])
REFERENCES [dbo].[award] ([id_award])
GO
ALTER TABLE [dbo].[useraward] CHECK CONSTRAINT [FK_useraward_award]
GO
ALTER TABLE [dbo].[useraward]  WITH CHECK ADD  CONSTRAINT [FK_useraward_users] FOREIGN KEY([id_user])
REFERENCES [dbo].[users] ([id_user])
GO
ALTER TABLE [dbo].[useraward] CHECK CONSTRAINT [FK_useraward_users]
GO
USE [master]
GO
ALTER DATABASE [usersawards] SET  READ_WRITE 
GO
