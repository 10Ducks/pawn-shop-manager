using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopManager.Dao
{
    class ThemTienDAO : BaseDao
    {
        public bool XuLy_ThemTien(int hd_id, DateTime ngayThem, float tienLai, float tienThem, int hinhThuc)
        {
            try
            {
                SqlConnection conn = DbProviderFactory.getInstance().connectDB();

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = conn;
                command.CommandText = "Xuly_ThemTien";
                command.Parameters.Add("@hd_id", System.Data.SqlDbType.Int).Value = hd_id;
                command.Parameters.Add("@ngayThem", System.Data.SqlDbType.Date).Value = ngayThem;
                command.Parameters.Add("@tienLai", System.Data.SqlDbType.Float).Value = tienLai;
                command.Parameters.Add("@tienThem", System.Data.SqlDbType.Float).Value = tienThem;
                command.Parameters.Add("@hinhThuc", System.Data.SqlDbType.Int).Value = hinhThuc;

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

        public DateTime layNgayThemTien(int hd_id)
        {
            DateTime result = new DateTime();
            try
            {
                SqlConnection conn = DbProviderFactory.getInstance().connectDB();

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = conn;
                command.CommandText = "layNgayThemTien";
                command.Parameters.Add("@hd_id", System.Data.SqlDbType.Int).Value = hd_id;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.NextResult()){
                    result = reader.GetDateTime(0);
                }

                DbProviderFactory.getInstance().closeConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return result;
        }
    }
}
