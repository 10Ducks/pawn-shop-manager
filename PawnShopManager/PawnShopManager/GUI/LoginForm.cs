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
   public partial class LoginForm : DevComponents.DotNetBar.Metro.MetroForm
   {
      public LoginForm()
      {
         InitializeComponent();
      }

      private void buttonX1_Click(object sender, EventArgs e)
      {
         MainForm2 mainForm = new MainForm2();
         mainForm.parent = this;         
         mainForm.Show();
         mainForm.WindowState = FormWindowState.Maximized;
         this.Hide();
      }

      private void buttonX2_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void labelX1_Click(object sender, EventArgs e)
      {

      }

      private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
      {

      }
   }
}
