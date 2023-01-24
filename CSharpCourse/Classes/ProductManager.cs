using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class ProductManager
    {
        public void add()
        {
            Console.WriteLine("Ürün eklendi");
        }
        public void remove()
        {
            Console.WriteLine("Ürün silindi");
        }
        public void update()
        {
            Console.WriteLine("Ürün güncellendi");
        }
        public void list()
        {
            Console.WriteLine("Ürün listelendi");
        }
    }
}
