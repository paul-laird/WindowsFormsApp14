using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class Order
    {
        private static int next=0;
        public int ID { get; set; }
        public DateTime Date { get; private set; }
        public Customer Customer { get; private set; }
        public List<OrderLine> lines { get; private set; }
        public Order(DateTime d, Customer c, List<OrderLine> l)
        {
            Customer = c;
            Date = d;
            ID = next++;
            lines = l;
        }

        internal int invoiceAmount()
        {
            int sum = 0;
            lines.ForEach(x => sum += (x.Product.Price * x.Quantity));
            return sum;
        }
    }
}
