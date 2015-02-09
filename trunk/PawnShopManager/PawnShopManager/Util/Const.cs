using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopManager.Util
{
   public class Const
   {
    
      public static readonly String PASSWORD = "";
      public static readonly String SALT = "";
      /** Empty string */
      public static readonly String EMPTY = "";
      /** N true */
      public static readonly String N_TRUE = "1";
      /** N false */
      public static readonly String N_FALSE = "0";
      /** Forward flash */
      public static readonly String FWDSLASH = "/";
      /** Colon */
      public static readonly String COLON = ":";
      /** Open bracket */
      public static readonly String OPEN_BRACKET = "(";
      /** Close bracket */
      public static readonly String CLOSE_BRACKET = ")";
      /** Hyphen */
      public static readonly String HYPHEN = "-";
      /** Hyphen */
      public static readonly String HYPHEN_NONE_DATA = "―";

      /** Constant of black slash */
      public static readonly String BACK_SLASH = "\\";

      /** Constant of apostrophe */
      public static readonly String APOSTROPHE = "'";

      /** Space string */
      public static readonly String SPACE = " ";

      /**
       * Define regular expressions patterns.
       */
      public static class Pattern
      {
         /** Password pattern */
         public static readonly String PASSWORD_PATTERN = "^(?=.*[a-zA-Z])(?=.*\\d)[a-zA-Z\\d]+$";
         /** SIP id password pattern */
         public static readonly String SIP_ID_PASSWORD_PATTERN = "^(?=.*[a-zA-Z])(?=.*\\d)[a-zA-Z\\d]+$";
         /** User name pattern */
         public static readonly String USERNAME_PATTERN = "[a-zA-Z0-9]{1,8}";
         /** Date pattern */
         public static readonly String DATE_PATTERN = "[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]";
         /** First number pattern */
         public static readonly String FIRST_NUMBER_PATTERN = "[2-9]";
         /** Last character pattern */
         public static readonly String LAST_CHARACTER_PATTERN = "[0-9*]";
         /** Outside call number pattern */
         public static readonly String OUTSIDE_CALL_NUMBER_PATTERN = "[\\-a-zA-Z0-9]+";
         /** SIP server address pattern */
         public static readonly String SIP_SERVER_ADDRESS_PATTERN = "[\\-\\.a-zA-Z0-9]+";
         /** File version */
         public static readonly String FILE_VERSION = "[\\-\\.a-zA-Z0-9]+";
         /** Global ip pattern */
         public static readonly String GLOBAL_IP_PATTERN = "^([01]?\\d\\d?|2[0-4]\\d|25[0-5])\\." + "([01]?\\d\\d?|2[0-4]\\d|25[0-5])\\." + "([01]?\\d\\d?|2[0-4]\\d|25[0-5])\\." + "([01]?\\d\\d?|2[0-4]\\d|25[0-5])$";
      }

      /**
       * 名称: ErrorType class
       * 機能概要: Define error types.
       */
      public static class ERROR_TYPE
      {
         /** Session error */
         public static readonly int SESSION_ERROR = 0;
         /** System error */
         public static readonly int SYSTEM_ERROR = 1;
      }

      /**
       * 名称: Error code class
       * 機能概要: Define error code.
       */
      public static class ERROR_CODE
      {
         public static readonly String I010101 = "I010101";
      }

      /**
       * 名称: Message code class
       * 機能概要: Define message for error code.
       */
      public static class MESSAGE_CODE
      {
         /** DB success */
         public static readonly String I010101 = "[DB SUCCESS]";
         /** DB error */
         public static readonly String E010102 = "[DB ERROR]";
      }

      /**
       * 名称: ReturnCode class
       * 機能概要: Define return codes
       */
      public static class ReturnCode
      {
         /** OK */
         public static readonly int OK = 0;
         /** NG */
         public static readonly int NG = -1;
      }

      /**
       * 名称: TableName class
       * 機能概要: Define name of table in DB
       */
      public static class TableName
      {
         public static readonly String TABLE_ADMIN = "tbl_Admin";
         public static readonly String TABLE_CHI_TIET_HOP_DONG = "tbl_Chi_Tiet_Hop_Dong";
         public static readonly String TABLE_CHUOC_HANG = "tbl_Chuoc_Hang";
         public static readonly String TABLE_HANG_HOA = "tbl_Hang_Hoa";
         public static readonly String TABLE_HOP_DONG = "tbl_Hop_Dong";
         public static readonly String TABLE_LOAI_HANG = "tbl_Loai_Hang";
         public static readonly String TABLE_THANH_LY = "tbl_Thanh_Ly";
         public static readonly String TABLE_THEM_TIEN = "tbl_Them_Tien";
         public static readonly String TABLE_THU_CHI = "tbl_Thu_Chi";
         public static readonly String TABLE_TRA_LAI_TRUOC = "tbl_Tra_Lai_Truoc";
      }

      /**
       * 名称: TableKey class
       * 機能概要: Define primary key 's name of table in DB
       */
      public static class TableKey
      {
         
      }
   }
}
