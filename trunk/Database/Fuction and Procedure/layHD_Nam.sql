--lấy hợp đồng theo năm
ALTER PROC layHD_Nam(@Nam int)
AS
BEGIN
	SELECT *
	FROM tbl_Hop_Dong
	WHERE YEAR(hd_ngaytao) = @Nam
	  AND delete_flag = 0
	ORDER BY hd_ngaytao
END

Exec layHD_Nam '2014'