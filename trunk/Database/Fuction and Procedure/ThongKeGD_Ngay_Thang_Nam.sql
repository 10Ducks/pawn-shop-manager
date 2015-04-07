
ALTER PROC ThongKeGD_Ngay_Thang_Nam (@ngay int, @thang int, @nam int)
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
							where  (@ngay = 0 or DAY(hd.hd_ngaytao) = @ngay)
							and (@thang = 0 or MONTH(hd.hd_ngaytao) = @thang)
							and (@nam = 0 or YEAR(hd.hd_ngaytao) = @nam)
						)

	set @tongVonChuocDo = 
						(
							select sum(chuoc_tongtien)
							from tbl_Chuoc_Hang c
							where  (@ngay = 0 or DAY(c.chuoc_ngaytao) = @ngay)
							and (@thang = 0 or MONTH(c.chuoc_ngaytao) = @thang)
							and (@nam = 0 or YEAR(c.chuoc_ngaytao) = @nam)
						)

	set @tongLaiTraTruoc = 
						(
							select sum(tralai_tien)
							from tbl_Tra_Lai_Truoc tlt
							where  (@ngay = 0 or DAY(tlt.tralai_ngaytao) = @ngay)
							and (@thang = 0 or MONTH(tlt.tralai_ngaytao) = @thang)
							and (@nam = 0 or YEAR(tlt.tralai_ngaytao) = @nam)
						)

	
	set @tongTienLayThem = 
						(
							select sum(tt.them_tien)
							from tbl_Them_Tien tt
							where  (@ngay = 0 or DAY(tt.them_ngaytao) = @ngay)
							and (@thang = 0 or MONTH(tt.them_ngaytao) = @thang)
							and (@nam = 0 or YEAR(tt.them_ngaytao) = @nam)
						)
	set @tongLaiThanhLy = 
						(
							select sum(tl.thanhly_tien - hd.hd_tien_cam)
							from tbl_Thanh_Ly tl
							left join tbl_Hop_Dong hd 
								on tl.hd_id = hd.hd_id 
							where  (@ngay = 0 or DAY(tl.thanhly_ngay) = @ngay)
							and (@thang = 0 or MONTH(tl.thanhly_ngay) = @thang)
							and (@nam = 0 or YEAR(tl.thanhly_ngay) = @nam)
						)
	set @tongLaiThanhLy = @tongLaiThanhLy - @tongTienLayThem + @tongLaiTraTruoc

	set @tongTienThuKhac = 
						(
							select sum(tc.tc_tien)
							from tbl_Thu_Chi tc
							where  (@ngay = 0 or DAY(tc.tc_ngaytao) = @ngay)
							and (@thang = 0 or MONTH(tc.tc_ngaytao) = @thang)
							and (@nam = 0 or YEAR(tc.tc_ngaytao) = @nam)
								and tc.tc_loai = 1
						)

	set @tongTienChiKhac = 
						(
							select sum(tc.tc_tien)
							from tbl_Thu_Chi tc
							where  (@ngay = 0 or DAY(tc.tc_ngaytao) = @ngay)
							and (@thang = 0 or MONTH(tc.tc_ngaytao) = @thang)
							and (@nam = 0 or YEAR(tc.tc_ngaytao) = @nam)
							and tc.tc_loai = 2
						)


	if @tongVonChuocDo = 0  set @tongVonChuocDo = 0
	if @tongLaiTraTruoc = 0  set @tongLaiTraTruoc = 0
	if @tongLaiThanhLy = 0  set @tongLaiThanhLy = 0
	if @tongTienThuKhac = 0  set @tongTienThuKhac = 0
	if @tongTienCamDo = 0  set @tongTienCamDo = 0
	if @tongTienLayThem = 0  set @tongTienLayThem = 0
	if @tongTienChiKhac = 0  set @tongTienChiKhac = 0
	
	select @tongVonChuocDo as tongVonChuocDo, 
		 @tongLaiTraTruoc as tongLaiTraTruoc,  
		 @tongLaiThanhLy as tongLaiThanhLy, 
		 @tongTienThuKhac as tongTienThuKhac, 
		 @tongTienCamDo as tongTienCamDo, 
		 @tongTienLayThem as tongTienLayThem,
		 @tongTienChiKhac as tongTienChiKhac	
END

exec ThongKeGD_Ngay_Thang_Nam 0,0,0