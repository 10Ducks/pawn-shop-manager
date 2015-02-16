using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawnShopManager.Dto;
using System.Data.SqlClient;

namespace PawnShopManager.Dao
{
   class ChuocHangDAO : BaseDao
   {
      private readonly string CHUOC_ID = "chuoc_id";
      private readonly string HD_ID = "hd_id";
      private readonly string CHUOC_NGAYTAO = "chuoc_ngaytao";
      private readonly string CHUOC_SONGAY = "chuoc_songay";
      private readonly string CHUOC_TIENLAI_THOATHUAN = "chuoc_tienlai_thoathuan";
      private readonly string CHUOC_TIENLAI_QUAHAN = "chuoc_tienlai_quahan";
      private readonly string CHUOC_TONGTIEN = "chuoc_tongtien";
      private readonly string CHUOC_TANGGIAM = "chuoc_tanggiam";

      public List<TkChuocDto> thongKe_Chuoc(int ngay, int thang, int nam){

         SqlConnection conn = DbProviderFactory.getInstance().connectDB();

         SqlCommand command = new SqlCommand(); 
         command.CommandType = System.Data.CommandType.StoredProcedure;
         command.Connection = conn;
         if(ngay != 0){ //chon theo ngay
            command.CommandText = "thongke_DaChuoc_Ngay";
            command.Parameters.Add("@Ngay", System.Data.SqlDbType.Int).Value = ngay;
            command.Parameters.Add("@Thang", System.Data.SqlDbType.Int).Value = thang;
            command.Parameters.Add("@Nam", System.Data.SqlDbType.Int).Value = nam;
         }else if(thang != 0){ //chon theo thang
            command.CommandText = "thongke_DaChuoc_Thang";
            command.Parameters.Add("@Thang", System.Data.SqlDbType.Int).Value = thang;
            command.Parameters.Add("@Nam", System.Data.SqlDbType.Int).Value = nam;
         }else { //chon theo nam
            command.CommandText = "thongke_DaChuoc_Nam";
            command.Parameters.Add("@Nam", System.Data.SqlDbType.Int).Value = nam;
         }

         SqlDataReader reader = command.ExecuteReader();
         List<TkChuocDto> ds = new List<TkChuocDto>();
         while (reader.Read())
         {
            TkChuocDto tkChuocDto = new TkChuocDto();
            tkChuocDto.maHD = reader.GetInt32(0);
            tkChuocDto.tenKH = reader.GetString(1);
            tkChuocDto.loaiHang = reader.GetInt32(2).ToString();
            tkChuocDto.tenMatHang = reader.GetString(3);
            tkChuocDto.chatLuong = reader.GetString(4);
            tkChuocDto.bienSo = reader.GetString(5);
            tkChuocDto.loaiXe= reader.GetString(6);
            tkChuocDto.tienCam = reader.GetDouble(7);
            tkChuocDto.ngayCam = reader.GetString(8);
            tkChuocDto.ngayHetHan = reader.GetString(9);
            tkChuocDto.soNgayCam = reader.GetInt32(10);
            ds.Add(tkChuocDto);
         }

         DbProviderFactory.getInstance().closeConnection();
         return ds;
      }
   }
}
