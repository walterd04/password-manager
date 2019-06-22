using PasswordManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManager.Core.Services
{
    public class Encryption : IEncryption //TODO: maybe implement own encryption algorithm
    {
        public string Encrypt(string password)
        {
            using (Aes myAes = Aes.Create())
            {
                byte[] encrypted = EncryptStringToBytes(password, myAes.Key, myAes.IV);
                return DecryptStringFromBytes(encrypted, myAes.Key, myAes.IV);
            }            
        }

        public string Decrypt(string password)
        {
            throw new NotImplementedException();
        }

        private static byte[] EncryptStringToBytes(string text, byte[] key, byte[] iv)
        {
            if (!CheckDecryptValues(text, key, iv)) throw new ArgumentNullException();

            byte[] retVal;

            using (Aes algorithm = Aes.Create())
            {
                algorithm.Key = key;
                algorithm.IV = iv;

                ICryptoTransform encryptor = algorithm.CreateEncryptor(algorithm.Key, algorithm.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                        }
                        retVal = msEncrypt.ToArray();
                    }
                }
            }

            return retVal;
        }

        private static string DecryptStringFromBytes(byte[] text, byte[] key, byte[] iv)
        {
            if (!CheckDecryptValues(text, key, iv)) throw new ArgumentNullException();

            string retVal = null;

            using (Aes algorithm = Aes.Create())
            {
                algorithm.Key = key;
                algorithm.IV = iv;

                ICryptoTransform decryptor = algorithm.CreateDecryptor(algorithm.Key, algorithm.IV);

                using (MemoryStream msDecrypt = new MemoryStream(text))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            retVal = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return retVal;
        }

        private static bool CheckDecryptValues(byte[] text, byte[] key, byte[] iv)
        {
            if (text is null || text.Length <= 0) return false;
            if (key is null || key.Length <= 0) return false;
            if (iv is null || iv.Length <= 0) return false;

            return true;
        }

        private static bool CheckDecryptValues(string text, byte[] key, byte[] iv)
        {
            if (text is null || text.Length <= 0) return false;
            if (key is null || key.Length <= 0) return false;
            if (iv is null || iv.Length <= 0) return false;

            return true;
        }
    }
}
