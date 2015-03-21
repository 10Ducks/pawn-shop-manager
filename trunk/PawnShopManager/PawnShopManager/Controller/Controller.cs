using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawnShopManager.Dao;
using PawnShopManager.Entity;
using PawnShopManager.Dto;
using System.Data;

namespace PawnShopManager.Controller
{
   class Controller
   {
      private AdminDAO adminDAO = new AdminDAO();
      private ChuocHangDAO chuocHangDAO = new ChuocHangDAO();
      private HopDongDAO hopDongDAO = new HopDongDAO();
      private ChiTietHangCamDAO chiTietHangCamDAO = new ChiTietHangCamDAO();
      private TraLaiTruocDAO traLaiTruocDAO = new TraLaiTruocDAO();
      private ThanhLyDAO thanhLyDAO = new ThanhLyDAO();
      private ThemTienDAO themTienDAO = new ThemTienDAO();
	  private ThuChiDAO thuchiDAO = new ThuChiDAO();

      private static Controller controller = null;

      private Controller(){}
      public static Controller getInstance()
      {
         if (controller == null)
         {
            controller = new Controller();
         }
         return controller;
      }  

      public List<Admin> getLogin(string id, string pass){
           return adminDAO.getLogin(id, pass);
      }

      public List<TkChuocDto> thongKe_Chuoc_List(int ngay, int thang, int nam)
      {
         return chuocHangDAO.thongKe_Chuoc_List(ngay, thang, nam);
      }

      public DataTable thongKe_Chuoc_DataTable(int ngay, int thang, int nam)
      {
         return chuocHangDAO.thongKe_Chuoc_DataTable(ngay, thang, nam);
      }

      public DataTable layHD_Chuoc(int ngay, int thang, int nam)
      {
         return chuocHangDAO.layHD_Chuoc(ngay, thang, nam);
      }

      public DataTable thongKe_ChuaChuoc_DataTable(int ngay, int thang, int nam){
         return chuocHangDAO.thongKe_ChuaChuoc_DataTable(ngay, thang, nam);
      }

      public DataTable layHD_ChuaChuoc(int ngay, int thang, int nam){
         return chuocHangDAO.layHD_ChuaChuoc(ngay, thang, nam);
      }

      public DataTable timKiem(int maBN, int loaiHang, string tenKH, string cmnd,
                              string dienThoai, string tuNgay, string toiNgay, int type){
         return hopDongDAO.timKiem( maBN,  loaiHang,  tenKH,  cmnd,
                               dienThoai,  tuNgay,  toiNgay, type);
      }

      public DataTable timKiem_2(int maBN, int loaiHang, string tenKH, string cmnd,
                                    string dienThoai, string tuNgay, string toiNgay)
      {
         return hopDongDAO.timKiem_2(maBN, loaiHang, tenKH, cmnd,
                               dienThoai, tuNgay, toiNgay);
      }

      public int getMaBN_max(){
         return hopDongDAO.getMaBN_max();
      }

      public bool themChiTietHangCam_Vang(int hd_id, int soLuong, string tenMH, float giatri, int loai)
      {
         return chiTietHangCamDAO.themChiTietHangCam_Vang(hd_id, soLuong, tenMH, giatri, loai);
      }

      public bool themChiTietHangCam_Xe(int hd_id, string bienSo, float giaTri, 
			string chatLuong, string loaiXe, string nhanSoXe)
      {
         return chiTietHangCamDAO.themChiTietHangCam_Xe(hd_id, bienSo, giaTri, chatLuong, loaiXe, nhanSoXe);
      }
   
      public int themHD(int maBN, DateTime ngayTao, float tienCam, 
					string cmnd, string tenKH, string dienThoai, 
					string diaChi, 
					float laiSuat_ThoaThuan, float laiSuat_QuaHan){
         return hopDongDAO.themHD(maBN, ngayTao, tienCam, cmnd, tenKH, dienThoai, diaChi, laiSuat_ThoaThuan, laiSuat_QuaHan);
      }
      
      public HopDongDto layHD_TheoMaBN(int maBN, int nam){
         return hopDongDAO.layHD_TheoMaBN(maBN, nam);
      }   

      public string[] layTatCaMaBN(){
         return hopDongDAO.layTatCaMaBN();
      public bool themTC(int loaiThuChi, DateTime ngayThuChi, float tienThuChi,
                      string ghiChu)
      {
          return thuchiDAO.themTC(loaiThuChi, ngayThuChi, tienThuChi,
                      ghiChu);
      }      }

      public DataTable layCTHC_TheoHdId(int hd_id){
         return chiTietHangCamDAO.layCTHC_TheoHdId(hd_id);
      }

      public double layTienTraLaiTruoc(int maHD){
         return traLaiTruocDAO.layTienTraLaiTruoc(maHD);
      }

      public bool Xuly_ChuocDo(int hd_id, DateTime ngayChuoc, 
			       float tienLaiThoaThuan,  float tienLaiQuaHan, 
			       float tienTangGiam,  float tongTien){
         return chuocHangDAO.Xuly_ChuocDo(hd_id, ngayChuoc, tienLaiThoaThuan, tienLaiQuaHan, tienTangGiam, tongTien);
      }

      public bool XuLy_ThanhLy(int hd_id, DateTime ngayThanhLy, float tienThanhLy){
         return thanhLyDAO.XuLy_ThanhLy(hd_id, ngayThanhLy, tienThanhLy);
      }

      public bool Xuly_TraLaiTruoc(int hd_id, DateTime ngayTraLai, int soNgay, float tienTraTruoc){
         return traLaiTruocDAO.Xuly_TraLaiTruoc(hd_id, ngayTraLai, soNgay, tienTraTruoc);
      }

      public bool xuLy_BaoMatHD(int hd_id, DateTime ngayBaoMat){
         return hopDongDAO.xuLy_BaoMatHD( hd_id, ngayBaoMat);
      }

      public bool XuLy_ThemTien( int hd_id,  DateTime ngayThem,  float tienLai,  float tienThem,  int hinhThuc){
         return themTienDAO.XuLy_ThemTien(hd_id, ngayThem, tienLai, tienThem, hinhThuc);
      }
   }
}
