using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_06_Labs
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
           
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            using (tempdbEntities objContext = new tempdbEntities())
            {
                //query the products class for a particular product from the textbox
                var intLinqFiltered = // This returns an IEnumerable compatible object!
                    from c in objContext.Products.AsEnumerable()
                    where c.Name == textBoxProduct.Text
                    select c.Name;


                foreach (var element in intLinqFiltered)
                {
                    textBoxResult.AppendText(element + Environment.NewLine);
                }
            }

        }
    }
}
