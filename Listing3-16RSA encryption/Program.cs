using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Listing3_16RSA_encryption
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
            Console.WriteLine("Plain text:{0}",plainText);
            //RSA works on byte arrays, not strings of text
            //this will convert our input string into bytes and back
            ASCIIEncoding converter = new ASCIIEncoding();

            //convert the plain text into a byte array
            byte[] plainBytes = converter.GetBytes(plainText);

            DumpBytes("Plain bytes: ",plainBytes);
            byte[] encryptedBytes;
            byte[] decryptedbytes;

            //Create new RSA to encrypt the data
            //should be wrapped in using for production code
            RSACryptoServiceProvider rsaEncrypt = new RSACryptoServiceProvider();
            //get the keys out of the encryptor
            string publicKey = rsaEncrypt.ToXmlString(includePrivateParameters:false);
            Console.WriteLine("Public key:{0}",publicKey);
            string privateKey = rsaEncrypt.ToXmlString(includePrivateParameters:true);
            Console.WriteLine("Private key:{0}",privateKey);

            rsaEncrypt.FromXmlString(privateKey);

            encryptedBytes = rsaEncrypt.Encrypt(plainBytes,fOAEP:false);
            DumpBytes("Encrypted bytes: ",encryptedBytes);

            RSACryptoServiceProvider rsaDecrypt = new RSACryptoServiceProvider();

            rsaDecrypt.FromXmlString(privateKey);

            decryptedbytes = rsaDecrypt.Decrypt(encryptedBytes,fOAEP:false);
            DumpBytes("Decrypted bytes:",decryptedbytes);
            Console.WriteLine("Decrypted string: {0}", converter.GetString(decryptedbytes));
           
            Console.ReadKey();

        }
    }
}
