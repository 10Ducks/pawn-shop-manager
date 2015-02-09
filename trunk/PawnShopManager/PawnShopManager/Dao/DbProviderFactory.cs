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
      private string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
      private static DbProviderFactory dbProviderFactory = null;
      public SqlConnection conn;

      private DbProviderFactory() {}

      public static DbProviderFactory getInstance()
      {
         if (dbProviderFactory == null)
         {
            dbProviderFactory = new DbProviderFactory();
         }
         return dbProviderFactory;
      }  

      public SqlConnection connectDB()
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
      public void closeConnection()
      {
         try
         {
            if (conn != null)
            {
               conn.Close();
               Console.WriteLine("Dong ket noi.");
            }
         }
         catch (SqlException e)
         {
            Console.WriteLine(e.Message);
         }
      }

   }
}
