using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_Aula_123.Entites.Enums;
using Exercicio_Aula_123.Entites;

namespace Exercicio_Aula_123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY):");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthdate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            OrderStatus item = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Order order = new Order(DateTime.Now, item, client);

            Console.Write("How many items to this order?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; n >= i; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name:");
                string namep = Console.ReadLine();
                Console.Write("Product price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(namep, price);

                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());              
                OrderItem orderitem = new OrderItem(quantity, price, product);
                order.AddItemProd(orderitem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
