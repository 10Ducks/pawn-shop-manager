--lấy tất cả hợp đồng theo ngày nhập vào
CREATE PROC layHD_Ngay(@Date date)
AS
BEGIN
	SELECT *
	FROM tbl_Hop_Dong
	WHERE CONVERT(VARCHAR(10),hd_ngaytao, 20) = CONVERT(VARCHAR(10),@Date, 20)
	  AND delete_flag = 0
END

exec layHD_Ngay '2010-11-14'