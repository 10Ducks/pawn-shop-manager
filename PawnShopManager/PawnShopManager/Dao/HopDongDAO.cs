using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawnShopManager.Dto;

namespace PawnShopManager.Dao
{
   class HopDongDAO : BaseDao
   {
#region Function
      #region genSql_TimKiem
      /// <summary>
      /// sinh ra cau truy van de tim kiem
      /// </summary>
      /// <param name="maBN"></param>
      /// <param name="loaiHang"></param>
      /// <param name="tenKH"></param>
      /// <param name="cmnd"></param>
      /// <param name="dienThoai"></param>
      /// <param name="tuNgay"></param>
      /// <param name="toiNgay"></param>
      /// <param name="type">kieu 1: bang chinh, 2: bang phu</param>
      /// <returns></returns>
      public string genSql_TimKiem(
                        Int32 maBN, Int32 loaiHang, String tenKH, String cmnd, 
                        String dienThoai, String tuNgay, String toiNgay, int type){
         StringBuilder sb = new StringBuilder();
         sb.Append("	Select ");
         sb.Append("		hd.hd_id as 'maHD'");
         if(type == 1){
            sb.Append("	, ");
            sb.Append("		hd.hd_maBN, ");
            sb.Append("		hd.hd_ngaytao, ");
            sb.Append("		hd.hd_kh_Ten, ");
            sb.Append("		hd.hd_kh_CMND, ");
            sb.Append("		hd.hd_kh_DienThoai, ");
            sb.Append("		hd.hd_tien_cam, ");
            sb.Append("		chuoc.chuoc_tienlai_thoathuan, ");
            sb.Append("		chuoc.chuoc_tienlai_quahan, ");
            sb.Append("		chuoc.chuoc_tanggiam, ");
            sb.Append("		chuoc.chuoc_tongtien, ");
            sb.Append("		chuoc.chuoc_tongtien - hd.hd_tien_cam as 'tienLoi', ");
            sb.Append("		chuoc.chuoc_ngaytao, ");
            sb.Append("		case  ");
            sb.Append("			when (chuoc.chuoc_ngaytao IS NULL ) then ");
            sb.Append("				Datediff(day, hd.hd_ngaytao, GETDATE()) ");
            sb.Append("			else ");
            sb.Append("				Datediff(day, hd.hd_ngaytao, chuoc.chuoc_ngaytao) ");
            sb.Append("		end as 'soNgayCam', ");
            sb.Append("		case  ");
            sb.Append("			when (hd.hd_trangthai = 1) then ");
            sb.Append("				'Chưa chuộc' ");
            sb.Append("			when (hd.hd_trangthai = 2) then ");
            sb.Append("				'Đã chuộc' ");
            sb.Append("			when (hd.hd_trangthai = 3) then ");
            sb.Append("				'Đã thanh lý' ");
            sb.Append("		end as 'tinhTrang' ");
         }
         sb.Append("	from tbl_Hop_Dong hd");
         sb.Append("	left join tbl_Chuoc_Hang chuoc ");
         sb.Append("		on hd.hd_id = chuoc.hd_id ");
         //sb.Append("	left join tbl_Chi_Tiet_Hang_Cam cthc ");
         //sb.Append("		on hd.hd_id = cthc.hd_id ");
         sb.Append("	where hd.delete_flag = 0 ");

         if (maBN > 0)
         {
            sb.Append(" and hd.hd_maBN = ").Append(maBN);
            //sb.Append(" and YEAR(hd.hd_ngaytao) = YEAR(GETDATE())");
         }
         if (!tenKH.Equals(""))
         {
            sb.Append(" and hd.hd_kh_Ten like N'%").Append(tenKH).Append("%'");
         }
         if (!cmnd.Equals(""))
         {
            sb.Append(" and hd.hd_kh_cmnd like '%").Append(cmnd).Append("%'");
         }
         if (!dienThoai.Equals(""))
         {
            sb.Append(" and hd.hd_kh_dienthoai like '%").Append(dienThoai).Append("%'");
         }
         if (!tuNgay.Equals(""))
         {
            sb.Append(" and hd.hd_ngaytao >= '").Append(tuNgay).Append("'");
         }
         if (!toiNgay.Equals(""))
         {
            sb.Append(" and hd.hd_ngaytao <= '").Append(toiNgay).Append("'");
         }
         if (loaiHang > -1)
         {
            if (loaiHang == 0) //vàng
            {
               sb.Append(" and hd.hd_id in ( select ");
               sb.Append("                      cthc.hd_id ");
               sb.Append("                   from tbl_Chi_Tiet_Hang_Cam cthc");
               sb.Append("                   where cthc.loai_id in (2,3,4) ");
               sb.Append("                     and cthc.delete_flag = 0 ");
               sb.Append("                  ) ");
            }
            if (loaiHang == 1) //xe
            {
               sb.Append(" and hd.hd_id in ( select ");
               sb.Append("                      cthc.hd_id ");
               sb.Append("                   from tbl_Chi_Tiet_Hang_Cam cthc");
               sb.Append("                   where cthc.loai_id = 1 ");
               sb.Append("                     and cthc.delete_flag = 0 ");
               sb.Append("                  ) ");
            }
         }
         return sb.ToString();
      }
      #endregion

