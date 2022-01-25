using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Listing3_17_RSA_key_management
{
    class Program
    {
        static void Main(string[] args)
        {
            string containerName = "MyKeyStore";
            CspParameters csp = new CspParameters();
            csp.KeyContainerName = containerName;

            //create a new RSA to encrypt the data
            RSACryptoServiceProvider rsaStore = new RSACryptoServiceProvider(csp);
            Console.WriteLine("Stored keys:{0}", rsaStore.ToXmlString(includePrivateParameters: true));

            RSACryptoServiceProvider rsaLoad = new RSACryptoServiceProvider(csp);
            Console.WriteLine("loaded keys:{0}", rsaLoad.ToXmlString(includePrivateParameters: true));
            rsaStore.PersistKeyInCsp = false;
            rsaStore.Clear();
            Console.ReadKey();
        }
    }
}
