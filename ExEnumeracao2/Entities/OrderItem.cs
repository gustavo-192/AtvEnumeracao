using System;
using System.Globalization;

namespace ExEnumeracao2.Entities
{
    //Item de pedido
    class OrderItem
    {
        public int Quantity  { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        
        //Construtor vazio
        public OrderItem()
        {

        }
        //Construtor com 3 Parâmetros 
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;

        }
        //Método Para calcular e retornar o subtotal (QUATIDADE * PREÇO) 
        public double SubTotal()
        {
            return Quantity * Price;
        }
        //Método Override para retornar as formatações de NOME, PREÇO E QUANTIDADE
        public override string ToString()
        {
            return Product.Name + ",  $" + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Quantity: " + Quantity + ": Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
