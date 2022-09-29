
using System.Security.Cryptography;

namespace Lab2_EnSimpelButik
{
    public class Product
    {
        //Field
        private string _currency;
        public string Currency
        {
            get { _currency = "SEK"; return _currency; }
            set { _currency = value; }
        }

        private string _prodName;
        public string ProdName
        {
            get { return _prodName; }
            set { _prodName = value; }
        }

        private float _price;
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private float _totalPrice;
        public float TotalPrice
        {
            get { _totalPrice = Price * Quantity; return _totalPrice; }
        }

        //Method
        public void Qty()
        {
            int qty = 0;
            bool done = false;
            while (done == false)
            {
                Console.WriteLine("\n1: Öka antal | 2: Minska antal | 3: Klar");

                var keyPress = Console.ReadKey();
                Console.Clear();
                if (keyPress.Key == ConsoleKey.D1)
                {
                    qty++;
                    Quantity = qty;
                    Console.WriteLine($"Din kundvagn innehåller {Quantity} st {ProdName}");
                    Console.WriteLine($"Du har varor för den totala kostnaden {TotalPrice} {Currency}");
                }
                else if (keyPress.Key == ConsoleKey.D2 && Quantity > 0)
                {
                    qty--;
                    Quantity = qty;
                    Console.WriteLine($"Din kundvagn innehåller {Quantity} st {ProdName}");
                    Console.WriteLine($"Du har varor för den totala kostnaden {TotalPrice} {Currency}");
                }
                else if (keyPress.Key == ConsoleKey.D3)
                {
                    done = true;
                }
                
            }
        }
        //Constructor

        public Product(string prodName, float price, int quantity)
        {
            _prodName = prodName;
            _price = price;
            _quantity = quantity;
        }
    }
}
