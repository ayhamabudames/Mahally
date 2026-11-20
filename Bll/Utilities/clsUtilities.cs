using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Utilities
{
    public class clsUtilities
    {
        static string KeyName = @"HKEY_CURRENT_USER\Software\Mahally";
        static string EncryptionKey = "67676767676767676767676767676767";
        public static string ComputeHash256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public static void SaveCredentialsToRegistry(string username, string password)
        {
            username = Encrypt(username);
            password = Encrypt(password);
            Registry.SetValue(KeyName, "Username", username);
            Registry.SetValue(KeyName, "Password", password);
        }

        public static void ClearCredentialsFromRegistry()
        {
            clsGlobal.CurrentUser = null;
            Registry.SetValue(KeyName, "Username", "");
            Registry.SetValue(KeyName, "Password", "");
        }

        public static bool GetCredentialsFromRegistry(out string username, out string password)
        {

            username = (string)Registry.GetValue(KeyName, "Username", "");
            password = (string)Registry.GetValue(KeyName, "Password", "");
            if( !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                username = Decrypt(username);
                password = Decrypt(password);
                return true;
            }
            else
            {
                return false;
            }
        }

        static string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(EncryptionKey);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }


                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        static string Decrypt(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(EncryptionKey);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
