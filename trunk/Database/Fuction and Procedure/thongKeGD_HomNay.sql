--tổng thu chi, thống kê giao dịch theo ngày truyền vào
CREATE PROC thongKeGD (@ngay datetime)
AS
BEGIN
	declare @tongVonChuocDo float
	declare @tongLaiTraTruoc float
	declare @tongLaiThanhLy float
	declare @tongTienThuKhac float
	declare @tongTienCamDo float
	declare @tongTienLayThem float
	declare @tongTienChiKhac float

	set @tongTienCamDo = 
						(
							select sum(hd.hd_tien_cam)
							from tbl_Hop_Dong hd
							where  hd.hd_ngaytao = convert(varchar(10), @ngay, 102)
						)

	set @tongVonChuocDo = 
						(
							select sum(chuoc_tongtien)
							from tbl_Chuoc_Hang c
							where  c.chuoc_ngaytao = convert(varchar(10), @ngay, 102)
						)

	set @tongLaiTraTruoc = 
						(
							select sum(tralai_tien)
							from tbl_Tra_Lai_Truoc tlt
							where  tlt.tralai_ngaytao = convert(varchar(10), @ngay, 102)
						)

	
	set @tongTienLayThem = 
						(
							select sum(tt.them_tien)
							from tbl_Them_Tien tt
							where  tt.them_ngaytao = convert(varchar(10), @ngay, 102)
						)
	set @tongLaiThanhLy = 
						(
							select sum(tl.thanhly_tien - hd.hd_tien_cam)
							from tbl_Thanh_Ly tl
							left join tbl_Hop_Dong hd 
								on tl.hd_id = hd.hd_id 
							where tl.thanhly_ngay = convert(varchar(10), @ngay, 102)
						)
	set @tongLaiThanhLy = @tongLaiThanhLy - @tongTienLayThem + @tongLaiTraTruoc

	set @tongTienThuKhac = 
						(
							select sum(tc.tc_tien)
							from tbl_Thu_Chi tc
							where tc.tc_ngaytao = convert(varchar(10), @ngay, 102)
								and tc.tc_loai = 1
						)

	set @tongTienChiKhac = 
						(
							select sum(tc.tc_tien)
							from tbl_Thu_Chi tc
							where tc.tc_ngaytao = convert(varchar(10), @ngay, 102)
							and tc.tc_loai = 2
						)


	if @tongVonChuocDo is null  set @tongVonChuocDo = 0
	if @tongLaiTraTruoc is null  set @tongLaiTraTruoc = 0
	if @tongLaiThanhLy is null  set @tongLaiThanhLy = 0
	if @tongTienThuKhac is null  set @tongTienThuKhac = 0
	if @tongTienCamDo is null  set @tongTienCamDo = 0
	if @tongTienLayThem is null  set @tongTienLayThem = 0
	
	select @tongVonChuocDo as tongVonChuocDo, 
		 @tongLaiTraTruoc as tongLaiTraTruoc,  
		 @tongLaiThanhLy as tongLaiThanhLy, 
		 @tongTienThuKhac as tongTienThuKhac, 
		 @tongTienCamDo as tongTienCamDo, 
		 @tongTienLayThem as tongTienLayThem,
		 @tongTienChiKhac as tongTienChiKhac
END

exec thongKeGD_HomNay

select convert(varchar(10), @ngay, 102)