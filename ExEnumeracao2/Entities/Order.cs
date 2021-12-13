using System;
using System.Collections.Generic;
using ExEnumeracao2.Entities.Enum;

namespace ExEnumeracao2.Entities
{
    //pedido
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        //Construtor vazio
        public Order()
        {

        }
        //Construtor com três parâmetros
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        //Método para adicionar itens na lista
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        //Método para remover itens da lista
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        //Método para somar e retornar o Total de itens
        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total = total + item.SubTotal();
            }
            return total;
        }
    }
}
