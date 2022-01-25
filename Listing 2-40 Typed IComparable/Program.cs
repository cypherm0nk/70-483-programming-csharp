using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_40_Typed_IComparable
{
    public interface IAccount : IComparable<IAccount>
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }
    public class BankAccount : IAccount, IComparable<BankAccount>
    {

        private decimal balance;

        public int CompareTo(IAccount account)
        {
            if (account == null) return 1;
            return this.balance.CompareTo(account.GetBalance());
        }

        public int CompareTo(BankAccount other)
        {
            throw new NotImplementedException();
        }

        public decimal GetBalance()
        {
            throw new NotImplementedException();
        }

        public void PayInFunds(decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool WithdrawFunds(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
