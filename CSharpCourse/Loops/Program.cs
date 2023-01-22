using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //forLoop();
            //whileLoop();
            //doWhileLoop();
            //forEachLoop();
            Console.WriteLine(asalsayiMi(4));
            Console.ReadLine();            
        }

      

        static void forLoop()
        {
            for (int i = 1; i <=100; i++)
            {
               Console.WriteLine(i);
            }
        }
        static void whileLoop()
        {
            int number = 100;
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }

        }
        static void doWhileLoop()
        {
            int number = 10;
            do
            {//şart sağlanmazsa bile do mutlaka bir kere çalışır
                Console.WriteLine(number);
                number--;

            } while (number>=11);
        }
        static void forEachLoop()
        {
            string[] Students = { "Selin", "Tanla", "Test" };
            foreach (var item in Students)
            {
                Console.WriteLine(item);
            }
        }
        static Boolean asalsayiMi(int number)
        {
            bool result = true; 
        
            for (int i = 2; i <= number; i++)
            {
                if (number%i==0)
                {
                    result= false;
                }
            }
            return result;
        }
    }
}
