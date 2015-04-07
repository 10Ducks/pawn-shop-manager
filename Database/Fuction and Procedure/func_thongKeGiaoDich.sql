--thong ke giao dich theo ngay thang nam
--loai giao dich: 0: tat ca, 1: Cam do, 2: Thanh ly, 3 Them tien, 4: tra lai truoc, 5: thu chi khac
ALTER FUNCTION func_thongKeGiaoDich ( @ngay int, @thang int, @nam int, @loaiGD int)
RETURNS  @tblThongKe table
	(
		maHD				int,
		ngayGiaoDich		date,
		loaiGD				nvarchar(50),
		tenKH				nvarchar(100),
		soDT				varchar(20),
		loaiHang			nvarchar(50),
		tongTien			float,
		tienGiam			float,
		tienLoi				float,
		thanhToan			float
	)
AS
BEGIN
	--loai giao dich: 0: tat ca, 1: Cam do, 2: Thanh ly, 3 Them tien, 4: tra lai truoc, 5: thu chi khac
	--1: Cam Do
	INSERT @tblThongKe
		select
			hd.hd_maBN,
			hd.hd_ngaytao,
			N'Cầm đồ' as loaiGD,
			hd.hd_kh_Ten,
			hd.hd_kh_DienThoai,
			loai.loaihang_ten,
			hd.hd_tien_cam,
			c.chuoc_tanggiam,
			c.chuoc_tongtien - hd.hd_tien_cam as tienLoi,
			c.chuoc_tongtien
		from tbl_Hop_Dong hd
		left join tbl_Chi_Tiet_Hang_Cam cthc on hd.hd_id = cthc.hd_id
		left join tbl_Loai_Hang loai on loai.loaihang_id = cthc.loai_id
		left join tbl_Chuoc_Hang c on hd.hd_id = c.hd_id

		where
			(@ngay = 0 or DAY(hd.hd_ngaytao) = @ngay)
		and	(@thang = 0 or MONTH(hd.hd_ngaytao) = @thang)
		and (@nam = 0 or YEAR(hd.hd_ngaytao) = @nam)
		and (@loaiGD = 0 or @loaiGD = 1)

	--2: Thanh ly
	INSERT @tblThongKe
		select
			hd.hd_maBN,
			hd.hd_ngaytao,
			N'Thanh lý' as loaiGD,
			hd.hd_kh_Ten,
			hd.hd_kh_DienThoai,
			loai.loaihang_ten,
			hd.hd_tien_cam,
			0, --tang giam
			tl.thanhly_tien - hd.hd_tien_cam as tienLoi,
			tl.thanhly_tien
		from tbl_Hop_Dong hd
		left join tbl_Chi_Tiet_Hang_Cam cthc on hd.hd_id = cthc.hd_id
		left join tbl_Loai_Hang loai on loai.loaihang_id = cthc.loai_id
		left join tbl_Thanh_Ly tl on hd.hd_id = tl.hd_id

		where
			(@ngay = 0 or DAY(hd.hd_ngaytao) = @ngay)
		and	(@thang = 0 or MONTH(hd.hd_ngaytao) = @thang)
		and (@nam = 0 or YEAR(hd.hd_ngaytao) = @nam)
		and (@loaiGD = 0 or @loaiGD = 2)

	--3: Them tien
	INSERT @tblThongKe
		select
			hd.hd_maBN,
			hd.hd_ngaytao,
			N'Thêm tiền' as loaiGD,
			hd.hd_kh_Ten,
			hd.hd_kh_DienThoai,
			loai.loaihang_ten,
			hd.hd_tien_cam,
			0, --tang giam
			0 as tienLoi,
			tt.them_tien
		from tbl_Hop_Dong hd
		left join tbl_Chi_Tiet_Hang_Cam cthc on hd.hd_id = cthc.hd_id
		left join tbl_Loai_Hang loai on loai.loaihang_id = cthc.loai_id
		left join tbl_Them_Tien tt on hd.hd_id = tt.hd_id

		where
			(@ngay = 0 or DAY(hd.hd_ngaytao) = @ngay)
		and	(@thang = 0 or MONTH(hd.hd_ngaytao) = @thang)
		and (@nam = 0 or YEAR(hd.hd_ngaytao) = @nam)
		and (@loaiGD = 0 or @loaiGD = 3)

	--4: Tra Lai truoc
	INSERT @tblThongKe
		select
			hd.hd_maBN,
			hd.hd_ngaytao,
			N'Trả lãi trước' as loaiGD,
			hd.hd_kh_Ten,
			hd.hd_kh_DienThoai,
			loai.loaihang_ten,
			hd.hd_tien_cam,
			0, --tang giam
			0 as tienLoi,
			tl.tralai_tien
		from tbl_Hop_Dong hd
		left join tbl_Chi_Tiet_Hang_Cam cthc on hd.hd_id = cthc.hd_id
		left join tbl_Loai_Hang loai on loai.loaihang_id = cthc.loai_id
		left join tbl_Tra_Lai_Truoc tl on hd.hd_id = tl.hd_id

		where
			(@ngay = 0 or DAY(hd.hd_ngaytao) = @ngay)
		and	(@thang = 0 or MONTH(hd.hd_ngaytao) = @thang)
		and (@nam = 0 or YEAR(hd.hd_ngaytao) = @nam)
		and (@loaiGD = 0 or @loaiGD = 4)

	--5: thu chi khac
	INSERT @tblThongKe
		select
			0,
			tc.tc_ngaytao,
			case tc.tc_loai
				when 1 then 'Thu chi khác (thu)'
				when 2 then 'Thu Chi khác (chi)'
			end as loaiGD,
			'' as tenKH,
			'' as soDT,
			N'Thu Chi khác',
			tc.tc_tien,
			0, --tang giam
			0 as tienLoi,
			tc.tc_tien
		from tbl_Thu_Chi tc
		where
			(@ngay = 0 or DAY(tc_ngaytao) = @ngay)
		and	(@thang = 0 or MONTH(tc_ngaytao) = @thang)
		and (@nam = 0 or YEAR(tc_ngaytao) = @nam)
		and (@loaiGD = 0 or @loaiGD = 5)
   RETURN
END

select *
from func_thongKeGiaoDich(0,0,2015,0)

