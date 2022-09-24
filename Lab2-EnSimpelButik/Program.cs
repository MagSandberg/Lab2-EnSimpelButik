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
                if (keyPress.Key != ConsoleKey.D1 && keyPress.Key != ConsoleKey.D2 && keyPress.Key != ConsoleKey.Q)
                {
                    Console.Write("Fel inmatning: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(keyPress.KeyChar);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nVänligen välj 1, 2 eller Q för att avsluta.\n");
                }
                else
                {
                    switch (keyPress.Key)
                    {
                        case ConsoleKey.D1:
                            Login userLogin = new Login();
                            Console.Clear();
                            Console.WriteLine("* Logga in *\n");
                            Console.Write("Fyll i ditt namn: ");
                            userLogin.Name = Console.ReadLine();
                            Console.Write("Fyll i ditt lösenord: ");
                            userLogin.Password = Console.ReadLine();

                            Console.ReadKey();
                            //Metod() logga in med fält Name, Password
                            //OM match mot txtfil login = true
                            //ANNARS Val om man vill registrera ny kund
                            break;
                        case ConsoleKey.D2:
                            Console.Clear();
                            Console.WriteLine("CASE2");
                            Console.ReadKey();
                            //Metod() registrera kund med fält Name, Password 
                            break;
                        case ConsoleKey.Q:
                            Environment.Exit(0);
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
                if (keyPress.Key != ConsoleKey.D1 && keyPress.Key != ConsoleKey.D2 && keyPress.Key != ConsoleKey.D3 && keyPress.Key != ConsoleKey.Q)
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
                            break;
                    }
                }
            }
        }
    }
}