      #region genSql_TimKiem_2
      public string genSql_TimKiem_2(
                        Int32 maBN, Int32 loaiHang, String tenKH, String cmnd,
                        String dienThoai, String tuNgay, String toiNgay)
      {
         string subSql = genSql_TimKiem(maBN, loaiHang, tenKH, cmnd, 
                        dienThoai, tuNgay, toiNgay, 2);
         StringBuilder sb = new StringBuilder();
         sb.Append(" select ");
         sb.Append(" 	hd.hd_id as 'maHD', ");
         sb.Append(" 	hd.hd_maBN as 'maBN', ");
         sb.Append(" 	loai.loaihang_ten as 'loaiHang', ");
         sb.Append(" 	cthc.cthc_ten_hang_cam as 'tenMatHang', ");
         sb.Append(" 	cthc.cthc_soluong as 'soLuong', ");
         sb.Append(" 	CASE   ");
         sb.Append(" 	  WHEN cthc.loai_id IN (2,3,4) THEN 'chỉ'  ");
         sb.Append(" 	  ELSE 'chiếc'  ");
         sb.Append(" 	END as 'donViTinh', ");
         sb.Append(" 	cthc.cthc_chatluong as 'chatLuong', ");
         sb.Append(" 	cthc.cthc_BienSoXe as 'bienSo', ");
         sb.Append(" 	cthc.cthc_loaixe as 'loaiXe', ");
         sb.Append(" 	cthc.loai_id as 'loaiHangId' ");
         sb.Append(" from tbl_Hop_Dong hd, tbl_Chi_Tiet_Hang_Cam cthc, tbl_Loai_Hang loai ");
         sb.Append(" where hd.hd_id = cthc.hd_id ");
         sb.Append(" and cthc.loai_id = loai.loaihang_id ");
         sb.Append(" and cthc.hd_id in (").Append(subSql).Append(" )");
         if (loaiHang > -1)
         {
            if (loaiHang == 0) //vàng
            {
               sb.Append(" and cthc.loai_id in (2,3,4) ");
            }
            if (loaiHang == 1) //xe
            {
               sb.Append(" and cthc.loai_id = 1");
            }
         }
         return sb.ToString();
      }
      #endregion

      #region timKiem
      public DataTable timKiem(Int32 maBN, Int32 loaiHang, String tenKH, String cmnd,
                        String dienThoai, String tuNgay, String toiNgay, int type)
      {
         DataTable dataTable = new DataTable("TimKiem");
         SqlDataAdapter adapter = new SqlDataAdapter();
         SqlConnection conn = DbProviderFactory.getInstance().connectDB();

         SqlCommand command = new SqlCommand();
         command.CommandType = System.Data.CommandType.Text;
         command.Connection = conn;
         command.CommandText = genSql_TimKiem(maBN, loaiHang, tenKH, cmnd, dienThoai, tuNgay, toiNgay, type);
         
         Console.WriteLine("----------------------------------------------------");
         Console.WriteLine("genSql_TimKiem");
         Console.WriteLine(command.CommandText);
         Console.WriteLine("----------------------------------------------------");
   
         adapter.SelectCommand = command;
         adapter.Fill(dataTable);

         DbProviderFactory.getInstance().closeConnection();
         return dataTable;
      }
      #endregion

      #region timKiem_2
      public DataTable timKiem_2(Int32 maBN, Int32 loaiHang, String tenKH, String cmnd,
                        String dienThoai, String tuNgay, String toiNgay)
      {
         DataTable dataTable = new DataTable("TimKiem2");
         SqlDataAdapter adapter = new SqlDataAdapter();
         SqlConnection conn = DbProviderFactory.getInstance().connectDB();

         SqlCommand command = new SqlCommand();
         command.CommandType = System.Data.CommandType.Text;
         command.Connection = conn;
         command.CommandText = genSql_TimKiem_2(maBN, loaiHang, tenKH, cmnd, dienThoai, tuNgay, toiNgay);
         
         Console.WriteLine("----------------------------------------------------");
         Console.WriteLine("genSql_TimKiem_2");
         Console.WriteLine(command.CommandText);
         Console.WriteLine("----------------------------------------------------");

         adapter.SelectCommand = command;
         adapter.Fill(dataTable);

         DbProviderFactory.getInstance().closeConnection();
         return dataTable;
      }
      #endregion

