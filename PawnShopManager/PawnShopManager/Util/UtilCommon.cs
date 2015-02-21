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

      private static string[] mangso = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
      private static string dochangchuc(int so, bool daydu)
      {
         string chuoi = "";
         int chuc = so / 10;
         int donvi = so % 10;
         if (chuc > 1)
         {
            chuoi = " " + mangso[chuc] + " mươi";
            if (donvi == 1)
            {
               chuoi += " mốt";
            }
         }
         else if (chuc == 1)
         {
            chuoi = " mười";
            if (donvi == 1)
            {
               chuoi += " một";
            }
         }
         else if (daydu && donvi > 0)
         {
            chuoi = " lẻ";
         }
         if (donvi == 5 && chuc > 1)
         {
            chuoi += " lăm";
         }
         else if (donvi > 1 || (donvi == 1 && chuc == 0))
         {
            chuoi += " " + mangso[donvi];
         }
         return chuoi;
      }
      private static string docblock(int so, bool daydu)
      {
         string chuoi = "";
         int tram = so / 100;
         so = so % 100;
         if (daydu || tram > 0)
         {
            chuoi = " " + mangso[tram] + " trăm";
            chuoi += dochangchuc(so, true);
         }
         else
         {
            chuoi = dochangchuc(so, false);
         }
         return chuoi;
      }
      private static string dochangtrieu(int so, bool daydu)
      {
         string chuoi = "";
         int trieu = so / 1000000;
         so = so % 1000000;
         if (trieu > 0)
         {
            chuoi = docblock(trieu, daydu) + " triệu";
            daydu = true;
         }
         int nghin = so / 1000;
         so = so % 1000;
         if (nghin > 0)
         {
            chuoi += docblock(nghin, daydu) + " nghìn";
            daydu = true;
         }
         if (so > 0)
         {
            chuoi += docblock(so, daydu);
         }
         return chuoi;
      }
      public static string docso(double so)
      {
         if (so == 0) { return mangso[0]; }
         string chuoi = "";
         string hauto = "";
         int ty = 0;
         do
         {
            ty = (int)(so % 1000000000);
            so = (int)(so / 1000000000);
            if (so > 0)
            {
               chuoi = dochangtrieu(ty, true) + hauto + chuoi;
            }
            else
            {
               chuoi = dochangtrieu(ty, false) + hauto + chuoi;
            }
            hauto = " tỷ";
         } while (so > 0);
         return chuoi;
      } 
   }
}
