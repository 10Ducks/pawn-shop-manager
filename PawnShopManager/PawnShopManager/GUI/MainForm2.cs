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
using PawnShopManager.GUI.BODY;

namespace PawnShopManager.GUI
{
   public partial class MainForm2 : DevComponents.DotNetBar.Metro.MetroForm
   {
      public LoginForm parent;
      public DevComponents.DotNetBar.Metro.MetroForm child = null;
      private CamDo camDoForm = null;
      private KiemHang kiemHangForm = null;
      private QlHangCam qlHangCam = null;
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
         openChild(enumButtonAction.bntCamDo);
         SESSION.Add("Action", enumButtonAction.bntCamDo); //luu session, luu nut nao dang dc active
         bntCamDo.Image = Properties.Resources.Money_Bag_48_active;
         int w1 = Screen.PrimaryScreen.WorkingArea.Width;         
         lblPadding.PaddingRight += (w1 - 1300)/2;
      }

      private void bntCamDo_MouseHover(object sender, EventArgs e)
      {
         hoverButton(bntCamDo);
      }

      private void bntCamDo_MouseLeave(object sender, EventArgs e)
      {
         leaveButton(bntCamDo);
      }


      private void bntThoat_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void bntQlHangCam_MouseHover(object sender, EventArgs e)
      {
         hoverButton(bntQlHangCam);
      }

      private void bntQlHangCam_MouseLeave(object sender, EventArgs e)
      {
         leaveButton(bntQlHangCam);
      }

      private void bntThongKe_MouseHover(object sender, EventArgs e)
      {
         hoverButton(bntThongKe);
      }

      private void bntThongKe_MouseLeave(object sender, EventArgs e)
      {
         leaveButton(bntThongKe);
      }

      private void bntKiemHang_MouseHover(object sender, EventArgs e)
      {

         hoverButton(bntKiemHang);
      }

      private void bntKiemHang_MouseLeave(object sender, EventArgs e)
      {

         leaveButton(bntKiemHang);
      }

      private void bntThuChi_MouseHover(object sender, EventArgs e)
      {
         hoverButton(bntThuChi);
      }

      private void bntThuChi_MouseLeave(object sender, EventArgs e)
      {

         leaveButton(bntThuChi);
      }

      private void bntTimKiem_MouseHover(object sender, EventArgs e)
      {
         hoverButton(bntTimKiem);
      }

      private void bntTimKiem_MouseLeave(object sender, EventArgs e)
      {
         leaveButton(bntTimKiem);
      }

      private void bntThoat_MouseHover(object sender, EventArgs e)
      {
         bntThoat.Image = Properties.Resources.Logout_48_hover;
      }
      private void bntCamDo_Click(object sender, EventArgs e)
      {
         openChild(enumButtonAction.bntCamDo);
         activeButton(bntCamDo);
         SESSION["Action"] = enumButtonAction.bntCamDo;
      }

      public enum enumButtonAction
      {
         bntCamDo, bntQlHangCam, bntThongKe, bntKiemHang, bntThuChi, bntTimKiem
      }

      private void bntQlHangCam_Click(object sender, EventArgs e)
      {
         openChild(enumButtonAction.bntQlHangCam);
         activeButton(bntQlHangCam);
         SESSION["Action"] = enumButtonAction.bntQlHangCam;
      }

      private void bntThongKe_Click(object sender, EventArgs e)
      {
         SESSION["Action"] = enumButtonAction.bntThongKe;
         activeButton(bntThongKe);
      }

      private void bntKiemHang_Click(object sender, EventArgs e)
      {         
         activeButton(bntKiemHang);
         openChild(enumButtonAction.bntKiemHang);
         SESSION["Action"] = enumButtonAction.bntKiemHang;
      }

      private void bntThuChi_Click(object sender, EventArgs e)
      {
         SESSION["Action"] = enumButtonAction.bntThuChi;
         activeButton(bntThuChi);
      }

      private void bntTimKiem_Click(object sender, EventArgs e)
      {
         SESSION["Action"] = enumButtonAction.bntTimKiem;
         activeButton(bntTimKiem);
      }
      private void bntThoat_MouseLeave(object sender, EventArgs e)
      {
         bntThoat.Image = Properties.Resources.Logout_48;
      }

      #endregion