      #region lẫy mã BN lớn nhất
      public int getMaBN_max(){
         SqlConnection conn = DbProviderFactory.getInstance().connectDB();

         SqlCommand command = new SqlCommand();
         command.CommandType = System.Data.CommandType.StoredProcedure;
         command.Connection = conn;
         command.CommandText = "layMaBN_Max";
         command.Parameters.Add("@maBN_max", System.Data.SqlDbType.Int);
         command.Parameters["@maBN_max"].Direction = ParameterDirection.Output;
         command.ExecuteNonQuery();

         DbProviderFactory.getInstance().closeConnection();
         return Convert.ToInt32(command.Parameters["@maBN_max"].Value);
      }
      #endregion

      #region thêm Hợp đồng
      public int themHD(int maBN, DateTime ngayTao, float tienCam, 
					string cmnd, string tenKH, string dienThoai, 
					string diaChi, 
					float laiSuat_ThoaThuan, float laiSuat_QuaHan){
         try{
            SqlConnection conn = DbProviderFactory.getInstance().connectDB();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.CommandText = "themHD";
            command.Parameters.Add("@hd_maBN", System.Data.SqlDbType.Int).Value = maBN;
            command.Parameters.Add("@hd_ngaytao", System.Data.SqlDbType.Date).Value = ngayTao;
            command.Parameters.Add("@hd_tien_cam", System.Data.SqlDbType.Float).Value = tienCam;
            command.Parameters.Add("@hd_kh_CMND", System.Data.SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@hd_kh_Ten", System.Data.SqlDbType.NVarChar).Value = tenKH;
            command.Parameters.Add("@hd_kh_DienThoai", System.Data.SqlDbType.VarChar).Value = dienThoai;
            command.Parameters.Add("@hd_kh_Diachi", System.Data.SqlDbType.NVarChar).Value = diaChi;
            command.Parameters.Add("@hd_LaiSuat_ThoaThuan", System.Data.SqlDbType.Float).Value = laiSuat_ThoaThuan;
            command.Parameters.Add("@hd_LaiSuat_QuaHan", System.Data.SqlDbType.Float).Value = laiSuat_QuaHan;

            command.Parameters.Add("@keyAuto", System.Data.SqlDbType.Int);
            command.Parameters["@keyAuto"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            DbProviderFactory.getInstance().closeConnection();
            return Convert.ToInt32(command.Parameters["@keyAuto"].Value);
         }catch(Exception ex){
            Console.WriteLine(ex.StackTrace);
            return -1;
         }
      }
      #endregion

      #region lấy hợp đồng them mã BN - trong phần quản lý hàng cầm
      public HopDongDto layHD_TheoMaBN(int maBN, int nam){

         SqlConnection conn = DbProviderFactory.getInstance().connectDB();

         SqlCommand command = new SqlCommand("layHD_TheoMaBN", conn);
         command.CommandType = System.Data.CommandType.StoredProcedure;
         command.Parameters.Add("@maBN", System.Data.SqlDbType.Int).Value = maBN;
         command.Parameters.Add("@nam", System.Data.SqlDbType.Int).Value = nam;

         SqlDataReader reader = command.ExecuteReader();
         HopDongDto hd = null;
         while (reader.Read())
         {
            hd = new HopDongDto();
            hd.hd_id = reader.GetInt32(0);
            hd.maBN = reader.GetInt32(1);
            hd.ngayTao = reader.GetDateTime(2);
            hd.trangThai = reader.GetInt32(3);
            hd.baoMat = reader.GetBoolean(4);
            hd.tienCam = reader.GetDouble(5);
            hd.cmnd = reader.GetString(6);
            hd.tenKH = reader.GetString(7);
            hd.laiSuatThoaThuan = reader.GetDouble(8);
            hd.laiSuatQuaHan = reader.GetDouble(9);
            hd.thoiHan = reader.GetInt32(10);

            break; //cheat code, only 1 was returned
         }

         DbProviderFactory.getInstance().closeConnection();
         return hd;
      }
      #endregion

      #region lấy tất cả mã biên nhận
      public string[] layTatCaMaBN()
      {
         SqlConnection conn = DbProviderFactory.getInstance().connectDB();

         SqlCommand command = new SqlCommand("layTatCaMaBN", conn);
         command.CommandType = System.Data.CommandType.StoredProcedure;

         SqlDataReader reader = command.ExecuteReader();
         List<string> list = new List<string>();
         while (reader.Read())
         {
            list.Add(reader.GetInt32(0).ToString());
         }

         DbProviderFactory.getInstance().closeConnection();
         return list.ToArray();
      }
      #endregion

      public bool xuLy_BaoMatHD(int hd_id, DateTime ngayBaoMat)
      {
         try
         {
            SqlConnection conn = DbProviderFactory.getInstance().connectDB();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.CommandText = "XuLy_BaoMatHD";
            command.Parameters.Add("@hd_id", System.Data.SqlDbType.Int).Value = hd_id;
            command.Parameters.Add("@ngayBaoMat", System.Data.SqlDbType.Date).Value = ngayBaoMat;

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
#endregion
   }
}
