--thêm chi tiết hàng cầm, loại vàng
ALTER PROC themCTHC_Vang(@hd_id int, @soLuong int, @tenMH nvarchar(50), @giatri float, @chatLuong nvarchar(50), @loai int)
AS
BEGIN
	insert into tbl_Chi_Tiet_Hang_Cam
		(hd_id, cthc_soluong, cthc_ten_hang_cam, cthc_giatri, cthc_ChatLuong, loai_id)
	values
		(@hd_id, @soLuong, @tenMH, @giatri, @chatLuong, @loai)
END

exec themCTHC_Vang 2506, 1, N'Nhẫn vàng PNJ', 55555, N'Nhẫn mới mua', 2
select * from tbl_Hop_Dong hd where hd.hd_maBN = 1 and YEAR(hd.hd_ngaytao) = 2015
select * from tbl_Chi_Tiet_Hang_Cam cthc where cthc.hd_id = 2506