USE [master]
GO
/****** Object:  Database [SARAZA]    Script Date: 2022-09-26 5:44:33 PM ******/
CREATE DATABASE [SARAZA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SARAZA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SARAZA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SARAZA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SARAZA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SARAZA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SARAZA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SARAZA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SARAZA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SARAZA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SARAZA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SARAZA] SET ARITHABORT OFF 
GO
ALTER DATABASE [SARAZA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SARAZA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SARAZA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SARAZA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SARAZA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SARAZA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SARAZA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SARAZA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SARAZA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SARAZA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SARAZA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SARAZA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SARAZA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SARAZA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SARAZA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SARAZA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SARAZA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SARAZA] SET RECOVERY FULL 
GO
ALTER DATABASE [SARAZA] SET  MULTI_USER 
GO
ALTER DATABASE [SARAZA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SARAZA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SARAZA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SARAZA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SARAZA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SARAZA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SARAZA', N'ON'
GO
ALTER DATABASE [SARAZA] SET QUERY_STORE = OFF
GO
USE [SARAZA]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 2022-09-26 5:44:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[IdBitacora] [int] IDENTITY(1,1) NOT NULL,
	[Arma] [nvarchar](50) NOT NULL,
	[Distancia] [int] NOT NULL,
	[Disparo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[IdBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [SARAZA] SET  READ_WRITE 
GO
