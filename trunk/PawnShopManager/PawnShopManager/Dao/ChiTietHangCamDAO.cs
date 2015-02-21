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
