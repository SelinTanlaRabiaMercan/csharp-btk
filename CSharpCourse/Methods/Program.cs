using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 8;
            int number3 ;
            var result = carp(number1, number2, out number3);

            topla(number1, number2);//parametreli metod
            Console.WriteLine(number1 + " * " + number2 + " : " + carp(number1, number2));
            Console.WriteLine(number1 + " * " + number2 + " * "
                + number3 + " : " + result);
            defaultDegerliParametr(number1);
            Console.WriteLine(topla(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20));
            Console.ReadLine();
        }
        static void topla(int number1, int number2)
        {
            Console.WriteLine(number1 + " + " + number2 + " : " + (number1 + number2));
        }
        static int carp(int number1, int number2)
        {
            return number1 * number2;
        }
        //method overloading  --  aşırı yüklenme
        static int carp(int number1, int number2, out int number3)
        {
            number3 = 10;
            return number1 * number2 * number3;
        }
        /*
            C# içerisinde yer alan ref ve out anahtar kelimeleri aynı işlemi yapar.
            Ancak ref ile kullanımda değişkene başlangıç değerinin verilmesi gerekirken out 
            anahtar kelimesi ile kullanımda başlangıç değerinin verilmesine gerek yoktur.
         */

        static void defaultDegerliParametr(int number1, int number2 = 10)
        {
            //parametreye değer verilmezse dfault değeri kullanır
            //default değer her zaman en sona yazılır
            //birden fazla default değer verilebilir
            Console.WriteLine(number1 + " - " + number2 + " : " + (number1 - number2));
        }
        //params ile metodumuza aynı tipte istediğimiz kadar parametre gönderebiliriz
        static int topla(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
