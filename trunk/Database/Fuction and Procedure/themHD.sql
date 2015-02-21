
--thêm mới một hợp đồng
ALTER PROC themHD(@hd_maBN int, @hd_ngaytao date, @hd_tien_cam float, 
					@hd_kh_CMND varchar(20), @hd_kh_Ten nvarchar(50), @hd_kh_DienThoai varchar(15), 
					@hd_kh_Diachi nvarchar(max), 
					@hd_LaiSuat_ThoaThuan float, @hd_LaiSuat_QuaHan float,
					@keyAuto int output)
AS
BEGIN
	
	insert into tbl_Hop_Dong 
		(hd_maBN, hd_ngaytao, hd_trangthai, hd_baomat, hd_tien_cam, 
		hd_kh_CMND, hd_kh_Ten, hd_kh_DienThoai, hd_kh_Diachi, hd_LaiSuat_ThoaThuan, hd_LaiSuat_QuaHan)
		values (
					@hd_maBN,
					@hd_ngaytao, --hd_ngaytao
					1, --hd_trangthai 1: chua thanh toan
					0, --hd_baomat 0: chua mat
					@hd_tien_cam, 
					@hd_kh_CMND, 
					@hd_kh_Ten, 
					@hd_kh_DienThoai, 
					@hd_kh_Diachi, 
					@hd_LaiSuat_ThoaThuan, 
					@hd_LaiSuat_QuaHan
				)
	SET @keyAuto = SCOPE_IDENTITY();
	--print @keyAuto
	Select SCOPE_IDENTITY() as 'keyAuto'
END

DECLARE @result int;
exec themHD 6, 1000000, '123456789', 'Quyền', '0993872364', 'Tân Chánh Hiệp Q.12 Tp.HCM', 3.3, 4.4, @result output
select @result as 'result'
select * from tbl_Hop_Dong hd where hd.hd_id = 2512

exec layMaBN_Max