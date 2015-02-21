
-----------------------------------------------------------------------------------------

select CONVERT(VARCHAR(10),GETDATE(), 20)

--thống kê hàng đã thanh lý theo ngày
CREATE PROC thongKe_ThanhLy_Ngay(@Ngay int, @Thang int, @Nam int)
AS
BEGIN
	select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		loai.loaihang_ten as 'loaiHang',
		cthc.cthc_ten_hang_cam as 'tenMatHang',
		cthc.cthc_chatluong as 'chatLuong',
		cthc.cthc_BienSoXe as 'bienSo',
		cthc.cthc_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan'
		
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hang_Cam cthc, tbl_Loai_Hang loai, tbl_Thanh_Ly tl
	where hd.hd_id = cthc.hd_id
	  and tl.hd_id = hd.hd_id	  
	  and loai.loaihang_id = cthc.loai_id
	  and hd.hd_trangthai = 3 --3: đã thanh lý
	  --check delete
	  and hd.delete_flag = 0
	  and cthc.delete_flag = 0
	  and tl.delete_flag = 0
		 
	  and DAY(hd.hd_ngaytao) = @Ngay
	  and MONTH(hd.hd_ngaytao) = @Thang
	  and YEAR(hd.hd_ngaytao) = @Nam
	ORDER BY hd.hd_maBN	  
END
exec thongke_thanhly_ngay 11,11,2011

--thống kê hàng đã thanh lý theo tháng
CREATE PROC thongKe_ThanhLy_Thang(@Thang int, @Nam int)
AS
BEGIN
	select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		loai.loaihang_ten as 'loaiHang',
		cthc.cthc_ten_hang_cam as 'tenMatHang',
		cthc.cthc_chatluong as 'chatLuong',
		cthc.cthc_BienSoXe as 'bienSo',
		cthc.cthc_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan'
		
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hang_Cam cthc, tbl_Loai_Hang loai, tbl_Thanh_Ly tl
	where hd.hd_id = cthc.hd_id
	  and tl.hd_id = hd.hd_id	  
	  and loai.loaihang_id = cthc.loai_id
	  and hd.hd_trangthai = 3 --3: đã thanh lý
	  --check delete
	  and hd.delete_flag = 0
	  and cthc.delete_flag = 0
	  and tl.delete_flag = 0
		 
	  and MONTH(hd.hd_ngaytao) = @Thang
	  and YEAR(hd.hd_ngaytao) = @Nam
	ORDER BY hd.hd_maBN	  
END
exec thongke_thanhly_thang 11,2011

--thống kê hàng đã thanh lý theo năm
CREATE PROC thongKe_ThanhLy_Nam(@Nam int)
AS
BEGIN
	select
		hd.hd_maBN as 'maHD',
		hd.hd_kh_Ten as 'tenKH',
		loai.loaihang_ten as 'loaiHang',
		cthc.cthc_ten_hang_cam as 'tenMatHang',
		cthc.cthc_chatluong as 'chatLuong',
		cthc.cthc_BienSoXe as 'bienSo',
		cthc.cthc_loaixe as 'loaiXe',
		hd.hd_tien_cam as 'tienCam',
		CONVERT(VARCHAR(10),hd.hd_ngaytao, 3) as 'ngayCam',
		CONVERT(VARCHAR(10),DATEADD(day,59,hd.hd_ngaytao), 3) as 'ngayHetHan'
		
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hang_Cam cthc, tbl_Loai_Hang loai, tbl_Thanh_Ly tl
	where hd.hd_id = cthc.hd_id
	  and tl.hd_id = hd.hd_id	  
	  and loai.loaihang_id = cthc.loai_id
	  and hd.hd_trangthai = 3 --3: đã thanh lý
	  --check delete
	  and hd.delete_flag = 0
	  and cthc.delete_flag = 0
	  and tl.delete_flag = 0
		 
	  and YEAR(hd.hd_ngaytao) = @Nam
	ORDER BY hd.hd_maBN	  
END
exec thongke_thanhly_Nam 2011

