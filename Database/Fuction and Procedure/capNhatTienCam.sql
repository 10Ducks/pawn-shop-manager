--cập nhật lại tiền cầm
CREATE PROC capNhatTienCam(@hd_id int, @tienCam float)
AS
BEGIN
	Update tbl_Hop_Dong
	set hd_tien_cam = @tienCam
	where hd_id = @hd_id
END