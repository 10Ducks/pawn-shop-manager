ALTER PROC ThongKeGiaoDich(@ngay int, @thang int, @nam int, @loai int)
AS
BEGIN
	select * from func_thongKeGiaoDich(@ngay, @thang, @nam, @loai)
END

exec ThongKeGiaoDich 0,0,2015,0