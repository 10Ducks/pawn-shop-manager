using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopManager.Util
{
   class base64
   {
      public static void main()
      {
         string str = "kamejokokakolaA123kakaka";
         Console.WriteLine("---------------------");
         Console.WriteLine("{0}",Base64Encode(str));
      }
      public static string Base64Encode(string plainText)
      {
         var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
         return System.Convert.ToBase64String(plainTextBytes);
      }
      public static string Base64Decode(string base64EncodedData)
      {
         var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
         return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
      }
   }
}
