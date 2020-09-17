using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula_123.Entites
{
    class Product
    {
        public string Namep { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Namep = name;
            Price = price;
        }
    }

  

}
