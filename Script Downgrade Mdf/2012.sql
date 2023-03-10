USE [master]
GO
/****** Object:  Database [AntrianRS]    Script Date: 21/01/2019 18:07:54 ******/
CREATE DATABASE [AntrianRS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Antrian_dat', FILENAME = N'E:\Tugas Kuliah\###Semester 3\PL\FINAL PROJECT\PRESENTASI\Antrian_dat.mdf' , SIZE = 5120KB , MAXSIZE = 10240KB , FILEGROWTH = 2048KB )
 LOG ON 
( NAME = N'Antrian_log', FILENAME = N'E:\Tugas Kuliah\###Semester 3\PL\FINAL PROJECT\PRESENTASI\Antrian_log.ldf' , SIZE = 5120KB , MAXSIZE = 10240KB , FILEGROWTH = 2048KB )
GO
ALTER DATABASE [AntrianRS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AntrianRS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AntrianRS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AntrianRS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AntrianRS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AntrianRS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AntrianRS] SET ARITHABORT OFF 
GO
ALTER DATABASE [AntrianRS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AntrianRS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AntrianRS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AntrianRS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AntrianRS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AntrianRS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AntrianRS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AntrianRS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AntrianRS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AntrianRS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AntrianRS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AntrianRS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AntrianRS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AntrianRS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AntrianRS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AntrianRS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AntrianRS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AntrianRS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AntrianRS] SET  MULTI_USER 
GO
ALTER DATABASE [AntrianRS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AntrianRS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AntrianRS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AntrianRS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [AntrianRS]
GO
/****** Object:  Table [dbo].[Asuransi]    Script Date: 21/01/2019 18:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Asuransi](
	[Kd_A] [varchar](10) NOT NULL,
	[Nama_A] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Kd_A] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DataID]    Script Date: 21/01/2019 18:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DataID](
	[ID_Pasien] [varchar](5) NOT NULL,
	[Nama_Pasien] [varchar](15) NULL,
	[JK_ID] [varchar](1) NULL,
	[Tgl_Lahir_ID] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Pasien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Dokter]    Script Date: 21/01/2019 18:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dokter](
	[Kd_Dokter] [varchar](5) NOT NULL,
	[Nama_Dokter] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Kd_Dokter] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kdaid]    Script Date: 21/01/2019 18:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kdaid](
	[Kd_AntriID] [varchar](10) NOT NULL,
	[ID_Pasien] [varchar](5) NOT NULL,
	[Kd_Poli] [varchar](10) NOT NULL,
	[Kd_Dokter] [varchar](5) NOT NULL,
	[kd_A] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Kd_AntriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoginAdmin]    Script Date: 21/01/2019 18:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoginAdmin](
	[Username] [varchar](5) NOT NULL,
	[Password] [varchar](18) NULL,
	[Nama] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoginStaff]    Script Date: 21/01/2019 18:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoginStaff](
	[Username] [char](4) NOT NULL,
	[Password] [varchar](18) NULL,
	[Nama] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Poli]    Script Date: 21/01/2019 18:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Poli](
	[Kd_Poli] [varchar](10) NOT NULL,
	[Nama_Poli] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Kd_Poli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Asuransi] ([Kd_A], [Nama_A]) VALUES (N'AS01', N'BPJS')
INSERT [dbo].[Asuransi] ([Kd_A], [Nama_A]) VALUES (N'AS02', N'Prudential')
INSERT [dbo].[Asuransi] ([Kd_A], [Nama_A]) VALUES (N'AS03', N'AXAMandiri')
INSERT [dbo].[Asuransi] ([Kd_A], [Nama_A]) VALUES (N'AS04', N'BMPutera19')
INSERT [dbo].[Asuransi] ([Kd_A], [Nama_A]) VALUES (N'AS05', N'IFinancial')
INSERT [dbo].[Asuransi] ([Kd_A], [Nama_A]) VALUES (N'AS06', N'Jiwasraya')
INSERT [dbo].[Asuransi] ([Kd_A], [Nama_A]) VALUES (N'AS07', N'Avrist')
INSERT [dbo].[Asuransi] ([Kd_A], [Nama_A]) VALUES (N'AS08', N'Sinarmas')
INSERT [dbo].[Asuransi] ([Kd_A], [Nama_A]) VALUES (N'AS09', N'Lain-Lain')
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P001', N'Rafly', N'L', CAST(N'1999-07-29' AS Date))
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P002', N'Andrian', N'L', CAST(N'1999-07-29' AS Date))
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P003', N'Wicaksana', N'L', CAST(N'1999-07-29' AS Date))
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P004', N'Sufirna', N'p', CAST(N'1998-03-17' AS Date))
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P005', N'Doni', N'L', CAST(N'2001-05-05' AS Date))
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P006', N'Rival', N'L', CAST(N'1987-01-26' AS Date))
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P007', N'Agus', N'L', CAST(N'1993-02-28' AS Date))
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P008', N'Hery', N'L', CAST(N'1996-04-30' AS Date))
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P009', N'Rendi', N'L', CAST(N'1989-04-02' AS Date))
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P010', N'Herma', N'L', CAST(N'1990-05-03' AS Date))
INSERT [dbo].[DataID] ([ID_Pasien], [Nama_Pasien], [JK_ID], [Tgl_Lahir_ID]) VALUES (N'P011', N'Adi', N'L', CAST(N'1899-09-18' AS Date))
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D01', N'Jakurai')
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D02', N'Shiki')
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D03', N'Kaoru')
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D04', N'Muzaki')
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D05', N'Demian')
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D06', N'Rafael')
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D07', N'Anto')
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D08', N'Tri')
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D09', N'Agung')
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D10', N'Linda')
INSERT [dbo].[Dokter] ([Kd_Dokter], [Nama_Dokter]) VALUES (N'D11', N'Rumi')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'A001', N'P002', N'A01', N'D11', N'AS02')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'A004', N'P004', N'A01', N'D02', N'AS03')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'B001', N'P001', N'B01', N'D11', N'AS03')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'B002', N'P008', N'B01', N'D11', N'AS03')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'C001', N'P001', N'C01', N'D03', N'AS04')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'C002', N'P005', N'C01', N'D03', N'AS04')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'C003', N'P004', N'C01', N'D11', N'AS05')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'C004', N'P003', N'C01', N'D03', N'AS01')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'C005', N'P008', N'C01', N'D02', N'AS02')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'G001', N'P003', N'G01', N'D11', N'AS02')
INSERT [dbo].[Kdaid] ([Kd_AntriID], [ID_Pasien], [Kd_Poli], [Kd_Dokter], [kd_A]) VALUES (N'H001', N'P011', N'H01', N'D07', N'AS02')
INSERT [dbo].[LoginAdmin] ([Username], [Password], [Nama]) VALUES (N'1195', N'rafly', N'Rafly Andrian Wicaksana')
INSERT [dbo].[LoginAdmin] ([Username], [Password], [Nama]) VALUES (N'Admin', N'Admin', N'Rafly Andrian Wicaksana')
INSERT [dbo].[LoginStaff] ([Username], [Password], [Nama]) VALUES (N'1122', N'Seox', N'Orchid')
INSERT [dbo].[LoginStaff] ([Username], [Password], [Nama]) VALUES (N'1195', N'rafly', N'Rafly Andrian Wicaksana')
INSERT [dbo].[Poli] ([Kd_Poli], [Nama_Poli]) VALUES (N'A01', N'Umum')
INSERT [dbo].[Poli] ([Kd_Poli], [Nama_Poli]) VALUES (N'B01', N'Saraf')
INSERT [dbo].[Poli] ([Kd_Poli], [Nama_Poli]) VALUES (N'C01', N'Orthopedi')
INSERT [dbo].[Poli] ([Kd_Poli], [Nama_Poli]) VALUES (N'D01', N'THT')
INSERT [dbo].[Poli] ([Kd_Poli], [Nama_Poli]) VALUES (N'E01', N'Gigi')
INSERT [dbo].[Poli] ([Kd_Poli], [Nama_Poli]) VALUES (N'F01', N'Anak')
INSERT [dbo].[Poli] ([Kd_Poli], [Nama_Poli]) VALUES (N'G01', N'Kulit dan Kelamin')
INSERT [dbo].[Poli] ([Kd_Poli], [Nama_Poli]) VALUES (N'H01', N'Penyakit Dalam')
INSERT [dbo].[Poli] ([Kd_Poli], [Nama_Poli]) VALUES (N'I01', N'Mata')
INSERT [dbo].[Poli] ([Kd_Poli], [Nama_Poli]) VALUES (N'J01', N'Kandungan')
ALTER TABLE [dbo].[Kdaid]  WITH CHECK ADD FOREIGN KEY([ID_Pasien])
REFERENCES [dbo].[DataID] ([ID_Pasien])
GO
ALTER TABLE [dbo].[Kdaid]  WITH CHECK ADD FOREIGN KEY([kd_A])
REFERENCES [dbo].[Asuransi] ([Kd_A])
GO
ALTER TABLE [dbo].[Kdaid]  WITH CHECK ADD FOREIGN KEY([Kd_Dokter])
REFERENCES [dbo].[Dokter] ([Kd_Dokter])
GO
ALTER TABLE [dbo].[Kdaid]  WITH CHECK ADD FOREIGN KEY([Kd_Poli])
REFERENCES [dbo].[Poli] ([Kd_Poli])
GO
USE [master]
GO
ALTER DATABASE [AntrianRS] SET  READ_WRITE 
GO
