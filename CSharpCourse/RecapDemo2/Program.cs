using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger=new DatabaseLogger();
            customerManager.add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void add()
        {
            Logger.log();
            //DatabaseLogger databaseLogger = new DatabaseLogger();
            //databaseLogger.log();
            Console.WriteLine("Customer added");
        }
    }
    class DatabaseLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("logged to file");
        }
    }
    interface ILogger
    {
        void log();
    }
}
