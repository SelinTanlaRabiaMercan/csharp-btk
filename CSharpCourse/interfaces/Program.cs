using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interfaceler asla newlemez
            //interfacesIntro();
            //demo();
            //demo2();
            cokluImplementasyon();
            Console.ReadLine();
        }
        private static void interfacesIntro()
        {
            persoNmanager persoNmanager = new persoNmanager();
            persoNmanager.Add(new Customer
            {
                id = 1,
                name = "Test",
                email = "Test",
                password = 123
            });
            persoNmanager.Add(new Student
            {
                id = 2,
                name = "test2",
                email = "Test2",
                studentNo = 1
            });
        }
        interface IPerson
        {
            int id { get; set; }
            string name { get; set; }
            string email { get; set; }
        }
        class Customer : IPerson
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }

            public int password { get; set; }
        }
        class Student : IPerson
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }

            public int studentNo { get; set; }
        }
        class persoNmanager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.name + " " + person.email);
            }

        }

        public static void demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new sqlServerCustomerDal());
            customerManager.Add(new oracleCustomerDal());
            customerManager.Update(new sqlServerCustomerDal());
        }

        public static void demo2()
        {
            ICustomerDal[] customerDals = new ICustomerDal[2]
          {
               new oracleCustomerDal(),
               new sqlServerCustomerDal()
          };
            foreach (var customerDal in customerDals)
            {
                customerDal.Delete();
            }
        }

        public static void cokluImplementasyon()
        {
            IWorker[] workers = new IWorker[]
            {
                new manager(),
                new robot()
            };
            foreach(var worker in workers)
            {
                worker.worker();
            }
        }
        interface IWorker
        {
            void worker();
        }
        interface getSalary
        {
            void salary();
        }
        interface eat
        {
            void eat();
        }
        class manager : IWorker, getSalary, eat
        {
            public void eat()
            {
                throw new NotImplementedException();
            }

            public void salary()
            {
                throw new NotImplementedException();
            }

            public void worker()
            {
                Console.WriteLine("manager work");
            }
        }
        class robot : IWorker
        {
            public void worker()
            {
                Console.WriteLine("robot work");
            }
        }
    }
}