--Thống kê Thu theo ngày
ALTER PROC thongKe_Thu_Ngay(@Ngay int, @Thang int, @Nam int)
AS
BEGIN
	select
		tc.tc_loai		as	'loaiHinhThuc',
		tc.tc_ngaytao	as	'ngayTao',
		tc.tc_tien		as	'tien',
		tc.tc_note		as	'ghiChu',
		tc.hd_id	as	'hopDongId'
	from tbl_Thu_Chi tc
	where DAY(tc.tc_ngaytao) = @Ngay
	  and MONTH(tc.tc_ngaytao) = @Thang
	  and YEAR(tc.tc_ngaytao) = @Nam
END
exec thongKe_Thu_Ngay 11, 11, 2015

--thống kê thu theo tháng
ALTER PROC thongKe_Thu_Thang(@Thang int, @Nam int)
AS
BEGIN
	select
		tc.tc_loai		as	'loaiHinhThuc',
		tc.tc_ngaytao	as	'ngayTao',
		tc.tc_tien		as	'tien',
		tc.tc_note		as	'ghiChu',
		tc.hd_id	as	'hopDongId'
	from tbl_Thu_Chi tc
	where MONTH(tc.tc_ngaytao) = @Thang
	  and YEAR(tc.tc_ngaytao) = @Nam
END
exec thongKe_Thu_Thang  11, 2015

--thống kê thu theo năm
ALTER PROC thongKe_Thu_Nam(@Nam int)
AS
BEGIN
	select
		tc.tc_loai		as	'loaiHinhThuc',
		tc.tc_ngaytao	as	'ngayTao',
		tc.tc_tien		as	'tien',
		tc.tc_note		as	'ghiChu',
		tc.hd_id	as	'hopDongId'
	from tbl_Thu_Chi tc
	where YEAR(tc.tc_ngaytao) = @Nam
END
exec thongKe_Thu_Nam  2015

--Tìm mã biên nhận (trong năm)
CREATE PROC timMaBN(@MaBN int)
AS
BEGIN
	select
		hd.hd_kh_Ten as 'tenKH',
		hd.hd_kh_CMND as 'CMND',
		lh.loaihang_ten as 'loaiHang'
	from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hang_Cam cthc, tbl_Loai_Hang lh
END


--tìm kiếm
CREATE PROC timkiem(@MaBN int, @LoaiHang int, @TenKH nvarchar(50), @CMND varchar(20), @DienThoai varchar(15),
					@TuNgay date, @DenNgay date)
AS
BEGIN
	Select
		hd.hd_id,
		hd.hd_maBN,
		hd.hd_ngaytao,
		hd.hd_kh_Ten,
		hd.hd_kh_CMND,
		hd.hd_kh_DienThoai,
		hd.hd_tien_cam,
		chuoc.chuoc_tienlai_thoathuan,
		chuoc.chuoc_tienlai_quahan,
		chuoc.chuoc_tanggiam,
		chuoc.chuoc_tongtien,
		chuoc.chuoc_tongtien - hd.hd_tien_cam as 'tienLoi',
		chuoc.chuoc_ngaytao,
		case chuoc.chuoc_ngaytao
			when (null) then
				Datediff(day, hd.hd_ngaytao, GETDATE())
			else
				Datediff(day, hd.hd_ngaytao, chuoc.chuoc_ngaytao)
		end as 'aaa'
	from tbl_Hop_Dong hd
	left join tbl_Chuoc_Hang chuoc
		on hd.hd_id = chuoc.hd_id
	where hd.hd_id = 1671
	Order by hd.hd_id
	
	
END
-----------------------------------------------------------------------------------------

select a.cthc_BienSoXe from tbl_Chi_Tiet_Hang_Cam a group by a.hd_id

--test

select *
from tbl_Hop_Dong hd
--where hd.hd_maBN = 7310
where Coalesce(hd.hd_maBN,hd.hd_maBN)= Isnull(7310, 7310)

select ISNULL(null, 10)

select *
from tbl_Hop_Dong hd
where hd.hd_id not in (select chuoc.hd_id
						from tbl_Chuoc_Hang chuoc
						where chuoc.delete_flag = 0)
