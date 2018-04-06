using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class Customer
    {
        static int next = 0;
        public int ID { get; private set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public Customer(string a, string n)
        {
            ID = next++;
            Address = a;
            Name = n;
        }
    }
}
