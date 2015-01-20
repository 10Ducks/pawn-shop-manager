using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawnShopManager.GUI.body
{
   public partial class Gold_body : DevComponents.DotNetBar.Metro.MetroForm
   {
      public Gold_body()
      {
         InitializeComponent();
      }

      private void Gold_body_Resize(object sender, EventArgs e)
      {
         Console.WriteLine("Width-child: " + this.Width);
         Console.WriteLine("Height-child: " + this.Height);
      }
   }
}
