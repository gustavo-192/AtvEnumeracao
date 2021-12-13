using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExEnumeracao2.Entities.Enum;

namespace ExEnumeracao2.Entities
{
    //Produto
    class Product
    {
        public string Name { get; set; }
        public double  Price { get; set; }

        //Construtor vazio
        public Product()
        {

        }
        //Construtor com 2 parâmetros
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
