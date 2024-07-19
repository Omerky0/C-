using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "Ömer";
            customer.LastName = "Köy";

            Customer customer2 = new Customer
            {
                Id = 1,
                City = "İstanbul",
                FirstName = "Kaan",
                LastName = "Köy"

            };
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();


            Console.ReadLine();

        }
        class ProductManager
        {
            public void Add()
            {
                Console.WriteLine("Product Added");
            }

            public void Update()
            {
                Console.WriteLine("Product Updated");
            }
        }
        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Added");
            }

            public void Update()
            {
                Console.WriteLine("Customer Updated");
            }
        }


    }
}