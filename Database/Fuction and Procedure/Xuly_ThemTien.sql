--xử lý thêm tiền
CREATE PROC Xuly_ThemTien(@hd_id int, @ngayThem date, @tienLai float, @tienThem float, @hinhThuc int)
AS
BEGIN
	insert into tbl_Them_Tien (hd_id, them_ngaytao, them_tienlai, them_tien, them_hinhthuc_tralai)
	values (@hd_id, @ngayThem, @tienLai, @tienThem, @hinhThuc)
END