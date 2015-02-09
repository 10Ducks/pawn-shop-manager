using System;

namespace PawnShopManager.Entity
{
   class ChuocHang
   {
      public Int32 chuoc_Id { get; set; }
      public Int32 hd_Id { get; set; }
      public String chuoc_NgayTao { get; set; }
      public Int16 chuoc_SoNgay { get; set; }
      public float chuoc_TienLai_ThoaThuan { get; set; }
      public float chuoc_TienLai_QuaHan { get; set; }
      public float chuoc_TongTien { get; set; }
      public float chuoc_TangGiam { get; set; }
   }
}
