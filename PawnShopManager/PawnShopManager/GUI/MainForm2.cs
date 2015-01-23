using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PawnShopManager.GUI
{
   public partial class MainForm2 : DevComponents.DotNetBar.Metro.MetroForm
   {
      public LoginForm parent;
      private Hashtable SESSION = new Hashtable();
      public MainForm2()
      {
         InitializeComponent();
      }



      #region Event
      private void MainForm2_FormClosed(object sender, FormClosedEventArgs e)
      {
         parent.Show();
      }

      private void MainForm2_Load(object sender, EventArgs e)
      {
         SESSION.Add("Action", buttonAction.CamDo);
         bntCamDo.Image = Properties.Resources.Money_Bag_48_active;

         body.Gold_body goldForm = new body.Gold_body();
         goldForm.MdiParent = this;

         goldForm.WindowState = FormWindowState.Normal;
         goldForm.Show();
         goldForm.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
      }

      private void bntCamDo_MouseHover(object sender, EventArgs e)
      {

         if (!SESSION["Action"].Equals(buttonAction.CamDo)) bntCamDo.Image = Properties.Resources.Money_Bag_48_hover;
      }

      private void bntCamDo_MouseLeave(object sender, EventArgs e)
      {
         if (SESSION["Action"].Equals(buttonAction.CamDo)) bntCamDo.Image = Properties.Resources.Money_Bag_48_active;
         else bntCamDo.Image = Properties.Resources.Money_Bag_48;
      }


      private void bntThoat_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void bntQlHangCam_MouseHover(object sender, EventArgs e)
      {
         if (!SESSION["Action"].Equals(buttonAction.QlHangCam)) bntQlHangCam.Image = Properties.Resources.Data_Find_48_hover;
      }

      private void bntQlHangCam_MouseLeave(object sender, EventArgs e)
      {
         if (SESSION["Action"].Equals(buttonAction.QlHangCam)) bntQlHangCam.Image = Properties.Resources.Data_Find_48_active;
         else bntQlHangCam.Image = Properties.Resources.Data_Find_48;
      }

      private void bntThongKe_MouseHover(object sender, EventArgs e)
      {
         if (!SESSION["Action"].Equals(buttonAction.ThongKe)) bntThongKe.Image = Properties.Resources.Clock_01_48_hover;
      }

      private void bntThongKe_MouseLeave(object sender, EventArgs e)
      {

         if (SESSION["Action"].Equals(buttonAction.ThongKe)) bntThongKe.Image = Properties.Resources.Clock_01_48_active;
         else bntThongKe.Image = Properties.Resources.Clock_01_48;
      }

      private void bntKiemHang_MouseHover(object sender, EventArgs e)
      {

         if (!SESSION["Action"].Equals(buttonAction.KiemHang)) bntKiemHang.Image = Properties.Resources.Book_Open_48_hover;
      }

      private void bntKiemHang_MouseLeave(object sender, EventArgs e)
      {

         if (SESSION["Action"].Equals(buttonAction.KiemHang)) bntKiemHang.Image = Properties.Resources.Book_Open_48_active;
         else bntKiemHang.Image = Properties.Resources.Book_Open_48;
      }

      private void bntThuChi_MouseHover(object sender, EventArgs e)
      {

         if (!SESSION["Action"].Equals(buttonAction.ThuChi)) bntThuChi.Image = Properties.Resources.Dollar_48_hover;
      }

      private void bntThuChi_MouseLeave(object sender, EventArgs e)
      {

         if (SESSION["Action"].Equals(buttonAction.ThuChi)) bntThuChi.Image = Properties.Resources.Dollar_48_active;
         else bntThuChi.Image = Properties.Resources.Dollar_48;
      }

      private void bntTimKiem_MouseHover(object sender, EventArgs e)
      {

         if (!SESSION["Action"].Equals(buttonAction.TimKiem)) bntTimKiem.Image = Properties.Resources.Search_48_hover;
      }

      private void bntTimKiem_MouseLeave(object sender, EventArgs e)
      {

         if (SESSION["Action"].Equals(buttonAction.TimKiem)) bntTimKiem.Image = Properties.Resources.Search_48_active;
         else bntTimKiem.Image = Properties.Resources.Search_48;
      }

      private void bntThoat_MouseHover(object sender, EventArgs e)
      {
         bntThoat.Image = Properties.Resources.Logout_48_hover;
      }

      private void bntThoat_MouseLeave(object sender, EventArgs e)
      {
         bntThoat.Image = Properties.Resources.Logout_48;
      }

      #endregion

      #region Function
      private void switchButton()
      {
         bntCamDo.Image = Properties.Resources.Money_Bag_48;
         bntQlHangCam.Image = Properties.Resources.Data_Find_48;
         bntThongKe.Image = Properties.Resources.Clock_01_48;
         bntKiemHang.Image = Properties.Resources.Book_Open_48;
         bntThuChi.Image = Properties.Resources.Dollar_48;
         bntTimKiem.Image = Properties.Resources.Search_48;

         //if (bnt.Equals(bntCamDo)) bnt.Image = Properties.Resources.Money_Bag_48_active;
         //if (bnt.Equals(bntQlHangCam)) bnt.Image = Properties.Resources.Data_Find_48_active;
         //if (bnt.Equals(bntThongKe)) bnt.Image = Properties.Resources.Clock_01_48_active;
         //if (bnt.Equals(bntKiemHang)) bnt.Image = Properties.Resources.Clock_01_48_active;
         //if (bnt.Equals(bntThuChi)) bnt.Image = Properties.Resources.Dollar_48_active;
         //if (bnt.Equals(bntTimKiem)) bnt.Image = Properties.Resources.Search_48_active;
      }
      #endregion

      private void bntCamDo_Click(object sender, EventArgs e)
      {
         SESSION["Action"] = buttonAction.CamDo;
         switchButton();
      }

      public enum buttonAction
      {
         CamDo, QlHangCam, ThongKe, KiemHang, ThuChi, TimKiem
      }

      private void bntQlHangCam_Click(object sender, EventArgs e)
      {
         SESSION["Action"] = buttonAction.QlHangCam;
         switchButton();
      }

      private void bntThongKe_Click(object sender, EventArgs e)
      {
         SESSION["Action"] = buttonAction.ThongKe;
         switchButton();
      }

      private void bntKiemHang_Click(object sender, EventArgs e)
      {
         SESSION["Action"] = buttonAction.KiemHang;
         switchButton();
      }

      private void bntThuChi_Click(object sender, EventArgs e)
      {
         SESSION["Action"] = buttonAction.ThuChi;
         switchButton();
      }

      private void bntTimKiem_Click(object sender, EventArgs e)
      {
         SESSION["Action"] = buttonAction.TimKiem;
         switchButton();
      }

   }
}
