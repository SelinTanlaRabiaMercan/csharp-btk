using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance //kalıtım , miras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //demo();
            //virtualMetodlar();
            //abstractClass();
            Console.ReadLine();
        }
        static void demo()
        {
            Person[] person = new Person[2] {
                new Customer
                {
                    Id=1,Name="Tanla",Description="lorem ıpsum dolor sit",City="izmir"
                },
                new Employee
                {
                    Id=2,Name="Selin",Description="lorem lorem",Departman="stajyer"
                }
            };
            foreach (Person p in person)
            {
                Console.WriteLine(p.Id + " . " + p.Name);
            }
        }
        static void virtualMetodlar()
        {
            Sqlserver sqlserver = new Sqlserver();
            sqlserver.add();
            Mysql mysql = new Mysql();
            mysql.add();
        }
        static void abstractClass()
        {
            Database1 db1 = new sqlServer();
            db1.delete();
        }
    }
    //demo
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Employee : Person
    {
        public string Departman { get; set; }
    }
    //virtual metodlar
    class Database
    {
        public virtual void add()//temel methodun dışına çıkabilirim demek
        {
            Console.WriteLine("Added");
        }
        public virtual void delete()
        {
            Console.WriteLine("deleted");
        }
    }
    class Sqlserver : Database
    {
        public override void add()
        {
            Console.WriteLine("Added with sql");
            //base.add();
        }
    }
    class Mysql : Database
    {

    }
    //abstract class
    abstract class Database1
    {
        //add işlemi tüm databaselerde aynı fakat delete işlemi tüm databaselerde aynı değil
        public void add()
        {
            Console.WriteLine("added");
        }
        public abstract void delete();
    }
    class sqlServer : Database1
    {
        public override void delete()
        {
            Console.WriteLine("delete sql");
        }
    }
}
