--lay ngay them tien
CREATE PROC layNgayThemTien (@hd_id int)
AS
BEGIN
	Select tt.them_ngaytao
	From tbl_Them_Tien tt
	where tt.hd_id = @hd_id
END