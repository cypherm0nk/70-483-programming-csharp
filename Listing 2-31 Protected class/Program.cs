using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_31_Protected_class
{
    class bankAccount
    {
        protected class Address
        {
            public string FirstLine;
            public string PostCode;
        }
        protected decimal accountBalance = 0;

    }
    class OverdraftAccount : bankAccount {
        decimal overdraftLimit = 100;
        Address GuarantorAddress;
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
