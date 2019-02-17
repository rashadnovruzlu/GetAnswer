USE [master]
GO
/****** Object:  Database [GETANSWER]    Script Date: 2/18/2019 1:41:39 AM ******/
CREATE DATABASE [GETANSWER]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GetAnswer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\GetAnswer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GetAnswer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\GetAnswer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GETANSWER] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GETANSWER].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GETANSWER] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GETANSWER] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GETANSWER] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GETANSWER] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GETANSWER] SET ARITHABORT OFF 
GO
ALTER DATABASE [GETANSWER] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GETANSWER] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GETANSWER] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GETANSWER] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GETANSWER] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GETANSWER] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GETANSWER] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GETANSWER] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GETANSWER] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GETANSWER] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GETANSWER] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GETANSWER] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GETANSWER] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GETANSWER] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GETANSWER] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GETANSWER] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GETANSWER] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GETANSWER] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GETANSWER] SET  MULTI_USER 
GO
ALTER DATABASE [GETANSWER] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GETANSWER] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GETANSWER] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GETANSWER] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GETANSWER] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GETANSWER] SET QUERY_STORE = OFF
GO
USE [GETANSWER]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [GETANSWER]
GO
/****** Object:  User [Rashad]    Script Date: 2/18/2019 1:41:40 AM ******/
CREATE USER [Rashad] FOR LOGIN [Rashad] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [Rashad]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Rashad]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Rashad]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Rashad]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Rashad]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Rashad]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Rashad]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [Rashad]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [Rashad]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserId] [nvarchar](128) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[DoctorateDegreeId] [tinyint] NULL,
	[CityId] [int] NULL,
	[Phone] [nvarchar](100) NULL,
	[Base64Image] [nvarchar](max) NULL,
	[About] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[Tags] [nvarchar](250) NOT NULL,
	[Title] [nvarchar](500) NOT NULL,
	[Body] [nvarchar](max) NOT NULL,
	[CorrectAnswerId] [int] NULL,
	[ViewCount] [int] NOT NULL,
	[UsefulCount] [int] NOT NULL,
	[NotUsefulCount] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionTag]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionTag](
	[QuestionId] [int] NOT NULL,
	[TagId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Level] [tinyint] NOT NULL,
	[JoinDate] [datetime] NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[Body] [nvarchar](max) NOT NULL,
	[UsefulCount] [int] NOT NULL,
	[NotUsefulCount] [int] NOT NULL,
	[IsCorrectAnswer] [tinyint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_ALL_QUESTION]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[VW_ALL_QUESTION]
AS
SELECT
qn.Id as QuestionId, 
qn.Title,
qn.Body,
qn.CreatedDate,
qn.ViewCount,
answers.AnswerCount,
(qn.UsefulCount-qn.NotUsefulCount) as Votes,
ans.UserName,
ui.Base64Image as UserImage,
ct.Id as CategoryId,
ct.Name as Category,
qn.CorrectAnswerId,
STUFF (Tags.Name, 1, 1,'') as Tags
FROM Question qn
INNER JOIN Category ct on qn.CategoryId=ct.Id
INNER JOIN AspNetUsers ans on ans.Id=qn.UserId
LEFT JOIN UserInfo ui on ans.Id=ui.UserId
LEFT JOIN Answer ar on qn.Id=ar.QuestionId
CROSS APPLY 
(SELECT COUNT(1) FROM Answer ar WHERE ar.QuestionId=qn.Id)answers(AnswerCount)
CROSS APPLY (
SELECT ',' + tg.Name FROM QuestionTag qt
INNER JOIN Tag tg on qt.TagId=tg.Id
where qt.QuestionId=qn.Id
for xml path(''))tags(Name)

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CountryId] [int] NOT NULL,
	[CityName] [nvarchar](100) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [nvarchar](128) NOT NULL,
	[Secret] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[ApplicationType] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[RefreshTokenLifeTime] [int] NOT NULL,
	[AllowedOrigin] [nvarchar](100) NULL,
 CONSTRAINT [PK_dbo.Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AnsweId] [int] NOT NULL,
	[Comment] [nvarchar](max) NOT NULL,
	[ReadDate] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[County]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[County](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](200) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_County] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorateDegree]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorateDegree](
	[Id] [tinyint] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_DoctoralDegrees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FileType]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileType](
	[Id] [int] NOT NULL,
	[Extension] [nvarchar](10) NOT NULL,
	[MIMEType] [nvarchar](200) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_FileType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionAddition]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionAddition](
	[QuestionId] [int] NOT NULL,
	[AnswerSendEmail] [bit] NOT NULL,
	[AnswerSendPhone] [bit] NOT NULL,
 CONSTRAINT [PK_QuestionAddition] PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionAttachmentFile]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionAttachmentFile](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[FileName] [nvarchar](125) NOT NULL,
	[FileTypeId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_QuestionAttachmentFile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RefreshTokens]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RefreshTokens](
	[Id] [nvarchar](128) NOT NULL,
	[Subject] [nvarchar](50) NOT NULL,
	[ClientId] [nvarchar](50) NOT NULL,
	[IssuedUtc] [datetime] NOT NULL,
	[ExpiresUtc] [datetime] NOT NULL,
	[ProtectedTicket] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.RefreshTokens] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInterestTag]    Script Date: 2/18/2019 1:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInterestTag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TagId] [int] NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_UserInterestTag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 2/18/2019 1:41:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 2/18/2019 1:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 2/18/2019 1:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleId]    Script Date: 2/18/2019 1:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 2/18/2019 1:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 2/18/2019 1:41:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Answer] ADD  CONSTRAINT [DF_Answer_UsefulCount]  DEFAULT ((0)) FOR [UsefulCount]
