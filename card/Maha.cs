using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card
{
    class MaharatraCard : BankCard
    {
        public IDebite GetDebite()
        {
            return new Mahadebit();
        }

        public Icredite GetIcredite()
        {
            return new Mahacredit();
        }
    }
    class Mahacredit : Icredite
    {
        public void newcredit()

        {
            Console.WriteLine("MaharatraBank Credit Card Here.....");
        }
    }
    class Mahadebit : IDebite
    {
        public void newdebit()
        {
            Console.WriteLine("MaharatraBank debite Card Here.....");
        }
    }
}
