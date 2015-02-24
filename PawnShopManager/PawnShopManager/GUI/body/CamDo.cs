using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using PawnShopManager.Util;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PawnShopManager.GUI.BODY
{
   public partial class CamDo : DevComponents.DotNetBar.Metro.MetroForm
   {
      public MainForm2 parent = new MainForm2();
      
      public CamDo()
      {
         InitializeComponent();
         setTabIndex();

         dateTimeInput_NgayCam.Value = DateTime.Now;

         cboLoaiHang.SelectedIndex = 0;
         cboLoaiVang.SelectedIndex = 0;

         chboxMotMon.CheckedChanged += changeStateCheckboxHandler_MotMon;
         chboxMotMon.Checked = true;
         chboxNhieuMon.CheckedChanged += changeStateCheckboxHandler_NhieuMon;
         chboxNhieuMon.Checked = false;

         GridPanel panel = dataGridDsHangCam.PrimaryGrid;

         GridColumn column = panel.Columns["huy"];
         column.EditorType = typeof(MyGridButtonXEditControl);

         Global.txtTienChu_Vang = txtTienChu_Vang;
         Global.lblTongTien_Vang2 = lblTongTien_Vang2;
      }

#region Event
      #region thay đổi trạng thái checkbox 1 món
      private void changeStateCheckboxHandler_MotMon(object sender, EventArgs e){
         if (chboxMotMon.Checked)
         {
            chboxNhieuMon.Checked = false;
            dataGridDsHangCam.Visible = false;
            bntThemHangCam.Enabled = false;
            bntThemHangCam.Visible = false;
         }
         if (!chboxNhieuMon.Checked && !chboxMotMon.Checked)
         {
            chboxMotMon.Checked = true;
         }
      }
      #endregion

      #region thay đổi trạng thái checkbox nhiều món
      private void changeStateCheckboxHandler_NhieuMon(object sender, EventArgs e)
      {
         if (chboxNhieuMon.Checked)
         {
            chboxMotMon.Checked = false;

            dataGridDsHangCam.Visible = true;
            bntThemHangCam.Enabled = true;
            bntThemHangCam.Visible = true;
         }
         if (!chboxNhieuMon.Checked && !chboxMotMon.Checked)
         {
            chboxNhieuMon.Checked = true;
         }
      }
      #endregion

      #region thay đổi chỉ số cboLoaiHang
      private void cboLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (cboLoaiHang.SelectedIndex == 0)
         {
            visibleVang();

         }
         else if (cboLoaiHang.SelectedIndex == 1)
         {
            visibleXe();

         }
         superValidator1.Enabled = true;
      }
      #endregion

      #region click nút thêm hàng cầm
      private void bntThemHangCam_Click(object sender, EventArgs e)
      {
         //check tinh hop le
         if (!superValidator1.Validate(txtTenVatCam)
               || !superValidator1.Validate(txtSoLuong)
               || !superValidator1.Validate(cboLoaiVang))
         {
            return;
         }

         if (txtSoLuong.Text.Trim().Equals(""))
         {
            MessageBox.Show("Yêu cầu nhập số lượng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
         }

         if (txtTienCam_Vang.Text.Trim().Equals(""))
         {
            MessageBox.Show("Yêu cầu nhập tiền cầm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
         }

         Regex regex = new Regex("^[0-9]*$");
         if (!regex.IsMatch(txtTienCam_Vang.Text.Trim()))
         {
            lblTongTien_Vang2.Text = "Yêu cầu không nhập chữ!";
            txtTienChu_Vang.Text = "Yêu cầu không nhập chữ!";
            return;
         }

         string tenMH = txtTenVatCam.Text.Trim();
         string soLuong = txtSoLuong.Text.Trim();
         string loaiVang = "Vàng";
         string giatri = txtTienCam_Vang.Text.Trim();
         int loai = 5;
         switch (cboLoaiVang.SelectedIndex)
         {
            case 0:
               loaiVang = "Vàng 18k";
               loai = 2;
               break;
            case 1:
               loaiVang = "Vàng 24k";
               loai = 3;
               break;
            case 2:
               loaiVang = "Vàng trắng";
               loai = 4;
               break;
         }
         GridPanel panel = dataGridDsHangCam.PrimaryGrid;
         GridRow row = new GridRow(
                tenMH,
                soLuong,
                loaiVang,
                giatri,
                "Xóa", loai);
         dataGridDsHangCam.BeginUpdate();
         panel.Rows.Add(row);
         dataGridDsHangCam.EndUpdate();

         Global.tongTien_Vang_Nhieu += float.Parse(giatri);
        
         if (chboxNhieuMon.Checked)
         {
            lblTongTien_Vang2.Text = String.Format("{0:0,0}", Global.tongTien_Vang_Nhieu) + " VNĐ";
            txtTienChu_Vang.Text = Util.UtilCommon.docso(Global.tongTien_Vang_Nhieu) + " đồng.";
         }
      }
      #endregion

      #region click nút Lưu
      private void btnLuu_Click(object sender, EventArgs e)
      {
         if (!superValidator1.Validate(txtTenKH)
                        || !superValidator1.Validate(txtCMND)
                        || !superValidator1.Validate(txtDienThoai))
         {
            return;
         }

         //vang 1 mon
         if (cboLoaiHang.SelectedIndex == 0 && chboxMotMon.Checked)
         {
            themHD_Vang_1();
         }
         //vang nhieu mon
         if (cboLoaiHang.SelectedIndex == 0 && chboxNhieuMon.Checked)
         {
            themHD_Vang_N();
         }

         //xe         
         if (cboLoaiHang.SelectedIndex == 1)
         {
            themHD_Xe();
         }

      }
      #endregion

      #region click nút thêm biên nhận mới
      private void btnThemBienNhanMoi_Click(object sender, EventArgs e)
      {

      }
      #endregion

      #region Form Load
      private void CamDo_Load(object sender, EventArgs e)
      {
         int maBN = Controller.Controller.getInstance().getMaBN_max();
         lblMaHD.Text = "Mã biên nhận: " + String.Format("{0:D5}", maBN);
      }
      #endregion

      #region thay đổi chữ txtTienCam_Vang
      private void txtTienCam_Vang_TextChanged(object sender, EventArgs e)
      {
         if (txtTienCam_Vang.Text.Trim().Equals(""))
         {
            return;
         }
         Regex regex = new Regex("^[0-9]*$");
         if (!regex.IsMatch(txtTienCam_Vang.Text.Trim()))
         {
            lblTongTien_Vang2.Text = "Yêu cầu không nhập chữ!";
            txtTienChu_Vang.Text = "Yêu cầu không nhập chữ!";
            return;
         }
         if (chboxMotMon.Checked)
         {
            lblTongTien_Vang2.Text = String.Format("{0:0,0}", Double.Parse(txtTienCam_Vang.Text.Trim())) + " VNĐ";
            txtTienChu_Vang.Text = Util.UtilCommon.docso(Double.Parse(txtTienCam_Vang.Text.Trim())) + " đồng.";
         }
      }
      #endregion

      #region thay đổi chữ txtTienCam_Xe
      private void txtTienCam_Xe_TextChanged(object sender, EventArgs e)
      {
         if(txtTienCam_Xe.Text.Trim().Equals("")){
            return;
         }
         Regex regex = new Regex("^[0-9]*$");
         if (!regex.IsMatch(txtTienCam_Xe.Text.Trim()))
         {
            txtTienChu_Xe.Text = "Yêu cầu không nhập chữ!";
            return;
         }
         txtTienChu_Xe.Text = Util.UtilCommon.docso(Double.Parse(txtTienCam_Xe.Text.Trim())) + " đồng.";
      }
      #endregion

#endregion

#region Function

      private void visibleVang()
      {
         lbl_1.Text = "Tên vật cầm: ";
         lbl_2.Text = "Loại vàng: ";
         lbl_3.Text = "Số lượng (chỉ): ";
         lbl_4.Text = "Tiền cầm: ";
         //vang

         chboxMotMon.Visible = true;
         chboxNhieuMon.Visible = true;
         txtTenVatCam.Visible = true;
         cboLoaiVang.Visible = true;
         txtSoLuong.Visible = true;
         txtTienCam_Vang.Visible = true;
         if (!chboxMotMon.Checked)
         {
            bntThemHangCam.Visible = true;
            dataGridDsHangCam.Visible = true;
         }

         lblTongTien_Vang1.Visible = true;
         lblTongTien_Vang2.Visible = true;
         lblTienChu_Vang.Visible = true;
         txtTienChu_Vang.Visible = true;

         //xe
         txtBienSoXe.Visible = false;
         txtNhanSoXe.Visible = false;
         txtChatLuong.Visible = false;
         txtLoaiXe.Visible = false;
         txtTienCam_Xe.Visible = false;
         lblTienCam_Xe.Visible = false;
         lblTienChu_Xe.Visible = false;
         txtTienChu_Xe.Visible = false;

      }

      private void visibleXe()
      {
         lbl_1.Text = "Biển số xe: ";
         lbl_2.Text = "Nhãn số xe: ";
         lbl_3.Text = "Loại xe: ";
         lbl_4.Text = "Chất lượng: ";

         dataGridDsHangCam.Visible = false;
         chboxMotMon.Visible = false;
         chboxNhieuMon.Visible = false;
         txtTenVatCam.Visible = false;
         cboLoaiVang.Visible = false;
         txtSoLuong.Visible = false;
         txtTienCam_Vang.Visible = false;
         bntThemHangCam.Visible = false;
         lblTongTien_Vang1.Visible = false;
         lblTongTien_Vang2.Visible = false;
         lblTienChu_Vang.Visible = false;
         txtTienChu_Vang.Visible = false;

         txtBienSoXe.Visible = true;
         txtNhanSoXe.Visible = true;
         txtChatLuong.Visible = true;
         txtLoaiXe.Visible = true;
         txtTienCam_Xe.Visible = true;
         lblTienCam_Xe.Visible = true;
         lblTienChu_Xe.Visible = true;
         txtTienChu_Xe.Visible = true;
      }

      #region thêm hợp đồng xe máy
      public void themHD_Xe() {
         //check tinh hop le
         if (!superValidator1.Validate(txtTenKH)
               || !superValidator1.Validate(txtCMND)
               || !superValidator1.Validate(txtDienThoai)
               || !superValidator1.Validate(txtBienSoXe)
               || !superValidator1.Validate(txtLoaiXe)
               || !superValidator1.Validate(txtTienCam_Xe)
               || !superValidator1.Validate(txtLaiSuatThoaThuan)
               || !superValidator1.Validate(txtLaiSuatQuaHan))
         {
            return;
         }

         //hoi y kien
         if (MessageBox.Show("Bạn có chắc tạo hợp đồng xe?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
         {
            return;
         }

         string tenKH = txtTenKH.Text.Trim();
         string cmnd = txtCMND.Text.Trim();
         string dienThoai = txtDienThoai.Text.Trim();
         string diaChi = txtDiaChi.Text.Trim();

         string bienSo = txtBienSoXe.Text.Trim();
         string chatLuong = txtChatLuong.Text.Trim();
         string loaiXe = txtLoaiXe.Text.Trim();
         string nhanSoXe = txtNhanSoXe.Text.Trim();
         float tienCam = float.Parse(txtTienCam_Xe.Text.Trim());

         float laiSuat_ThoaThuan = float.Parse(txtLaiSuatThoaThuan.Text.Trim());
         float laiSuat_QuaHan = float.Parse(txtLaiSuatQuaHan.Text.Trim());

         int maBN = Controller.Controller.getInstance().getMaBN_max();
         DateTime ngayCam = dateTimeInput_NgayCam.Value;

         //them hop dong moi
         int keyAuto = Controller.Controller.getInstance().themHD(maBN, ngayCam, tienCam, cmnd, tenKH, dienThoai, diaChi, laiSuat_ThoaThuan, laiSuat_QuaHan);
         if (keyAuto > 0)
         {
            //save
            if (Global.SESSION.ContainsKey("KeyAuto"))
            {
               Global.SESSION["KeyAuto"] = keyAuto;
            }
            else
            {
               Global.SESSION.Add("KeyAuto", keyAuto);
            }

            bool result = Controller.Controller.getInstance().themChiTietHangCam_Xe(keyAuto, bienSo, tienCam, chatLuong, loaiXe, nhanSoXe);
            if (result)
            {
               MessageBox.Show("Thêm hợp đồng xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
               EnableComponentAfterAdd(false);
            }
            else
            {
               MessageBox.Show("Không thể thêm mới mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
         else
         {
            MessageBox.Show("Không thể thêm mới hợp đồng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      #endregion

      #region thêm hợp đồng vàng - 1 món
      public void themHD_Vang_1()
      {
         //check tinh hop le
         if (!superValidator1.Validate(txtTenKH)
               || !superValidator1.Validate(txtCMND)
               || !superValidator1.Validate(txtDienThoai)
               || !superValidator1.Validate(txtTenVatCam)
               || !superValidator1.Validate(txtSoLuong)
               || !superValidator1.Validate(cboLoaiVang)
               || !superValidator1.Validate(txtLaiSuatThoaThuan)
               || !superValidator1.Validate(txtLaiSuatQuaHan))
         {
            return;
         }

         if (txtSoLuong.Text.Trim().Equals(""))
         {
            MessageBox.Show("Yêu cầu nhập số lượng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
         }

         //hoi y kien
         if (MessageBox.Show("Bạn có chắc hợp đồng chỉ có 1 món?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
         {
            return;
         }

         string tenKH = txtTenKH.Text.Trim();
         string cmnd = txtCMND.Text.Trim();
         string dienThoai = txtDienThoai.Text.Trim();
         string diaChi = txtDiaChi.Text.Trim();
         string tenVatCam = txtTenVatCam.Text.Trim();
         int soLuong = Int32.Parse(txtSoLuong.Text.Trim());
         float tienCam = float.Parse(txtTienCam_Vang.Text.Trim());
         float laiSuat_ThoaThuan = float.Parse(txtLaiSuatThoaThuan.Text.Trim());
         float laiSuat_QuaHan = float.Parse(txtLaiSuatQuaHan.Text.Trim());
         int maBN = Controller.Controller.getInstance().getMaBN_max();
         DateTime ngayCam = dateTimeInput_NgayCam.Value;

         int loai = 5;
         switch (cboLoaiVang.SelectedIndex)
         {
            case 0:
               loai = 2;
               break;
            case 1:
               loai = 3;
               break;
            case 2:
               loai = 4;
               break;
         }

         //them hop dong moi
         int keyAuto = Controller.Controller.getInstance().themHD(maBN, ngayCam, tienCam, cmnd, tenKH, dienThoai, diaChi, laiSuat_ThoaThuan, laiSuat_QuaHan);
         if (keyAuto > 0)
         {
            //save
            if (Global.SESSION.ContainsKey("KeyAuto"))
            {
               Global.SESSION["KeyAuto"] = keyAuto;
            }
            else
            {
               Global.SESSION.Add("KeyAuto", keyAuto);
            }

            bool result = Controller.Controller.getInstance().themChiTietHangCam_Vang(keyAuto, soLuong, tenVatCam, tienCam, loai);
            if (result)
            {
               MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
               EnableComponentAfterAdd(false);
            }
            else
            {
               MessageBox.Show("Không thể thêm mới mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
         else
         {
            MessageBox.Show("Không thể thêm mới hợp đồng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      #endregion

      #region thêm hợp đồng vàng - nhiều món
      public void themHD_Vang_N() {
         //check tinh hop le
         if (!superValidator1.Validate(txtTenKH)
               || !superValidator1.Validate(txtCMND)
               || !superValidator1.Validate(txtDienThoai) 
               || !superValidator1.Validate(txtLaiSuatThoaThuan)
               || !superValidator1.Validate(txtLaiSuatQuaHan))
         {
            return;
         }

         if (dataGridDsHangCam.PrimaryGrid.Rows.Count < 1)
         {
            MessageBox.Show("Yêu cầu tối thiểu 1 món hàng được cầm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
         }

         //hoi y kien
         string msg = String.Format("Bạn có chắc hợp đồng chỉ có {0} món?", dataGridDsHangCam.PrimaryGrid.Rows.Count);
         if (MessageBox.Show(msg, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
         {
            return;
         }

         string tenKH = txtTenKH.Text.Trim();
         string cmnd = txtCMND.Text.Trim();
         string dienThoai = txtDienThoai.Text.Trim();
         string diaChi = txtDiaChi.Text.Trim();
         
         float laiSuat_ThoaThuan = float.Parse(txtLaiSuatThoaThuan.Text.Trim());
         float laiSuat_QuaHan = float.Parse(txtLaiSuatQuaHan.Text.Trim());
         int maBN = Controller.Controller.getInstance().getMaBN_max();
         DateTime ngayCam = dateTimeInput_NgayCam.Value;
         float tienCam = (float)Global.tongTien_Vang_Nhieu;

         //them hop dong moi
         int keyAuto = Controller.Controller.getInstance().themHD(maBN, ngayCam, tienCam, cmnd, tenKH, dienThoai, diaChi, laiSuat_ThoaThuan, laiSuat_QuaHan);
         if (keyAuto > 0)
         {
            //luu key moi tao
            if (Global.SESSION.ContainsKey("KeyAuto"))
            {
               Global.SESSION["KeyAuto"] = keyAuto;
            }
            else
            {
               Global.SESSION.Add("KeyAuto", keyAuto);
            }

            //luu chi tiet hang cam vao hop dong moi tao
            int rowCount = dataGridDsHangCam.PrimaryGrid.Rows.Count;
            GridPanel panel = dataGridDsHangCam.PrimaryGrid;
            bool flag = true;
            for(int i = 0; i < rowCount; i++){
               GridRow row = (GridRow)panel.Rows[i];
               string tenMH = row.Cells["tenMH"].Value.ToString();
               int soLuong = Int32.Parse(row.Cells["soLuong"].Value.ToString());
               int loai = Int32.Parse(row.Cells["loai"].Value.ToString());
               float tien = float.Parse(row.Cells["giatri"].Value.ToString());
               bool result = Controller.Controller.getInstance().themChiTietHangCam_Vang(keyAuto, soLuong, tenMH, tien, loai);
               if (!result)
               {
                  MessageBox.Show("Không thể thêm mới mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  flag = false;
                  break;                  
               }               
            }
            if(flag){
               MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
               EnableComponentAfterAdd(false);
            }
         }
         else
         {
            MessageBox.Show("Không thể thêm mới hợp đồng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      #endregion

      #region bật tắt các Control sau khi thêm thành công hợp đồng
      private void EnableComponentAfterAdd(bool flag){
         groupPanel1.Enabled = flag;
         groupVang.Enabled = flag;
         txtTenKH.Enabled = flag;
         txtDiaChi.Enabled = flag;
         txtDienThoai.Enabled = flag;
         txtCMND.Enabled = flag;

         btnLuu.Enabled = flag;
         btnIn.Enabled = !flag;
         btnThemBienNhanMoi.Enabled = !flag;
      }
      #endregion

      private void setTabIndex(){
         //chung 1
         cboLoaiHang.TabIndex = 1;
         txtTenKH.TabIndex = 2;
         txtCMND.TabIndex = 3;
         txtDienThoai.TabIndex = 4;
         txtDiaChi.TabIndex = 5;

         //vang
         chboxMotMon.TabIndex = 6;
         chboxNhieuMon.TabIndex = 7;
         txtTenVatCam.TabIndex = 8;
         txtSoLuong.TabIndex = 9;
         cboLoaiVang.TabIndex = 10;
         txtTienCam_Vang.TabIndex = 11;
         bntThemHangCam.TabIndex = 12;
   
         //xe
         txtBienSoXe.TabIndex = 6;
         txtLoaiXe.TabIndex = 7;
         txtNhanSoXe.TabIndex = 8;
         txtChatLuong.TabIndex = 9;
           
         //chung 2
         txtLaiSuatThoaThuan.TabIndex = 13;
         txtLaiSuatQuaHan.TabIndex = 14;

         btnLuu.TabIndex = 15;
         btnIn.TabIndex = 16;
         btnVietLai.TabIndex = 17;
         btnThemBienNhanMoi.TabIndex = 18; 
      }
#endregion

      #region MyGridButtonXEditControl

      /// <summary>
      /// GridButtonXEditControl Class that controls the
      /// ButtonX color initialization and user button clicks.
      /// </summary>
      private class MyGridButtonXEditControl : GridButtonXEditControl
      {
         /// <summary>
         /// Constructor
         /// </summary>
         public MyGridButtonXEditControl()
         {
            // We want to be notified when the user clicks the button
            // so that we can change the underlying cell value to reflect
            // the mouse click.
            Click += MyGridButtonXEditControlClick;    
         }

         #region InitializeContext

         /// <summary>
         /// Initializes the color table for the button
         /// </summary>
         /// <param name="cell"></param>
         /// <param name="style"></param>
         public override void
             InitializeContext(GridCell cell, CellVisualStyle style)
         {
            base.InitializeContext(cell, style);
            ColorTable = eButtonColor.OrangeWithBackground;
         }

         #endregion

         #region MyGridButtonXEditControlClick

         /// <summary>
         /// Handles user clicks of the button
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         void MyGridButtonXEditControlClick(object sender, EventArgs e)
         {
            int rowIndex = EditorCell.RowIndex;
            GridPanel panel = EditorCell.Parent.GridPanel;
            GridRow r = (GridRow)panel.Rows[rowIndex];
            double giatri = Double.Parse(r.Cells["giatri"].Value.ToString());
            panel.Rows.RemoveAt(rowIndex);

            Global.tongTien_Vang_Nhieu -= giatri;
            Global.lblTongTien_Vang2.Text = String.Format("{0:0,0}", Global.tongTien_Vang_Nhieu) + " VNĐ";
            Global.txtTienChu_Vang.Text = Util.UtilCommon.docso(Global.tongTien_Vang_Nhieu) + " đồng.";
         }

         #endregion
      }

      #endregion

   }
}
