using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawnShopManager.GUI
{
   public partial class MainForm2 : DevComponents.DotNetBar.Metro.MetroForm
   {
      public LoginForm parent;
      public MainForm2()
      {
         InitializeComponent();
      }

      private void MainForm2_FormClosed(object sender, FormClosedEventArgs e)
      {
         parent.Show();
      }

#region Event
      private void MainForm2_Load(object sender, EventArgs e)
      {
         body.Gold_body goldForm = new body.Gold_body();
         goldForm.MdiParent = this;
         goldForm.WindowState = FormWindowState.Normal;
         //goldForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
         //goldForm.Width = this.Width;
         goldForm.Show();
      }

      private void bntCamDo_MouseHover(object sender, EventArgs e)
      {
         bntCamDo.Image = Properties.Resources.Money_Bag_48_hover;
      }

      private void bntCamDo_MouseLeave(object sender, EventArgs e)
      {
         bntCamDo.Image = Properties.Resources.Money_Bag_48;
      }

      private void bntQLHangCam_MouseHover(object sender, EventArgs e)
      {
         bntQLHangCam.Image = Properties.Resources.Data_Find_48_hover;
      }  

      private void bntQLHangCam_MouseLeave(object sender, EventArgs e)
      {
         bntQLHangCam.Image = Properties.Resources.Data_Find_48;
      }

      private void bntThongKe_MouseHover(object sender, EventArgs e)
      {
         bntThongKe.Image = Properties.Resources.Clock_01_48_hover;
      }

      private void bntThongKe_MouseLeave(object sender, EventArgs e)
      {
         bntThongKe.Image = Properties.Resources.Clock_01_48;
      }

      private void bntKiemHang_MouseHover(object sender, EventArgs e)
      {
         bntKiemHang.Image = Properties.Resources.Book_Open_48_hover;
      }

      private void bntKiemHang_MouseLeave(object sender, EventArgs e)
      {
         bntKiemHang.Image = Properties.Resources.Book_Open_48;
      }

      private void bntThuChi_MouseHover(object sender, EventArgs e)
      {
         bntThuChi.Image = Properties.Resources.Dollar_48_hover;
      }

      private void bntThuChi_MouseLeave(object sender, EventArgs e)
      {
         bntThuChi.Image = Properties.Resources.Dollar_48;
      }

      private void bntTimKiem_MouseHover(object sender, EventArgs e)
      {
         bntTimKiem.Image = Properties.Resources.Search_48_hover;
      }

      private void bntTimKiem_MouseLeave(object sender, EventArgs e)
      {
         bntTimKiem.Image = Properties.Resources.Search_48;
      }

      private void bntExit_MouseHover(object sender, EventArgs e)
      {
         bntExit.Image = Properties.Resources.Logout_48_hover;
      }

      private void bntExit_MouseLeave(object sender, EventArgs e)
      {
         bntExit.Image = Properties.Resources.Logout_48;
      }
#endregion

      private void bntExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
