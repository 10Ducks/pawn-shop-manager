--Bảng Admin
--kiểm tra đăng nhập, nếu không đúng mật khẩu thì trả về null
CREATE PROC getLogin(@ID varchar(50), @PASS varchar(256))
AS
BEGIN
	SELECT *
	FROM tbl_Admin
	WHERE Admin_Id = @ID
	AND Admin_Password = @PASS
END

EXEC getLogin 'admin', '123'
-----------------------------------------------------------------------------------------

--Bảng Hợp đồng
--lấy mã biên nhận cao nhất trong 1 năm nào đó, khi thêm vào bảng hợp đồng thì +1 vào.
CREATE PROC layMaBN_Max
AS
BEGIN
	select top 1 hd_maBN
	from tbl_Hop_Dong
	where year(hd_ngaytao) = YEAR(GETDATE())
	  and delete_flag = 0
	order by hd_maBN desc
END

exec layMaBN_Max

--lấy tất cả hợp đồng theo ngày nhập vào
ALTER PROC layHD_Ngay(@Date date)
AS
BEGIN
	SELECT *
	FROM tbl_Hop_Dong
	WHERE CONVERT(VARCHAR(10),hd_ngaytao, 20) = CONVERT(VARCHAR(10),@Date, 20)
	  AND delete_flag = 0
END

select CONVERT(VARCHAR(10),GETDATE(), 20)
exec layHD_Ngay '2010-11-14'

--lấy hợp đồng theo tháng trong năm
ALTER PROC layHD_ThangNam(@Thang int, @Nam int)
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

--lấy hợp đồng theo năm
CREATE PROC layHD_Nam(@Nam int)
AS
BEGIN
	SELECT *
	FROM tbl_Hop_Dong
	WHERE YEAR(hd_ngaytao) = @Nam
	  AND delete_flag = 0
	ORDER BY hd_ngaytao
END

Exec layHD_Nam '2014'

--thống kê hàng tồn theo ngày
ALTER PROC thongKe_HangTon_Ngay(@Ngay int, @Thang int, @Nam int)
AS
BEGIN
	select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		loai.loaihang_ten as 'loaiHang',
		hang.hang_ten as 'tenMatHang',
		hang.hang_chatluong as 'chatLuong',
		hang.xe_bienso as 'bienSo',
		hang.xe_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan',
		Datediff(day, hd.hd_ngaytao, GETDATE()) as 'soNgayCam'
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hang_Cam cthc, tbl_Hang_Hoa hang, tbl_Loai_Hang loai
	where hd.hd_id = cthc.hd_id
	  and cthc.hang_id = hang.hang_id
	  and loai.loaihang_id = hang.loaihang_id
	  and hd.hd_trangthai = 0
		
	  and DAY(hd.hd_ngaytao) = @Ngay
	  and MONTH(hd.hd_ngaytao) = @Thang
	  and YEAR(hd.hd_ngaytao) = @Nam
	  
	  --check delete
	  and hd.delete_flag = 0
	  and cthd.delete_flag = 0
	  and hang.delete_flag = 0
END

select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		loai.loaihang_ten as 'loaiHang',
		cthc.hang_ten as 'tenMatHang',
		cthc.hang_chatluong as 'chatLuong',
		cthc.xe_bienso as 'bienSo',
		cthc.xe_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan',
		Datediff(day, hd.hd_ngaytao, GETDATE()) as 'soNgayCam'
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hang_Cam cthc, tbl_Loai_Hang loai
	where hd.hd_id = cthc.hd_id	  
	  and loai.loaihang_id = hang.loaihang_id
	  and hd.hd_trangthai = 0
		
	  and DAY(hd.hd_ngaytao) = @Ngay
	  and MONTH(hd.hd_ngaytao) = @Thang
	  and YEAR(hd.hd_ngaytao) = @Nam
	  
	  --check delete
	  and hd.delete_flag = 0
	  and cthd.delete_flag = 0
	  and hang.delete_flag = 0

exec thongKe_HangTon_Ngay 3,12,2015

--thống kê hàng tồn theo tháng
ALTER PROC thongKe_HangTon_Thang(@Thang int, @Nam int)
AS
BEGIN
	select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		loai.loaihang_ten as 'loaiHang',
		hang.hang_ten as 'tenMatHang',
		hang.hang_chatluong as 'chatLuong',
		hang.xe_bienso as 'bienSo',
		hang.xe_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan',
		Datediff(day, hd.hd_ngaytao, GETDATE()) as 'soNgayCam'
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hop_Dong cthd, tbl_Hang_Hoa hang, tbl_Loai_Hang loai
	where hd.hd_id = cthd.hd_id
	  and cthd.hang_id = hang.hang_id
	  and loai.loaihang_id = hang.loaihang_id
	  and hd.hd_trangthai = 0
		
	  and MONTH(hd.hd_ngaytao) = @Thang
	  and YEAR(hd.hd_ngaytao) = @Nam
	  
	  --check delete
	  and hd.delete_flag = 0
	  and cthd.delete_flag = 0
	  and hang.delete_flag = 0
END

exec thongke_HangTon_thang 3,2015

