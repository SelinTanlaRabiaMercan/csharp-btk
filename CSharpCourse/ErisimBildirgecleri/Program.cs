using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBildirgecleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            eb eb = new eb();
            Console.WriteLine(eb.pblc);
            //Console.WriteLine(eb.prvt);
            //Console.WriteLine(eb.prtctd);
            eb.ebb();
            Console.ReadLine();
        }
    }
    class eb
    {
        public String pblc { get; set; } //heryerden ulaşılabilir
        private String prvt { get; set; }//sadece aynı class içinde ualşılabilir
        protected String prtctd { get; set; }//aynı class ve miras alınan classlarda ulaşılabilir
        public void ebb()
        {
            Console.WriteLine("-------------");
            Console.WriteLine(pblc);
            Console.WriteLine(prvt);
            Console.WriteLine(prtctd);
        }
    }
    class eb2
    {
        void ebb()
        {
            eb eb = new eb();
            Console.WriteLine(eb.pblc);
            //Console.WriteLine(eb.prvt);
            //Console.WriteLine(eb.prtctd);

        }
    }
    class eb3 : eb
    {
        public void ob2()
        {
            eb eb = new eb();
            Console.WriteLine(pblc);
            //Console.WriteLine(prvt);
            Console.WriteLine(prtctd);
        }
    }
    public class pc
    {
        public String pblc { get; set; }
    }
}



