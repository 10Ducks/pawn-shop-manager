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

        public static double[] tinhTienLai(DateTime ngayCam, DateTime ngayChuoc, double tienCam, double laiSuatThoaThuan, double laiSuatQuaHan, int thoiHan, DateTime ngayThemTien, float tienThem)
        {
            double[] tienLai = new double[2];
            tienLai[0] = 0; //tiền lãi thỏa thuận
            tienLai[1] = 0; //tiền lãi quá hạn
            int soNgayHetHan = thoiHan * 30; //thời hạn tính theo tháng, 1 tháng mặc định 30 ngày
            int dayDiff = ngayChuoc.Subtract(ngayCam).Days + 1; //tính cả ngày cầm nên sẽ + thêm 1
            //trường hợp ko có thêm tiền
            if (tienThem <= 0)
            {
                
                //chưa quá hạn
                if (dayDiff <= soNgayHetHan)
                {
                    double laisuat = (laiSuatThoaThuan / 30) * dayDiff;
                    tienLai[0] = tienCam * laisuat / 100;
                }
                //quá hạn
                if (dayDiff > soNgayHetHan)
                {
                    double laisuatTT = (laiSuatThoaThuan / 30) * soNgayHetHan;
                    double laisuatQH = (laiSuatThoaThuan / 30) * (dayDiff - soNgayHetHan);
                    tienLai[0] = tienCam * laisuatTT / 100;
                    tienLai[1] = tienCam * laisuatQH / 100;
                }
            }

            //trường hợp có thêm tiền
            //ko cho thêm tiền nếu quá hạn
            if (tienThem > 0)
            {
                //so tien lai truoc khi them tien
                int dayDiff1 = ngayThemTien.Subtract(ngayCam).Days;
                //so tien lai truoc sau them tien
                int dayDiff2 = ngayChuoc.Subtract(ngayThemTien).Days + 1;
                double laisuat = (laiSuatThoaThuan / 30) * dayDiff1;
                tienLai[0] = tienCam * laisuat / 100;

                laisuat = (laiSuatThoaThuan / 30) * dayDiff2;
                tienLai[0] += (tienCam + tienThem) * laisuat / 100;
                //quá hạn
                if (dayDiff > soNgayHetHan)
                {
                    double laisuatQH = (laiSuatThoaThuan / 30) * (dayDiff - soNgayHetHan);
                    tienLai[1] = tienCam * laisuatQH / 100;
                }
            }
            return tienLai;
        }

        public static string formatTien(double tien)
        {
            return String.Format("{0:0,0}", tien);
        }

        public static string formatNgay(DateTime ngay)
        {
            return String.Format("{0:dd/MM/yyyy}", ngay);
        }

        public static bool validateInteger(string s){
            if(s.Equals("")){
                return false;
            }
            //Regex regex = new Regex("[0-9]");
            //return regex.IsMatch(s);
            Int32 x;
            return Int32.TryParse(s, out x);
        }
    }
}
