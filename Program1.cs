using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace card
{
    public class Program1
    {
        private static string? userEmail;
        private static string? password;

        public static void Main(string[] args)
        {

     
            for (; ; )
            {
                Console.WriteLine("Welcome TO Bank");
                Thread.Sleep(1000);

                Console.WriteLine("1)SignUp-for new User 2)Login-for exsting User");
                int sn = Convert.ToInt32(Console.ReadLine());
                switch (sn)
                {
                    case 1: SignUp(); break;
                    case 2: Login(); break;
                }

            }


        }
        //static String userEmail;
        //static String password;
        public static void Login()
        {
            try
            {
             Thread.Sleep(2000);
            Console.WriteLine("Welcome TO Login Page");

            Console.WriteLine("Enter Your Email:-");
            String un=(Console.ReadLine());

            Console.WriteLine("Enter Your password:-");
            String pass=(Console.ReadLine());
          
                if ( un.Equals(userEmail))
                {
                    if (pass.Equals(password))
                    {
                        Console.WriteLine("Login Successfully...");

                        Bank.bank();
                    }
                    else
                    {
                        Console.WriteLine("Wrong password..");
                        Login();

                    }
                    Console.WriteLine("Wrong User..");
                    Login();


                }
                
                else
                {
                    Console.WriteLine("Wrong Input please try again..");
                    Login();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter correct credientials.."+ex.Message);
            }
        }

        public static void SignUp()
        {
            Console.WriteLine("Enter Your Full Name:- ");
            string name= Console.ReadLine();

            Console.WriteLine("Enter Your Address:- ");
            string userAddress = Console.ReadLine();

            Console.WriteLine("Enter Your PhoneNumber:- ");
            string PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Your Email :- ");
            var userEmail = Console.ReadLine();

            Console.WriteLine("Enter Your Password :- ");
            var password =Console.ReadLine();


            Console.WriteLine("SignUp Sucessfull...");
            Login();

        }

       

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
