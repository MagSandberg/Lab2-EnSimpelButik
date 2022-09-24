namespace Lab2_EnSimpelButik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool login = false;
            while (login == false)
            {
                Console.WriteLine("1: Logga in\n2: Registrera ny kund");
                var keyPress = Console.ReadKey();
                Console.Clear();
                if (keyPress.Key != ConsoleKey.D1 && keyPress.Key != ConsoleKey.D2)
                {
                    Console.WriteLine("Fel val. Vänligen välj 1 eller 2.\n");
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
                    }
                }
            }
        }
    }
}