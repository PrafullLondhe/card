using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card
{
    class Sbicredit : Icredite
    {
        public void newcredit()
        {
            Console.WriteLine("SBI Credite Card Here.....");

        }
    }
    class Sbidebit : IDebite
    {
        public void newdebit()
        {
            Console.WriteLine("SBI Debit Card Here.....");
        }
    }

    class SBICard : BankCard
    {
        public IDebite GetDebite()
        {
            return new Sbidebit();
        }

        public Icredite GetIcredite()
        {
            return new Sbicredit();
        }
    }
}
