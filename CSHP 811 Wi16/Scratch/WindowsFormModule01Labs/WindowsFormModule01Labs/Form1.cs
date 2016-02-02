using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormModule01Labs
{
    public partial class Form1 : Form
    {
        private enum customerType { unknown = 0, wholesale = 1, retail = 2};

        customerType customer;

        customerStruct cust;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonRetail_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonWholeSale.Checked = false;
            customer = customerType.retail;
            cust.customer = customerType.retail;
        }

        private void radioButtonWholeSale_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonRetail.Checked = false;
            customer = customerType.wholesale;
            cust.customer = customerType.wholesale;
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            cust.customerName = textBox1.Text;
            MessageBox.Show(cust.getData());
            //if (customer == customerType.retail) MessageBox.Show("Retail");
            //else if (customer == customerType.wholesale) MessageBox.Show("Wholesale");
            //else MessageBox.Show("Unknown");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        struct customerStruct
        {
            public string customerName;
            public customerType customer;

            public string getData() { return customerName + " - " + customer.ToString(); }
        }
    }
}
