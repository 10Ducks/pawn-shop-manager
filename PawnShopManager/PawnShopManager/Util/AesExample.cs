using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PawnShopManager.Util
{
   internal class AesExample
   {
      public static void main()
      {
         try
         {
            string original = "Here is some data to encrypt!";

            // Create a new instance of the Aes
            // class.  This generates a new key and initialization
            // vector (IV).
            using (Aes myAes = Aes.Create())
            {
               // Encrypt the string to an array of bytes.
               byte[] encrypted = EncryptStringToBytes_Aes(original,
myAes.Key, myAes.IV);

               // Decrypt the bytes to a string.
               string roundtrip = DecryptStringFromBytes_Aes(encrypted,
myAes.Key, myAes.IV);
               //char[] chars = new char[encrypted.Length / sizeof(char)];
               //System.Buffer.BlockCopy(encrypted, 0, chars, 0, encrypted.Length);
               //string str = new string(chars);
               //string s = Encoding.UTF8.GetString(encrypted, 0, encrypted.Length);
               //Display the original data and the decrypted data.
               Console.WriteLine("Original:   {0}", original);
               Console.WriteLine("Round Trip: {0}", roundtrip);
               Console.WriteLine();
               Console.WriteLine("--------------------------------");
               for(int i=0; i<encrypted.Length; i++){
                 Console.Write(encrypted[i]);
               }

            }
         }
         catch (Exception e)
         {
            Console.WriteLine("Error: {0}", e.Message);
         }
      }

      private static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key,
byte[] IV)
      {
         // Check arguments.
         if (plainText == null || plainText.Length <= 0)
            throw new ArgumentNullException("plainText");
         if (Key == null || Key.Length <= 0)
            throw new ArgumentNullException("Key");
         if (IV == null || IV.Length <= 0)
            throw new ArgumentNullException("Key");
         byte[] encrypted;
         // Create an Aes object
         // with the specified key and IV.
         using (Aes aesAlg = Aes.Create())
         {
            aesAlg.Key = Key;
            aesAlg.IV = IV;

            // Create a decrytor to perform the stream transform.
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key
, aesAlg.IV);

            // Create the streams used for encryption.
            using (MemoryStream msEncrypt = new MemoryStream())
            {
               using (CryptoStream csEncrypt = new CryptoStream(msEncrypt
, encryptor, CryptoStreamMode.Write))
               {
                  using (StreamWriter swEncrypt = new StreamWriter(
csEncrypt))
                  {
                     //Write all data to the stream.
                     swEncrypt.Write(plainText);
                  }
                  encrypted = msEncrypt.ToArray();
               }
            }
         }

         // Return the encrypted bytes from the memory stream.
         return encrypted;
      }

      private static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key
, byte[] IV)
      {
         // Check arguments.
         if (cipherText == null || cipherText.Length <= 0)
            throw new ArgumentNullException("cipherText");
         if (Key == null || Key.Length <= 0)
            throw new ArgumentNullException("Key");
         if (IV == null || IV.Length <= 0)
            throw new ArgumentNullException("Key");

         // Declare the string used to hold
         // the decrypted text.
         string plaintext = null;

         // Create an Aes object
         // with the specified key and IV.
         using (Aes aesAlg = Aes.Create())
         {
            aesAlg.Key = Key;
            aesAlg.IV = IV;

            // Create a decrytor to perform the stream transform.
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key
, aesAlg.IV);

            // Create the streams used for decryption.
            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
               using (CryptoStream csDecrypt = new CryptoStream(msDecrypt
, decryptor, CryptoStreamMode.Read))
               {
                  using (StreamReader srDecrypt = new StreamReader(
csDecrypt))
                  {
                     // Read the decrypted bytes from the decrypting stream
                     // and place them in a string.
                     plaintext = srDecrypt.ReadToEnd();
                  }
               }
            }
         }

         return plaintext;
      }
   }
}