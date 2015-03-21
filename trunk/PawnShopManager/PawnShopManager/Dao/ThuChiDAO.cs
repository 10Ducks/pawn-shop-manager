using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopManager.Dao
{
    class ThuChiDAO
    {
        #region thêm Thu Chi
        public bool themTC(int loaiThuChi, DateTime ngayThuChi, float tienThuChi,
                      string ghiChu)
        {
            try
            {
                SqlConnection conn = DbProviderFactory.getInstance().connectDB();

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = conn;
                command.CommandText = "themTHUCHI";
                command.Parameters.Add("@tc_loai", System.Data.SqlDbType.Int).Value = loaiThuChi;
                command.Parameters.Add("@tc_ngaytao", System.Data.SqlDbType.Date).Value = ngayThuChi;
                command.Parameters.Add("@tc_tien", System.Data.SqlDbType.Float).Value = tienThuChi;
                command.Parameters.Add("@tc_note", System.Data.SqlDbType.NVarChar).Value = ghiChu;
                command.Parameters.Add("@keyAuto", System.Data.SqlDbType.Int);
                command.Parameters["@keyAuto"].Direction = ParameterDirection.Output;

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
