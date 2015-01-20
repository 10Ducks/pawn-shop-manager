using System;

namespace PawnShopManager.Controller
{
   class SystemError
   {
      /** Error title */
      private String _errorTitle;

      /** Error message */
      private String _errorMessage;
     
      /** Error type */
      private int _errorType;

      /** Error code */
      private String _errorCode;

      /**
       * Default constructor
       */
      public SystemError()
      {
         //this.errorType = Const.ERROR_TYPE.SESSION_ERROR;
         //this.errorCode = "";
      }
      #region Getter and Setter
      public String ErrorTitle
      {
         get { return _errorTitle; }
         set { _errorTitle = value; }
      }
      public String ErrorMessage
      {
         get { return _errorMessage; }
         set { _errorMessage = value; }
      }
      public int ErrorType
      {
         get { return _errorType; }
         set { _errorType = value; }
      }
      public String ErrorCode
      {
         get { return _errorCode; }
         set { _errorCode = value; }
      }
      #endregion
   }
}
