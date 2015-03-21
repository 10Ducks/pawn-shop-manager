using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopManager.Dao
{
   class TraLaiTruocDAO
   {
      public double layTienTraLaiTruoc(int maHD){
         double result = 0;
         SqlConnection conn = DbProviderFactory.getInstance().connectDB();

         SqlCommand command = new SqlCommand("layTienDongLaiTruoc", conn);
         command.CommandType = System.Data.CommandType.StoredProcedure;
         command.Parameters.Add("@MaHD", System.Data.SqlDbType.Int).Value = maHD;

         SqlDataReader reader = command.ExecuteReader();
         while (reader.Read())
         {
            result = reader.GetDouble(0);
            break; //cheat code, only 1 was returned
         }

         DbProviderFactory.getInstance().closeConnection();
         return result;
      }

      public bool Xuly_TraLaiTruoc(int hd_id, DateTime ngayTraLai, int soNgay, float tienTraTruoc){
         try
         {
            SqlConnection conn = DbProviderFactory.getInstance().connectDB();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.CommandText = "Xuly_TraLaiTruoc";
            command.Parameters.Add("@hd_id", System.Data.SqlDbType.Int).Value = hd_id;
            command.Parameters.Add("@ngayTraLai", System.Data.SqlDbType.Date).Value = ngayTraLai;
            command.Parameters.Add("@soNgay", System.Data.SqlDbType.Int).Value = soNgay;
            command.Parameters.Add("@tien", System.Data.SqlDbType.Float).Value = tienTraTruoc;

            command.ExecuteNonQuery();

            DbProviderFactory.getInstance().closeConnection();
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.StackTrace);
            return false;
         }
         return true;
      }
   }
}
