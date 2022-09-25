using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_EnSimpelButik
{
    public class Customer
    {
        public string Name { get; private set; }

        private string Password { get; set; }

        private List<Product> _cart;
        public List<Product> Cart { get { return _cart; } }

        public Customer(string name, string password)
        {
            Name = name;
            Password = password;
            _cart = new List<Product>();
        }
    }
}
