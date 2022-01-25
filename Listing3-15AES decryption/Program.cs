using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_15AES_decryption
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

            //Now do the decryption

            string decryptedText;
            using (Aes aes = Aes.Create())
            {
                //Configure the aes instances with the key and initialization vector to use for decryption
                aes.Key = key;
                aes.IV = initializationVector;
                //Create a decryptor from aes
                //should be wrapped in using form production code
                ICryptoTransform decryptor = aes.CreateDecryptor();
                using (MemoryStream decryptStream = new MemoryStream(cipherText))
                {
                    using (CryptoStream decryptCryptoStream = new CryptoStream(decryptStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(decryptCryptoStream))
                        {
                            //Read the encrypted bytes from the decrypting stream and place them in a string
                            decryptedText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            Console.WriteLine("Decripted text: {0}",decryptedText);

            Console.ReadKey();
        }
    }
}
