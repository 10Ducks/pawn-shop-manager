using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopManager.Dao
{
   class ChiTietHangCamDAO : BaseDao
   {
#region Function
      public bool themChiTietHangCam_Vang(int hd_id, int soLuong, string tenMH, float giatri, int loai){
         try
         {
            string chatLuong;
            switch(loai)
            {
               case 2:
                  chatLuong = "Vàng 18k";
                  break;
               case 3:
                  chatLuong = "Vàng 24k";
                  break;
               case 4:
                  chatLuong = "Vàng trắng";
                  break;
               default:
                  chatLuong = "Vàng";
                  break;
            }
            SqlConnection conn = DbProviderFactory.getInstance().connectDB();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.CommandText = "themCTHC_Vang";
            command.Parameters.Add("@hd_id", System.Data.SqlDbType.Int).Value = hd_id;
            command.Parameters.Add("@soLuong", System.Data.SqlDbType.Int).Value = soLuong;
            command.Parameters.Add("@tenMH", System.Data.SqlDbType.NVarChar).Value = tenMH;
            command.Parameters.Add("@giatri", System.Data.SqlDbType.Float).Value = giatri;
            command.Parameters.Add("@loai", System.Data.SqlDbType.Int).Value = loai;
            command.Parameters.Add("@chatLuong", System.Data.SqlDbType.NVarChar).Value = chatLuong;

            command.ExecuteNonQuery();

            DbProviderFactory.getInstance().closeConnection();
            return true;
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.StackTrace);
            return false;
         }
      }

      public bool themChiTietHangCam_Xe(int hd_id, string bienSo, float giaTri, 
			string chatLuong, string loaiXe, string nhanSoXe)
      {
         try
         {
            SqlConnection conn = DbProviderFactory.getInstance().connectDB();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.CommandText = "themCTHC_Xe";
            command.Parameters.Add("@hd_id", System.Data.SqlDbType.Int).Value = hd_id;
            command.Parameters.Add("@bienSo", System.Data.SqlDbType.VarChar).Value = bienSo;
            command.Parameters.Add("@giaTri", System.Data.SqlDbType.Float).Value = giaTri;
            command.Parameters.Add("@chatLuong", System.Data.SqlDbType.NVarChar).Value = chatLuong;
            command.Parameters.Add("@loaiXe", System.Data.SqlDbType.NVarChar).Value = loaiXe;
            command.Parameters.Add("@nhanSoXe", System.Data.SqlDbType.NVarChar).Value = nhanSoXe;

            command.ExecuteNonQuery();

            DbProviderFactory.getInstance().closeConnection();
            return true;
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.StackTrace);
            return false;
         }
      }
#endregion
   }
}
