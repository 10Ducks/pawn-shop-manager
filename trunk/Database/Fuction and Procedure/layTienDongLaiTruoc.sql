--lấy tiền đóng lãi trước
ALTER PROC layTienDongLaiTruoc(@MaHD int)
AS
BEGIN
	select tl.tralai_tien
	from tbl_Tra_Lai_Truoc tl
	where tl.delete_flag = 0
	  and tl.hd_id = @MaHD
END

exec layTienDongLaiTruoc 1234