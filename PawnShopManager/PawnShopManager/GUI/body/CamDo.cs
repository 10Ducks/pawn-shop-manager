using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawnShopManager.GUI.BODY
{
   public partial class CamDo : DevComponents.DotNetBar.Metro.MetroForm
   {
      public MainForm2 parent = new MainForm2();
      public bool firstRun = true;
      public CamDo()
      {
         InitializeComponent();
         cboLoaiHang.SelectedIndex = 0;
      }

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
         if (!chboxMotMon.Checked) { 
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
         }else{
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

   }
}
