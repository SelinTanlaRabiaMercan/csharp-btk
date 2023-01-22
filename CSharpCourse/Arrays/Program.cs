using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            array1();
            array2();
            multipleArrays();
            Console.ReadLine();
        }
        static void array1()
        {
            string[] Students = new string[3];//parantez içi eleman sayısı
            Students[0] = "Selin";
            Students[1] = "Tanla";
            Students[2] = "Mercan";

            foreach (string s in Students)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----------------");
        }
        static void array2()
        {
            string[] Students = { "Selin", "Tanla", "Test" };
            foreach (var item in Students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
        }
        //çoklu dizi
        static void multipleArrays()
        {
            //5 bölgeden 3 şehir
            string[,] regions = new string[5, 3]
            {
                { "istanbul", "izmit", "balıkesir" },//marmara
                { "konya", "ankara", "kırıkkale" },//iç anadolu
                { "antalya", "adana", "mersin" },//akdeniz
                { "trabzon", "rize", "samsun" },//karadeniz
                { "izmir", "muğla", "manisa" }//ege
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(" "+regions[i,j]);

                }
                Console.WriteLine("--------------- ");
            }
        }
    }
}
