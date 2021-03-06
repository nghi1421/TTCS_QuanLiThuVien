USE [master]
GO
/****** Object:  Database [QuanLiThuVien]    Script Date: 6/13/2022 2:53:13 AM ******/
CREATE DATABASE [QuanLiThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLiThuVien.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLiThuVien_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiThuVien] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLiThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLiThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiThuVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLiThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLiThuVien', N'ON'
GO
USE [QuanLiThuVien]
GO
/****** Object:  User [nghi]    Script Date: 6/13/2022 2:53:13 AM ******/
CREATE USER [nghi] FOR LOGIN [nghi] WITH DEFAULT_SCHEMA=[nghi]
GO
/****** Object:  User [ad]    Script Date: 6/13/2022 2:53:13 AM ******/
CREATE USER [ad] FOR LOGIN [ad] WITH DEFAULT_SCHEMA=[ad]
GO
/****** Object:  DatabaseRole [Thuthu]    Script Date: 6/13/2022 2:53:13 AM ******/
CREATE ROLE [Thuthu]
GO
/****** Object:  DatabaseRole [admin]    Script Date: 6/13/2022 2:53:13 AM ******/
CREATE ROLE [admin]
GO
ALTER ROLE [Thuthu] ADD MEMBER [nghi]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [nghi]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [nghi]
GO
ALTER ROLE [db_datareader] ADD MEMBER [nghi]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [nghi]
GO
ALTER ROLE [admin] ADD MEMBER [ad]
GO
ALTER ROLE [db_owner] ADD MEMBER [ad]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Thuthu]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Thuthu]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Thuthu]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Thuthu]
GO
ALTER ROLE [db_owner] ADD MEMBER [admin]
GO
/****** Object:  Schema [ad]    Script Date: 6/13/2022 2:53:13 AM ******/
CREATE SCHEMA [ad]
GO
/****** Object:  Schema [nghi]    Script Date: 6/13/2022 2:53:13 AM ******/
CREATE SCHEMA [nghi]
GO
/****** Object:  Table [dbo].[CT_PHIEUMUONTRA]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUMUONTRA](
	[MAPMT] [nvarchar](10) NOT NULL,
	[MAS] [nvarchar](10) NOT NULL,
	[NGAYTRA] [date] NULL,
	[GIAHAN] [bit] NOT NULL,
	[PHIPHAT] [money] NULL,
	[GHICHU] [ntext] NULL,
	[MATT] [nvarchar](10) NULL,
 CONSTRAINT [PK_CT_PHIEUMUONGTRA] PRIMARY KEY CLUSTERED 
(
	[MAPMT] ASC,
	[MAS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAP](
	[MAPN] [nvarchar](10) NOT NULL,
	[MADS] [nvarchar](10) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [money] NOT NULL,
	[MACTPN] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_CT_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MADS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CUONSACH]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUONSACH](
	[MAS] [nvarchar](10) NOT NULL,
	[MANGAN] [nvarchar](10) NULL,
	[MACTPN] [int] NOT NULL,
 CONSTRAINT [PK_CUONSACH] PRIMARY KEY CLUSTERED 
(
	[MAS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DAUSACH]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAUSACH](
	[MADS] [nvarchar](10) NOT NULL,
	[TENSACH] [nvarchar](100) NOT NULL,
	[SOTRANG] [int] NOT NULL,
	[KHOSACH] [nvarchar](3) NOT NULL CONSTRAINT [DF_DAUSACH_KHOSACH]  DEFAULT (N'Vừa'),
	[NAMXB] [int] NOT NULL CONSTRAINT [DF_DAUSACH_NAMXB]  DEFAULT ((2000)),
	[MATL] [nvarchar](10) NOT NULL,
	[MANXB] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_DAUSACH] PRIMARY KEY CLUSTERED 
(
	[MADS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MADG] [nvarchar](10) NOT NULL,
	[HOTEN] [nvarchar](100) NULL,
	[SDT] [nvarchar](10) NOT NULL,
	[GIOITINH] [nvarchar](3) NOT NULL,
	[DIACHI] [nvarchar](200) NULL,
	[NGAYSINH] [date] NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MADG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KE]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KE](
	[MAKE] [nvarchar](10) NOT NULL,
	[TENKE] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KE] PRIMARY KEY CLUSTERED 
(
	[MAKE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LEPHI]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LEPHI](
	[MATT] [nvarchar](10) NOT NULL,
	[MADG] [nvarchar](10) NOT NULL,
	[NGAYDP] [date] NOT NULL,
	[PHIHANGNAM] [money] NOT NULL,
	[NGAYBATDAU] [date] NOT NULL,
 CONSTRAINT [PK_LEPHI] PRIMARY KEY CLUSTERED 
(
	[MATT] ASC,
	[MADG] ASC,
	[NGAYDP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGAN]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGAN](
	[MANGAN] [nvarchar](10) NOT NULL,
	[MAKE] [nvarchar](10) NOT NULL,
	[TENNGAN] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NGAN] PRIMARY KEY CLUSTERED 
(
	[MANGAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MANXB] [nvarchar](10) NOT NULL,
	[TENNXB] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[MANXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUMUONTRA]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUONTRA](
	[MAPMT] [nvarchar](10) NOT NULL,
	[MADG] [nvarchar](10) NOT NULL,
	[MATT] [nvarchar](10) NOT NULL,
	[NGAYMUON] [date] NOT NULL,
	[NGAYHENTRA] [date] NOT NULL,
 CONSTRAINT [PK_PHIEUMUONTRA] PRIMARY KEY CLUSTERED 
(
	[MAPMT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [nvarchar](10) NOT NULL,
	[MATT] [nvarchar](10) NOT NULL,
	[THOIGIANLAP] [datetime] NOT NULL CONSTRAINT [DF_PHIEUNHAP_THOIGIANLAP]  DEFAULT (getdate()),
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANGTAC]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANGTAC](
	[MATG] [nvarchar](10) NOT NULL,
	[MADS] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_SANGTAC] PRIMARY KEY CLUSTERED 
(
	[MATG] ASC,
	[MADS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MATG] [nvarchar](10) NOT NULL,
	[HOTEN] [nvarchar](100) NOT NULL,
	[GIOITINH] [nvarchar](3) NOT NULL,
	[DIACHI] [nvarchar](200) NULL,
	[NGAYSINH] [date] NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MATG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MATL] [nvarchar](10) NOT NULL,
	[TENTL] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MATL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THUTHU]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUTHU](
	[MATT] [nvarchar](10) NOT NULL,
	[HOTEN] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](10) NOT NULL,
	[GIOITINH] [nvarchar](3) NOT NULL CONSTRAINT [DF_THUTHU_GIOITINH]  DEFAULT ('Nam'),
	[DIACHI] [nvarchar](200) NULL,
	[NGAYSINH] [date] NULL,
	[LUONG] [money] NOT NULL CONSTRAINT [DF_THUTHU_LUONG]  DEFAULT ((1000000)),
	[TRANGTHAINGHI] [bit] NOT NULL CONSTRAINT [DF_THUTHU_TRANGTHAINGHI]  DEFAULT ((0)),
 CONSTRAINT [PK_THUTHU] PRIMARY KEY CLUSTERED 
(
	[MATT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DAUSACH] ([MADS], [TENSACH], [SOTRANG], [KHOSACH], [NAMXB], [MATL], [MANXB]) VALUES (N'DS01', N'Hoang tưởng', 129, N'Lớn', 2022, N'TL01', N'NXB01')
INSERT [dbo].[KE] ([MAKE], [TENKE]) VALUES (N'K01', N'Kệ số 1')
INSERT [dbo].[KE] ([MAKE], [TENKE]) VALUES (N'K02', N'Kệ số 2')
INSERT [dbo].[KE] ([MAKE], [TENKE]) VALUES (N'K03', N'Kệ số 3')
INSERT [dbo].[KE] ([MAKE], [TENKE]) VALUES (N'K04', N'Kệ số 4')
INSERT [dbo].[NGAN] ([MANGAN], [MAKE], [TENNGAN]) VALUES (N'N01', N'K01', N'Ngăn số 1')
INSERT [dbo].[NGAN] ([MANGAN], [MAKE], [TENNGAN]) VALUES (N'N02', N'K01', N'Ngăn số 2')
INSERT [dbo].[NGAN] ([MANGAN], [MAKE], [TENNGAN]) VALUES (N'N03', N'K01', N'Ngăn số 3')
INSERT [dbo].[NGAN] ([MANGAN], [MAKE], [TENNGAN]) VALUES (N'N04', N'K01', N'Ngăn số 4')
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [DIACHI]) VALUES (N'NXB01', N'Kim Đồng', N'12 Đường Láng, Thanh Xuân, Hà Nội')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MATT], [THOIGIANLAP]) VALUES (N'PN01', N'TT01', CAST(N'2022-05-31 02:40:08.667' AS DateTime))
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MATT], [THOIGIANLAP]) VALUES (N'PN02', N'TT01', CAST(N'2022-06-08 15:42:34.603' AS DateTime))
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MATT], [THOIGIANLAP]) VALUES (N'PN03', N'TT01', CAST(N'2022-06-08 15:44:19.183' AS DateTime))
INSERT [dbo].[TACGIA] ([MATG], [HOTEN], [GIOITINH], [DIACHI], [NGAYSINH]) VALUES (N'1', N'quan', N'nam', N'binh thuan', CAST(N'2000-01-01' AS Date))
INSERT [dbo].[TACGIA] ([MATG], [HOTEN], [GIOITINH], [DIACHI], [NGAYSINH]) VALUES (N'3', N'tu', N'nam', N'aa', CAST(N'2000-01-01' AS Date))
INSERT [dbo].[THELOAI] ([MATL], [TENTL]) VALUES (N'TL01', N'Tình cảm')
INSERT [dbo].[THUTHU] ([MATT], [HOTEN], [SDT], [GIOITINH], [DIACHI], [NGAYSINH], [LUONG], [TRANGTHAINGHI]) VALUES (N'TT01', N'Nguyễn Thanh Nghị', N'0123123123', N'Nam', N'20 Quang Trung, Thủ Đức, Hồ Chí Minh', CAST(N'2001-04-01' AS Date), 2000000.0000, 0)
/****** Object:  Index [UK_MACTPN]    Script Date: 6/13/2022 2:53:13 AM ******/
ALTER TABLE [dbo].[CT_PHIEUNHAP] ADD  CONSTRAINT [UK_MACTPN] UNIQUE NONCLUSTERED 
(
	[MACTPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_TENNXB]    Script Date: 6/13/2022 2:53:13 AM ******/
ALTER TABLE [dbo].[NHAXUATBAN] ADD  CONSTRAINT [UK_TENNXB] UNIQUE NONCLUSTERED 
(
	[TENNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_TENTL]    Script Date: 6/13/2022 2:53:13 AM ******/
ALTER TABLE [dbo].[THELOAI] ADD  CONSTRAINT [UK_TENTL] UNIQUE NONCLUSTERED 
(
	[TENTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_PHIEUMUONTRA] ADD  CONSTRAINT [DF_CT_PHIEUMUONGTRA_PHIPHAT]  DEFAULT ((0)) FOR [PHIPHAT]
GO
ALTER TABLE [dbo].[DOCGIA] ADD  CONSTRAINT [DF_DOCGIA_GIOITINH]  DEFAULT ('Nam') FOR [GIOITINH]
GO
ALTER TABLE [dbo].[PHIEUMUONTRA] ADD  CONSTRAINT [DF_PHIEUMUONTRA_NGAYMUON]  DEFAULT (getdate()) FOR [NGAYMUON]
GO
ALTER TABLE [dbo].[CT_PHIEUMUONTRA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUONTRA_CUONSACH] FOREIGN KEY([MAS])
REFERENCES [dbo].[CUONSACH] ([MAS])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUMUONTRA] CHECK CONSTRAINT [FK_CT_PHIEUMUONTRA_CUONSACH]
GO
ALTER TABLE [dbo].[CT_PHIEUMUONTRA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUONTRA_PHIEUMUONTRA] FOREIGN KEY([MAPMT])
REFERENCES [dbo].[PHIEUMUONTRA] ([MAPMT])
GO
ALTER TABLE [dbo].[CT_PHIEUMUONTRA] CHECK CONSTRAINT [FK_CT_PHIEUMUONTRA_PHIEUMUONTRA]
GO
ALTER TABLE [dbo].[CT_PHIEUMUONTRA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUONTRA_THUTHU] FOREIGN KEY([MATT])
REFERENCES [dbo].[THUTHU] ([MATT])
GO
ALTER TABLE [dbo].[CT_PHIEUMUONTRA] CHECK CONSTRAINT [FK_CT_PHIEUMUONTRA_THUTHU]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAP_DAUSACH] FOREIGN KEY([MADS])
REFERENCES [dbo].[DAUSACH] ([MADS])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [FK_CT_PHIEUNHAP_DAUSACH]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PHIEUNHAP] ([MAPN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [FK_CT_PHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CUONSACH]  WITH CHECK ADD  CONSTRAINT [FK_CUONSACH_CT_PHIEUNHAP] FOREIGN KEY([MACTPN])
REFERENCES [dbo].[CT_PHIEUNHAP] ([MACTPN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CUONSACH] CHECK CONSTRAINT [FK_CUONSACH_CT_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CUONSACH]  WITH CHECK ADD  CONSTRAINT [FK_CUONSACH_NGAN] FOREIGN KEY([MANGAN])
REFERENCES [dbo].[NGAN] ([MANGAN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CUONSACH] CHECK CONSTRAINT [FK_CUONSACH_NGAN]
GO
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD  CONSTRAINT [FK_DAUSACH_NHAXUATBAN] FOREIGN KEY([MANXB])
REFERENCES [dbo].[NHAXUATBAN] ([MANXB])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DAUSACH] CHECK CONSTRAINT [FK_DAUSACH_NHAXUATBAN]
GO
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD  CONSTRAINT [FK_DAUSACH_THELOAI] FOREIGN KEY([MATL])
REFERENCES [dbo].[THELOAI] ([MATL])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DAUSACH] CHECK CONSTRAINT [FK_DAUSACH_THELOAI]
GO
ALTER TABLE [dbo].[LEPHI]  WITH CHECK ADD  CONSTRAINT [FK_LEPHI_DOCGIA] FOREIGN KEY([MADG])
REFERENCES [dbo].[DOCGIA] ([MADG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LEPHI] CHECK CONSTRAINT [FK_LEPHI_DOCGIA]
GO
ALTER TABLE [dbo].[LEPHI]  WITH CHECK ADD  CONSTRAINT [FK_LEPHI_THUTHU] FOREIGN KEY([MATT])
REFERENCES [dbo].[THUTHU] ([MATT])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LEPHI] CHECK CONSTRAINT [FK_LEPHI_THUTHU]
GO
ALTER TABLE [dbo].[NGAN]  WITH CHECK ADD  CONSTRAINT [FK_NGAN_KE] FOREIGN KEY([MAKE])
REFERENCES [dbo].[KE] ([MAKE])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NGAN] CHECK CONSTRAINT [FK_NGAN_KE]
GO
ALTER TABLE [dbo].[PHIEUMUONTRA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUONTRA_DOCGIA] FOREIGN KEY([MADG])
REFERENCES [dbo].[DOCGIA] ([MADG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PHIEUMUONTRA] CHECK CONSTRAINT [FK_PHIEUMUONTRA_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUONTRA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUONTRA_THUTHU] FOREIGN KEY([MATT])
REFERENCES [dbo].[THUTHU] ([MATT])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PHIEUMUONTRA] CHECK CONSTRAINT [FK_PHIEUMUONTRA_THUTHU]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_THUTHU] FOREIGN KEY([MATT])
REFERENCES [dbo].[THUTHU] ([MATT])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_THUTHU]
GO
ALTER TABLE [dbo].[SANGTAC]  WITH CHECK ADD  CONSTRAINT [FK_SANGTAC_DAUSACH] FOREIGN KEY([MADS])
REFERENCES [dbo].[DAUSACH] ([MADS])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SANGTAC] CHECK CONSTRAINT [FK_SANGTAC_DAUSACH]
GO
ALTER TABLE [dbo].[SANGTAC]  WITH CHECK ADD  CONSTRAINT [FK_SANGTAC_TACGIA] FOREIGN KEY([MATG])
REFERENCES [dbo].[TACGIA] ([MATG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SANGTAC] CHECK CONSTRAINT [FK_SANGTAC_TACGIA]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [CK_DONGIA] CHECK  (([DONGIA]>(0)))
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [CK_DONGIA]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [CK_SOLUONG] CHECK  (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [CK_SOLUONG]
GO
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD  CONSTRAINT [CK_KHOSACH] CHECK  (([KHOSACH]=N'Lớn' OR [KHOSACH]=N'Nhỏ' OR [KHOSACH]=N'Vừa'))
GO
ALTER TABLE [dbo].[DAUSACH] CHECK CONSTRAINT [CK_KHOSACH]
GO
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD  CONSTRAINT [CK_SOTRANG] CHECK  (([SOTRANG]>(0)))
GO
ALTER TABLE [dbo].[DAUSACH] CHECK CONSTRAINT [CK_SOTRANG]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [CK_GT] CHECK  (([GIOITINH]=N'Nữ' OR [GIOITINH]='Nam'))
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [CK_GT]
GO
ALTER TABLE [dbo].[LEPHI]  WITH CHECK ADD  CONSTRAINT [CK_LEPHI] CHECK  (([PHIHANGNAM]>(0)))
GO
ALTER TABLE [dbo].[LEPHI] CHECK CONSTRAINT [CK_LEPHI]
GO
ALTER TABLE [dbo].[PHIEUMUONTRA]  WITH CHECK ADD  CONSTRAINT [CK_NGAYHENTRA] CHECK  (([NGAYHENTRA]>[NGAYMUON]))
GO
ALTER TABLE [dbo].[PHIEUMUONTRA] CHECK CONSTRAINT [CK_NGAYHENTRA]
GO
ALTER TABLE [dbo].[PHIEUMUONTRA]  WITH CHECK ADD  CONSTRAINT [CK_PHIEUMUONTRA1] CHECK  ((datediff(day,[NGAYMUON],[NGAYHENTRA])<=(7)))
GO
ALTER TABLE [dbo].[PHIEUMUONTRA] CHECK CONSTRAINT [CK_PHIEUMUONTRA1]
GO
ALTER TABLE [dbo].[TACGIA]  WITH CHECK ADD  CONSTRAINT [CK_GIOITINH] CHECK  (([GIOITINH]=N'Nữ' OR [GIOITINH]='Nam'))
GO
ALTER TABLE [dbo].[TACGIA] CHECK CONSTRAINT [CK_GIOITINH]
GO
ALTER TABLE [dbo].[THUTHU]  WITH CHECK ADD  CONSTRAINT [CK_GT1] CHECK  (([GIOITINH]=N'Nữ' OR [GIOITINH]='Nam'))
GO
ALTER TABLE [dbo].[THUTHU] CHECK CONSTRAINT [CK_GT1]
GO
ALTER TABLE [dbo].[THUTHU]  WITH CHECK ADD  CONSTRAINT [CK_LUONG] CHECK  (([LUONG]>(0)))
GO
ALTER TABLE [dbo].[THUTHU] CHECK CONSTRAINT [CK_LUONG]
GO
/****** Object:  StoredProcedure [dbo].[BACK_UP_DIFF]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BACK_UP_DIFF] @subtenjob varchar(3),@f_type int
,@f_interval int,@subday_type int,@subday_interval int,
@f_relative_interval int,@f_recurrence_factor int, @ngay_bat_dau int, 
@ngay_ket_thuc int,@gio_bat_dau int, @gio_ket_thuc int
as
BEGIN TRANSACTION
DECLARE @ReturnCode INT
SELECT @ReturnCode = 0
/****** Object:  JobCategory [Database Maintenance]    Script Date: 6/3/2022 5:46:18 PM ******/
IF NOT EXISTS (SELECT name FROM msdb.dbo.syscategories WHERE name=N'Database Maintenance' AND category_class=1)
BEGIN
EXEC @ReturnCode = msdb.dbo.sp_add_category @class=N'JOB', @type=N'LOCAL', @name=N'Database Maintenance'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

END
DECLARE @jobId BINARY(16)
DECLARE @tenMoi VARCHAR(50)
SET @tenMoi = CONCAT('MaintenancePlan1.Subplan_', @subtenjob)
EXEC @ReturnCode =  msdb.dbo.sp_add_job @job_name=@tenMoi,
		@enabled=1, 
		@notify_level_eventlog=2, 
		@notify_level_email=0, 
		@notify_level_netsend=0, 
		@notify_level_page=0, 
		@delete_level=0, 
		@description=N'No description available.', 
		@category_name=N'Database Maintenance', 
		@owner_login_name=N'sa', @job_id = @jobId OUTPUT
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [Subplan_1]    Script Date: 6/3/2022 5:46:18 PM ******/
DECLARE @sub_plan_moi VARCHAR(50)
SET @sub_plan_moi = CONCAT('Subplan_', @subtenjob) 
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=@sub_plan_moi,
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'SSIS', 
		@command=N'/Server "$(ESCAPE_NONE(SRVR))" /SQL "Maintenance Plans\MaintenancePlan1" /set "\Package\Subplan_1.Disable;false"', 
		@flags=0
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_update_job @job_id = @jobId, @start_step_id = 1
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobschedule @job_id=@jobId, @name=N'MaintenancePlan1.Subplan_1', 
		@enabled=1, 
		@freq_type=@f_type, 
		@freq_interval=@f_interval, 
		@freq_subday_type=@subday_type, 
		@freq_subday_interval=@subday_interval, 
		@freq_relative_interval=@f_relative_interval, 
		@freq_recurrence_factor=@f_recurrence_factor, 
		@active_start_date=@ngay_bat_dau, 
		@active_end_date=@ngay_ket_thuc, 
		@active_start_time=@gio_bat_dau, 
		@active_end_time=@gio_ket_thuc, 
		@schedule_uid=N'1adb5ca5-3433-45f9-87de-713e44af8522'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobserver @job_id = @jobId, @server_name = N'(local)'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
COMMIT TRANSACTION
GOTO EndSave
QuitWithRollback:
    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
EndSave:

GO
/****** Object:  StoredProcedure [dbo].[BACK_UP_FULL]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[BACK_UP_FULL] @subtenjob varchar(3),@f_type int
,@f_interval int,@subday_type int,@subday_interval int,
@f_relative_interval int,@f_recurrence_factor int, @ngay_bat_dau int, 
@ngay_ket_thuc int,@gio_bat_dau int, @gio_ket_thuc int
as
BEGIN TRANSACTION
DECLARE @ReturnCode INT
SELECT @ReturnCode = 0
/****** Object:  JobCategory [Database Maintenance]    Script Date: 6/3/2022 5:06:35 PM ******/
IF NOT EXISTS (SELECT name FROM msdb.dbo.syscategories WHERE name=N'Database Maintenance' AND category_class=1)
BEGIN
EXEC @ReturnCode = msdb.dbo.sp_add_category @class=N'JOB', @type=N'LOCAL', @name=N'Database Maintenance'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

END

DECLARE @jobId BINARY(16)
DECLARE @tenMoi VARCHAR(50)
SET @tenMoi = CONCAT('MaintenancePlan.Subplan_', @subtenjob)
EXEC @ReturnCode =  msdb.dbo.sp_add_job @job_name=@tenMoi,
		@enabled=1, 
		@notify_level_eventlog=2, 
		@notify_level_email=0, 
		@notify_level_netsend=0, 
		@notify_level_page=0, 
		@delete_level=0, 
		@description=N'No description available.', 
		@category_name=N'Database Maintenance', 
		@owner_login_name=N'sa', @job_id = @jobId OUTPUT
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [Subplan_1]    Script Date: 6/3/2022 5:06:35 PM ******/
DECLARE @sub_plan_moi VARCHAR(50)
SET @sub_plan_moi = CONCAT('Subplan_', @subtenjob) 
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=@sub_plan_moi,
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'SSIS', 
		@command=N'/Server "$(ESCAPE_NONE(SRVR))" /SQL "Maintenance Plans\MaintenancePlan" /set "\Package\Subplan_1.Disable;false"', 
		@flags=0
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_update_job @job_id = @jobId, @start_step_id = 1
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobschedule @job_id=@jobId, @name=N'MaintenancePlan', 
		@enabled=1, 
		@freq_type=@f_type, 
		@freq_interval=@f_interval, 
		@freq_subday_type=@subday_type, 
		@freq_subday_interval=@subday_interval, 
		@freq_relative_interval=@f_relative_interval, 
		@freq_recurrence_factor=@f_recurrence_factor, 
		@active_start_date=@ngay_bat_dau, 
		@active_end_date=@ngay_ket_thuc, 
		@active_start_time=@gio_bat_dau, 
		@active_end_time=@gio_ket_thuc, 
		@schedule_uid=N'f0a8afbf-3955-4dff-8044-890cd5254c04'        ----------------------------copy cái  @schedule_uid của cái job tạo sẵn của maintenence plan bỏ vào
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobserver @job_id = @jobId, @server_name = N'(local)'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
COMMIT TRANSACTION
GOTO EndSave
QuitWithRollback:
    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
EndSave:
GO
/****** Object:  StoredProcedure [dbo].[sp_generateDifferentialBackups]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_generateDifferentialBackups]  
   @strBackupPath NVARCHAR (25) ='D:\bktest\' --variable for location of DIFFERENTIAL backups  
AS  
SET NOCOUNT ON   
-- Get the name of all user databases    
DECLARE @strTimeStamp NVARCHAR(12)   --variable for timestamp value   
DECLARE @strSQL NVARCHAR(100)        -- used for generating dynamic SQL statements   
DECLARE @databaseName NVARCHAR(128)  -- used as variable to store database names   
set  @databaseName='quanlithuvien'

 
BEGIN   
   PRINT 'Checking for the latest FULL database backup for: [' + @databaseName +']'  
       
   DECLARE @strphysical_device_name NVARCHAR(400) -- variable for physical_device_name   


   -- Reads the MSDB database to check for the latest FULL database backup         
   set @strphysical_device_name= (SELECT TOP 1 physical_device_name   
   FROM msdb.dbo.backupset a INNER JOIN msdb.dbo.backupmediafamily b      
   ON a.media_set_id = b.media_set_id      
   WHERE database_name='' + @databaseName + ''   
   AND type='D'   
   ORDER BY backup_finish_date desc)
   --Check if the database does not have any FULL backups at all  
	if (@strphysical_device_name is null)
   BEGIN  
	  return 0;
   END  
   ELSE     
   --If the database has FULL backups,  
   BEGIN   
      DECLARE @result INT   
      EXEC xp_fileexist @strphysical_device_name, @result output    
      IF (@result = 1)  --@result will return 1 if the specified file exists, if it doesn't, it will return 0   
      BEGIN   
         SET @strTimeStamp=(SELECT FORMAT (getdate(), 'yyyyMMddHHmmss')) 
         SET @strTimeStamp=@strTimeStamp + REPLACE(CONVERT(CHAR(8), GETDATE(), 108),':','')   
         EXEC ('BACKUP DATABASE ' + @databaseName + ' TO DISK=''' + @strBackupPath + @databaseName + '_DIFF_' + @strTimeStamp + '.BAK'' WITH INIT, DIFFERENTIAL, DESCRIPTION=''DIFFERENTIAL Backup for ' + @databasename + ' database''') -- change this value should you decide to change the backup type to something other than differential    
         PRINT '=================database backup: ' + @strphysical_device_name   
         PRINT 'DIFFERENTIAL database backup: ' + @strBackupPath + @databaseName + '_DIFF_' + @strTimeStamp + '.BAK'   
		RETURN 1;
      END   
      ELSE  
		BEGIN 
         PRINT  'WARNING: FULL database backup file is missing. Generate the FULL database backup first. Aborting DIFFERENTIAL backup command.'   
			RETURN 0;
		END
	END  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getpermissons]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_getpermissons] @name nvarchar(50) as
SELECT dp.name AS memberof, us.name
FROM     sys.sysusers AS us RIGHT OUTER JOIN
                  sys.database_role_members AS rm ON us.uid = rm.member_principal_id INNER JOIN
                  sys.database_principals AS dp ON rm.role_principal_id = dp.principal_id AND us.uid NOT IN
                      (SELECT principal_id
                       FROM      sys.database_principals
                       WHERE   (type = 'S')) AND us.name <> 'dbo' and us.name=@name
GO
/****** Object:  StoredProcedure [dbo].[sp_getrole]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_getrole] as
select * from sys.database_principals where type='R' and principal_id > 0 and principal_id <16384
GO
/****** Object:  StoredProcedure [dbo].[sp_getrolefromname]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_getrolefromname] @name nvarchar(50) as
SELECT sys.syslogins.name,
                      (SELECT name
                       FROM      sys.sysusers
                       WHERE   (uid = sys.sysmembers.groupuid)) AS NHOM, sys.syslogins.createdate
FROM     sys.sysusers AS sysusers_1 INNER JOIN
                  sys.sysmembers ON sysusers_1.uid = sys.sysmembers.memberuid INNER JOIN
                  sys.syslogins ON sysusers_1.sid = sys.syslogins.sid
WHERE  (sys.sysmembers.groupuid < 16383) and sys.syslogins.name = @name
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEMTRA_QUYEN]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KIEMTRA_QUYEN] (@LOGINNAME NVARCHAR(100))
AS
	DECLARE @UID INT
	SELECT @UID= uid FROM sys.sysusers 
  	WHERE sid = SUSER_SID(@LOGINNAME)
	IF ((SELECT TENNHOM=NAME FROM sys.sysusers
    	WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@UID)) = 'admin')
		RETURN 1
	RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QuanLiThuVien'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'SA'
  BEGIN 
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  END
RETURN 0  -- THANH CONG
GO
/****** Object:  StoredProcedure [dbo].[SP_TUSINH_MACUONSACH_TANGDAN]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TUSINH_MACUONSACH_TANGDAN](
@MA_NEXT NVARCHAR(10) output
)
AS
BEGIN
	DECLARE @MAX INT
	SELECT @MAX = COUNT(MAS) +1 FROM CUONSACH
	IF @MAX < 10
		SET @MA_NEXT = 'S' + RIGHT('0'+ CAST(@MAX AS NVARCHAR(9)),9)
	ELSE IF @MAX>=10
		SET @MA_NEXT = 'S' + RIGHT(CAST(@MAX AS NVARCHAR(9)),9)
	WHILE(EXISTS (SELECT MAS FROM CUONSACH WHERE @MA_NEXT = MAS))
	BEGIN
		SELECT @MAX = @MAX +1
		IF @MAX < 10
		SET @MA_NEXT = 'S' + RIGHT('0'+ CAST(@MAX AS NVARCHAR(9)),9)
	ELSE IF @MAX>=10
		SET @MA_NEXT = 'S' + RIGHT(CAST(@MAX AS NVARCHAR(9)),9)
	END
END

GO
/****** Object:  StoredProcedure [dbo].[Xoa_Login]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_Login]
  @LGNAME VARCHAR(50),
  @USRNAME VARCHAR(50)
  
AS
  EXEC SP_DROPUSER @USRNAME
  EXEC SP_DROPLOGIN @LGNAME
GO
/****** Object:  Trigger [dbo].[TR_SUA_CTPHIEUNHAP]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_SUA_CTPHIEUNHAP]
ON  [dbo].[CT_PHIEUNHAP]  
AFTER  UPDATE
AS
BEGIN
	
	DECLARE @SOLUONGNHAP INT
	DECLARE @SOLUONGXOA INT
	DECLARE @MACTPN INT
	SELECT @SOLUONGNHAP = SOLUONG, @MACTPN = MACTPN FROM inserted
	SELECT @SOLUONGXOA = SOLUONG FROM deleted
	
	IF(@SOLUONGNHAP != @SOLUONGXOA)
		BEGIN

		IF EXISTS (SELECT * FROM CUONSACH WHERE @MACTPN = MACTPN AND MANGAN IS NOT NULL)
			BEGIN
				RAISERROR('Cuốn sách của phiếu nhập đã được xếp lên kệ! Không được sửa số lượng của của chi tiết phiếu nhập', 16, 1)
				UPDATE CT_PHIEUNHAP SET SOLUONG = @SOLUONGXOA
				RETURN
			END

		SET XACT_ABORT ON
		BEGIN TRANSACTION
		BEGIN TRY
			IF (@SOLUONGNHAP - @SOLUONGXOA > 0)
				BEGIN
					
					SET @SOLUONGNHAP = @SOLUONGNHAP - @SOLUONGXOA
					
					ALTER TABLE CUONSACH DISABLE TRIGGER TR_THEM_CUONSACH
					WHILE(@SOLUONGNHAP !=0)
					BEGIN
						DECLARE @MASACH NVARCHAR(10)
						EXEC SP_TUSINH_MACUONSACH_TANGDAN @MASACH OUTPUT
						INSERT INTO CUONSACH (MAS,MANGAN,MACTPN) VALUES(@MASACH, NULL, @MACTPN)
						SET @SOLUONGNHAP = @SOLUONGNHAP -1
					END
					ALTER TABLE CUONSACH ENABLE TRIGGER TR_THEM_CUONSACH
				END
			ELSE IF (@SOLUONGNHAP - @SOLUONGXOA < 0)
				BEGIN
		--			SET @SOLUONGNHAP =  

					ALTER TABLE CUONSACH DISABLE TRIGGER TR_XOA_CUONSACH
					DELETE CUONSACH WHERE MACTPN = @MACTPN
					ALTER TABLE CUONSACH ENABLE TRIGGER TR_XOA_CUONSACH

					ALTER TABLE CUONSACH DISABLE TRIGGER TR_THEM_CUONSACH
					WHILE(@SOLUONGNHAP !=0)
						BEGIN
							DECLARE @MASACH1 NVARCHAR(10)
							EXEC SP_TUSINH_MACUONSACH_TANGDAN @MASACH1 OUTPUT
							INSERT INTO CUONSACH (MAS,MANGAN,MACTPN) VALUES(@MASACH1, NULL, @MACTPN)
							SET @SOLUONGNHAP = @SOLUONGNHAP -1
						END
					ALTER TABLE CUONSACH ENABLE TRIGGER TR_THEM_CUONSACH

				END	
				
			COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		   DECLARE @ErrorMessage VARCHAR(2000)
		   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
		   RAISERROR(@ErrorMessage, 16, 1)
		END CATCH
	END
END
GO
/****** Object:  Trigger [dbo].[TR_THEM_CTPHIEUNHAP]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_THEM_CTPHIEUNHAP]
ON  [dbo].[CT_PHIEUNHAP]  
AFTER  INSERT
AS
BEGIN
	DECLARE @SOLUONG INT
	DECLARE @MACTPN INT
	SELECT @SOLUONG = SOLUONG, @MACTPN = MACTPN FROM inserted

	SET XACT_ABORT ON
	BEGIN TRANSACTION
	BEGIN TRY
		ALTER TABLE CUONSACH DISABLE TRIGGER TR_THEM_CUONSACH 
		WHILE(@SOLUONG !=0)
		BEGIN
			DECLARE @MASACH NVARCHAR(10)
			EXEC SP_TUSINH_MACUONSACH_TANGDAN @MASACH OUTPUT
			INSERT INTO CUONSACH (MAS,MANGAN,MACTPN) VALUES(@MASACH, NULL, @MACTPN)
			SET @SOLUONG = @SOLUONG -1
		END
		ALTER TABLE CUONSACH ENABLE TRIGGER TR_THEM_CUONSACH
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	   DECLARE @ErrorMessage VARCHAR(2000)
	   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
	   RAISERROR(@ErrorMessage, 16, 1)
	END CATCH
END
GO
/****** Object:  Trigger [dbo].[TR_XOA_CTPHIEUNHAP]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_XOA_CTPHIEUNHAP]
ON  [dbo].[CT_PHIEUNHAP]  
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @MACTPN INT
	SELECT  @MACTPN = MACTPN FROM deleted

	IF EXISTS (SELECT * FROM CUONSACH WHERE @MACTPN = MACTPN AND MANGAN IS NOT NULL)
		BEGIN
			RAISERROR('Cuốn sách của phiếu nhập đã được xếp lên kệ! Không được xóa phiếu nhập', 16, 1)
			RETURN
		END

	SET XACT_ABORT ON
	BEGIN TRANSACTION
	BEGIN TRY
		ALTER TABLE CUONSACH DISABLE TRIGGER TR_XOA_CUONSACH
		DELETE CUONSACH WHERE MACTPN = @MACTPN
		ALTER TABLE CUONSACH ENABLE TRIGGER TR_XOA_CUONSACH
		DELETE CT_PHIEUNHAP WHERE MACTPN = @MACTPN
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	   DECLARE @ErrorMessage VARCHAR(2000)
	   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
	   RAISERROR(@ErrorMessage, 16, 1)
	END CATCH
END
GO
/****** Object:  Trigger [dbo].[TR_SUA_CUONSACH]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_SUA_CUONSACH]
ON [dbo].[CUONSACH]
AFTER UPDATE
AS
BEGIN
	DECLARE @MACTPN_MOI INT,@MACTPN_CU INT, @SOLUONG_MOI INT, @SOLUONG_CU INT
	SELECT @MACTPN_MOI = MACTPN FROM inserted
	SELECT @MACTPN_CU = MACTPN FROM deleted
	SELECT @SOLUONG_MOI = SOLUONG FROM CT_PHIEUNHAP WHERE MACTPN = @MACTPN_MOI
	SELECT @SOLUONG_CU = SOLUONG FROM CT_PHIEUNHAP WHERE MACTPN = @MACTPN_CU 
	IF (@MACTPN_MOI !=@MACTPN_CU)
		BEGIN
			SET XACT_ABORT ON
			BEGIN TRANSACTION
			BEGIN TRY
				ALTER TABLE CT_PHIEUNHAP DISABLE TRIGGER TR_SUA_CTPHIEUNHAP 
				UPDATE CT_PHIEUNHAP SET SOLUONG = @SOLUONG_MOI+1 WHERE  @MACTPN_MOI = MACTPN

				IF (@SOLUONG_CU = 1)
					DELETE CT_PHIEUNHAP WHERE MACTPN = @MACTPN_CU
				ELSE
					UPDATE CT_PHIEUNHAP SET SOLUONG = @SOLUONG_CU-1 WHERE  @MACTPN_CU = MACTPN

				ALTER TABLE CT_PHIEUNHAP ENABLE TRIGGER TR_SUA_CTPHIEUNHAP
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
			   DECLARE @ErrorMessage VARCHAR(2000)
			   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
			   RAISERROR(@ErrorMessage, 16, 1)
			END CATCH
		END
END
GO
/****** Object:  Trigger [dbo].[TR_THEM_CUONSACH]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_THEM_CUONSACH]
ON [dbo].[CUONSACH]
AFTER INSERT
AS
BEGIN
	DECLARE @MASACH NVARCHAR(10)
	DECLARE @MACTPN INT, @SOLUONG INT
	SELECT @MASACH = MAS, @MACTPN = MACTPN FROM inserted
	SELECT @SOLUONG = SOLUONG FROM CT_PHIEUNHAP WHERE MACTPN = @MACTPN
	ALTER TABLE CT_PHIEUNHAP DISABLE TRIGGER TR_SUA_CTPHIEUNHAP 
	UPDATE CT_PHIEUNHAP SET SOLUONG = @SOLUONG+1 WHERE MACTPN = @MACTPN
	ALTER TABLE CT_PHIEUNHAP ENABLE TRIGGER TR_SUA_CTPHIEUNHAP
END
GO
/****** Object:  Trigger [dbo].[TR_XOA_CUONSACH]    Script Date: 6/13/2022 2:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_XOA_CUONSACH]
ON [dbo].[CUONSACH]
AFTER DELETE
AS 
BEGIN
	DECLARE @MACTPN INT, @SOLUONG INT
	SELECT @MACTPN = MACTPN FROM deleted
	SELECT @SOLUONG = SOLUONG FROM CT_PHIEUNHAP WHERE MACTPN = @MACTPN

	IF (@SOLUONG = 1)
		BEGIN
			DELETE CT_PHIEUNHAP WHERE MACTPN = @MACTPN
		END
	ELSE
		BEGIN
			ALTER TABLE CT_PHIEUNHAP DISABLE TRIGGER TR_SUA_CTPHIEUNHAP 
			UPDATE CT_PHIEUNHAP SET SOLUONG = @SOLUONG-1 WHERE  @MACTPN = MACTPN
			ALTER TABLE CT_PHIEUNHAP ENABLE TRIGGER TR_SUA_CTPHIEUNHAP
		END
				
END
GO
USE [master]
GO
ALTER DATABASE [QuanLiThuVien] SET  READ_WRITE 
GO
