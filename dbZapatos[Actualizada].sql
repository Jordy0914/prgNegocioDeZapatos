USE [master]
GO
/****** Object:  Database [dbZapatos]    Script Date: 16/6/2016 4:35:35 p. m. ******/
CREATE DATABASE [dbZapatos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbZapatos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\dbZapatos.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbZapatos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\dbZapatos_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[tbBitacoraConexion]    Script Date: 16/6/2016 4:35:35 p. m. ******/
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
/****** Object:  Table [dbo].[tbCorreo]    Script Date: 16/6/2016 4:35:35 p. m. ******/
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
/****** Object:  Table [dbo].[tbFacturaDetalle]    Script Date: 16/6/2016 4:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbFacturaDetalle](
	[idFacturaDetalle] [int] NOT NULL,
	[idFactura] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_tbFacturaDetalle] PRIMARY KEY CLUSTERED 
(
	[idFacturaDetalle] ASC,
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbFacturaEncabezado]    Script Date: 16/6/2016 4:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbFacturaEncabezado](
	[idFactura] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[total] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_tbFacturaEncabezado] PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbProducto]    Script Date: 16/6/2016 4:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProducto](
	[idProducto] [int] IDENTITY(0,1) NOT NULL,
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
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbRoles]    Script Date: 16/6/2016 4:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRoles](
	[idRol] [int] NOT NULL,
	[nombre] [nvarchar](20) NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbRoles] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbRolesVistas]    Script Date: 16/6/2016 4:35:35 p. m. ******/
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
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbRolesVistas] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC,
	[idVista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbTelefono]    Script Date: 16/6/2016 4:35:35 p. m. ******/
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
/****** Object:  Table [dbo].[tbUsuario]    Script Date: 16/6/2016 4:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsuario](
	[idUsuario] [int] IDENTITY(0,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](24) NOT NULL,
	[nombre] [nchar](20) NOT NULL,
	[apellido1] [nchar](20) NOT NULL,
	[apellido2] [nchar](20) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[tipoIdentificacion] [nchar](20) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[puesto] [nchar](20) NOT NULL,
	[cedula] [int] NOT NULL,
	[creadoPor] [int] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[modificadoPor] [int] NULL,
	[fechaModificacion] [date] NULL,
 CONSTRAINT [PK_tbEmpleado] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbUsuariosRoles]    Script Date: 16/6/2016 4:35:35 p. m. ******/
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
/****** Object:  Table [dbo].[tbUsuarioVistas]    Script Date: 16/6/2016 4:35:35 p. m. ******/
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
/****** Object:  Table [dbo].[tbVistas]    Script Date: 16/6/2016 4:35:35 p. m. ******/
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
ALTER TABLE [dbo].[tbBitacoraConexion]  WITH CHECK ADD  CONSTRAINT [FK_tbBitacoraConexion_tbUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[tbUsuario] ([idUsuario])
GO
ALTER TABLE [dbo].[tbBitacoraConexion] CHECK CONSTRAINT [FK_tbBitacoraConexion_tbUsuario]
GO
ALTER TABLE [dbo].[tbCorreo]  WITH CHECK ADD  CONSTRAINT [FK_tbCorreo_tbUsuario] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tbUsuario] ([idUsuario])
GO
ALTER TABLE [dbo].[tbCorreo] CHECK CONSTRAINT [FK_tbCorreo_tbUsuario]
GO
ALTER TABLE [dbo].[tbFacturaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_tbFacturaDetalle_tbFacturaEncabezado] FOREIGN KEY([idFactura])
REFERENCES [dbo].[tbFacturaEncabezado] ([idFactura])
GO
ALTER TABLE [dbo].[tbFacturaDetalle] CHECK CONSTRAINT [FK_tbFacturaDetalle_tbFacturaEncabezado]
GO
ALTER TABLE [dbo].[tbFacturaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_tbFacturaDetalle_tbProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[tbProducto] ([idProducto])
GO
ALTER TABLE [dbo].[tbFacturaDetalle] CHECK CONSTRAINT [FK_tbFacturaDetalle_tbProducto]
GO
ALTER TABLE [dbo].[tbFacturaEncabezado]  WITH CHECK ADD  CONSTRAINT [FK_tbFacturaEncabezado_tbUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[tbUsuario] ([idUsuario])
GO
ALTER TABLE [dbo].[tbFacturaEncabezado] CHECK CONSTRAINT [FK_tbFacturaEncabezado_tbUsuario]
GO
ALTER TABLE [dbo].[tbRolesVistas]  WITH CHECK ADD  CONSTRAINT [FK_tbRolesVistas_tbRoles1] FOREIGN KEY([idRol])
REFERENCES [dbo].[tbRoles] ([idRol])
GO
ALTER TABLE [dbo].[tbRolesVistas] CHECK CONSTRAINT [FK_tbRolesVistas_tbRoles1]
GO
ALTER TABLE [dbo].[tbRolesVistas]  WITH CHECK ADD  CONSTRAINT [FK_tbRolesVistas_tbVistas1] FOREIGN KEY([idVista])
REFERENCES [dbo].[tbVistas] ([idVista])
GO
ALTER TABLE [dbo].[tbRolesVistas] CHECK CONSTRAINT [FK_tbRolesVistas_tbVistas1]
GO
ALTER TABLE [dbo].[tbTelefono]  WITH CHECK ADD  CONSTRAINT [FK_tbTelefono_tbUsuario] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tbUsuario] ([idUsuario])
GO
ALTER TABLE [dbo].[tbTelefono] CHECK CONSTRAINT [FK_tbTelefono_tbUsuario]
GO
ALTER TABLE [dbo].[tbUsuariosRoles]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuariosRoles_tbRoles1] FOREIGN KEY([idRol])
REFERENCES [dbo].[tbRoles] ([idRol])
GO
ALTER TABLE [dbo].[tbUsuariosRoles] CHECK CONSTRAINT [FK_tbUsuariosRoles_tbRoles1]
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
ALTER TABLE [dbo].[tbUsuarioVistas]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuarioVistas_tbVistas1] FOREIGN KEY([idVista])
REFERENCES [dbo].[tbVistas] ([idVista])
GO
ALTER TABLE [dbo].[tbUsuarioVistas] CHECK CONSTRAINT [FK_tbUsuarioVistas_tbVistas1]
GO
USE [master]
GO
ALTER DATABASE [dbZapatos] SET  READ_WRITE 
GO
