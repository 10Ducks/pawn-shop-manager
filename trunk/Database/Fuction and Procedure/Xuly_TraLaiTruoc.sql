--xử lý trả lãi trước
CREATE PROC Xuly_TraLaiTruoc(@hd_id int, @ngayTraLai date, @soNgay int, @tien float)
AS
BEGIN
	insert into tbl_Tra_Lai_Truoc(hd_id, tralai_ngaytao, tralai_so_ngay, tralai_tien)
	values (@hd_id, @ngayTraLai, @soNgay, @tien)
END