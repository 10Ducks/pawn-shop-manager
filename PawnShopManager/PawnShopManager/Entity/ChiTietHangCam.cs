using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopManager.Entity
{
   class ChiTietHangCam
   {
      public Int32 cthc_Id { get; set; }
      public Int32 hd_Id { get; set; }
      public Int32 cthc_SoLuong { get; set; }
      public Double cthc_GiaTri { get; set; }
      public String cthc_TenHangCam { get; set; }
      public Int32 cthc_Loai_Id { get; set; }
      public String cthc_BienSoXe { get; set; }
      public String cthc_ChatLuong { get; set; }
      public String cthc_LoaiXe { get; set; }
      public String cthc_NhanSoXe { get; set; }
   }
}
