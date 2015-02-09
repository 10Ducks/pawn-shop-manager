using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawnShopManager.Entity;
using System.Data.SqlClient;
using PawnShopManager.Util;

namespace PawnShopManager.Dao
{
   class AdminDAO : BaseDao
   {
      private readonly string ADMIN_ID = "Admin_Id";
      private readonly string ADMIN_PASSWORD = "Admin_Password";

      public List<Admin> getLogin(string id, string pass){
         SqlConnection conn = DbProviderFactory.getInstance().connectDB();
         
         SqlCommand command = new SqlCommand("getLogin", conn);
         command.CommandType = System.Data.CommandType.StoredProcedure;
         command.Parameters.Add("@ID", System.Data.SqlDbType.Text).Value = id;
         command.Parameters.Add("@Pass", System.Data.SqlDbType.Text).Value = pass;

         SqlDataReader reader = command.ExecuteReader();
         List<Admin> ds = new List<Admin>();
         while (reader.Read())
         {
            Admin admin = new Admin();
            admin.admin_Id = reader.GetString(0);
            admin.admin_Password = reader.GetString(1);
            ds.Add(admin);
         }

         DbProviderFactory.getInstance().closeConnection() ;
         return ds;
      }
   }
}
