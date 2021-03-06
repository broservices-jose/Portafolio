
USE [master]
GO
/****** Object:  Database [DocumentosDB]    Script Date: 09/10/2016 9:50:57 ******/
CREATE DATABASE [DocumentosDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DocumentosDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DocumentosDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DocumentosDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DocumentosDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DocumentosDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DocumentosDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DocumentosDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DocumentosDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DocumentosDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DocumentosDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DocumentosDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DocumentosDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DocumentosDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DocumentosDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DocumentosDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DocumentosDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DocumentosDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DocumentosDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DocumentosDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DocumentosDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DocumentosDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DocumentosDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DocumentosDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DocumentosDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DocumentosDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DocumentosDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DocumentosDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DocumentosDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DocumentosDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DocumentosDB] SET  MULTI_USER 
GO
ALTER DATABASE [DocumentosDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DocumentosDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DocumentosDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DocumentosDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DocumentosDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DocumentosDB]
GO
/****** Object:  Table [dbo].[Buzon]    Script Date: 09/10/2016 9:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buzon](
	[empleado] [int] NULL,
	[documento] [int] NULL,
	[estado] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 09/10/2016 9:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Documento]    Script Date: 09/10/2016 9:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Documento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 09/10/2016 9:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[departamento] [int] NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[cedula] [varchar](20) NOT NULL,
	[tipo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EnvioExterno]    Script Date: 09/10/2016 9:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EnvioExterno](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mensajero] [int] NULL,
	[remitente] [int] NULL,
	[destinatario] [int] NULL,
	[asunto] [varchar](50) NULL,
	[enviado] [datetime] NULL,
	[recibido] [datetime] NULL,
	[documento] [int] NULL,
	[completado] [bit] NULL DEFAULT ((0)),
	[direccion] [varchar](50) NULL,
	[telefono] [varchar](14) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EnvioInterno]    Script Date: 09/10/2016 9:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EnvioInterno](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mensajero] [int] NULL,
	[remitente] [int] NULL,
	[destinatario] [int] NULL,
	[asunto] [varchar](50) NULL,
	[enviado] [datetime] NULL,
	[recibido] [datetime] NULL,
	[documento] [int] NULL,
	[completado] [bit] NULL DEFAULT ((0)),
	[telefono] [varchar](14) NULL,
	[direccion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 09/10/2016 9:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[empleado] [int] NULL,
	[cuenta] [varchar](30) NULL,
	[contraseña] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Buzon] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Buzon]  WITH CHECK ADD FOREIGN KEY([documento])
REFERENCES [dbo].[Documento] ([id])
GO
ALTER TABLE [dbo].[Buzon]  WITH CHECK ADD FOREIGN KEY([empleado])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD FOREIGN KEY([departamento])
REFERENCES [dbo].[Departamento] ([id])
GO
ALTER TABLE [dbo].[EnvioExterno]  WITH CHECK ADD FOREIGN KEY([documento])
REFERENCES [dbo].[Documento] ([id])
GO
ALTER TABLE [dbo].[EnvioExterno]  WITH CHECK ADD FOREIGN KEY([mensajero])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[EnvioExterno]  WITH CHECK ADD FOREIGN KEY([remitente])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[EnvioExterno]  WITH CHECK ADD FOREIGN KEY([destinatario])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[EnvioInterno]  WITH CHECK ADD FOREIGN KEY([destinatario])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[EnvioInterno]  WITH CHECK ADD FOREIGN KEY([documento])
REFERENCES [dbo].[Documento] ([id])
GO
ALTER TABLE [dbo].[EnvioInterno]  WITH CHECK ADD FOREIGN KEY([mensajero])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[EnvioInterno]  WITH CHECK ADD FOREIGN KEY([remitente])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([empleado])
REFERENCES [dbo].[Empleado] ([id])
GO
USE [master]
GO
ALTER DATABASE [DocumentosDB] SET  READ_WRITE 
GO
