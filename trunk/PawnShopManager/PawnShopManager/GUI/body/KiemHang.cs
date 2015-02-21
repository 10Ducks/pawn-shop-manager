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
using DevComponents.DotNetBar.Controls;
using System.Collections;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace PawnShopManager.GUI.BODY
{
   public partial class KiemHang : DevComponents.DotNetBar.Metro.MetroForm
   {

      public KiemHang()
      {
         InitializeComponent();

         superGridControl_Chuoc.DataBindingComplete += SuperGridControlDataBindingComplete;
         superGridControl_Ton.DataBindingComplete += SuperGridControlDataBindingComplete;
      }

#region Event

      #region KiemHang_Load
      private void KiemHang_Load(object sender, EventArgs e)
      {
         cboTkTheo_Ton.SelectedIndex = 0;
         cboTkTheo_Chuoc.SelectedIndex = 0;
      }
      #endregion

      #region cboTkTheo_Ton_SelectedIndexChanged
      private void cboTkTheo_Ton_SelectedIndexChanged(object sender, EventArgs e)
      {
         int i = cboTkTheo_Ton.SelectedIndex;
         if (i == 0)
         { //chon Ngay
            datePicker_Ton.CustomFormat = "dd/MM/yyyy";
            datePicker_Ton.ButtonDropDown.Visible = true;
            lblLoaiThongKe_Ton.Text = "Chọn ngày:";
         }
         else if (i == 1)
         { //chon Thang
            datePicker_Ton.CustomFormat = "MM/yyyy";
            datePicker_Ton.ButtonDropDown.Visible = false;
            lblLoaiThongKe_Ton.Text = "Chọn tháng:";
         }
         else if (i == 2)
         { //chon Nam
            datePicker_Ton.CustomFormat = "yyyy";
            datePicker_Ton.ButtonDropDown.Visible = false;
            lblLoaiThongKe_Ton.Text = "Chọn năm:";
         }
      }
      #endregion

      #region cboTkTheo_Chuoc_SelectedIndexChanged
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
      #endregion

      #region btnKiemHang_Chuoc_Click
      private void btnKiemHang_Chuoc_Click(object sender, EventArgs e)
      {
         int index = cboTkTheo_Chuoc.SelectedIndex;
         int ngay = 0, thang = 0, nam = 0;

         ngay = Int16.Parse(datePicker_Chuoc.Value.Day.ToString());
         thang = Int16.Parse(datePicker_Chuoc.Value.Month.ToString());
         nam = Int16.Parse(datePicker_Chuoc.Value.Year.ToString());

         if (index == 1) //chon theo thang
         {
            ngay = 0;
         }
         else if (index == 2) //chon theo nam
         {
            ngay = 0;
            thang = 0;
         }

         DataSet dataSet = new DataSet();
         DataTable tblHdChuoc = Controller.Controller.getInstance().layHD_Chuoc(ngay, thang, nam);
         DataTable tblChiTietHdChuoc = Controller.Controller.getInstance().thongKe_Chuoc_DataTable(ngay, thang, nam);
         dataSet.Tables.Add(tblHdChuoc);
         dataSet.Tables.Add(tblChiTietHdChuoc);
         dataSet.Relations.Add("1", dataSet.Tables[0].Columns["maHD"],
                                                    dataSet.Tables[1].Columns["maHD"], false);

         superGridControl_Chuoc.PrimaryGrid.DataSource = dataSet;
         superGridControl_Chuoc.PrimaryGrid.DataMember = "HopDongChuoc";

         //khoi tao cac bien dem
         int dem18k = 0, dem24k = 0, demTrang = 0, demXe = 0;
         for (int i = 0; i < tblChiTietHdChuoc.Rows.Count; i++)
         {
            string loaiId = tblChiTietHdChuoc.Rows[i]["loaiHangId"].ToString();
            int soLuong = Int32.Parse(tblChiTietHdChuoc.Rows[i]["soLuong"].ToString());
            switch (loaiId)
            {
               case "1":
                  demXe += soLuong;
                  break;
               case "2":
                  dem18k += soLuong;
                  break;
               case "3":
                  dem24k += soLuong;
                  break;
               case "4":
                  demTrang += soLuong;
                  break;
            }
         }

         lblTongSoMon_Chuoc.Text = tblChiTietHdChuoc.Rows.Count.ToString();
         lbl18k_Chuoc.Text = dem18k.ToString();
         lbl24k_Chuoc.Text = dem24k.ToString();
         lblVangTrang_Chuoc.Text = demTrang.ToString();
         lblXeMay_Chuoc.Text = demXe.ToString();
      }
      #endregion

      #region SuperGridControlDataBindingComplete
      void SuperGridControlDataBindingComplete(
                  object sender, GridDataBindingCompleteEventArgs e)
      {
         GridPanel panel = e.GridPanel;

         panel.GroupByRow.Visible = true;

         switch (panel.DataMember)
         {
            case "HopDongChuoc":
               Customize_HopDong_Panel(panel);
               break;

            case "ThongKeChuoc":
               Customize_HangCam_Panel(panel);
               break;
            case "HopDongChuaChuoc":
               Customize_HopDong_Panel(panel);
               break;

            case "ThongKeChuaChuoc":
               Customize_HangCam_Panel(panel);
               break;
         }
      }
      #endregion

      #region btnKiemHang_Ton_Click
      private void btnKiemHang_Ton_Click(object sender, EventArgs e)
      {
         int index = cboTkTheo_Ton.SelectedIndex;
         int ngay = 0, thang = 0, nam = 0;

         ngay = Int16.Parse(datePicker_Ton.Value.Day.ToString());
         thang = Int16.Parse(datePicker_Ton.Value.Month.ToString());
         nam = Int16.Parse(datePicker_Ton.Value.Year.ToString());

         if (index == 1) //chon theo thang
         {
            ngay = 0;
         }
         else if (index == 2) //chon theo nam
         {
            ngay = 0;
            thang = 0;
         }

         DataSet dataSet = new DataSet();
         DataTable tblHdChuaChuoc = Controller.Controller.getInstance().layHD_ChuaChuoc(ngay, thang, nam);
         DataTable tblChiTietHdChuaChuoc = Controller.Controller.getInstance().thongKe_ChuaChuoc_DataTable(ngay, thang, nam);
         dataSet.Tables.Add(tblHdChuaChuoc);
         dataSet.Tables.Add(tblChiTietHdChuaChuoc);
         dataSet.Relations.Add("1", dataSet.Tables[0].Columns["maHD"],
                                                    dataSet.Tables[1].Columns["maHD"], false);

         superGridControl_Ton.PrimaryGrid.DataSource = dataSet;
         superGridControl_Ton.PrimaryGrid.DataMember = "HopDongChuaChuoc";

         //khoi tao cac bien dem
         int dem18k = 0, dem24k = 0, demTrang = 0, demXe = 0;
         for (int i = 0; i < tblChiTietHdChuaChuoc.Rows.Count; i++)
         {
            string loaiId = tblChiTietHdChuaChuoc.Rows[i]["loaiHangId"].ToString();
            int soLuong = Int32.Parse(tblChiTietHdChuaChuoc.Rows[i]["soLuong"].ToString());
            switch (loaiId)
            {
               case "1":
                  demXe += soLuong;
                  break;
               case "2":
                  dem18k += soLuong;
                  break;
               case "3":
                  dem24k += soLuong;
                  break;
               case "4":
                  demTrang += soLuong;
                  break;
            }
         }

         lblTongSoMon_Ton.Text = tblChiTietHdChuaChuoc.Rows.Count.ToString();
         lbl18k_Ton.Text = dem18k.ToString();
         lbl24k_Ton.Text = dem24k.ToString();
         lblVangTrang_Ton.Text = demTrang.ToString();
         lblXeMay_Ton.Text = demXe.ToString();
      }
      #endregion

#endregion
     
#region Function

      #region Customize_HopDong_Panel
      private void Customize_HopDong_Panel(GridPanel panel)
      {
         panel.FrozenColumnCount = 1;
         panel.ColumnHeader.RowHeight = 30;

         panel.Columns[0].GroupBoxEffects = GroupBoxEffects.None;
         panel.Columns["maHD"].HeaderText = "Mã BN";
         panel.Columns["tenKH"].HeaderText = "Tên KH";
         panel.Columns["dienThoai"].HeaderText = "Điện thoại";
         panel.Columns["tienCam"].HeaderText = "Tiền cầm";
         panel.Columns["ngayCam"].HeaderText = "Ngày cầm";
         panel.Columns["ngayHetHan"].HeaderText = "Ngày tới hạn";
         panel.Columns["soNgayCam"].HeaderText = "Số ngày cầm";

         panel.Columns[0].CellStyles.Default.Background =
             new Background(Color.AliceBlue);

         foreach (GridColumn column in panel.Columns)
         {
            column.ColumnSortMode = ColumnSortMode.Multiple;
         }

         superGridControl_Chuoc.BeginUpdate();
         double tongTien = 0;
         foreach (GridRow row in panel.Rows)
         {
            row.Cells["tienCam"].Value = String.Format("{0:0,0}", (double)row.Cells["tienCam"].Value);
            tongTien += (double)row.Cells["tienCam"].Value;
            //check qua han
            if(Int32.Parse(row.Cells["soNgayCam"].Value.ToString()) > 60){
               //row.CellStyles.Default.Background = new Background(Color.Red);
               //row.CellStyles.Default.TextColor = Color.Red;
               row.Cells["soNgayCam"].CellStyles.Default.Background = new Background(Color.Red);
            }
         }
         superGridControl_Chuoc.EndUpdate();
         
         if(tabTkHangChuoc.IsSelected){
            lblTongSoTien_Chuoc.Text = String.Format("{0:0,0}", tongTien);
         }
         if (tabTkHangTon.IsSelected)
         {
            lblTongSoTien_Ton.Text = String.Format("{0:0,0}", tongTien);
         }
      }
      #endregion

      #region Customize_HangCam_Panel
      private void Customize_HangCam_Panel(GridPanel panel)
      {
         panel.FrozenColumnCount = 1;
         panel.ColumnHeader.RowHeight = 30;

         panel.Columns[0].GroupBoxEffects = GroupBoxEffects.None;
         panel.Columns["maHD"].Visible = false;
         panel.Columns["loaiHangId"].Visible = false;
         panel.Columns["loaiHang"].HeaderText = "Loại hàng";
         panel.Columns["tenMatHang"].HeaderText = "Tên MH";
         panel.Columns["soLuong"].HeaderText = "Số lượng";
         panel.Columns["donViTinh"].HeaderText = "Đơn vị tính";
         panel.Columns["chatLuong"].HeaderText = "Chất lượng";
         panel.Columns["bienSo"].HeaderText = "Biển Số";
         panel.Columns["loaiXe"].HeaderText = "Loại xe";

         panel.SelectionGranularity = SelectionGranularity.RowWithCellHighlight;
         panel.InitialSelection = RelativeSelection.Row;
         panel.ReadOnly = true;
         panel.GroupByRow.WatermarkText = "Kéo cột vào đây để lọc";
         panel.Caption.Text = String.Format("Các hàng cầm của KH <font color=\"Maroon\"><i>\"{0}</i>\"</font>",
                         ((GridRow)panel.Parent)["tenKH"].Value);

         superGridControl_Chuoc.BeginUpdate();
         foreach (GridRow row in panel.Rows)
         {
            string loaiHang = row.Cells["loaiHang"].Value.ToString();
            string dvt = row.Cells["donViTinh"].Value.ToString();
            if (loaiHang == "Vàng trang") //fix loi database
            {
               row.Cells["loaiHang"].Value = "Vàng trắng";
            }
            if (dvt == "chi?") //fix loi database
            {
               row.Cells["donViTinh"].Value = "chỉ";
            }

         }
         superGridControl_Chuoc.EndUpdate();
      }
      #endregion

#endregion
      
   }
}
