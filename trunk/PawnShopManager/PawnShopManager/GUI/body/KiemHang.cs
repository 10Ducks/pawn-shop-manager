using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PawnShopManager.Dto;

namespace PawnShopManager.GUI.BODY
{
   public partial class KiemHang : DevComponents.DotNetBar.Metro.MetroForm
   {
      public KiemHang()
      {
         InitializeComponent();
      }

      private void KiemHang_Load(object sender, EventArgs e)
      {
         cboTkTheo_Ton.SelectedIndex = 0;
         cboTkTheo_Chuoc.SelectedIndex = 0;
      }

      private void cboTkTheo_Ton_SelectedIndexChanged(object sender, EventArgs e)
      {
         int i = cboTkTheo_Ton.SelectedIndex;
         if (i == 0)
         { //chon Ngay
            datePicker_Ton.CustomFormat = "dd/MM/yyyy";
            datePicker_Ton.ButtonDropDown.Visible = true;
            lblLoaiThongKe_Ton.Text = "Chọn ngày:";
         }else if(i == 1){ //chon Thang
            datePicker_Ton.CustomFormat = "MM/yyyy";
            datePicker_Ton.ButtonDropDown.Visible = false;
            lblLoaiThongKe_Ton.Text = "Chọn tháng:";
         }else if(i == 2){ //chon Nam
            datePicker_Ton.CustomFormat = "yyyy";
            datePicker_Ton.ButtonDropDown.Visible = false;
            lblLoaiThongKe_Ton.Text = "Chọn năm:";
         }
      }

      private void cboTkTheo_Chuoc_SelectedIndexChanged(object sender, EventArgs e)
      {
         int i = cboTkTheo_Chuoc.SelectedIndex;
         if (i == 0)
         { //chon Ngay
            datePicker_Chuoc.CustomFormat = "dd/MM/yyyy";
            datePicker_Chuoc.ButtonDropDown.Visible = true;
            lblLoaiThongKe_Chuoc.Text = "Chọn ngày:";
         }
         else if (i == 1)
         { //chon Thang
            datePicker_Chuoc.CustomFormat = "MM/yyyy";
            datePicker_Chuoc.ButtonDropDown.Visible = false;
            lblLoaiThongKe_Chuoc.Text = "Chọn tháng:";
         }
         else if (i == 2)
         { //chon Nam
            datePicker_Chuoc.CustomFormat = "yyyy";
            datePicker_Chuoc.ButtonDropDown.Visible = false;
            lblLoaiThongKe_Chuoc.Text = "Chọn năm:";
         }
      }

      private void btnKiemHang_Chuoc_Click(object sender, EventArgs e)
      {
         int index = cboTkTheo_Chuoc.SelectedIndex;         
         int ngay = 0, thang = 0, nam = 0;

         if (index == 0)
         { //chon theo ngay
            ngay = Int16.Parse(datePicker_Chuoc.Value.Day.ToString());
            thang = Int16.Parse(datePicker_Chuoc.Value.Month.ToString());
            nam = Int16.Parse(datePicker_Chuoc.Value.Year.ToString());
         }
         else if (index == 1) //chon theo thang
         {
            thang = Int16.Parse(datePicker_Chuoc.Value.Month.ToString());
            nam = Int16.Parse(datePicker_Chuoc.Value.Year.ToString());
         }
         else if (index == 2) //chon theo nam
         {
            nam = Int16.Parse(datePicker_Chuoc.Value.Year.ToString());
         }
         
         
         List<TkChuocDto> listThongKe = Controller.Controller.getInstance().thongKe_Chuoc(ngay, thang, nam);
         dataGridKiemHang_Chuoc.RowCount = 0;
         int dem_18k = 0, dem_24k = 0, dem_trang = 0, dem_xe = 0, dem_khac = 0;
         for(int i=0; i<listThongKe.Count; i++){
            TkChuocDto dto = listThongKe[i];
            string loaiHang = "";
            
            switch (dto.loaiHang){
               case "1":
                  loaiHang = "Xe";
                  dem_xe++;
                  break;
               case "2":
                  loaiHang = "Vàng 18k";
                  dem_18k++;
                  break;
               case "3":
                  loaiHang = "Vàng 24k";
                  dem_24k++;
                  break;
               case "4":
                  loaiHang = "Vàng trắng";
                  dem_trang++;
                  break;
               case "5":
                  loaiHang = "Khác";
                  dem_khac++;
                  break;
            }
            dataGridKiemHang_Chuoc.Rows.Add( dto.maHD,
                                             dto.tenKH,
                                             loaiHang,
                                             dto.tenMatHang,
                                             dto.chatLuong,
                                             dto.bienSo,
                                             dto.loaiXe,
                                             String.Format("{0:0,0}", dto.tienCam),
                                             dto.ngayCam,
                                             dto.ngayHetHan,
                                             dto.soNgayCam);
         }
      
         lblTongSoMon_Chuoc.Text = dataGridKiemHang_Chuoc.RowCount.ToString();
         lbl18k_Chuoc.Text = dem_18k.ToString();
         lbl24k_Chuoc.Text = dem_24k.ToString();
         lblVangTrang_Chuoc.Text = dem_trang.ToString();
         lblXeMay_Chuoc.Text = dem_xe.ToString();
      }

   }
}