select *
from tbl_Chuoc_Hang c, tbl_Hop_Dong hd
where hd.hd_id = c.hd_id
order by c.hd_id
 
SELECT RAND() Random_Number
SELECT RAND(100), RAND(), RAND() 

SELECT randomNumber, COUNT(1) countOfRandomNumber
FROM (
SELECT ABS(CAST(NEWID() AS binary(6)) %100) + 60 randomNumber
FROM sysobjects) sample
GROUP BY randomNumber
ORDER BY randomNumber

SELECT ABS(CAST(NEWID() AS binary(6)) %30) + 1 randomNumber
FROM sysobjects
 
--edit database to right
update tbl_Chuoc_Hang
set
	--tbl_Chuoc_Hang.chuoc_ngaytao = DATEADD(day, ABS(CAST(NEWID() AS binary(6)) %80) + 10,tbl_Hop_Dong.hd_ngaytao)
	--tbl_Chuoc_Hang.chuoc_songay = Datediff(day, tbl_Hop_Dong.hd_ngaytao, tbl_Chuoc_Hang.chuoc_ngaytao)
	--tbl_Chuoc_Hang.chuoc_tienlai_thoathuan =
		--lãi suất thỏa thuận / 30 --> lãi suất 1 ngày
		--xong nhân số ngày --> lãi suất của tổng ngày
		--nhân phần trăm với tiền cầm --> lãi suất thỏa thuận
	--	tbl_Chuoc_Hang.chuoc_songay * tbl_Hop_Dong.hd_LaiSuat_ThoaThuan / 30 *  tbl_Hop_Dong.hd_tien_cam / 100
	--tbl_Chuoc_Hang.chuoc_tienlai_quahan =
		--60 ngày đầu tính theo lãi suất thỏa thuận --> lãi thỏa thuận * 2
		--nhân phần trăm với tiền cầm ra lãi tính theo thỏa thuận
		--số ngày còn lại trừ đi 60 --> số ngày dôi ra
		--nhân lãi suất quá hạn với ngày dôi ra --> lãi suất của ngày dôi
		--nhân phần trăm với tiền cầm --> lãi quá hạn so với ngày dôi
		--cộng 2 lãi lại --> lãi quá hạn
	--	((tbl_Hop_Dong.hd_tien_cam * tbl_Hop_Dong.hd_LaiSuat_ThoaThuan * 2 / 100)) + ((tbl_Chuoc_Hang.chuoc_songay - 60) * tbl_Hop_Dong.hd_LaiSuat_QuaHan / 30 *  tbl_Hop_Dong.hd_tien_cam / 100)
	tbl_Chuoc_Hang.chuoc_tongtien = 
		case 
			when tbl_Chuoc_Hang.chuoc_songay > 60 then
				tbl_Chuoc_Hang.chuoc_tanggiam + tbl_Chuoc_Hang.chuoc_tienlai_quahan + tbl_Hop_Dong.hd_tien_cam - (select sum(tl.tralai_tien) from tbl_Tra_Lai_Truoc tl where tl.hd_id = tbl_Hop_Dong.hd_id)
			else
				tbl_Chuoc_Hang.chuoc_tanggiam + tbl_Chuoc_Hang.chuoc_tienlai_thoathuan + tbl_Hop_Dong.hd_tien_cam - (select sum(tl.tralai_tien) from tbl_Tra_Lai_Truoc tl where tl.hd_id = tbl_Hop_Dong.hd_id)
		end
from tbl_Hop_Dong
where tbl_Hop_Dong.hd_id = tbl_Chuoc_Hang.hd_id

update tbl_Hop_Dong
set
	tbl_Hop_Dong.hd_trangthai = 2
where tbl_Hop_Dong.hd_id in (select c.hd_id
							 from tbl_Chuoc_Hang c)
							
update tbl_Hop_Dong
set
	tbl_Hop_Dong.hd_trangthai = 3
where tbl_Hop_Dong.hd_id in (select c.hd_id
							 from tbl_Thanh_Ly c)
	
 
  


-----------------------------------------------------------------------------------------