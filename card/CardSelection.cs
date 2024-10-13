using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card
{
    internal class CardSelection
    {
        public static void Card()
        {

            Console.WriteLine("Welcome To Crad Section");
            Thread.Sleep(5000);


            Console.WriteLine("Please select The Bank 1) SBI Bank Card 2)MAhARATRA Bank Crad 3) Exit");
            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == 1)
            {

                BankCard Sbicard = new SBICard();
                Icredite Sbicreditcard = Sbicard.GetIcredite();
                IDebite Sbidebitcard = Sbicard.GetDebite();

                Sbicreditcard.newcredit();
                Sbidebitcard.newdebit();
            }
            else if (userinput == 2)
            {

                BankCard Mahacard = new MaharatraCard();
                Icredite Mahacreditcard = Mahacard.GetIcredite();
                IDebite Mahadebitcard = Mahacard.GetDebite();

                Mahacreditcard.newcredit();
                Mahadebitcard.newdebit();
                Console.ReadLine();
            }
            else
            { System.Environment.Exit(1); }



        }
    }
}
