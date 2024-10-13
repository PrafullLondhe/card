using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card
{
    internal class Bank
    {
        public static void bank()
        {

            Console.WriteLine("WelCome To Bank Service ");
            Thread.Sleep(2000);
            for (; ; ) {
                Console.WriteLine("1)Balance check 2)Deposite Money 3)Withdrow Money 4)Get Card 5)Exit");
                int input = Convert.ToInt32(Console.ReadLine());

                switch(input) {
                    case 1: balanceCheck();break;
                    case 2: deposite(); break; 
                    case 3: withdrow(); break;
                    case 4: CardSelection.Card();break;
                    case 5: System.Environment.Exit(0); break;  
                    default: Console.WriteLine("");
                        break;


                }

            }
        }
        static decimal balance=0;
        static decimal TotolAmount;
        static decimal withdrowAmt;
        private static void withdrow()
        {
            Console.WriteLine("Enter Amount For Withdrow");
            withdrowAmt=Convert.ToDecimal( Console.ReadLine());
            TotolAmount = TotolAmount - withdrowAmt;
            Console.WriteLine("You Withdrow Amount:- "+ withdrowAmt+" And Available Balance is:- "+ TotolAmount);
           
        }

        private static void balanceCheck()
        {
            Console.WriteLine("Your Available Balance is :- "+TotolAmount);
        }

        private static void deposite()
        {
            Console.WriteLine("Enter The Amount For Deposite");
            balance= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Amount Added Successfully...");
            TotolAmount = balance;
            Console.WriteLine($"You HaveIn Your Account:- "+ TotolAmount);
        }
    }
}
