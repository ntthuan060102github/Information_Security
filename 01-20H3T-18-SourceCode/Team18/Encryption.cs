using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team18.Database;
using System.Security.Cryptography;

namespace Team18
{
    public class Encryption
    {
        private const int KeySize = 256; //key có độ dài 256 bits - 32 bytes
        private static string key = "ATBM_Team18"; //key dưới dạng string có độ dài tối đa 16 ký tự unicode(mỗi ký tự chiếm 2 bytes)

        public static string GetKey()
        {
            return key;
        }

        public static string EncryptData(string data, string key)
        {
            byte[] encryptedBytes;
            byte[] keyBytes;
            //Chuyển key dạng chuỗi sang 1 mảng byte gồm 32 bytes sử dụng hàm băm SHA-256
            using (SHA256 sha256 = SHA256.Create())
            {
                keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
            }

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = KeySize;
                aes.Key = keyBytes;
                aes.GenerateIV();

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                byte[] dataBytes = Encoding.UTF8.GetBytes(data);

                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(aes.IV, 0, aes.IV.Length);
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(dataBytes, 0, dataBytes.Length);
                        cs.FlushFinalBlock();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return Convert.ToBase64String(encryptedBytes);
        }

        public static string DecryptData(string encryptedData, string key)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedData);
            byte[] keyBytes;
            using (SHA256 sha256 = SHA256.Create())
            {
                keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
            }

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = KeySize;
                aes.Key = keyBytes;

                byte[] iv = new byte[aes.BlockSize / 8];
                Array.Copy(encryptedBytes, 0, iv, 0, iv.Length);
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(encryptedBytes, iv.Length, encryptedBytes.Length - iv.Length);
                        cs.FlushFinalBlock();
                    }
                    byte[] decryptedBytes = ms.ToArray();
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
        }
    }
}
