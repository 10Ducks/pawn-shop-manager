using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PawnShopManager.Dao
{
   class DbProviderFactory
   {
      public string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
      private static DbProviderFactory dbProviderFactory = null;
      private SqlConnection conn;

      private DbProviderFactory() {}

      public static DbProviderFactory getInstall()
      {
         if (dbProviderFactory == null)
         {
            dbProviderFactory = new DbProviderFactory();
         }
         return dbProviderFactory;
      }  

      private SqlConnection connectDB()
      {
         conn = new SqlConnection(connectString);
         conn.Open();
         return conn;
      }

      /**
     * Close connection
     *
     * @param dbConnection Connection to DB
     *
     */
      private void closeConnection(SqlConnection dbConnection)
      {
         try
         {
            if (dbConnection != null)
            {
               dbConnection.Close();
            }
         }
         catch (SqlException e)
         {
            Console.WriteLine(e.Message);
         }
      }

   }
}
