--lấy hợp đồng them Mã biên nhận - trong phần quản lý hàng cầm
ALTER PROC layHD_TheoMaBN(@maBN int, @nam int)
AS
BEGIN
	select 
		hd.hd_id as 'hd_id',
		hd.hd_maBN as 'maBN',
		hd.hd_ngaytao as 'ngayTao',
		hd.hd_trangthai as 'trangThai',
		hd.hd_baomat as 'baoMat',
		hd.hd_tien_cam as 'tienCam',
		hd.hd_kh_CMND as 'cmnd',
		hd.hd_kh_Ten as 'tenKH',
		hd.hd_LaiSuat_ThoaThuan as 'laiSuatThoaThuan',
		hd.hd_LaiSuat_QuaHan as 'laiSuatQuaHan',
		hd.hd_thoihan as 'thoiHan'
	from tbl_Hop_Dong hd
	where hd.hd_maBN = @maBN
	  and hd.delete_flag = 0
	  and YEAR(hd.hd_ngaytao) = @nam
END

exec layHD_TheoMaBN 17

select * from tbl_Chi_Tiet_Hang_Cam a where a.hd_id = 2516