--thống kê hàng tồn theo năm
ALTER PROC thongKe_HangTon_Nam(@Nam int)
AS
BEGIN
	select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		loai.loaihang_ten as 'loaiHang',
		hang.hang_ten as 'tenMatHang',
		hang.hang_chatluong as 'chatLuong',
		hang.xe_bienso as 'bienSo',
		hang.xe_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan',
		Datediff(day, hd.hd_ngaytao, GETDATE()) as 'soNgayCam'
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hop_Dong cthd, tbl_Hang_Hoa hang, tbl_Loai_Hang loai
	where hd.hd_id = cthd.hd_id
	  and cthd.hang_id = hang.hang_id
	  and loai.loaihang_id = hang.loaihang_id
	  and hd.hd_trangthai = 0
		
	  and YEAR(hd.hd_ngaytao) = @Nam
	  
	  --check delete
	  and hd.delete_flag = 0
	  and cthd.delete_flag = 0
	  and hang.delete_flag = 0
END

exec thongke_HangTon_thang 2015

--thống kê hàng đã chuộc theo ngày
CREATE PROC thongKe_DaChuoc_Ngay(@Ngay int, @Thang int, @Nam int)
AS
BEGIN
	select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		loai.loaihang_ten as 'loaiHang',
		hang.hang_ten as 'tenMatHang',
		hang.hang_chatluong as 'chatLuong',
		hang.xe_bienso as 'bienSo',
		hang.xe_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan',
		Datediff(day, hd.hd_ngaytao, GETDATE()) as 'soNgayCam'
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hop_Dong cthd, tbl_Hang_Hoa hang, tbl_Loai_Hang loai
	where hd.hd_id = cthd.hd_id
	  and cthd.hang_id = hang.hang_id
	  and loai.loaihang_id = hang.loaihang_id
	  and hd.hd_trangthai = 1 --1: chuoc, 2:thanh ly
		
	  and DAY(hd.hd_ngaytao) = @Ngay
	  and MONTH(hd.hd_ngaytao) = @Thang
	  and YEAR(hd.hd_ngaytao) = @Nam
	  
	  --check delete
	  and hd.delete_flag = 0
	  and cthd.delete_flag = 0
	  and hang.delete_flag = 0
END

--thống kê hàng đã chuộc theo tháng
CREATE PROC thongKe_DaChuoc_Thang(@Thang int, @Nam int)
AS
BEGIN
	select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		loai.loaihang_ten as 'loaiHang',
		hang.hang_ten as 'tenMatHang',
		hang.hang_chatluong as 'chatLuong',
		hang.xe_bienso as 'bienSo',
		hang.xe_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan',
		Datediff(day, hd.hd_ngaytao, GETDATE()) as 'soNgayCam'
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hop_Dong cthd, tbl_Hang_Hoa hang, tbl_Loai_Hang loai
	where hd.hd_id = cthd.hd_id
	  and cthd.hang_id = hang.hang_id
	  and loai.loaihang_id = hang.loaihang_id
	  and hd.hd_trangthai = 1 --1: chuoc, 2:thanh ly
		
	  and MONTH(hd.hd_ngaytao) = @Thang
	  and YEAR(hd.hd_ngaytao) = @Nam
	  
	  --check delete
	  and hd.delete_flag = 0
	  and cthd.delete_flag = 0
	  and hang.delete_flag = 0
END

--thống kê hàng đã chuộc theo năm
CREATE PROC thongKe_DaChuoc_Nam(@Nam int)
AS
BEGIN
	select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		loai.loaihang_ten as 'loaiHang',
		hang.hang_ten as 'tenMatHang',
		hang.hang_chatluong as 'chatLuong',
		hang.xe_bienso as 'bienSo',
		hang.xe_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan',
		Datediff(day, hd.hd_ngaytao, GETDATE()) as 'soNgayCam'
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hop_Dong cthd, tbl_Hang_Hoa hang, tbl_Loai_Hang loai
	where hd.hd_id = cthd.hd_id
	  and cthd.hang_id = hang.hang_id
	  and loai.loaihang_id = hang.loaihang_id
	  and hd.hd_trangthai = 1 --1: chuoc, 2:thanh ly
		
	  and YEAR(hd.hd_ngaytao) = @Nam
	  
	  --check delete
	  and hd.delete_flag = 0
	  and cthd.delete_flag = 0
	  and hang.delete_flag = 0
END

--test
select * from tbl_Chi_Tiet_Hop_Dong

update tbl_Hop_Dong
set hd_trangthai = 0
where hd_trangthai = 5

select *
from tbl_Hop_Dong hd
where hd.hd_id not in (select chuoc.hd_id
						from tbl_Chuoc_Hang chuoc
						where chuoc.delete_flag = 0)

select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		hd.hd_kh_CMND as 'CMND',
		loai.loaihang_ten as 'loaiHang',
		hang.hang_ten as 'tenMatHang',
		hang.hang_chatluong as 'chatLuong',
		hang.xe_bienso as 'bienSo',
		hang.xe_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan',
		Datediff(day, hd.hd_ngaytao, GETDATE()) as 'soNgayCam'
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hop_Dong cthd, tbl_Hang_Hoa hang, tbl_Loai_Hang loai
	where hd.hd_id = cthd.hd_id
	  and cthd.hang_id = hang.hang_id
	  and loai.loaihang_id = hang.loaihang_id
	  and hd.hd_trangthai = 0
		
	  and YEAR(hd.hd_ngaytao) = 2015
	  
	  and hd.hd_maBN = 1111 --tim theo maBN. sửa lại chỗ này
	  
	  --check delete
	  and hd.delete_flag = 0
	  and cthd.delete_flag = 0
	  and hang.delete_flag = 0
-----------------------------------------------------------------------------------------