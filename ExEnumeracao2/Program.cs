using System;
using System.Globalization;
using ExEnumeracao2.Entities;
using ExEnumeracao2.Entities.Enum;

namespace ExEnumeracao2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ler os dados de um pedido com N itens(N fornecido pelo usuário).Depois, mostrar um
             sumário do pedido conforme exemplo (próxima página). Nota: o instante do pedido deve
             o instante do sistema: DateTime.Now
            */

            //Insira os dados do cliente
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            //Nome
            string name = Console.ReadLine();
            Console.Write("Email: ");
            //Email
            string email = Console.ReadLine();
            //Data de nascimento
            Console.Write("Birth date (DD//MM/YYYY): ");
            DateTime birthdDate = DateTime.Parse(Console.ReadLine());

            //Insira os dados do pedido
            Console.WriteLine("Enter order data: ");
            //Status
            Console.Write("Status: ");
            OrderStatus orderstatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            //Instanciando na classe cliente
            Client client = new Client(name, email, birthdDate);
            //Instanciando a classe ORDER 
            Order order = new Order(DateTime.Now, orderstatus, client);

            //-----------------------------------------------------------------------------------------------------------------//


            //Quantos itens para este pedido?
            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            for (int i = 1; i <= items; i++)
            {
                Console.WriteLine("Enter #" + i + " item data");
                //Nome
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                //Preço do produto
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Quantidade
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //Instanciando a classe Product
                Product product = new Product(productName, productPrice);
                //Instanciando a classe OrderItem
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                //Adicionando item ao método AddItem
                order.AddItem(orderItem);
            }
                
                //Printando na tela

                //RESUMO DE PEDIDO
                Console.WriteLine("ORDER SUMMARY: ");
                //Momento do pedido
                Console.WriteLine("Order moment: " + order.Moment);
                //Status do pedido
                Console.WriteLine("Order status: " + order.Status);
                //Cliente
                Console.WriteLine("Client: " + client.Name + "  " + client.BirthDate.ToString("d") + " - " + client.Email);
                //Itens de pedido
                Console.WriteLine("Order items: ");
                
                //FOREACH para imprimir itens da Lista formatados com ToString()
                foreach (OrderItem item in order.Items)
                {
                    Console.WriteLine(item.ToString());
                }
                //Imprimindo o Preço total dos itens
                Console.WriteLine("Total price: $" + order.Total().ToString("F2", CultureInfo.InvariantCulture));        
        }
    }
}
