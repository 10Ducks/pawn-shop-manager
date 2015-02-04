USE [PawnShop]
GO
/****** Object:  Table [dbo].[tbl_Loai_Hang]    Script Date: 02/04/2015 20:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Loai_Hang](
	[loaihang_id] [int] NOT NULL,
	[loaihang_ten] [varchar](10) NULL,
 CONSTRAINT [Pk_tbl_Loai_Hang_0] PRIMARY KEY CLUSTERED 
(
	[loaihang_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tên của loại hàng hóa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Loai_Hang', @level2type=N'COLUMN',@level2name=N'loaihang_ten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Loại hàng hóa, vd: vàng, xe' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Loai_Hang'
GO
/****** Object:  Table [dbo].[tbl_Hop_Dong]    Script Date: 02/04/2015 20:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Hop_Dong](
	[hd_id] [int] IDENTITY(1,1) NOT NULL,
	[hd_maBN] [int] NOT NULL,
	[hd_ngaytao] [datetime] NOT NULL,
	[hd_trangthai] [int] NULL,
	[hd_baomat] [bit] NULL,
	[hd_tien_cam] [float] NULL,
	[hd_kh_CMND] [varchar](20) NULL,
	[delete_flag] [bit] NOT NULL,
	[hd_kh_Ten] [nvarchar](50) NOT NULL,
	[hd_kh_DienThoai] [varchar](15) NULL,
	[hd_kh_Diachi] [nvarchar](max) NULL,
 CONSTRAINT [Pk_tbl_Hop_Dong] PRIMARY KEY CLUSTERED 
(
	[hd_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [Idx_tbl_Hop_Dong] UNIQUE NONCLUSTERED 
(
	[hd_maBN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'mã của hd' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hop_Dong', @level2type=N'COLUMN',@level2name=N'hd_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'mã biên nhận tùy thuộc vào năm' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hop_Dong', @level2type=N'COLUMN',@level2name=N'hd_maBN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Thời gian tạo hợp đồng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hop_Dong', @level2type=N'COLUMN',@level2name=N'hd_ngaytao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'trạng thái của hợp đồng
chưa thanh toán
đã thanh toán (chuộc)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hop_Dong', @level2type=N'COLUMN',@level2name=N'hd_trangthai'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Báo mất hợp đồng của khách hàng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hop_Dong', @level2type=N'COLUMN',@level2name=N'hd_baomat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tổng giá trị của hợp đồng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hop_Dong', @level2type=N'COLUMN',@level2name=N'hd_tien_cam'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'hợp đồng của khách hàng nào..' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hop_Dong', @level2type=N'COLUMN',@level2name=N'hd_kh_CMND'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Bảng hợp đồng giao dịch' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hop_Dong'
GO
/****** Object:  Table [dbo].[tbl_Thu_Chi]    Script Date: 02/04/2015 20:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Thu_Chi](
	[tc_id] [int] IDENTITY(1,1) NOT NULL,
	[tc_loai] [int] NOT NULL,
	[tc_ngaytao] [datetime] NULL,
	[tc_tien] [float] NOT NULL,
	[tc_note] [nvarchar](max) NULL,
 CONSTRAINT [Pk_tbl_Thu_Chi] PRIMARY KEY CLUSTERED 
(
	[tc_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã thu chi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Thu_Chi', @level2type=N'COLUMN',@level2name=N'tc_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Loại thu hoặc chi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Thu_Chi', @level2type=N'COLUMN',@level2name=N'tc_loai'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày thu chi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Thu_Chi', @level2type=N'COLUMN',@level2name=N'tc_ngaytao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số tiền thu chi
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Thu_Chi', @level2type=N'COLUMN',@level2name=N'tc_tien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ghi chú' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Thu_Chi', @level2type=N'COLUMN',@level2name=N'tc_note'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Bảng lưu thông tin thu chi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Thu_Chi'
GO
/****** Object:  Table [dbo].[tbl_Admin]    Script Date: 02/04/2015 20:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Admin](
	[Admin_Id] [varchar](50) NOT NULL,
	[Admin_Password] [varchar](256) NOT NULL,
 CONSTRAINT [Pk_tbl_Admin] PRIMARY KEY CLUSTERED 
(
	[Admin_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tai khoan dang nhap' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Admin', @level2type=N'COLUMN',@level2name=N'Admin_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Password cua tai khoan' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Admin', @level2type=N'COLUMN',@level2name=N'Admin_Password'
GO
/****** Object:  Table [dbo].[tbl_Tra_Lai_Truoc]    Script Date: 02/04/2015 20:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Tra_Lai_Truoc](
	[tralai_id] [int] IDENTITY(1,1) NOT NULL,
	[hd_id] [int] NOT NULL,
	[tralai_ngaytao] [datetime] NOT NULL,
	[tralai_so_ngay] [int] NULL,
	[tralai_tien] [float] NOT NULL,
	[delete_flag] [bit] NOT NULL,
 CONSTRAINT [Pk_tbl_tra_lai] PRIMARY KEY CLUSTERED 
(
	[tralai_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [idx_tbl_tra_lai] ON [dbo].[tbl_Tra_Lai_Truoc] 
(
	[hd_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'thời gian trả lãi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Tra_Lai_Truoc', @level2type=N'COLUMN',@level2name=N'tralai_ngaytao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'số ngày muốn trả' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Tra_Lai_Truoc', @level2type=N'COLUMN',@level2name=N'tralai_so_ngay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'số tiền trả' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Tra_Lai_Truoc', @level2type=N'COLUMN',@level2name=N'tralai_tien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Bảng trả lãi trước' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Tra_Lai_Truoc'
GO
/****** Object:  Table [dbo].[tbl_Them_Tien]    Script Date: 02/04/2015 20:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Them_Tien](
	[them_id] [int] IDENTITY(1,1) NOT NULL,
	[hd_id] [int] NOT NULL,
	[them_ngaytao] [datetime] NULL,
	[them_tienlai] [float] NULL,
	[them_tien] [float] NULL,
	[them_hinhthuc_tralai] [int] NULL,
	[delete_flag] [bit] NULL,
 CONSTRAINT [Pk_tbl_them_tien] PRIMARY KEY CLUSTERED 
(
	[them_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [idx_tbl_them_tien] ON [dbo].[tbl_Them_Tien] 
(
	[hd_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ngày lấy thêm tiền' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Them_Tien', @level2type=N'COLUMN',@level2name=N'them_ngaytao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Bảng lấy thêm tiền ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Them_Tien'
GO
/****** Object:  Table [dbo].[tbl_Thanh_Ly]    Script Date: 02/04/2015 20:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Thanh_Ly](
	[thanhly_id] [int] IDENTITY(1,1) NOT NULL,
	[thanhly_ngay] [datetime] NOT NULL,
	[thanhly_tien] [float] NOT NULL,
	[hd_id] [int] NULL,
 CONSTRAINT [Pk_tbl_Thanh_Ly] PRIMARY KEY CLUSTERED 
(
	[thanhly_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [idx_tbl_Thanh_Ly] UNIQUE NONCLUSTERED 
(
	[hd_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã thanh lý' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Thanh_Ly', @level2type=N'COLUMN',@level2name=N'thanhly_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày thanh lý' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Thanh_Ly', @level2type=N'COLUMN',@level2name=N'thanhly_ngay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số tiền thanh lý' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Thanh_Ly', @level2type=N'COLUMN',@level2name=N'thanhly_tien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Table lưu thông tin thanh lí của hàng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Thanh_Ly'
GO
/****** Object:  Table [dbo].[tbl_Hang_Hoa]    Script Date: 02/04/2015 20:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Hang_Hoa](
	[hang_id] [int] IDENTITY(1,1) NOT NULL,
	[hang_ten] [nvarchar](100) NOT NULL,
	[hang_soluong] [int] NULL,
	[hang_giatri] [float] NULL,
	[hang_giatri_that] [float] NULL,
	[xe_bienso] [varchar](20) NULL,
	[xe_loaixe] [varchar](100) NULL,
	[hang_chatluong] [nvarchar](50) NULL,
	[loaihang_id] [int] NULL,
	[delete_flag] [bit] NOT NULL,
 CONSTRAINT [Pk_tbl_Loai_Hang] PRIMARY KEY CLUSTERED 
(
	[hang_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [idx_tbl_Hang_Hoa] ON [dbo].[tbl_Hang_Hoa] 
(
	[loaihang_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id của mặt hàng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hang_Hoa', @level2type=N'COLUMN',@level2name=N'hang_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên của mặt hàng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hang_Hoa', @level2type=N'COLUMN',@level2name=N'hang_ten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng của mặt hàng, vd: chỉ (vàng) ...' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hang_Hoa', @level2type=N'COLUMN',@level2name=N'hang_soluong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Giá trị của mặt hàng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hang_Hoa', @level2type=N'COLUMN',@level2name=N'hang_giatri'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'giá trị thực tế của món hang
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hang_Hoa', @level2type=N'COLUMN',@level2name=N'hang_giatri_that'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nếu hàng là xe thì có biển số' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hang_Hoa', @level2type=N'COLUMN',@level2name=N'xe_bienso'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Loại xe: AB, Nouvou ...' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hang_Hoa', @level2type=N'COLUMN',@level2name=N'xe_loaixe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Chất lượng của món hàng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hang_Hoa', @level2type=N'COLUMN',@level2name=N'hang_chatluong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Loại của hàng cầm' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hang_Hoa', @level2type=N'COLUMN',@level2name=N'loaihang_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'các mặt hàng được cầm, vàng, xe ...' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Hang_Hoa'
GO
/****** Object:  Table [dbo].[tbl_Chuoc_Hang]    Script Date: 02/04/2015 20:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Chuoc_Hang](
	[chuoc_id] [int] IDENTITY(1,1) NOT NULL,
	[hd_id] [int] NOT NULL,
	[chuoc_ngaytao] [datetime] NULL,
	[chuoc_songay] [int] NULL,
	[chuoc_tienlai_thoathuan] [float] NULL,
	[chuoc_tienlai_quahan] [float] NULL,
	[chuoc_tongtien] [float] NULL,
	[delete_flag] [bit] NULL,
	[chuoc_tanggiam] [float] NULL,
 CONSTRAINT [Pk_tbl_chuoc] PRIMARY KEY CLUSTERED 
(
	[chuoc_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [idx_tbl_Chuoc_Hang] ON [dbo].[tbl_Chuoc_Hang] 
(
	[hd_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số ngày kể từ ngày cầm' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Chuoc_Hang', @level2type=N'COLUMN',@level2name=N'chuoc_songay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tiền tăng giảm do chủ tiệm quyết định' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Chuoc_Hang', @level2type=N'COLUMN',@level2name=N'chuoc_tanggiam'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'bảng chuộc' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Chuoc_Hang'
GO
/****** Object:  Table [dbo].[tbl_Chi_Tiet_Hop_Dong]    Script Date: 02/04/2015 20:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Chi_Tiet_Hop_Dong](
	[cthd_id] [int] IDENTITY(1,1) NOT NULL,
	[hd_id] [int] NOT NULL,
	[hang_id] [int] NOT NULL,
	[cthd_soluong] [int] NULL,
	[cthd_giatri] [float] NULL,
	[cthd_lai_thoathuan] [float] NULL,
	[cthd_lai_quahan] [float] NULL,
	[delete_flag] [bit] NOT NULL,
 CONSTRAINT [Pk_tbl_chitiet_hopdong] PRIMARY KEY CLUSTERED 
(
	[cthd_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [idx_tbl_Chi_Tiet_Hop_Dong] ON [dbo].[tbl_Chi_Tiet_Hop_Dong] 
(
	[hang_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [idx_tbl_chitiet_hopdong] ON [dbo].[tbl_Chi_Tiet_Hop_Dong] 
(
	[hd_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id của chi tiết hợp đồng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Chi_Tiet_Hop_Dong', @level2type=N'COLUMN',@level2name=N'cthd_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'chi tiết hợp đồng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Chi_Tiet_Hop_Dong'
GO
/****** Object:  Default [defo_tbl_Hop_Dong_hd_baomat]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Hop_Dong] ADD  CONSTRAINT [defo_tbl_Hop_Dong_hd_baomat]  DEFAULT ((0)) FOR [hd_baomat]
GO
/****** Object:  Default [defo_tbl_Hop_Dong_delete_flag]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Hop_Dong] ADD  CONSTRAINT [defo_tbl_Hop_Dong_delete_flag]  DEFAULT ((0)) FOR [delete_flag]
GO
/****** Object:  Default [defo_tbl_Thu_Chi_tc_ngaytao]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Thu_Chi] ADD  CONSTRAINT [defo_tbl_Thu_Chi_tc_ngaytao]  DEFAULT (getdate()) FOR [tc_ngaytao]
GO
/****** Object:  Default [defo_tbl_Tra_Lai_Truoc_delete_flag]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Tra_Lai_Truoc] ADD  CONSTRAINT [defo_tbl_Tra_Lai_Truoc_delete_flag]  DEFAULT ((0)) FOR [delete_flag]
GO
/****** Object:  Default [defo_tbl_Them_Tien_delete_flag]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Them_Tien] ADD  CONSTRAINT [defo_tbl_Them_Tien_delete_flag]  DEFAULT ((0)) FOR [delete_flag]
GO
/****** Object:  Default [defo_tbl_Thanh_Ly_thanhly_ngay]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Thanh_Ly] ADD  CONSTRAINT [defo_tbl_Thanh_Ly_thanhly_ngay]  DEFAULT (getdate()) FOR [thanhly_ngay]
GO
/****** Object:  Default [defo_tbl_Hang_Hoa_delete_flag]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Hang_Hoa] ADD  CONSTRAINT [defo_tbl_Hang_Hoa_delete_flag]  DEFAULT ((0)) FOR [delete_flag]
GO
/****** Object:  Default [defo_tbl_Chuoc_Hang_delete_flag]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Chuoc_Hang] ADD  CONSTRAINT [defo_tbl_Chuoc_Hang_delete_flag]  DEFAULT ((0)) FOR [delete_flag]
GO
/****** Object:  Default [defo_tbl_Chi_Tiet_Hop_Dong_delete_flag]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Chi_Tiet_Hop_Dong] ADD  CONSTRAINT [defo_tbl_Chi_Tiet_Hop_Dong_delete_flag]  DEFAULT ((0)) FOR [delete_flag]
GO
/****** Object:  ForeignKey [Fk_tbl_tra_lai]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Tra_Lai_Truoc]  WITH CHECK ADD  CONSTRAINT [Fk_tbl_tra_lai] FOREIGN KEY([hd_id])
REFERENCES [dbo].[tbl_Hop_Dong] ([hd_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Tra_Lai_Truoc] CHECK CONSTRAINT [Fk_tbl_tra_lai]
GO
/****** Object:  ForeignKey [Fk_tbl_them_tien]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Them_Tien]  WITH CHECK ADD  CONSTRAINT [Fk_tbl_them_tien] FOREIGN KEY([hd_id])
REFERENCES [dbo].[tbl_Hop_Dong] ([hd_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Them_Tien] CHECK CONSTRAINT [Fk_tbl_them_tien]
GO
/****** Object:  ForeignKey [Fk_tbl_Thanh_Ly]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Thanh_Ly]  WITH CHECK ADD  CONSTRAINT [Fk_tbl_Thanh_Ly] FOREIGN KEY([hd_id])
REFERENCES [dbo].[tbl_Hop_Dong] ([hd_id])
GO
ALTER TABLE [dbo].[tbl_Thanh_Ly] CHECK CONSTRAINT [Fk_tbl_Thanh_Ly]
GO
/****** Object:  ForeignKey [Fk_tbl_Hang_Hoa]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Hang_Hoa]  WITH CHECK ADD  CONSTRAINT [Fk_tbl_Hang_Hoa] FOREIGN KEY([loaihang_id])
REFERENCES [dbo].[tbl_Loai_Hang] ([loaihang_id])
GO
ALTER TABLE [dbo].[tbl_Hang_Hoa] CHECK CONSTRAINT [Fk_tbl_Hang_Hoa]
GO
/****** Object:  ForeignKey [Fk_tbl_Chuoc_Hang]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Chuoc_Hang]  WITH CHECK ADD  CONSTRAINT [Fk_tbl_Chuoc_Hang] FOREIGN KEY([hd_id])
REFERENCES [dbo].[tbl_Hop_Dong] ([hd_id])
GO
ALTER TABLE [dbo].[tbl_Chuoc_Hang] CHECK CONSTRAINT [Fk_tbl_Chuoc_Hang]
GO
/****** Object:  ForeignKey [Fk_tbl_Chi_Tiet_Hop_Dong]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Chi_Tiet_Hop_Dong]  WITH CHECK ADD  CONSTRAINT [Fk_tbl_Chi_Tiet_Hop_Dong] FOREIGN KEY([hang_id])
REFERENCES [dbo].[tbl_Hang_Hoa] ([hang_id])
GO
ALTER TABLE [dbo].[tbl_Chi_Tiet_Hop_Dong] CHECK CONSTRAINT [Fk_tbl_Chi_Tiet_Hop_Dong]
GO
/****** Object:  ForeignKey [Fk_tbl_chitiet_hopdong]    Script Date: 02/04/2015 20:37:40 ******/
ALTER TABLE [dbo].[tbl_Chi_Tiet_Hop_Dong]  WITH CHECK ADD  CONSTRAINT [Fk_tbl_chitiet_hopdong] FOREIGN KEY([hd_id])
REFERENCES [dbo].[tbl_Hop_Dong] ([hd_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Chi_Tiet_Hop_Dong] CHECK CONSTRAINT [Fk_tbl_chitiet_hopdong]
GO
