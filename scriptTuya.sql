USE [master]
GO
/****** Object:  Database [Tuya]    Script Date: 30/11/2023 11:34:06 a. m. ******/
CREATE DATABASE [Tuya]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tuya', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Tuya.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tuya_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Tuya_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Tuya] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tuya].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tuya] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tuya] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tuya] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tuya] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tuya] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tuya] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tuya] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tuya] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tuya] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tuya] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tuya] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tuya] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tuya] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tuya] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tuya] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tuya] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tuya] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tuya] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tuya] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tuya] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tuya] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tuya] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tuya] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tuya] SET  MULTI_USER 
GO
ALTER DATABASE [Tuya] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tuya] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tuya] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tuya] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tuya] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tuya] SET QUERY_STORE = OFF
GO
USE [Tuya]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 30/11/2023 11:34:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[Documento] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orden]    Script Date: 30/11/2023 11:34:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orden](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NULL,
	[Radicado] [varchar](15) NULL,
	[FechaCreacion] [datetime2](7) NULL,
	[Estado] [varchar](20) NULL,
 CONSTRAINT [PK_Orden] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Token]    Script Date: 30/11/2023 11:34:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Token](
	[IdToken] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Token] [varchar](max) NULL,
	[FechaCreacion] [datetime2](7) NULL,
	[FechaVencimiento] [datetime2](7) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Token] PRIMARY KEY CLUSTERED 
(
	[IdToken] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 30/11/2023 11:34:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NULL,
	[Clave] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Rol] [varchar](255) NULL,
	[Apellido] [varchar](255) NULL,
 CONSTRAINT [PK__Usuario__5B65BF97F8EA57E9] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Documento], [Email]) VALUES (1, N'alejo', N'pertuz', N'123', N'alejo@gmail.com')
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Documento], [Email]) VALUES (2, N'ana', N'lopez', N'321', N'ana@gmail.com')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Orden] ON 

INSERT [dbo].[Orden] ([Id], [ClienteId], [Radicado], [FechaCreacion], [Estado]) VALUES (1, 1, N'000001', CAST(N'2023-11-30T03:18:46.2150000' AS DateTime2), N'Creada')
SET IDENTITY_INSERT [dbo].[Orden] OFF
SET IDENTITY_INSERT [dbo].[Token] ON 

INSERT [dbo].[Token] ([IdToken], [IdUsuario], [Token], [FechaCreacion], [FechaVencimiento], [Estado]) VALUES (1, 1, N'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjEiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJhZG1pbiIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2dpdmVubmFtZSI6IkFkbWluIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc3VybmFtZSI6IkFkbWluIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW5pc3RyYWRvciIsImV4cCI6MTcwMTMxNDIxN30.n_O1kmcjCn0zP3JrBrpYp2UqblfpTNL8599HlgLjXPA', CAST(N'2023-11-29T21:17:05.4365821' AS DateTime2), CAST(N'2023-11-29T22:16:57.5265729' AS DateTime2), 0)
INSERT [dbo].[Token] ([IdToken], [IdUsuario], [Token], [FechaCreacion], [FechaVencimiento], [Estado]) VALUES (2, 1, N'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjEiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJhZG1pbiIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2dpdmVubmFtZSI6IkFkbWluIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc3VybmFtZSI6IkFkbWluIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW5pc3RyYWRvciIsImV4cCI6MTcwMTMxNzkwMn0.aL5vju_DAwgrQeY4a9ZEzIqc9wspN-ckry3Vb9ogSlo', CAST(N'2023-11-29T22:18:22.5823287' AS DateTime2), CAST(N'2023-11-29T23:18:22.5730151' AS DateTime2), 0)
INSERT [dbo].[Token] ([IdToken], [IdUsuario], [Token], [FechaCreacion], [FechaVencimiento], [Estado]) VALUES (3, 2, N'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjIiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJhbmFAZ21haWwuY29tIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZ2l2ZW5uYW1lIjoiQW5hIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc3VybmFtZSI6IkxvcGV6IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQ2FqZXJvIiwiZXhwIjoxNzAxMzE4MDM2fQ.jKHjjcf93xZxQOQ-e8ffgdurLaHxL_s4Gfmt5pbdwPs', CAST(N'2023-11-29T22:20:36.8838597' AS DateTime2), CAST(N'2023-11-29T23:20:36.8829604' AS DateTime2), 1)
INSERT [dbo].[Token] ([IdToken], [IdUsuario], [Token], [FechaCreacion], [FechaVencimiento], [Estado]) VALUES (4, 1, N'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjEiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJhZG1pbiIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2dpdmVubmFtZSI6IkFkbWluIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc3VybmFtZSI6IkFkbWluIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW5pc3RyYWRvciIsImV4cCI6MTcwMTM2NTA4OH0.pamvfBLgUwx_4T_yzJgZuJmv0abGLMPBffTUChnPymc', CAST(N'2023-11-30T11:24:48.8546745' AS DateTime2), CAST(N'2023-11-30T12:24:48.6855464' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Token] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Clave], [Email], [Rol], [Apellido]) VALUES (1, N'Admin', N'123', N'admin', N'Administrador', N'Admin')
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Clave], [Email], [Rol], [Apellido]) VALUES (2, N'Ana', N'321', N'ana@gmail.com', N'Cajero', N'Lopez')
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Clave], [Email], [Rol], [Apellido]) VALUES (3, N'Pablo', N'777', N'pablo@gmail.com', N'Soporte', N'Silva')
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Clave], [Email], [Rol], [Apellido]) VALUES (4, N'Carlo', N'854', N'carlos@gmail.com', N'Proveedor', N'Quintero')
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Clave], [Email], [Rol], [Apellido]) VALUES (5, N'Pamela', N'444', N'pamela@gmail.com', N'Usuario', N'Nuñez')
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Clave], [Email], [Rol], [Apellido]) VALUES (6, N'Maria', N'555', N'maria@gmail.com', N'Usuario', N'Masea')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
USE [master]
GO
ALTER DATABASE [Tuya] SET  READ_WRITE 
GO
