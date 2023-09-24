using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.DelegateAndEvents
{
    public delegate void LowBalance();
    class EventDemo2
    { 
        static void acc_LowBalanceEvent()
        {
            Console.WriteLine("No sufficient balance is available");
        }
        static void Main(string[] args)
        {
            Account acc = new Account(40000);
            acc.LowBalanceEvent += new LowBalance(acc_LowBalanceEvent);
            acc.Withdraw(50000);
        }
    }
    class Account
    {
        double Balance;
        public event LowBalance LowBalanceEvent;
        public Account(double _Balance)
        {
            Balance = _Balance;
        }
        public void Withdraw(double Amount)
        {
            double RemBalance = Balance - Amount;
            if (RemBalance < 1000)
            {
                LowBalanceEvent();
            }
            else
            {
                Console.WriteLine("Remaining Balance=" + RemBalance);
            }
        }
    }
}
