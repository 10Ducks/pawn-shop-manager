using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Globalization;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace PawnShopManager.GUI.BODY
{
    public partial class TimKiem : DevComponents.DotNetBar.Metro.MetroForm
    {
        public TimKiem()
        {
            InitializeComponent();

            superGridControl_TimKiem.DataBindingComplete += SuperGridControlDataBindingComplete;
        }

#region Event
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Int32 maBN, loaiHang;
            string tenKH, cmnd, dienThoai, tuNgay, toiNgay;

            maBN = txtMaBN.Text.Trim().Equals("") ? -1 : Int32.Parse(txtMaBN.Text.Trim());
            tenKH = txtTenKH.Text.Trim().Equals("") ? "" : txtTenKH.Text.Trim();
            cmnd = txtCmnd.Text.Trim().Equals("") ? "" : txtCmnd.Text.Trim();
            dienThoai = txtDienThoai.Text.Trim().Equals("") ? "" : txtDienThoai.Text.Trim();
            tuNgay = dateInput_TuNgay.Text.Trim().Equals("") ? "" : DateTime.Parse(dateInput_TuNgay.Text).ToString("yyyy-MM-dd");
            toiNgay = dateInput_ToiNgay.Text.Trim().Equals("") ? "" : DateTime.Parse(dateInput_ToiNgay.Text).ToString("yyyy-MM-dd");
            loaiHang = cboLoaiHang.SelectedIndex;

            DataSet dataSet = new DataSet();
            DataTable tbl1 = Controller.Controller.getInstance().timKiem(maBN, loaiHang, tenKH, cmnd, dienThoai, tuNgay, toiNgay, 1);
            DataTable tbl2 = Controller.Controller.getInstance().timKiem_2(maBN, loaiHang, tenKH, cmnd, dienThoai, tuNgay, toiNgay);
            dataSet.Tables.Add(tbl1);
            dataSet.Tables.Add(tbl2);
            dataSet.Relations.Add("1", dataSet.Tables[0].Columns["maHD"],
                                                    dataSet.Tables[1].Columns["maHD"], false);
            superGridControl_TimKiem.PrimaryGrid.DataSource = dataSet;
            superGridControl_TimKiem.PrimaryGrid.DataMember = "TimKiem";
        }
#endregion

#region Function
        #region SuperGridControlDataBindingComplete
        void SuperGridControlDataBindingComplete(
                    object sender, GridDataBindingCompleteEventArgs e)
        {
           GridPanel panel = e.GridPanel;

           panel.GroupByRow.Visible = true;

           switch (panel.DataMember)
           {
              case "TimKiem":
                 Customize_TimKiem_Panel(panel);
                 break;

              case "TimKiem2":
                 Customize_TimKiem2_Panel(panel);
                 break;
           }
        }
        #endregion

        #region Customize_TimKiem_Panel
        private void Customize_TimKiem_Panel(GridPanel panel)
        {
           panel.FrozenColumnCount = 1;
           panel.ColumnHeader.RowHeight = 30;

           panel.Columns[0].GroupBoxEffects = GroupBoxEffects.None;
           //panel.Columns["maHD"].Visible = false;
           panel.Columns["maHD"].HeaderText = "Mã hệ thống";
           panel.Columns["hd_maBN"].HeaderText = "Mã BN";
           panel.Columns["hd_ngaytao"].HeaderText = "Ngày cầm";
           panel.Columns["hd_kh_Ten"].HeaderText = "Tên KH";
           panel.Columns["hd_kh_CMND"].HeaderText = "CMND";
           panel.Columns["hd_kh_dienThoai"].HeaderText = "Điện thoại";
           panel.Columns["hd_tien_cam"].HeaderText = "Tiền cầm";
           panel.Columns["chuoc_tienlai_thoathuan"].HeaderText = "Tiền lãi thỏa thuận";
           panel.Columns["chuoc_tienlai_quahan"].HeaderText = "Tiền lãi quá hạn";
           panel.Columns["chuoc_tanggiam"].HeaderText = "Tiền tăng/giảm";
           panel.Columns["chuoc_tongtien"].HeaderText = "Tổng tiền chuộc";
           panel.Columns["tienLoi"].HeaderText = "Tiền lời";
           panel.Columns["chuoc_ngaytao"].HeaderText = "Ngày chuộc";
           panel.Columns["tinhTrang"].HeaderText = "Tình trạng";

           panel.Columns[0].CellStyles.Default.Background =
               new Background(Color.AliceBlue);

           foreach (GridColumn column in panel.Columns)
           {
              column.ColumnSortMode = ColumnSortMode.Multiple;
           }

           //superGridControl_TimKiem.BeginUpdate();
           //foreach (GridRow row in panel.Rows)
           //{
           //   row.Cells["hd_tien_cam"].Value = String.Format("{0:0,0}", (double)row.Cells["hd_tien_cam"].Value);
           //   //check qua han
           //   if (Int32.Parse(row.Cells["soNgayCam"].Value.ToString()) > 60)
           //   {
           //      row.Cells["soNgayCam"].CellStyles.Default.Background = new Background(Color.Red);
           //   }
           //}
           //superGridControl_TimKiem.EndUpdate();
        }
        #endregion

        #region Customize_TimKiem2_Panel
        private void Customize_TimKiem2_Panel(GridPanel panel)
        {
           panel.FrozenColumnCount = 1;
           panel.ColumnHeader.RowHeight = 30;
           panel.SelectionGranularity = SelectionGranularity.RowWithCellHighlight;
           panel.ReadOnly = true;

           panel.Columns[0].GroupBoxEffects = GroupBoxEffects.None;
           panel.Columns["maHD"].Visible = false;           
           panel.Columns["maBN"].Visible = false;
           panel.Columns["loaiHangId"].Visible = false;
           panel.Columns["loaiHang"].HeaderText = "Loại hàng";
           panel.Columns["tenMatHang"].HeaderText = "Tên MH";
           panel.Columns["soLuong"].HeaderText = "Số lượng";
           panel.Columns["donViTinh"].HeaderText = "Đơn vị tính";
           panel.Columns["chatLuong"].HeaderText = "Chất lượng";
           panel.Columns["bienSo"].HeaderText = "Biển số";
           panel.Columns["loaiXe"].HeaderText = "Loại xe";

           panel.Columns[0].CellStyles.Default.Background =
               new Background(Color.AliceBlue);

           foreach (GridColumn column in panel.Columns)
           {
              column.ColumnSortMode = ColumnSortMode.Multiple;
           }
           
        }
        #endregion
#endregion
    }
}