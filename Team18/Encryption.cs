using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team18
{
    public class Encryption
    {
        private const int KeySize = 128;

        public static string GenerateKey()
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = KeySize;
                aes.GenerateKey();
                return Convert.ToBase64String(aes.Key);
            }
        }
        public static void SaveKey(string key)
        {
            var query = "INSERT INTO KEY_STORAGE (KEY_VALUE) VALUES (:keyValue)";
            OracleCommand cmd = OracleDB.conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.Add(new OracleParameter("keyValue", key));
            cmd.ExecuteNonQuery();
        }

        public static string GetKey()
        {
            var query = "SELECT KEY_VALUE FROM KEY_STORAGE WHERE ROWNUM = 1 ORDER BY ID DESC";
            OracleCommand cmd = OracleDB.conn.CreateCommand();
            cmd.CommandText = query;
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return reader.GetString(0);
            }
            reader.Close();
            return null;
        }

        public static string EncryptData(string data, string key)
        {
            byte[] encryptedBytes;
            byte[] keyBytes = Convert.FromBase64String(key);

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
            byte[] keyBytes = Convert.FromBase64String(key);

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
