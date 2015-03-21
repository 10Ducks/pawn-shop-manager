using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopManager.Dao
{
   class ThanhLyDAO : BaseDao
   {
      public bool XuLy_ThanhLy(int hd_id, DateTime ngayThanhLy, float tienThanhLy){
         try
         {
            SqlConnection conn = DbProviderFactory.getInstance().connectDB();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.CommandText = "Xuly_ThanhLy";
            command.Parameters.Add("@hd_id", System.Data.SqlDbType.Int).Value = hd_id;
            command.Parameters.Add("@ngayThanhLy", System.Data.SqlDbType.Date).Value = ngayThanhLy;
            command.Parameters.Add("@tienThanhLy", System.Data.SqlDbType.Float).Value = tienThanhLy;

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
