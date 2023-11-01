using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Franklin_Templeton_DAL.Helpers
{
    public sealed class EncryptionHelper
    {
        private readonly string encryptionKey = "308e60e7-ba07-4a42-b120-d3ae3e382280";
        private readonly Aes aesEncryptor;

        public EncryptionHelper()
        {
            aesEncryptor = BuildAesEncryptor();
        }

        private Aes BuildAesEncryptor()
        {
            var aesEncryptor = Aes.Create();
            var pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            aesEncryptor.Key = pdb.GetBytes(32);
            aesEncryptor.IV = pdb.GetBytes(16);
            return aesEncryptor;
        }

        /// <summary>
        /// For encrypting any text
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public string Encrypt(string plainText)
        {
            try
            {
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, aesEncryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Decrypting any encrypted text.
        /// </summary>
        /// <param name="cipherText"></param>
        /// <returns></returns>
        public string Decrypt(string cipherText)
        {
            try
            {
                var clearBytes = Convert.FromBase64String(cipherText);

                using (MemoryStream msDecrypt = new MemoryStream())
                {
                     using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, aesEncryptor.CreateDecryptor(),CryptoStreamMode.Write))
                     {
                        csDecrypt.Write(clearBytes, 0, clearBytes.Length);
                     }
                    return Encoding.UTF8.GetString(msDecrypt.ToArray());
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}
