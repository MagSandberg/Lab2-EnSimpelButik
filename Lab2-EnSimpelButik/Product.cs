
namespace Lab2_EnSimpelButik
{
    public abstract class Product
    {
        //Field
        private string _productName;

        public virtual string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        private float _price;

        public virtual float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _quantity;

        public virtual int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        //Method
        public void Qty()
        {
            Console.WriteLine("1: Öka antal | 2: Minska antal");
            var keyPress = Console.ReadKey();
            if (keyPress.Key == ConsoleKey.D1)
            {
                Quantity++;
            }
            else if (keyPress.Key == ConsoleKey.D2)
            {
                Quantity--;
            }
        }
        //Constructor
    }
}
