using System;

namespace PawnShopManager.Entity
{
   class HopDong
   {
      public Int32 hd_Id { get; set; }
      public Int32 hd_maBN { get; set; }
      public String hd_NgayTao { get; set; }
      public Int32 hd_TrangThai { get; set; }
      public Boolean hd_BaoMat { get; set; }
      public Double hd_Tien_Cam { get; set; }
      public String hd_Kh_CMND { get; set; }
      public String hd_Kh_Ten { get; set; }
      public String hd_Kh_DienThoai { get; set; }
      public String hd_Kh_DiaChi { get; set; }
      public Double hd_LaiSuat_ThoaThuan { get; set; }
      public Double hd_LaiSuat_QuaHan { get; set; }
   }
}
