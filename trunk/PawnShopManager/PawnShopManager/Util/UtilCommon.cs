using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
namespace PawnShopManager.Util
{
   class UtilCommon
   {
      public static bool validatePhoneNumber(String str)
      {
         if (str == null)
         {
            return true;
         }
         Regex regex = new Regex(".*[^0-9-].*");
         return regex.IsMatch(str);
      }

      public static bool validatePassword(String str)
      {
         if (str == null)
         {
            return true;
         }
         Regex regex = new Regex(Const.Pattern.PASSWORD_PATTERN);
         return regex.IsMatch(str);
      }

      public static string base64Encode(string plainText)
      {
         var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
         return System.Convert.ToBase64String(plainTextBytes);
      }

      public static string base64Decode(string base64EncodedData)
      {
         var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
         return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
      }

      public static string sha256Base64Encode(string clearpwd)
      {
         using (var sha = SHA256Managed.Create())
         {
            string _salt = Const.SALT;
            var computedHash = sha.ComputeHash(Encoding.Unicode.GetBytes(clearpwd + _salt));
            return Convert.ToBase64String(computedHash);
         }
      }
      
      public static bool isEqual(string str1, string str2)
      {
         if (str1 == null && str2 == null)
         {
            return true;
         }
         if (str1 != null && str1.Equals(str2))
         {
            return true;
         }
         return false;
      }

   }
}
