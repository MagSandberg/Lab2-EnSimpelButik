using Lab2_EnSimpelButik;

bool login = true; //Bool för login-loop
bool loggedIn = false; //Bool när man är inloggad

while (true)
{
    while (login == true)
    {
        Console.WriteLine("1: Logga in | 2: Registrera ny kund | Q: Stäng program");
        var keyPress = Console.ReadKey();
        Console.Clear();
        System.ConsoleKey[] cK = { ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3, ConsoleKey.Q };
        if (keyPress.Key != cK[0] & keyPress.Key != cK[1] & keyPress.Key != cK[3])
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
                    login = false;
                    loggedIn = true; //ANNARS Val om man vill registrera ny kund
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

    while (loggedIn == true)
    {
        Console.WriteLine("1: Handla | 2: Kundvagn | 3: Till kassan | Q: Logga ut");
        var keyPress = Console.ReadKey();
        Console.Clear();
        System.ConsoleKey[] cK = { ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3, ConsoleKey.Q };
        if (keyPress.Key != cK[0] & keyPress.Key != cK[1] & keyPress.Key != cK[2] & keyPress.Key != cK[3])
        {
            Console.Write("Fel inmatning: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(keyPress.KeyChar);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nVänligen välj 1, 2, 3 eller Q för att logga ut.\n");
        }
        else
        {
            switch (keyPress.Key)
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
                    Console.WriteLine("* Logga ut *\n");
                    Console.WriteLine("Är du säker?\nTryck J för att logga ut eller valfri tangent för att gå tillbaka\n");
                    var verifyQuit = Console.ReadKey();
                    if (verifyQuit.Key == ConsoleKey.J)
                    {
                        loggedIn = false;
                        login = true;
                        Console.Clear();
                    }
                    break;
            }
        }
    }
}