using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
namespace Listing3_14AES_encryption
{

    class Program
    {
        static void DumpBytes(string title, byte[] bytes)
        {
            Console.Write(title);
            foreach (byte b in bytes)
            {
                Console.Write("{0:X} ", b);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string plainText = "This is my super secret data";
            //byte array to hold the encrypted message
            byte[] cipherText;
            //byte array to hold the key that was used form encryption
            byte[] key;
            //byte array to hold the initialization vector that was used for encryption
            byte[] initializationVector;
            //Create an AES instance
            //This creates a random key and initialization vector
            using (Aes aes = Aes.Create())
            {
                //copy the key ans the initialization vector
                key = aes.Key;
                initializationVector = aes.IV;

                ICryptoTransform encryptor = aes.CreateEncryptor();
                using (MemoryStream encryptMemoryStream = new MemoryStream())
                {
                    using (CryptoStream encryptCryptoStream = new CryptoStream(encryptMemoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(encryptCryptoStream))
                        {
                            swEncrypt.Write(plainText);
                        }
                        cipherText = encryptMemoryStream.ToArray();
                    }
                }
            }
            //dumnp out our data
            Console.WriteLine("String to encrypt: {0}", plainText);
            DumpBytes("Key: ", key);
            DumpBytes("Initialization Vector: ", initializationVector);
            DumpBytes("Encrypted: ", cipherText);
            Console.ReadKey();
        }
    }
}
