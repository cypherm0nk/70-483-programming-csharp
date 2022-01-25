using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_19Machine_level_keys
{
    class Program
    {
        static void Main(string[] args)
        {
            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "Machine level key";
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspParams);
            Console.WriteLine(rsa.ToXmlString(includePrivateParameters:false));

            rsa.PersistKeyInCsp = true;
            rsa.Clear();

        }
    }
}
