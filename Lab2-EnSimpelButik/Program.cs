using System.Security.Cryptography.X509Certificates;

namespace Lab2_EnSimpelButik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool login = false;
            while (login == false)
            {
                Console.WriteLine("1: Logga in\n2: Registrera ny kund\nQ: Stäng program");
                var keyPress = Console.ReadKey();
                Console.Clear();
                System.ConsoleKey[] cK = { ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.Q };
                if (keyPress.Key != cK[0] & keyPress.Key != cK[1] & keyPress.Key != cK[2])
                {
                    Console.Write("Fel inmatning: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(keyPress.KeyChar);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nVänligen välj mellan 1, 2 eller Q.\n");
                }
                else
                {
                    switch (keyPress.Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine("* Logga in *\n");
                            Login.LoginFields(); //Name, Password
                            //OM match mot .txt login = true
                            //ANNARS Val om man vill registrera ny kund
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine("* Registrera ny kund *\n");
                            Login.LoginFields(); //Name, Password
                            //Lägg till i .txt
                            break;
                        case ConsoleKey.Q:
                            Login.VerifyQuit();
                            Console.Clear();
                            break;
                    }
                }
            }

            bool loggedIn = false;
            while (loggedIn == false)
            {
                Console.WriteLine("1: Handla\n2: Kundvagn\n3: Till kassan\nQ: Stäng program");
                var keyPress = Console.ReadKey();
                Console.Clear();
                System.ConsoleKey[] cK = { ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3, ConsoleKey.Q };
                if (keyPress.Key != cK[0] & keyPress.Key != cK[1] & keyPress.Key != cK[2] & keyPress.Key != cK[3])
                {
                    Console.Write("Fel inmatning: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(keyPress.KeyChar);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nVänligen välj 1, 2, 3 eller Q för att avsluta.\n");
                }
                else
                {
                    var keyPressed = Console.ReadKey();
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine("Handla");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine("Kundvagn");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.D3:
                            Console.WriteLine("Till kassan");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.Q:
                            Login.VerifyQuit();
                            Console.Clear();
                            break;
                    }
                }
            }
        }
    }
}