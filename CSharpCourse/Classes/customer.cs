using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class customer
    {
        //prop , proberty ( özellik ) tanımlamak.
        public int id { get; set; }
        //public string LastName { get; set; }
        private string lastname;

        public string LastName
        {
            get { return "mrs."+lastname; }
            set { lastname = value; }
        }

        public string FirstName { get; set; }
        public string description { get; set; }
        public string city { get; set; }
        

       
    }
}
