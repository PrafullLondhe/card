
using card;

namespace Bank
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Program1 p1 = new Program1();
           
            
                for (; ; )
                {
                    Console.WriteLine("Welcome TO Bank");
                    Thread.Sleep(3000);
                    Console.WriteLine("1)Create Account 2)Deposite Money" +
                        " 3)Withdrow Money 4)Get Card 5)Exit");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input==1) { CreateAccount(); }
                    else if (input==2) { Deposite(); }
                    else if (input==3) { Withdrow(); }
                    else if (input==4) { Program1.Card(); }
                    else if (input==5) { System.Environment.Exit(1); }
                    else { Console.WriteLine("Enter The Right Input"); };
               
                    }


                }

        private static void Withdrow()
        {
            throw new NotImplementedException();
        }

        private static void Deposite()
        {
            throw new NotImplementedException();
        }

        private static void CreateAccount()
        {
            throw new NotImplementedException();
        }
    }

      
    
}
