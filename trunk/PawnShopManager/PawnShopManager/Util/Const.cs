using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopManager.Util
{
   class Const
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

      /** String min length 8 */
      public static readonly int STRING_MIN_8 = 8;
      /** String max length 32 */
      public static readonly int STRING_MAX_32 = 32;
      /** String max length 40 */
      public static readonly int STRING_MAX_40 = 40;
      /** String max length 128 */
      public static readonly int STRING_MAX_128 = 128;
      /** String max length 1024 */
      public static readonly int STRING_MAX_1024 = 1024;
      /** Number length 5 */
      public static readonly int NUMBER_LENGTH_5 = 5;
      /** Number length 11 */
      public static readonly int NUMBER_LENGTH_11 = 11;
      /** Number length 15 */
      public static readonly int NUMBER_LENGTH_15 = 15;
      /** Number length 32 */
      public static readonly int NUMBER_LENGTH_32 = 32;
      /** Number length 32 */
      public static readonly int NUMBER_LENGTH_128 = 128;
      /** Number min 1 */
      public static readonly int NUMBER_MIN_1 = 1;
      /** Number min 5 */
      public static readonly int NUMBER_MIN_5 = 5;
      /** Number max 30 */
      public static readonly int NUMBER_MAX_30 = 30;
      /** Number max 60 */
      public static readonly int NUMBER_MAX_60 = 60;
      /** Max port */
      public static readonly int MAX_PORT = 65535;
      /** Min port */
      public static readonly int MIN_PORT = 1;
      /** number character of Incoming Group Name */
      public static readonly int NUMBER_CHARACTER_INCOMING_GROUP_NAME = 2;
      /** CSV operator insert */
      public static readonly String CSV_OPERATOR_INSERT = "INSERT";
      /** CSV operator update */
      public static readonly String CSV_OPERATOR_UPDATE = "UPDATE";
      /** CSV operator delete */
      public static readonly String CSV_OPERATOR_DELETE = "DELETE";
      /** The max continuous characters allowed of password */
      public static readonly int PASSWORD_MAX_CHAR_CONTINUOUS = 3;
      /** The default number of rows display on table */
      public static readonly int DEFAULT_ROW_PER_PAGE = 10;
      /** The default current page */
      public static readonly int DEFAULT_CURENT_PAGE = 1;

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
         public static readonly String E010102 = "E010102";
         public static readonly String I010201 = "I010201";
         public static readonly String I010202 = "I010202";
         public static readonly String E010203 = "E010203";
         public static readonly String E010204 = "E010204";
         public static readonly String I010205 = "I010205";
         public static readonly String E010206 = "E010206";
         public static readonly String I010207 = "I010207";
         public static readonly String E020101 = "E020101";
         public static readonly String E020102 = "E020102";
         public static readonly String E020103 = "E020103";
         public static readonly String I020201 = "I020201";
         public static readonly String E020202 = "E020202";
         public static readonly String I020203 = "I020203";
         public static readonly String I020204 = "I020204";
         public static readonly String I020301 = "I020301";
         public static readonly String E020302 = "E020302";
         public static readonly String E020303 = "E020303";
         public static readonly String I020304 = "I020304";
         public static readonly String E020305 = "E020305";
         public static readonly String E020306 = "E020306";
         public static readonly String E020307 = "E020307";
         public static readonly String I020401 = "I020401";
         public static readonly String E020402 = "E020402";
         public static readonly String E020403 = "E020403";
         public static readonly String I020404 = "I020404";
         public static readonly String E020405 = "E020405";
         public static readonly String E020406 = "E020406";
         public static readonly String I020501 = "I020501";
         public static readonly String E020502 = "E020502";
         public static readonly String E020503 = "E020503";
         public static readonly String I020504 = "I020504";
         public static readonly String E020505 = "E020505";
         public static readonly String I020601 = "I020601";
         public static readonly String E020602 = "E020602";
         public static readonly String E020603 = "E020603";
         public static readonly String I020604 = "I020604";
         public static readonly String E020605 = "E020605";
         public static readonly String I020701 = "I020701";
         public static readonly String I020702 = "I020702";
         public static readonly String E020703 = "E020703";
         public static readonly String E020704 = "E020704";
         public static readonly String E020705 = "E020705";
         public static readonly String E020706 = "E020706";
         public static readonly String W020707 = "W020707";
         public static readonly String I020801 = "I020801";
         public static readonly String E020802 = "E020802";
         public static readonly String I020803 = "I020803";
         public static readonly String E020804 = "E020804";
         public static readonly String I020805 = "I020805";
         public static readonly String E020806 = "E020806";
         public static readonly String E030101 = "E030101";
         public static readonly String E030102 = "E030102";
         public static readonly String E030103 = "E030103";
         public static readonly String E030104 = "E030104";
         public static readonly String I030201 = "I030201";
         public static readonly String I030202 = "I030202";
         public static readonly String I030203 = "I030203";
         public static readonly String I030204 = "I030204";
         public static readonly String I030205 = "I030205";
         public static readonly String I030301 = "I030301";
         public static readonly String I030302 = "I030302";
         public static readonly String I030303 = "I030303";
         public static readonly String I030304 = "I030304";
         public static readonly String I030401 = "I030401";
         public static readonly String I030402 = "I030402";
         public static readonly String I030403 = "I030403";
         public static readonly String I030404 = "I030404";
         public static readonly String I030405 = "I030405";
         public static readonly String I030406 = "I030406";
         public static readonly String I030407 = "I030407";
         public static readonly String I030408 = "I030408";
         public static readonly String I030409 = "I030409";
         public static readonly String I030410 = "I030410";
         public static readonly String I030411 = "I030411";
         public static readonly String I030412 = "I030412";
         public static readonly String I030413 = "I030413";
         public static readonly String I030414 = "I030414";
         public static readonly String I030415 = "I030415";
         public static readonly String I030416 = "I030416";
         public static readonly String I030417 = "I030417";
         public static readonly String I030501 = "I030501";
         public static readonly String I030502 = "I030502";
         public static readonly String I030503 = "I030503";
         public static readonly String I030504 = "I030504";
         public static readonly String I030505 = "I030505";
         public static readonly String I030506 = "I030506";
         public static readonly String I030507 = "I030507";
         public static readonly String I030508 = "I030508";
         public static readonly String I030509 = "I030509";
         public static readonly String I030510 = "I030510";
         public static readonly String I030511 = "I030511";
         public static readonly String E030512 = "E030512";
         public static readonly String I030513 = "I030513";
         public static readonly String I030601 = "I030601";
         public static readonly String I030602 = "I030602";
         public static readonly String I030603 = "I030603";
         public static readonly String I030604 = "I030604";
         public static readonly String I030605 = "I030605";
         public static readonly String I030606 = "I030606";
         public static readonly String I030607 = "I030607";
         public static readonly String E030608 = "E030608";
         public static readonly String I030609 = "I030609";
         public static readonly String I030701 = "I030701";
         public static readonly String I030702 = "I030702";
         public static readonly String I030703 = "I030703";
         public static readonly String I030704 = "I030704";
         public static readonly String I030705 = "I030705";
         public static readonly String I030706 = "I030706";
         public static readonly String E030707 = "E030707";
         public static readonly String I030708 = "I030708";
         public static readonly String I030709 = "I030709";
         public static readonly String I030710 = "I030710";
         public static readonly String I030801 = "I030801";
         public static readonly String I030802 = "I030802";
         public static readonly String E030901 = "E030901";
         public static readonly String I031001 = "I031001";
         public static readonly String I031002 = "I031002";
         public static readonly String I031003 = "I031003";
         public static readonly String I031101 = "I031101";
         public static readonly String I031102 = "I031102";
         public static readonly String I031103 = "I031103";
         public static readonly String E031104 = "E031104";
         public static readonly String I031201 = "I031201";
         public static readonly String I031202 = "I031202";
         public static readonly String I031301 = "I031301";
         public static readonly String I031302 = "I031302";
         public static readonly String I031303 = "I031303";
         public static readonly String I031304 = "I031304";
         public static readonly String I031305 = "I031305";
         public static readonly String I031306 = "I031306";
         public static readonly String I031307 = "I031307";
         public static readonly String I031308 = "I031308";
         public static readonly String I031309 = "I031309";
         public static readonly String I031310 = "I031310";
         public static readonly String I031311 = "I031311";
         public static readonly String I031312 = "I031312";
         public static readonly String E031313 = "E031313";
         public static readonly String I031401 = "I031401";
         public static readonly String W031402 = "W031402";
         public static readonly String W031403 = "W031403";
         public static readonly String E031404 = "E031404";
         public static readonly String I031405 = "I031405";
         public static readonly String I031406 = "I031406";
         public static readonly String W031407 = "W031407";
         public static readonly String I031408 = "I031408";
         public static readonly String I031409 = "I031409";
         public static readonly String W031410 = "W031410";
         public static readonly String I031411 = "I031411";
         public static readonly String E031412 = "E031412";
         public static readonly String I031413 = "I031413";
         public static readonly String E031414 = "E031414";
         public static readonly String E031415 = "E031415";
         public static readonly String I031416 = "I031416";
         public static readonly String I031501 = "I031501";
         public static readonly String I031502 = "I031502";
         public static readonly String I031503 = "I031503";
         public static readonly String I031504 = "I031504";
         public static readonly String I031505 = "I031505";
         public static readonly String E031506 = "E031506";
         public static readonly String I031507 = "I031507";
         public static readonly String I031508 = "I031508";
         public static readonly String I031509 = "I031509";
         public static readonly String I031510 = "I031510";
         public static readonly String I031511 = "I031511";
         public static readonly String I031512 = "I031512";
         public static readonly String I031601 = "I031601";
         public static readonly String I031602 = "I031602";
         public static readonly String I031603 = "I031603";
         public static readonly String E031604 = "E031604";
         public static readonly String I031605 = "I031605";
         public static readonly String E031606 = "E031606";
         public static readonly String I031607 = "I031607";
         public static readonly String E031608 = "E031608";

         public static readonly String I031701 = "I031701";
         public static readonly String E031702 = "E031702";
         public static readonly String I031703 = "I031703";
         public static readonly String I031704 = "I031704";
         public static readonly String E031705 = "E031705";
         public static readonly String I031706 = "I031706";
         public static readonly String E031707 = "E031707";
         public static readonly String W030711 = "W030711";
         public static readonly String W030711_LIST_DB_TYPE = "W030711_LIST_DB_TYPE";
         public static readonly String W030711_LIST_INPUT_TYPE = "W030711_LIST_INPUT_TYPE";
         public static readonly String I031801 = "I031801";
         public static readonly String I030418 = "I030418";
         public static readonly String I030419 = "I030419";
         public static readonly String I030420 = "I030420";
         public static readonly String E030421 = "E030421";
         public static readonly String I030422 = "I030422";
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
         /** Start-up system */
         public static readonly String I010201 = "システムを起動します。";
         /** Read setting file successfully */
         public static readonly String I010202 = "設定ファイルの読み込みに成功しました。";
         /** Read setting file fail */
         public static readonly String E010203 = "設定ファイルの読み込みに失敗しました。\nエラー内容：%s";
         /** Setting file content is invalid */
         public static readonly String E010204 = "設定ファイルの内容が不正です。\nエラー内容：%s";
         /** Connect DB server successfully */
         public static readonly String I010205 = "DBサーバへの接続に成功しました。";
         /** Connect DB server fail */
         public static readonly String E010206 = "DBサーバへの接続に失敗しました。\nエラー内容：";
         /** Finish start-up */
         public static readonly String I010207 = "起動処理が完了しました。";
         /** Connect DB server fail */
         public static readonly String E020101 = "DBサーバへの接続に失敗しました。\nエラー内容：";
         /** Return error from DB server */
         public static readonly String E020102 = "DBサーバからエラーが返却されました。\nエラー内容：";
         /** Unknown error */
         public static readonly String E020103 = "予期せぬエラーが発生しました。\nエラー内容：";
         /** Received request for SO notification */
         public static readonly String I020201 = "SO通知の要求を受信しました。　SO番号=%s、SO番号枝番=%s";
         /** Fail in receiving request for SO notification */
         public static readonly String E020202 = "SO通知の要求の受信に失敗しました。\nエラー内容：";
         /** Sent response for SO notification */
         public static readonly String I020203 = "SO通知の応答を送信しました。　SO番号=%s、SO番号枝番=%s";
         /** Fail in sending response for SO notification */
         public static readonly String I020204 = "SO通知の応答の送信に失敗しました。　SO番号=%s、SO番号枝番=%sエラー内容：%s";
         /** Sent request for retrieve SO information */
         public static readonly String I020301 = "SO情報取得の要求を送信しました。　SO番号=%s、SO番号枝番=%s";
         /** Fail in connecting to place which get SO information */
         public static readonly String E020302 = "SO情報取得先との接続に失敗しました。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** Request for SO information timeout */
         public static readonly String E020303 = "SO情報取得の要求がタイムアウトしました。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** Received response for retrieve SO information */
         public static readonly String I020304 = "SO情報取得の応答を受信しました。　SO番号=%s、SO番号枝番=%s";
         /** Fail in receiving response for retrieve SO information */
         public static readonly String E020305 = "SO情報取得の応答の受信に失敗しました。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** Return error from main device */
         public static readonly String E020306 = "SO情報取得の応答で上位装置からエラーが返却されましたた。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** SO information is invalid */
         public static readonly String E020307 = "SO情報取得で取得したSO情報の内容に不備があります。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** Send request for process result */
         public static readonly String I020401 = "処理結果通知の要求を送信しました。　SO番号=%s、SO番号枝番=%s";
         /** Fail in connecting to place which notify process result */
         public static readonly String E020402 = "処理結果通知先との接続に失敗しました。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** Request for process result notification timeout */
         public static readonly String E020403 = "処理結果通知の要求がタイムアウトしました。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** Received response for process result notification */
         public static readonly String I020404 = "処理結果通知の応答を受信しました。　SO番号=%s、SO番号枝番=%s";
         /** Fail in receiving response for process result notification */
         public static readonly String E020405 = "処理結果通知の応答の受信に失敗しました。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** Return error from main device */
         public static readonly String E020406 = "処理結果通知の応答で上位装置からエラーが返却されました。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** Received request for progress notification */
         public static readonly String I020501 = "進捗通知の要求を受信しました。　SO番号=%s、SO番号枝番=%s";
         /** Fail in receiving request for progress notification */
         public static readonly String E020502 = "進捗通知の要求の受信に失敗しました。　\nエラー内容：";
         /** Appropriate SO number is not existed */
         public static readonly String E020503 = "進捗通知の要求を受信しましたが、該当SO番号が存在しませんでした。　SO番号=%s、SO番号枝番=%s";
         /** Received response for progress notification */
         public static readonly String I020504 = "進捗通知の応答を送信しました。　SO番号=%s、SO番号枝番=%s";
         /** Fail in receiving response for progress notification */
         public static readonly String E020505 = "進捗通知の応答の送信に失敗しました。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** Received setting information */
         public static readonly String I020601 = "設定情報照会の要求を受信しました。　SO番号=%s、SO番号枝番=%s";
         /** Fail in receiving setting information */
         public static readonly String E020602 = "設定情報照会の要求の受信に失敗しました。　\nエラー内容：";
         /** Appropriate SO number is not existed */
         public static readonly String E020603 = "設定情報照会の要求を受信しましたが、該当SO番号が存在しませんでした。　SO番号=%s、SO番号枝番=%s";
         /** Received response for setting information */
         public static readonly String I020604 = "設定情報照会の応答を送信しました。　SO番号=%s、SO番号枝番=%s";
         /** Fail in receiving response for setting information */
         public static readonly String E020605 = "設定情報照会の応答の送信に失敗しました。　SO番号=%s、SO番号枝番=%s\nエラー内容：%s";
         /** Start construct process */
         public static readonly String I020701 = "工事処理を開始します。　SO番号=%s、SO番号枝番=%s、SO種別=%s、N番=%s";
         /** Finish construct process */
         public static readonly String I020702 = "工事処理が完了しました。　SO番号=%s、SO番号枝番=%s、SO種別=%s、N番=%s";
         /** Have no appropriate SO information */
         public static readonly String E020703 = "該当するSO情報がありません。　SO番号=%s、SO番号枝番=%s、SO種別=%s、N番=%s";
         /** SO information is invalid */
         public static readonly String E020704 = "工事処理対象のSO情報の内容に不備があります。　SO番号=%s、SO番号枝番=%s、SO種別=%s、N番=%s\nエラー内容：%s";
         /** Fail in construct process */
         public static readonly String E020705 = "工事処理が失敗しました。　SO番号=%s、SO番号枝番=%s、SO種別=%s、N番=%s";
         /** Have no VM-ID */
         public static readonly String E020706 = "VM-IDの在庫がありません。　SO番号=%s、SO番号枝番=%s、SO種別=%s、N番=%s";
         /** Number of VM-ID is lower than threshold */
         public static readonly String W020707 = "VM-IDの在庫が閾値を下回りました。　SO番号=%s、SO番号枝番=%s、SO種別=%s、閾値=%s、VM-ID在庫数=%s";
         // #893 START
         /** Success in creating setting file on extension server */
         public static readonly String I020801 = "内線サーバ設定ファイルの生成に成功しました。  WebエントリID=%s、(予備)=%s、SO種別=%s、N番=%s、ログインID=%s";
         /** Fail in creating setting file on extension server */
         public static readonly String E020802 = "内線サーバ設定ファイルの生成に失敗しました。  WebエントリID=%s、(予備)=%s、SO種別=%s、N番=%s、ログインID=%s";
         // #955 START
         /** Success in uploading setting file to extension server */
         public static readonly String I020803 = "内線サーバへの、内線サーバ設定ファイルのSFTPアップロードに成功しました。  WebエントリID=%s、(予備)=%s、SO種別=%s、N番=%s、VM-ID=%s、(画面)ログインID=%s、接続先ホスト=%s";
         /** Fail in uploading setting file to extension server */
         public static readonly String E020804 = "内線サーバへの、内線サーバ設定ファイルのSFTPアップロードに失敗しました。 WebエントリID=%s、(予備)=%s、SO種別=%s、N番=%s、VM-ID=%s、(画面)ログインID=%s、接続先ホスト=%s";
         // #955 END
         /** Success in AMI command */
         public static readonly String I020805 = "内線サーバへの、AMIコマンドに成功しました。  WebエントリID=%s、(予備)=%s、SO種別=%s、N番=%s、VM-ID=%s、ログインID=%s";
         /** Fail in AMI command */
         public static readonly String E020806 = "内線サーバへの、AMIコマンドに失敗しました。  WebエントリID=%s、(予備)=%s、SO種別=%s、N番=%s、VM-ID=%s、ログインID=%s";
         // #893 END
         /** Have no session information */
         public static readonly String E030101 = "ログインユーザのセッション情報がありません。";
         /** Return error from DB server */
         public static readonly String E030102 = "DBサーバからエラーが返却されました。　ログインID=%s、セッションID=%s\nエラー内容：%s";
         /** Return error from Asterisk server */
         public static readonly String E030103 = "Asteriskサーバからエラーが返却されました。　ログインID=%s、セッションID=%s\nエラー内容：%s";
         /** Unknown error */
         public static readonly String E030104 = "予期せぬエラーが発生しました。　ログインID=%s、セッションID=%s\nエラー内容：%s";
         /** Authenticate error */
         public static readonly String I030201 = "認証に失敗しました。　ログインID=%s";
         /** Account is lock */
         public static readonly String I030202 = "アカウントがロックされています。　ログインID=%s";
         /** expired Password  */
         public static readonly String I030203 = "パスワードの有効期限が切れています。　ログインID=%s";
         /** Login successful */
         public static readonly String I030204 = "ログインしました。　ログインID=%s、セッションID=%s";
         /** Login information */
         public static readonly String I030205 = "ログインアクセス履歴: リモートアドレス = %s(%s) 、リクエストURL = %s 、ブラウザ情報 = %s";
         /** Input the wrong old password */
         public static readonly String I030301 = "旧パスワードの認証に失敗しました。　ログインID=%s、セッションID=%s";
         /** Use the old password */
         public static readonly String I030302 = "パスワードの変更に失敗しました。過去に利用したことのあるパスワードです。　ログインID=%s";
         /** Reply password is not match */
         public static readonly String I030303 = "パスワードの変更に失敗しました。変更後のパスワードと再入力されたパスワードが一致しません。　ログインID=%s";
         /** Change successfully */
         public static readonly String I030304 = "パスワードを変更しました。　ログインID=%s、セッションID=%s";
         /** Add incoming group information */
         public static readonly String I030401 = "着信グループ情報を追加します。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Update incoming group information */
         public static readonly String I030402 = "着信グループ情報を変更します。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Delete incoming group information */
         public static readonly String I030403 = "着信グループ情報を削除します。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Fail in retrieving incoming group information */
         public static readonly String I030404 = "着信グループ情報の取得に失敗しました。選択した着信グループ情報が削除されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Fail in adding incoming group information */
         public static readonly String I030405 = "着信グループ情報の追加に失敗しました。着信グループ情報をこれ以上追加できません。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Add fail, incoming group information because data is changed or deleted */
         public static readonly String I030406 = "着信グループ情報の追加に失敗しました。内線代表番号候補が削除もしくは変更されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Add fail, incoming group information because group child number is changed or deleted */
         public static readonly String I030407 = "着信グループ情報の追加に失敗しました。グループ子番号が削除もしくは変更されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Add fail, setting representative number for other incoming group */
         public static readonly String I030408 = "着信グループ情報の追加に失敗しました。内線代表番号が他の着信グループ情報の代表番号に設定されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Add fail, Service name is 050pfb so cannot set incoming extension number */
         public static readonly String I030409 = "着信グループ情報の追加に失敗しました。内線代表番号が外線サービス種別「050pfb」の外線番号の着信内線番号に設定されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Add fail, Cannot set same extension to other incoming group if call type is call pickup */
         public static readonly String I030410 = "着信グループ情報の追加に失敗しました。呼出方式がコールピックの場合、異なる着信グループに同じ内線番号を設定できません。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Update fail, incoming group because other updated */
         public static readonly String I030411 = "着信グループ情報の変更に失敗しました。着信グループ情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Update fail, representative number is deleted or changed */
         public static readonly String I030412 = "着信グループ情報の変更に失敗しました。内線代表番号候補が削除もしくは変更されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Update fail, group child number is deleted or changed */
         public static readonly String I030413 = "着信グループ情報の変更に失敗しました。グループ子番号が削除もしくは変更されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Update fail, setting representative number for other incoming group */
         public static readonly String I030414 = "着信グループ情報の変更に失敗しました。内線代表番号が他の着信グループ情報の代表番号に設定されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Update fail, service name is 050pfb so cannot set incoming extension number */
         public static readonly String I030415 = "着信グループ情報の変更に失敗しました。内線代表番号が外線サービス種別「050pfb」の外線番号の着信内線番号に設定されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Update fail, Cannot set same extension to other incoming group if call type is call pickup */
         public static readonly String I030416 = "着信グループ情報の変更に失敗しました。呼出方式がコールピックの場合、異なる着信グループに同じ内線番号を設定できません。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Delete fail, incoming group because other updated */
         public static readonly String I030417 = "着信グループ情報の削除に失敗しました。着信グループ情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s、着信グループ名=%s、呼び出し方式=%s、代表番号=%s";
         /** Add new outside incoming **/
         public static readonly String I030501 = "外線着信情報を追加します。　ログインID=%s、セッションID=%s";
         /** Update outside incoming **/
         public static readonly String I030502 = "外線着信情報を変更します。　ログインID=%s、セッションID=%s";
         /** Delete outside incoming **/
         public static readonly String I030503 = "外線着信情報を削除します。　ログインID=%s、セッションID=%s";
         /** Select fail outside incoming **/
         public static readonly String I030504 = "外線着信情報の取得に失敗しました。選択した外線着信情報が削除されています。　ログインID=%s、セッションID=%s";
         /** Add fail, service name is 050pfb so cannot set outside incoming extension number **/
         //Start Step1.6 #1289
         public static readonly String I030505 = "外線着信情報の追加に失敗しました。外線サービス種別が「050pfb」の場合、着信内線番号に代表番号、スマートフォン・ソフトフォン以外の端末、すでに他の外線番号の着信先に設定している内線番号を設定できません。　ログインID=%s、セッションID=%s";
         //End Step1.6 #1289
         /** Update fail, outside incoming group because other updated **/
         public static readonly String I030506 = "外線着信情報の変更に失敗しました。外線着信情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s";
         /** Update fail, service name is 050pfb so cannot set outside incoming extension number **/
         //Start Step1.6 #1289
         public static readonly String I030507 = "外線着信情報の変更に失敗しました。外線サービス種別が「050pfb」の場合、着信内線番号に代表番号、スマートフォン・ソフトフォン以外の端末、すでに他の外線番号の着信先に設定している内線番号を設定できません。　ログインID=%s、セッションID=%s";
         //End Step1.6 #1289
         /** Delete fail, outside incoming group because other updated **/
         public static readonly String I030508 = "外線着信情報の削除に失敗しました。外線着信情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s";
         /** Success in reading batch setting file for outgoing incoming information **/
         public static readonly String I030509 = "外線着信情報一括設定ファイルの読み込みに成功しました。　ログインID=%s、セッションID=%s";
         /** Fail in reading batch setting file for outgoing incoming information, format error **/
         public static readonly String I030510 = "外線着信情報一括設定ファイルの読み込みに失敗しました。フォーマットエラーです。　ログインID=%s、セッションID=%s";
         /** Reflected batch setting file to DB, format error **/
         public static readonly String I030511 = "外線着信情報一括設定ファイルのDB反映に成功しました。ログインID=%s、セッションID=%s";
         /** Fail in reflecting batch setting file to DB, format error **/
         public static readonly String E030512 = "外線着信情報一括設定ファイルのDB反映に失敗しました。ログインID=%s、セッションID=%s";
         /** Output setting file, format error **/
         //Start 1.6 Fix #1327
         //public static readonly String I030513 = "設定ファイルを出力します。フォーマットエラーです。　ログインID=%s、セッションID=%s、設定ファイル名=%s";
         public static readonly String I030513 = "設定ファイルを出力します。　ログインID=%s、セッションID=%s、設定ファイル名=%s";
         //End 1.6 Fix #1327
         /** Notify when update prefix */
         public static readonly String I030601 = "外線Prefix情報を設定しました。　ログインID=%s、セッションID=%s";
         /** Notify when setting outside outgoing */
         public static readonly String I030602 = "外線発信情報を設定します。　ログインID=%s、セッションID=%s";
         /** Fail in getting outside outgoing information */
         public static readonly String I030603 = "外線発信情報の取得に失敗しました。選択した外線発信情報が削除されています。　ログインID=%s、セッションID=%s";
         /** Fail in setting outside outgoing information */
         public static readonly String I030604 = "外線発信情報の設定に失敗しました。外線発信情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s";
         /** Success in reading batch file for outside outgoing information */
         public static readonly String I030605 = "外線発信情報一括設定ファイルの読み込みに成功しました。　ログインID=%s、セッションID=%s";
         /** Fail in reading batch file for outside outgoing information */
         public static readonly String I030606 = "外線発信情報一括設定ファイルの読み込みに失敗しました。フォーマットエラーです。　ログインID=%s、セッションID=%s";
         /** Success in reflecting batch file for outside outgoing information in DB */
         public static readonly String I030607 = "外線発信情報一括設定ファイルのDB反映に成功しました。　ログインID=%s、セッションID=%s";
         /** Fail in reflecting batch file for outside outgoing information in DB */
         public static readonly String E030608 = "外線発信情報一括設定ファイルのDB反映に失敗しました。　ログインID=%s、セッションID=%s";
         /** Output batch file for outside outgoing information */
         public static readonly String I030609 = "外線発信情報一括設定ファイルを出力します。　ログインID=%s、セッションID=%s";
         /** Update extension information */
         public static readonly String I030701 = "内線情報を変更します。　ログインID=%s、セッションID=%s";
         /** Fail in retrieving extension information */
         public static readonly String I030702 = "内線情報の取得に失敗しました。選択した内線情報が削除されています。　ログインID=%s、セッションID=%s";
         /** Fail in updating extension information */
         public static readonly String I030703 = "内線情報の変更に失敗しました。内線情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s";
         /** Success in reading batch file for extension information */
         public static readonly String I030704 = "内線情報一括設定ファイルの読み込みに成功しました。　ログインID=%s、セッションID=%s";
         /** Fail in reading batch file for extension information */
         public static readonly String I030705 = "内線情報一括設定ファイルの読み込みに失敗しました。フォーマットエラーです。　ログインID=%s、セッションID=%s";
         /** Success in reflecting batch file for extension information in DB */
         public static readonly String I030706 = "内線情報一括設定ファイルのDB反映に成功しました。　ログインID=%s、セッションID=%s";
         /** Fail in reflecting batch file for extension information in DB */
         public static readonly String E030707 = "内線情報一括設定ファイルのDB反映に失敗しました。　ログインID=%s、セッションID=%s";
         /** Output batch file for extension information */
         public static readonly String I030708 = "内線情報一括設定ファイルを出力します。　ログインID=%s、セッションID=%s";
         /** Fail in updating extension information */
         public static readonly String I030709 = "内線情報の変更に失敗しました。拠点番号の桁数が不正です。　ログインID=%s、セッションID=%s";
         /** Fail in retrieving extension information */
         public static readonly String I030710 = "内線情報の取得に失敗しました。端末番号の桁数が不正です。　ログインID=%s、セッションID=%s";
         /** Setting call regulation info */
         public static readonly String I030801 = "発信規制先情報を設定します。　ログインID=%s、セッションID=%s";
         /** Setting call regulation info failure */
         public static readonly String I030802 = "発信規制先情報の設定に失敗しました。発信規制先情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s";
         /** Fail in retrieving PBX information */
         public static readonly String E030901 = "PBX設定情報の取得に失敗しました。選択したPBX設定情報が削除されています。　ログインID=%s、セッションID=%s";
         /** Setting absence operation information */
         public static readonly String I031001 = "不在時動作情報を設定します。　ログインID=%s、セッションID=%s";
         /** Fail in setting absence operation information */
         public static readonly String I031002 = "不在時動作情報の設定に失敗しました。不在時動作情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s";
         /** Fail in display absence operation information */
         // Start 1.x #835
         public static readonly String I031003 = "不在時動作情報の表示に失敗しました。端末種別が\"VoIP-GW\"のため、不在時動作設定ができません。　ログインID=%s、セッションID=%s";
         // End 1.x #835
         /** Success in reading batch file for address list */
         public static readonly String I031101 = "アドレス表一括設定ファイルの読み込みに成功しました。　ログインID=%s、セッションID=%s";
         /** Fail in reading batch file for address list */
         public static readonly String I031102 = "アドレス表一括設定ファイルの読み込みに失敗しました。フォーマットエラーです。　ログインID=%s、セッションID=%s";
         /** Success in reflecting batch file for address list in DB */
         public static readonly String I031103 = "アドレス表一括設定ファイルのDB反映に成功しました。　ログインID=%s、セッションID=%s";
         /** Fail in reflecting batch file for address list in DB */
         public static readonly String E031104 = "アドレス表一括設定ファイルのDB反映に失敗しました。　ログインID=%s、セッションID=%s";
         /** Display notify information */
         public static readonly String I031201 = "お知らせ情報を設定します。　ログインID=%s、セッションID=%s";
         /** Fail in display notify information */
         public static readonly String I031202 = "お知らせ情報の設定に失敗しました。お知らせ情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s";
         /** Register account information */
         public static readonly String I031301 = "アカウント情報を登録します。　ログインID=%s、セッションID=%s、登録対象のログインID=%s";
         /** Release lock of account information */
         public static readonly String I031302 = "アカウント情報のロックを解除します。　ログインID=%s、セッションID=%s";
         /** Update password account information */
         public static readonly String I031303 = "アカウント情報のパスワードを変更します。　ログインID=%s、セッションID=%s、パスワード変更対象のログインID=%s";
         /** Account is delete by another **/
         public static readonly String I031304 = "アカウント情報を削除します。　ログインID=%s、セッションID=%s";
         /** Fail in retrieving account information */
         public static readonly String I031305 = "アカウント情報の取得に失敗しました。選択したアカウント情報が削除されています。　ログインID=%s、セッションID=%s";
         /** Update fail, Use old password **/
         public static readonly String I031306 = "アカウント情報のパスワードの変更に失敗しました。過去に利用したことのあるパスワードです。　ログインID=%s、セッションID=%s、パスワード変更対象のログインID=%s";
         /** Update fail, other update account information **/
         public static readonly String I031307 = "アカウント情報のパスワードの変更に失敗しました。アカウント情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s、パスワード変更対象のログインID=%s";
         /** Fail in deleting account information **/
         public static readonly String I031308 = "アカウント情報の削除に失敗しました。初期アカウントは削除できません。　ログインID=%s、セッションID=%s、削除対象のログインID=%s";
         /** Account is delete by anothe r**/
         public static readonly String I031309 = "アカウント情報の削除に失敗しました。アカウント情報は、すでに他のユーザによって変更されています。　ログインID=%s、セッションID=%s、削除するアカウントのログインID=%s";
         /** Success in reading batch file for account **/
         public static readonly String I031310 = "アカウント一括設定ファイルの読み込みに成功しました。　ログインID=%s、セッションID=%s";
         /** Fail in reading batch file for account **/
         public static readonly String I031311 = "アカウント一括設定ファイルの読み込みに失敗しました。フォーマットエラーです。　ログインID=%s、セッションID=%s";
         /** Success in reflecting batch file for account in DB **/
         public static readonly String I031312 = "アカウント一括設定ファイルのDB反映に成功しました。　ログインID=%s、セッションID=%s";
         /** Fail in reflecting batch file for account in DB **/
         public static readonly String E031313 = "アカウント一括設定ファイルのDB反映に失敗しました。　ログインID=%s、セッションID=%s";
         /** Start retrieve CDR log **/
         public static readonly String I031401 = "CDRログ取得を開始。 N番 = [%s] , IPアドレス = [%s] ";
         /** Have no download information **/
         public static readonly String W031402 = "ダウンロード先のファイルがありません。 [%s]   ";
         /** Fail in retrieving CDR log, then re-read **/
         public static readonly String E031403 = "CDRログ取得に失敗しました。再度取得を試みます。　N番 = [%s] , IPアドレス = [%s]";
         /** Fail in retrieving CDR log **/
         public static readonly String E031404 = "CDRログ取得に失敗しました。N番 = [%s] , IPアドレス = [%s]";
         /** Download file **/
         public static readonly String I031405 = "対象ファイルをダウンロードしました。 SRC = [%s] → DST = [%s]";
         /** Finish retrieving CDR log **/
         public static readonly String I031406 = "CDRログ取得を終了。 N番 = [%s] , IPアドレス = [%s]";
         /** Fail in deleting file **/
         public static readonly String W031407 = "ファイル削除に失敗しました　[%s]";
         /** Save CDR to DB **/
         public static readonly String I031408 = "CDRをDBへ保存しました。";
         /** Finish retrieving CDR **/
         public static readonly String I031409 = "全VMからのCDR取得が完了しました。";
         /** Fail in adding data **/
         public static readonly String E031410 = "データの追加に失敗しました。";
         /** Finish **/
         public static readonly String I031411 = "終了します。";
         /** Error occur **/
         public static readonly String E031412 = "エラー発生　%s";
         /** Error occur **/
         public static readonly String I031413 = "VM情報を取得";
         /** Error config value **/
         public static readonly String E031414 = "コンフィグ値が正しくありません\n-----------------------------\n%s\n-----------------------------";
         /** Fail in loading properties file **/
         public static readonly String E031415 = "プロパティファイルのロードに失敗しました。\nproperty file = 【%s】";
         /** Retrieve VM info **/
         public static readonly String I031416 = "VM情報を取得";
         /** Number of N Number **/
         public static readonly String I031501 = "N番件数 = [%s]";
         /** Target N Number **/
         public static readonly String I031502 = "対象N番 = [%s]";
         /** Get number of usage channel N Number **/
         // Start 1.x #835
         public static readonly String I031503 = "全チャネル数とVoipGW(複数)　の利用チャネル数を取得 N番 = [%s] , VM IPアドレス = [%s] ";
         // End 1.x #835
         /** Start SSH **/
         public static readonly String I031504 = "SSH開始.　コマンド = [%s]";
         /** End SSH **/
         public static readonly String I031505 = "SSH終了. 実行結果 = [%s]";
         /** Fail in SSH connection **/
         public static readonly String E031506 = "SSH接続に失敗しました。 詳細 [%s]";
         /** Number of usage channel **/
         public static readonly String I031507 = "利用チャネル数 = [%s]";
         /** Back number **/
         // Start 1.x #835
         public static readonly String I031508 = "VoipGWの拠点番号複数台利用無しの裏番号  = [%s]";
         // End 1.x #835
         /** Save data to DB **/
         public static readonly String E031509 = "トラック情報をDBへ保存しました";
         /** Finish retrieving traffic process **/
         public static readonly String I031510 = "全VMからトラヒック取得処理が完了しました。";
         /** Finish **/
         public static readonly String I031511 = "終了します。";
         /** Retrieve VM info **/
         public static readonly String I031512 = "VM情報を取得";
         /** Start processing for trouble transfer **/
         public static readonly String I031601 = "VM移転処理スレッドが起動しました。移転情報監視間隔は[%s]秒です。";
         /** Trasfer from terminal to destination **/
         public static readonly String I031602 = "VM移転予定がありました。移転を開始します。 移転元VM-ID = [%s] ,　移転先VM-ID = [%s]";
         /** Forward the Asterisk configuration file transfer original VM **/
         public static readonly String I031603 = "移転元VMのAsterisk設定ファイルを転送します。転送先パス = [%s]";
         /** Failed to transfer the Asterisk configuration files transfer the original VM. **/
         public static readonly String E031604 = "移転元VMのAsterisk設定ファイルを転送に失敗しました。 詳細 = [%s]";
         /** Reload the configuration of Asterisk. **/
         public static readonly String I031605 = "Asteriskの設定をリロードしました。";
         /** Failed to reload the configuration of Asterisk. **/
         public static readonly String E031606 = "Asteriskの設定のリロードに失敗しました。";
         /** VM rerouting is complete. **/
         public static readonly String I031607 = "VM支障移転が完了しました。移転元VM-ID = [%s] ,　移転先VM-ID = [%s]";
         /** VM rerouting failed. **/
         public static readonly String E031608 = "VM支障移転が失敗しました。移転元VM-ID = [%s] ,　移転先VM-ID = [%s]";

         // Start 1.x #654
         /** The terminal automatic operation setting begins.  */
         public static readonly String E031701 = "端末自動設定を開始します。";
         /** It failed in the acquisition of the template file for the terminal automatic operation setting. */
         public static readonly String E031702 = "端末自動設定用テンプレートファイルの取得に失敗しました。ファイルパス = [%s]";
         /** Terminal automatic configuration file making. */
         public static readonly String I031703 = "端末自動設定ファイル作成(アカウント情報.アカウント情報ID =　%s)、置換パラメータ:　内線番号情報.端末MACアドレス = %s、外線情報.外線番号 = %s、外線情報.SIPーID = %s、外線情報.SIPパスワード = %s、外線情報.サーバアドレス = %s、・外線情報.ポート番号 = %s";
         /** A terminal automatic configuration file was forwarded. */
         public static readonly String I031704 = "端末自動設定ファイルを転送しました。 サーバアドレス = [%s]、パス = [%s]";
         /** It failed in forwarding a terminal automatic configuration file. */
         public static readonly String E031705 = "端末自動設定ファイルの転送に失敗しました。 サーバ = [%s]、パス = [%s]　詳細 = [%s]";
         /** The terminal automatic operation setting was completed.  */
         public static readonly String I031706 = "端末自動設定が完了しました。";
         /** The terminal automatic operation setting failed.  */
         public static readonly String E031707 = "端末自動設定が失敗しました。";
         /** If terminal MAC address is exised */
         public static readonly String W030711 = "内線情報の取得に失敗しました。MACアドレスの重複を検知しました。　ログインID = %s、セッションID = %s、 以下の内線番号と重複しています。";
         public static readonly String W030711_LIST_DB_TYPE = "\nN番= %s、内線番号 = %s、MACアドレス = %s、種別 = DBレコード";
         public static readonly String W030711_LIST_INPUT_TYPE = "\nN番= %s、内線番号 = %s、MACアドレス = %s、種別 = 画面入力";
         public static readonly String I031801 = "VM支障移転を予約します。 移転元VM-ID= %s、移転先VM-ID= %s";
         /** Success in reading batch file for outside incoming information */
         public static readonly String I030418 = "着信グループ情報一括設定ファイルの読み込みに成功しました。　ログインID = %s、セッションID = %s";
         /** Fail in reading batch file for outside incoming information */
         public static readonly String I030419 = "着信グループ情報一括設定ファイルの読み込みに失敗しました。フォーマットエラーです。　ログインID = %s、セッションID = %s";
         /** Success in reflecting batch file for outside incoming information in DB */
         public static readonly String I030420 = "着信グループ情報一括設定ファイルのDB反映に成功しました。ログインID = %s、セッションID = %s";
         /** Fail in reflecting batch file for outside incoming information in DB */
         public static readonly String E030421 = "着信グループ情報一括設定ファイルのDB反映に失敗しました。ログインID = %s、セッションID = %s";
         /** Output batch file for outside incoming information */
         public static readonly String I030422 = "着信グループ情報一括設定ファイルを出力します。ログインID = %s、セッションID = %s";
      }

      /**
       * 名称: LoginMode class
       * 機能概要: Define login modes.
       */
      public static class LoginMode
      {
         /** Operator */
         public static readonly String OPERATOR = "OPERATOR";
         /** User manager before */
         public static readonly String USER_MANAGER_BEFORE = "USER_MANAGER_BEFORE";
         /** User manager after */
         public static readonly String USER_MANAGER_AFTER = "USER_MANAGER_AFTER";
         /** Terminal user */
         public static readonly String TERMINAL_USER = "TERMINAL_USER";
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
       * 名称: AccountType class
       * 機能概要: Define account type (number) in DB.
       */
      public static class ACCOUNT_TYPE
      {
         /** Operator */
         public static readonly int OPERATOR = 1;
         /** User manager */
         public static readonly int USER_MANAGER = 2;
         /** Terminal user */
         public static readonly int TERMINAL_USER = 3;
         /** Operator as Admin*/
         public static readonly int OPERATOR_ADMIN = 4;
      }

      /**
       * 名称: TableName class
       * 機能概要: Define name of table in DB
       */
      public static class TableName
      {

      }

      /**
       * 名称: TableKey class
       * 機能概要: Define primary key 's name of table in DB
       */
      public static class TableKey
      {
         public static readonly String ABSENCE_BEHAVIOR_INFO_ID = "absence_behavior_info_id";
         public static readonly String ACCOUNT_INFO_ID = "account_info_id";
         public static readonly String LOGIN_ID = "login_id";
         public static readonly String CALL_REGULATION_INFO_ID = "call_regulation_info_id";
         public static readonly String EXTENSION_NUMBER_INFO_ID = "extension_number_info_id";
         public static readonly String INCOMING_GROUP_CHILD_NUMBER_INFO_ID = "incoming_group_child_number_info_id";
         public static readonly String INCOMING_GROUP_INFO_ID = "incoming_group_info_id";
         public static readonly String INFOMATION_INFO_ID = "infomation_info_id";
         public static readonly String N_NUMBER_INFO_ID = "n_number_info_id";
         public static readonly String OUTSIDE_CALL_INCOMING_INFO_ID = "outside_call_incoming_info_id";
         public static readonly String OUTSIDE_CALL_INFO_ID = "outside_call_info_id";
         public static readonly String OUTSIDE_CALL_SENDING_INFO_ID = "outside_call_sending_info_id";
         public static readonly String SITE_ADDRESS_INFO_ID = "site_address_info_id";
         public static readonly String TRAFFIC_INFO_ID = "traffic_info_id";
         public static readonly String VM_INFO_ID = "vm_info_id";
         public static readonly String VM_RESOURCE_TYPE_MASTER_ID = "vm_resource_type_master_id";
         public static readonly String VM_TRANSFER_QUEUE_INFO_ID = "vm_transfer_queue_info_id";
      }

      public static class RowPerPage
      {
         public static readonly int option1 = 10;
         public static readonly int option2 = 50;
         public static readonly int option3 = 100;
      }
   }
}