      #region Function
      private enumButtonAction getButtonAction(DevComponents.DotNetBar.LabelItem bnt)
      {
         if (bnt.Equals(bntCamDo)) return enumButtonAction.bntCamDo;
         if (bnt.Equals(bntQlHangCam)) return enumButtonAction.bntQlHangCam;
         if (bnt.Equals(bntThongKe)) return enumButtonAction.bntThongKe;
         if (bnt.Equals(bntKiemHang)) return enumButtonAction.bntKiemHang;
         if (bnt.Equals(bntThuChi)) return enumButtonAction.bntThuChi;
         if (bnt.Equals(bntTimKiem)) return enumButtonAction.bntTimKiem;
         return enumButtonAction.bntCamDo;
      }
      private void activeButton(DevComponents.DotNetBar.LabelItem bnt)
      {
         bntCamDo.Image = Properties.Resources.Money_Bag_48;
         bntQlHangCam.Image = Properties.Resources.Data_Find_48;
         bntThongKe.Image = Properties.Resources.Clock_01_48;
         bntKiemHang.Image = Properties.Resources.Book_Open_48;
         bntThuChi.Image = Properties.Resources.Dollar_48;
         bntTimKiem.Image = Properties.Resources.Search_48;
         Console.WriteLine("Action " + SESSION["Action"]);
         Console.WriteLine("Click " + bnt.Text);

         if (bnt.Equals(bntCamDo)) bnt.Image = Properties.Resources.Money_Bag_48_active;
         if (bnt.Equals(bntQlHangCam)) bnt.Image = Properties.Resources.Data_Find_48_active;
         if (bnt.Equals(bntThongKe)) bnt.Image = Properties.Resources.Clock_01_48_active;
         if (bnt.Equals(bntKiemHang)) bnt.Image = Properties.Resources.Book_Open_48_active;
         if (bnt.Equals(bntThuChi)) bnt.Image = Properties.Resources.Dollar_48_active;
         if (bnt.Equals(bntTimKiem)) bnt.Image = Properties.Resources.Search_48_active;
      }

      private void hoverButton(DevComponents.DotNetBar.LabelItem bnt)
      {
         enumButtonAction bntAction = getButtonAction(bnt);
         Console.WriteLine("Action " + SESSION["Action"]);
         Console.WriteLine("hover " + bntAction);
         if (!SESSION["Action"].Equals(bntAction))
         {
            //button khong duoc active
            if (bntAction.Equals(enumButtonAction.bntCamDo)) bnt.Image = Properties.Resources.Money_Bag_48_hover;
            if (bntAction.Equals(enumButtonAction.bntQlHangCam)) bnt.Image = Properties.Resources.Data_Find_48_hover;
            if (bntAction.Equals(enumButtonAction.bntThongKe)) bnt.Image = Properties.Resources.Clock_01_48_hover;
            if (bntAction.Equals(enumButtonAction.bntKiemHang)) bnt.Image = Properties.Resources.Book_Open_48_hover;
            if (bntAction.Equals(enumButtonAction.bntThuChi)) bnt.Image = Properties.Resources.Dollar_48_hover;
            if (bntAction.Equals(enumButtonAction.bntTimKiem)) bnt.Image = Properties.Resources.Search_48_hover;
         }
      }
      private void leaveButton(DevComponents.DotNetBar.LabelItem bnt)
      {
         enumButtonAction bntAction = getButtonAction(bnt);
         Console.WriteLine("Action " + SESSION["Action"]);
         Console.WriteLine("Leave " + bntAction);
         if (!SESSION["Action"].Equals(bntAction))
         {
            //button khong duoc active
            if (bntAction.Equals(enumButtonAction.bntCamDo)) bnt.Image = Properties.Resources.Money_Bag_48;
            if (bntAction.Equals(enumButtonAction.bntQlHangCam)) bnt.Image = Properties.Resources.Data_Find_48;
            if (bntAction.Equals(enumButtonAction.bntThongKe)) bnt.Image = Properties.Resources.Clock_01_48;
            if (bntAction.Equals(enumButtonAction.bntKiemHang)) bnt.Image = Properties.Resources.Book_Open_48;
            if (bntAction.Equals(enumButtonAction.bntThuChi)) bnt.Image = Properties.Resources.Dollar_48;
            if (bntAction.Equals(enumButtonAction.bntTimKiem)) bnt.Image = Properties.Resources.Search_48;
         }
      }

      public void openChild(enumButtonAction bntAction)
      {
         if (SESSION["Action"] != null && SESSION["Action"].Equals(bntAction))
         {
            return;
         }
         if (child != null)
         {
            child.Hide();
         }
         switch (bntAction)
         {
            case enumButtonAction.bntCamDo:
               if (camDoForm == null)
               {
                  camDoForm = new CamDo();
                  
               }
               camDoForm.parent = this;
               camDoForm.MdiParent = this;
               camDoForm.Show();
               camDoForm.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
               child = camDoForm;
     
               break;
            case enumButtonAction.bntKiemHang:
               if (kiemHangForm == null)
               {
                  kiemHangForm = new KiemHang();
                  kiemHangForm.MdiParent = this;
               }
               kiemHangForm.WindowState = FormWindowState.Normal;
               kiemHangForm.Show();
               kiemHangForm.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
               kiemHangForm.WindowState = FormWindowState.Maximized;
               child = kiemHangForm;
               break;
            case enumButtonAction.bntQlHangCam:
               if (qlHangCam == null)
               {
                  qlHangCam = new QlHangCam();
                  qlHangCam.MdiParent = this;
               }
               qlHangCam.WindowState = FormWindowState.Normal;
               qlHangCam.Show();
               qlHangCam.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
               qlHangCam.WindowState = FormWindowState.Maximized;
               child = qlHangCam;
               break;
         }
      }
      #endregion

   }
}
