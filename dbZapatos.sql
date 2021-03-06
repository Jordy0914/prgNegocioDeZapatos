USE [master]
GO
/****** Object:  Database [dbZapatos]    Script Date: 14/06/2016 11:57:24 ******/
CREATE DATABASE [dbZapatos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbZapatos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\dbZapatos.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbZapatos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\dbZapatos_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbZapatos] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbZapatos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbZapatos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbZapatos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbZapatos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbZapatos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbZapatos] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbZapatos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbZapatos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbZapatos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbZapatos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbZapatos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbZapatos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbZapatos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbZapatos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbZapatos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbZapatos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbZapatos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbZapatos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbZapatos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbZapatos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbZapatos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbZapatos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbZapatos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbZapatos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbZapatos] SET  MULTI_USER 
GO
ALTER DATABASE [dbZapatos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbZapatos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbZapatos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbZapatos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbZapatos] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dbZapatos]
GO
/****** Object:  Table [dbo].[tbBitacoraConexion]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBitacoraConexion](
	[idBitacora] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [date] NOT NULL,
 CONSTRAINT [PK_tbAuditoria] PRIMARY KEY CLUSTERED 
(
	[idBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbCorreo]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCorreo](
	[idPersona] [int] NOT NULL,
	[idCorreo] [int] IDENTITY(0,1) NOT NULL,
	[tipo] [nvarchar](10) NOT NULL,
	[correo] [nvarchar](50) NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbCorreo] PRIMARY KEY CLUSTERED 
(
	[idCorreo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbEmpleado]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEmpleado](
	[idEmpleado] [int] IDENTITY(0,1) NOT NULL,
	[nombre] [nchar](20) NOT NULL,
	[apellido1] [nchar](20) NOT NULL,
	[apellido2] [nchar](20) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[tipoIdentificacion] [nchar](20) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[puesto] [nchar](20) NOT NULL,
	[cedula] [numeric](18, 0) NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbEmpleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbInventario]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbInventario](
	[idZapato] [int] IDENTITY(0,1) NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[modelo] [nchar](20) NOT NULL,
	[nombre] [nchar](20) NOT NULL,
	[talla] [numeric](2, 1) NOT NULL,
	[color] [nchar](10) NOT NULL,
	[costo] [int] NOT NULL,
	[precio] [int] NOT NULL,
	[marca] [nchar](20) NOT NULL,
	[categoria] [nchar](20) NOT NULL,
	[cantidad] [int] NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbZapato] PRIMARY KEY CLUSTERED 
(
	[idZapato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbRoles]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRoles](
	[idRole] [int] NOT NULL,
	[nombre] [nvarchar](20) NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbRoles] PRIMARY KEY CLUSTERED 
(
	[idRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbRolesVistas]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRolesVistas](
	[idRol] [int] NOT NULL,
	[idVista] [int] NOT NULL,
	[insertar] [int] NOT NULL,
	[modificar] [int] NOT NULL,
	[eliminar] [int] NOT NULL,
	[consultar] [int] NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbTelefono]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTelefono](
	[idPersona] [int] NOT NULL,
	[idTelefono] [int] IDENTITY(0,1) NOT NULL,
	[tipo] [nvarchar](10) NOT NULL,
	[telefono] [numeric](18, 0) NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modifcadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbTelefono] PRIMARY KEY CLUSTERED 
(
	[idTelefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbUsuario]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsuario](
	[idUsuario] [int] IDENTITY(0,1) NOT NULL,
	[usuario] [nvarchar](15) NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[password] [nvarchar](20) NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbUsuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbUsuariosRoles]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsuariosRoles](
	[idUsuario] [int] NOT NULL,
	[idRol] [int] NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbUsuariosRoles] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC,
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbUsuarioVistas]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsuarioVistas](
	[idUsuario] [int] NOT NULL,
	[idVista] [int] NOT NULL,
	[Insertar] [int] NOT NULL,
	[Modificar] [int] NOT NULL,
	[Eliminar] [int] NOT NULL,
	[Consultar] [int] NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbUsuarioVistas] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC,
	[idVista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbVistas]    Script Date: 14/06/2016 11:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbVistas](
	[idVista] [int] IDENTITY(0,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbVistas] PRIMARY KEY CLUSTERED 
(
	[idVista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tbBitacoraConexion]  WITH CHECK ADD  CONSTRAINT [FK_tbBitacora_tbUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[tbUsuario] ([idUsuario])
GO
ALTER TABLE [dbo].[tbBitacoraConexion] CHECK CONSTRAINT [FK_tbBitacora_tbUsuario]
GO
ALTER TABLE [dbo].[tbCorreo]  WITH CHECK ADD  CONSTRAINT [FK_tbCorreo_tbEmpleado] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tbEmpleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[tbCorreo] CHECK CONSTRAINT [FK_tbCorreo_tbEmpleado]
GO
ALTER TABLE [dbo].[tbInventario]  WITH CHECK ADD  CONSTRAINT [FK_tbInventario_tbEmpleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[tbEmpleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[tbInventario] CHECK CONSTRAINT [FK_tbInventario_tbEmpleado]
GO
ALTER TABLE [dbo].[tbRolesVistas]  WITH CHECK ADD  CONSTRAINT [FK_tbRolesVistas_tbRoles] FOREIGN KEY([idRol])
REFERENCES [dbo].[tbRoles] ([idRole])
GO
ALTER TABLE [dbo].[tbRolesVistas] CHECK CONSTRAINT [FK_tbRolesVistas_tbRoles]
GO
ALTER TABLE [dbo].[tbRolesVistas]  WITH CHECK ADD  CONSTRAINT [FK_tbRolesVistas_tbVistas] FOREIGN KEY([idVista])
REFERENCES [dbo].[tbVistas] ([idVista])
GO
ALTER TABLE [dbo].[tbRolesVistas] CHECK CONSTRAINT [FK_tbRolesVistas_tbVistas]
GO
ALTER TABLE [dbo].[tbTelefono]  WITH CHECK ADD  CONSTRAINT [FK_tbTelefono_tbEmpleado] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tbEmpleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[tbTelefono] CHECK CONSTRAINT [FK_tbTelefono_tbEmpleado]
GO
ALTER TABLE [dbo].[tbUsuariosRoles]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuariosRoles_tbRoles] FOREIGN KEY([idRol])
REFERENCES [dbo].[tbRoles] ([idRole])
GO
ALTER TABLE [dbo].[tbUsuariosRoles] CHECK CONSTRAINT [FK_tbUsuariosRoles_tbRoles]
GO
ALTER TABLE [dbo].[tbUsuariosRoles]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuariosRoles_tbUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[tbUsuario] ([idUsuario])
GO
ALTER TABLE [dbo].[tbUsuariosRoles] CHECK CONSTRAINT [FK_tbUsuariosRoles_tbUsuario]
GO
ALTER TABLE [dbo].[tbUsuarioVistas]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuarioVistas_tbUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[tbUsuario] ([idUsuario])
GO
ALTER TABLE [dbo].[tbUsuarioVistas] CHECK CONSTRAINT [FK_tbUsuarioVistas_tbUsuario]
GO
ALTER TABLE [dbo].[tbUsuarioVistas]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuarioVistas_tbVistas] FOREIGN KEY([idVista])
REFERENCES [dbo].[tbVistas] ([idVista])
GO
ALTER TABLE [dbo].[tbUsuarioVistas] CHECK CONSTRAINT [FK_tbUsuarioVistas_tbVistas]
GO
USE [master]
GO
ALTER DATABASE [dbZapatos] SET  READ_WRITE 
GO
