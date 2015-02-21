using PawnShopManager.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawnShopManager.GUI.BODY
{
   public partial class CamDo : DevComponents.DotNetBar.Metro.MetroForm
   {
      public MainForm2 parent = new MainForm2();

      public CamDo()
      {
         InitializeComponent();
         cboLoaiHang.SelectedIndex = 0;
         cboLoaiVang.SelectedIndex = 0;
         chboxNhieuMon.Checked = false;
         chboxMotMon.Checked = true;
      }

#region Event

      private void chboxMotMon_CheckedChanged(object sender, EventArgs e)
      {
         if (chboxMotMon.Checked)
         {
            chboxNhieuMon.Checked = false;
            dataGridDsHangCam.Visible = false;
            bntThemHangCam.Enabled = false;
            bntThemHangCam.Visible = false;
            lblDsHangCam.Visible = false;
         }
      }

      private void chboxNhieuMon_CheckedChanged(object sender, EventArgs e)
      {
         if (chboxNhieuMon.Checked)
         {
            chboxMotMon.Checked = false;

            dataGridDsHangCam.Visible = true;
            bntThemHangCam.Enabled = true;
            bntThemHangCam.Visible = true;
            lblDsHangCam.Visible = true;
         }
      }

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
            lblDsHangCam.Visible = true;
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
         lblDsHangCam.Visible = false;
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

      private void txtCMND_MouseEnter(object sender, EventArgs e)
      {
         if (txtCMND.SelectionStart > txtCMND.Text.Length)
         {
            txtCMND.SelectionStart = txtCMND.Text.Length;
            txtCMND.Focus();
         }
      }

      private void txtBienSoXe_MouseEnter(object sender, EventArgs e)
      {
         string[] bs = txtBienSoXe.Text.Split('-');
         if (bs[0].Trim().Length < 4 && txtBienSoXe.SelectionStart > 4)
         {
            txtBienSoXe.SelectionStart = bs[0].Trim().Length;
            txtBienSoXe.Focus();
         }
         else
         {
            if (bs[1].Trim().Length < 5 && txtBienSoXe.SelectionStart > txtBienSoXe.Text.Length)
            {
               txtBienSoXe.SelectionStart = bs[1].Trim().Length + 7;
               txtBienSoXe.Focus();
            }
         }
      }

      private void txtDienThoai_MouseEnter(object sender, EventArgs e)
      {
         if (txtDienThoai.SelectionStart > txtDienThoai.Text.Length)
         {
            txtDienThoai.SelectionStart = txtDienThoai.Text.Length;
            txtDienThoai.Focus();
         }
      }

      private void bntThemHangCam_Click(object sender, EventArgs e)
      {
         if (cboLoaiVang.SelectedItem != null)
         {
            MessageBox.Show(cboLoaiVang.SelectedItem.ToString());
         }
      }

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
         }

         //xe         
         if (cboLoaiHang.SelectedIndex == 1)
         {
         }

      }

      private void btnThemBienNhanMoi_Click(object sender, EventArgs e)
      {

      }

      private void CamDo_Load(object sender, EventArgs e)
      {
         int maBN = Controller.Controller.getInstance().getMaBN_max();
         lblMaHD.Text = "Mã biên nhận: " + String.Format("{0:D5}", maBN);
      }

      private void txtTienCam_Vang_TextChanged(object sender, EventArgs e)
      {
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

      private void txtTienCam_Xe_TextChanged(object sender, EventArgs e)
      {
         Regex regex = new Regex("^[0-9]*$");
         if (!regex.IsMatch(txtTienCam_Vang.Text.Trim()))
         {
            txtTienChu_Xe.Text = "Yêu cầu không nhập chữ!";
            return;
         }
         txtTienChu_Xe.Text = Util.UtilCommon.docso(Double.Parse(txtTienCam_Xe.Text.Trim())) + " Đồng";
      }

#endregion

#region Function

      #region thêm hợp đồng xe máy
      public void themHD_Xe() { }
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
            bool result = Controller.Controller.getInstance().themChiTietHangCam_Vang(keyAuto, soLuong, tenVatCam, tienCam, loai);
            if (result)
            {
               MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
               chboxMotMon.Enabled = false;
               chboxNhieuMon.Enabled = false;
               btnLuu.Enabled = false;
               if(Global.SESSION.ContainsKey("KeyAuto")){
                  Global.SESSION["KeyAuto"] = keyAuto;
               }else{
                  Global.SESSION.Add("KeyAuto", keyAuto);
               }
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
      public void themHD_Vang_N() { }
      #endregion

#endregion

   }
}
