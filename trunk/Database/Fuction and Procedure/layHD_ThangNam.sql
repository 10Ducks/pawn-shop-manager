--lấy hợp đồng theo tháng trong năm
CREATE PROC layHD_ThangNam(@Thang int, @Nam int)
AS
BEGIN
	SELECT *
	FROM tbl_Hop_Dong
	WHERE MONTH(hd_ngaytao) = @Thang
	  AND YEAR(hd_ngaytao) = @Nam
	  AND delete_flag = 0
	ORDER BY hd_ngaytao
END

Exec layHD_ThangNam '11', '2010'