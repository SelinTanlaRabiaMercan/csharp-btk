using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ctrl + k , ctrl + d : yazıyı düzenleme
            //ctrl + k , ctrl + c : seçili alanı yorum satırı yapma
            //ctrl + k , ctrl + u : seçili alandaki yorum satırlarını kaldırma

            ifbloklari();
            switchBloklari();

            Console.ReadLine();

        }

        static void ifbloklari()
        {
            var number = 17;

            //uzun kullanım
            if (number == 10)
            {
                Console.WriteLine("number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("number is 20");
            }
            else
            {
                Console.WriteLine("number is not 10 or 20");
            }

            //kısa kullanım
            Console.WriteLine(number == 10 ? "number is 10" : "number is not 10");
        }
        static void switchBloklari()
        {
            var number = 16;
            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                default:
                    Console.WriteLine("number is not 10 or 20");
                    break;
            }
          
        }

    }
}
