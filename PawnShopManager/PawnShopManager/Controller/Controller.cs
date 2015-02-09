using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawnShopManager.Dao;
using PawnShopManager.Entity;

namespace PawnShopManager.Controller
{
   class Controller
   {
      private AdminDAO adminDAO = new AdminDAO();
      private static Controller controller = null;
      private Controller(){}
      public static Controller getInstance()
      {
         if (controller == null)
         {
            controller = new Controller();
         }
         return controller;
      }  

      public List<Admin> getLogin(string id, string pass){
           return adminDAO.getLogin(id, pass);
      }

   }
}
