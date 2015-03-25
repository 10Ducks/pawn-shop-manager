--lấy tiền cầm của một hợp đồng
CREATE PROC layTienCam(@hd_id int)
AS
BEGIN
	Select hd.hd_tien_cam
	from tbl_Hop_Dong hd
	where hd.hd_id = @hd_id
END