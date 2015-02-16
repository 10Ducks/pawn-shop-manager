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
         int i = cboTkTheo_Chuoc.SelectedIndex;         
         int ngay = 0, thang = 0, nam = 0;

         if(i == 0){ //chon theo ngay
            ngay = Int16.Parse(datePicker_Chuoc.Value.Day.ToString());
            thang = Int16.Parse(datePicker_Chuoc.Value.Month.ToString());
            nam = Int16.Parse(datePicker_Chuoc.Value.Year.ToString());
         }
         else if (i == 1) //chon theo thang
         {
            thang = Int16.Parse(datePicker_Chuoc.Value.Month.ToString());
            nam = Int16.Parse(datePicker_Chuoc.Value.Year.ToString());
         }
         else if (i == 2) //chon theo nam
         {
            nam = Int16.Parse(datePicker_Chuoc.Value.Year.ToString());
         }

         List<TkChuocDto> listThongKe = Controller.Controller.getInstance().thongKe_Chuoc(ngay, thang, nam);
         for(int j=0; j<listThongKe.Count; j++){
            Console.WriteLine(listThongKe[j].loaiXe);
         }
      }


   }
}