GO
ALTER TABLE [dbo].[Answer] ADD  CONSTRAINT [DF_Answer_IsCorrectAnswer]  DEFAULT ((0)) FOR [IsCorrectAnswer]
GO
ALTER TABLE [dbo].[Answer] ADD  CONSTRAINT [DF_Answer_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Answer] ADD  CONSTRAINT [DF_Answer_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[Answer] ADD  CONSTRAINT [DF_Answer_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[City] ADD  CONSTRAINT [DF_City_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Comment] ADD  CONSTRAINT [DF_Comment_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Comment] ADD  CONSTRAINT [DF_Comment_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[Comment] ADD  CONSTRAINT [DF_Comment_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[County] ADD  CONSTRAINT [DF_County_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[DoctorateDegree] ADD  CONSTRAINT [DF_DoctoralDegrees_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[FileType] ADD  CONSTRAINT [DF_FileType_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Question] ADD  CONSTRAINT [DF_Question_ViewCount]  DEFAULT ((0)) FOR [ViewCount]
GO
ALTER TABLE [dbo].[Question] ADD  CONSTRAINT [DF_Question_UsefulCount]  DEFAULT ((0)) FOR [UsefulCount]
GO
ALTER TABLE [dbo].[Question] ADD  CONSTRAINT [DF_Question_NotUsefulCount]  DEFAULT ((0)) FOR [NotUsefulCount]
GO
ALTER TABLE [dbo].[Question] ADD  CONSTRAINT [DF_Question_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Question] ADD  CONSTRAINT [DF_Question_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[Question] ADD  CONSTRAINT [DF_Question_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[QuestionAddition] ADD  CONSTRAINT [DF_QuestionAddition_AnswerSendEmail]  DEFAULT ((0)) FOR [AnswerSendEmail]
GO
ALTER TABLE [dbo].[QuestionAddition] ADD  CONSTRAINT [DF_QuestionAddition_AnswerSendPhone]  DEFAULT ((0)) FOR [AnswerSendPhone]
GO
ALTER TABLE [dbo].[QuestionAttachmentFile] ADD  CONSTRAINT [DF_QuestionAttachmentFile_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Tag] ADD  CONSTRAINT [DF_Tag_Count]  DEFAULT ((0)) FOR [Count]
GO
ALTER TABLE [dbo].[UserInterestTag] ADD  CONSTRAINT [DF_UserInterestTag_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[UserInterestTag] ADD  CONSTRAINT [DF_UserInterestTag_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_Question] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([Id])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_Question]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUsers]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUsers_UserInfo] FOREIGN KEY([Id])
REFERENCES [dbo].[UserInfo] ([UserId])
GO
ALTER TABLE [dbo].[AspNetUsers] CHECK CONSTRAINT [FK_AspNetUsers_UserInfo]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_County] FOREIGN KEY([CountryId])
REFERENCES [dbo].[County] ([Id])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_County]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Answer] FOREIGN KEY([AnsweId])
REFERENCES [dbo].[Answer] ([Id])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Answer]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Answer] FOREIGN KEY([CorrectAnswerId])
REFERENCES [dbo].[Answer] ([Id])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Answer]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Category]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_QuestionAddition] FOREIGN KEY([Id])
REFERENCES [dbo].[QuestionAddition] ([QuestionId])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_QuestionAddition]
GO
ALTER TABLE [dbo].[QuestionAttachmentFile]  WITH CHECK ADD  CONSTRAINT [FK_QuestionAttachmentFile_FileType] FOREIGN KEY([FileTypeId])
REFERENCES [dbo].[FileType] ([Id])
GO
ALTER TABLE [dbo].[QuestionAttachmentFile] CHECK CONSTRAINT [FK_QuestionAttachmentFile_FileType]
GO
ALTER TABLE [dbo].[QuestionAttachmentFile]  WITH CHECK ADD  CONSTRAINT [FK_QuestionAttachmentFile_Question] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([Id])
GO
ALTER TABLE [dbo].[QuestionAttachmentFile] CHECK CONSTRAINT [FK_QuestionAttachmentFile_Question]
GO
ALTER TABLE [dbo].[QuestionTag]  WITH CHECK ADD  CONSTRAINT [FK_QuestionTag_Question] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([Id])
GO
ALTER TABLE [dbo].[QuestionTag] CHECK CONSTRAINT [FK_QuestionTag_Question]
GO
ALTER TABLE [dbo].[QuestionTag]  WITH CHECK ADD  CONSTRAINT [FK_QuestionTag_Tag] FOREIGN KEY([TagId])
REFERENCES [dbo].[Tag] ([Id])
GO
ALTER TABLE [dbo].[QuestionTag] CHECK CONSTRAINT [FK_QuestionTag_Tag]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_City] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([Id])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_City]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_DoctorateDegree] FOREIGN KEY([DoctorateDegreeId])
REFERENCES [dbo].[DoctorateDegree] ([Id])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_DoctorateDegree]
GO
ALTER TABLE [dbo].[UserInterestTag]  WITH CHECK ADD  CONSTRAINT [FK_UserInterestTag_AspNetUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[UserInterestTag] CHECK CONSTRAINT [FK_UserInterestTag_AspNetUsers]
GO
ALTER TABLE [dbo].[UserInterestTag]  WITH CHECK ADD  CONSTRAINT [FK_UserInterestTag_Tag] FOREIGN KEY([TagId])
REFERENCES [dbo].[Tag] ([Id])
GO
ALTER TABLE [dbo].[UserInterestTag] CHECK CONSTRAINT [FK_UserInterestTag_Tag]
GO
USE [master]
GO
ALTER DATABASE [GETANSWER] SET  READ_WRITE 
GO
