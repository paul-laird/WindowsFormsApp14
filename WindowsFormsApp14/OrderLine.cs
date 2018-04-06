using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class OrderLine
    {
        private static int next = 0;
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public OrderLine(Product p, Order o, int q)
        {
            Product = p;
            Quantity = q;
        }

    }
}
