using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopManager.Util
{
   class Sha256
   {
      private const string _salt = "P&0myWHq";
      public static void main()
      {
         string str = "kamejokokakolaA123kakaka";
         Console.WriteLine("---------------------");
         Console.WriteLine("{0}", CalculateHashedPassword(str));

      }
      private static string CalculateHashedPassword(string clearpwd)
      {
         using (var sha = SHA256Managed.Create())
         {
            var computedHash = sha.ComputeHash(Encoding.Unicode.GetBytes(clearpwd + _salt));
            return Convert.ToBase64String(computedHash);
         }
      }
   }
}
