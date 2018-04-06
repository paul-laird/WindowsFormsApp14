using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class Product
    {
        private static int next = 0;
        public int ID { get; private set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public Product(string d, int p)
        {
            Price = p;
            Description = d;
            ID = next++;
        }
    }

}
