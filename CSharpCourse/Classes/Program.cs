using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.list();
            customerManager.update();
            customerManager.add();
            customerManager.remove();
            Console.WriteLine();

            ProductManager product = new ProductManager();
            product.list();
            product.update();
            product.add();
            product.remove();
            Console.WriteLine();

            customer customer =new customer();
            customer.id = 1;
            customer.FirstName = "Selin";
            customer.LastName = "Tanla";
            customer.city = "dzc";
            customer.description = "Tnl";

            customer customer1 = new customer
            {
                id = 2,
                FirstName = "Test",
                LastName = "Test",
                city = "dzc",
                description = "Test"

            };

            Console.WriteLine(customer1.LastName);

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public void add()
        {
            Console.WriteLine("Müşteri eklendi");
        }
        public void remove()
        {
            Console.WriteLine("Müşteri silindi");
        }
        public void update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
        public void list()
        {
            Console.WriteLine("Müşteri listelendi");
        }
    }


}
