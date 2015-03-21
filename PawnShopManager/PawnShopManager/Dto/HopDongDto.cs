using System;

namespace PawnShopManager.Dto
{
   class HopDongDto
   {
      public Int32 hd_id { get; set; }
      public Int32 maBN { get; set; }
      public DateTime ngayTao { get; set; }
      public Int32 trangThai { get; set; }
      public Boolean baoMat { get; set; }
      public Double tienCam { get; set; }
      public String cmnd { get; set; }
      public String tenKH { get; set; }
      public Double laiSuatThoaThuan { get; set; }
      public Double laiSuatQuaHan { get; set; }
      public Int32 thoiHan { get; set; }
   }
}
