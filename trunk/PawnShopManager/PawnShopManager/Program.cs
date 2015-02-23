using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawnShopManager
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         //try{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI.LoginForm());         
            //Application.Run(new GUI.BODY.Test_Datagrid());         
            //Application.Run(new GUI.BODY.mergeDataGridView());         
         //}catch(Exception ex){
         //   Console.WriteLine(ex.StackTrace);
         //}
      }
   }
}
