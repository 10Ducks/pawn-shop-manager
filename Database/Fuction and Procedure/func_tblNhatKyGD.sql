--nhật ký giao dịch

ALTER FUNCTION nhatKyGiaoDich ( @hd_id int )
RETURNS @tblNhatKy TABLE
   (
    ngayGiaoDich		date,
    loaiGiaoDich		nvarchar(50),
    soTienGiaoDich      float,
    tongTienCam			float
   )
AS
BEGIN
	declare @tongTien float
	set @tongTien = (select hd.hd_tien_cam from tbl_hop_dong hd where hd.hd_id = @hd_id)
    INSERT @tblNhatKy
        SELECT hd.hd_ngaytao, N'Cầm đồ', hd.hd_tien_cam, @tongTien
        FROM tbl_Hop_Dong hd
        WHERE hd.hd_id = @hd_id
	
	declare @tienThem float
	set @tienThem = (select sum(tt.them_tien) from tbl_Them_Tien tt where tt.hd_id = @hd_id)
	set @tongTien = @tongTien + @tienThem
	INSERT @tblNhatKy
        SELECT tt.them_ngaytao, 
			Case
				When tt.them_hinhthuc_tralai = 0 Then N'Thêm tiền - Trả lãi trước'
				When tt.them_hinhthuc_tralai = 1 Then N'Thêm tiền - Trả lãi sau'
			END
			, tt.them_tien, @tongTien
        FROM tbl_Them_Tien tt
        WHERE tt.hd_id = @hd_id
	
	declare @tienTraTruoc float
	set @tienTraTruoc = (select sum(tlt.tralai_tien) from tbl_Tra_Lai_Truoc tlt where tlt.hd_id = @hd_id)
	set @tongTien = @tongTien - @tienTraTruoc
	INSERT @tblNhatKy
        SELECT tlt.tralai_ngaytao, N'Trả lãi trước', tlt.tralai_tien,  @tongTien
        FROM tbl_Tra_Lai_Truoc tlt
        WHERE tlt.hd_id = @hd_id
	
	INSERT @tblNhatKy
        SELECT c.chuoc_ngaytao, N'Chuộc hàng', c.chuoc_tongtien, @tongTien
        FROM tbl_Chuoc_Hang c
        WHERE c.hd_id = @hd_id

	INSERT @tblNhatKy
        SELECT tl.thanhly_ngay, N'Thanh lý', tl.thanhly_tien, @tongTien
        FROM tbl_Thanh_Ly tl
        WHERE tl.hd_id = @hd_id

   RETURN
END

select * from nhatKyGiaoDich(2121) tbl
order by tbl.ngayGiaoDich

create table mytable (id int identity(1,1), PersonID int,    Unit varchar(10))
insert into mytable values (1,'Che')
insert into mytable  values (1,'Mat')
insert into mytable  values (1,'Phy')
insert into mytable values (2,'Che2')
insert into mytable  values (2,'Mat2')
insert into mytable  values (2,'Phy2')
insert into mytable  values (3,'Phy3')

select * from mytable


SELECT t1.PersonID,
       Units =REPLACE( (SELECT Unit AS [data()]
           FROM mytable t2
          WHERE t2.PersonID = t1.PersonID
          ORDER BY Unit
            FOR XML PATH('')
            ), ' ', ' - ')
      FROM mytable t1
      GROUP BY PersonID ;

drop table mytable