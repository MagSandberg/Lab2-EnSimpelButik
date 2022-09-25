using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_EnSimpelButik
{
    public class Login
    {
        //Field
        public string Name { get; set; }
        public string Password { get; set; }
        //Method
        public static void LoginFields()
        {
            Login userLogin = new Login();
            Console.Write("Fyll i ditt namn: ");
            userLogin.Name = Console.ReadLine();
            Console.Write("Fyll i ditt lösenord: ");
            userLogin.Password = Console.ReadLine();
            Console.Clear();
        }

        public static void VerifyQuit()
        {
            Console.WriteLine("* Avsluta *\n");
            Console.WriteLine("Är du säker?\nTryck J för att avsluta eller valfri tangent för att gå tillbaka\n");
            var verifyQuit = Console.ReadKey();
            if (verifyQuit.Key == ConsoleKey.J)
            {
                Console.Clear();
                Environment.Exit(0);
            }
        }

        //Constructor
    public Login()
        {
            
        }
    }
}
