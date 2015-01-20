using PawnShopManager.Util;
using System;

namespace PawnShopManager.Controller
{
   class Result<T>
   {
      /** Return code */
      private int _retCode;
      /** System code */
      private SystemError _error;
      /** Generic data */
      private T _data;
      /** Lock Table */
      private String _lockTable;


      /**
       * Default constructor
       */
      public Result()
      {
         this.retCode = Const.ReturnCode.OK;
         this.error = new SystemError();
         this.data = default(T);
      }
# region getter and setter
      public int retCode
      {
         get
         {
            return _retCode;
         }
         set
         {
            _retCode = value;
         }
      }

      public SystemError error
      {
         get
         {
            return _error;
         }
         set
         {
            _error = value;
         }
      }

      public String lockTable
      {
         get
         {
            return _lockTable;
         }
         set
         {
            _lockTable = value;
         }
      }
     

      public  T data
      {
         get
         {
            return _data;
         }
         set
         {
            _data = value;
         }
      }
   }
#endregion
}
