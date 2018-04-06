using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        List<Customer> customers;
        List<Order> orders;
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private List<Order> loadOrders(int i)
        {
            DateTime monthAgo;
            if (DateTime.Now.Month>0) monthAgo = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, DateTime.Now.Day);
            else monthAgo = new DateTime(DateTime.Now.Year-1, DateTime.Now.Month +11, DateTime.Now.Day);
            Customer c = customers[i];
            var cOrders = from o in orders where o.Customer == c
                          && o.Date > monthAgo
                            select o;
            cOrders.OrderBy(x => x.invoiceAmount());
            //display something
            return (List<Order>) cOrders;
        }
    }
}
