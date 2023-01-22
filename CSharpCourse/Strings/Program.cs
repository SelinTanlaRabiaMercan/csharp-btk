using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //intro();
            stringOzellikleri();

            Console.ReadLine();
        }
        static void stringOzellikleri()
        {
            string word = "Selin Tanla Mercan";
            Console.WriteLine(word.Length);//string uzunluğu
            Console.WriteLine(word.Clone());//klon oluşturur
            Console.WriteLine(word.StartsWith("n"));//kelime n ile başlıyormu
            Console.WriteLine(word.EndsWith("n"));//kelime n ile bitiyormu
            Console.WriteLine(word.IndexOf("Mercan"));//Mercan kelimesi kaçıncı indexte arar
            Console.WriteLine(word.LastIndexOf("n"));//aramaaya sondan başlar
            Console.WriteLine(word.Insert(0,"Hello "));//kelimeye ekler
            Console.WriteLine(word.Substring(6));//6. indexten sonrasını al
            Console.WriteLine(word.ToLower());//hepsini küçük harf yap
            Console.WriteLine(word.ToUpper());//hepsini büyük harf yap
            Console.WriteLine(word.Remove(3));//3.den sonrasını sil  
            Console.WriteLine(word.Remove(3,8));//3.den sonrasını 8.ye kadar sil  
            Console.WriteLine(word.Replace(" ","+"));//yerlerini değiştir

        }
        static void intro()
        {
            string city = "Ankara";
            //harfleri altalta yazdırır
            foreach (var s in city)
            {
                Console.WriteLine(s);
            }
            string city2 = "istanbul";
            var result = city + city2;

            Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
