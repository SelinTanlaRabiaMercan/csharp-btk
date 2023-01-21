using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVeriables
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Hello World");
            Console.ReadLine();
         */

            //veriables
            byte number1 = 245;
            short number2 = 765;
            int number3 = 1068;
            long number4 = 456;
            decimal number5 =56.864m;
            double number6 = 45.45;
            bool b=true;
            char c = 'G';
            string s = "Tanla";

            Console.WriteLine("number is {0}", number1);
            Console.WriteLine("number is {0}", number2);
            Console.WriteLine("number is {0}", number3);
            Console.WriteLine("number is {0}", number4);
            Console.WriteLine("number is {0}", number5);
            Console.WriteLine("number is {0}", number6);
            Console.WriteLine("character is {0}", c);
            Console.WriteLine("string is {0}", s);
            Console.WriteLine("bool is {0}", b);
            Console.WriteLine(MyEnum.saturday);

            var number7 = 56;//var değişken değildir sadece veri tutar
            Console.WriteLine("number7 type is {0}", number7.GetType());
            number7 = 'k';
            Console.WriteLine("number7 type is {0}",number7.GetType());
            

            Console.ReadLine();

        }

        enum MyEnum
        {
            monday=2 , tuesday , wednesday , thursday , friday , saturday , sunday
                //başlangıç değerini değiştirdim
        }
    }
}
