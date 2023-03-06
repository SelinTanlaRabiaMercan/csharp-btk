using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();
    }
    class sqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("SQL silindi");
        }

        public void Update()
        {
            Console.WriteLine("SQL güncellendi ");
        }
    }
    class oracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle eklendi ");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Güncellendi");
        }
    }
    class CustomerManager{
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();
        }
        public void Update(ICustomerDal customerDal)
        {
            customerDal.Update();
        }
    
    }
}


