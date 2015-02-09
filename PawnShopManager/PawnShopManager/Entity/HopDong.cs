using System;

namespace PawnShopManager.Entity
{
   class HopDong
   {
      public Int32 hd_Id { get; set; }
      public Int16 hd_maBN { get; set; }
      public String hd_NgayTao { get; set; }
      public Int16 hd_TrangThai { get; set; }
      public Boolean hd_BaoMat { get; set; }
      public float hd_Tien_Cam { get; set; }
      public String hd_Kh_CMND { get; set; }
      public String hd_Kh_Ten { get; set; }
      public String hd_Kh_DienThoai { get; set; }
      public String hd_Kh_DiaChi { get; set; }

   }
}
