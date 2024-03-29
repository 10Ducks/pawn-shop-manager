--xử lý thanh lý đồ
CREATE PROC Xuly_ThanhLy(@hd_id int, @ngayThanhLy date, @tienThanhLy float)
AS
BEGIN
	--cập nhật lại trạng thái của hợp đồng
	update tbl_Hop_Dong
	set hd_trangthai = 3 --3: đã thanh lý
	where hd_id = @hd_id
	--thêm vào bảng thanh lý
	insert into tbl_Thanh_Ly (hd_id, thanhly_ngay, thanhly_tien)
	values (@hd_id, @ngayThanhLy, @tienThanhLy)
END