using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerDbController;

namespace CSHP811A_Assignment_06
{
    public partial class FormDBQuery : Form
    {
        #region fields

        #endregion


        public FormDBQuery()
        {
            InitializeComponent();

        }

        private void buttonInsertCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (tempdbEntities tde = new tempdbEntities())
                {
                    tde.pInsCustomer(Int32.Parse(textBoxInsertCustomerID.Text), textBoxInsertCustomerName.Text);
                }
                textBoxInsertCustomerID.Clear();
                textBoxInsertCustomerName.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not insert data");
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                tempdbEntities tde = new tempdbEntities();
                dataGridViewSelectedData.DataSource = tde.pSelCustomer().ToArray();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not select data");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (tempdbEntities tde = new tempdbEntities())
                {
                    tde.pDelCustomer(Int32.Parse(textBoxDeleteCustomerID.Text));
                }
                textBoxDeleteCustomerID.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not delete data");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (tempdbEntities tde = new tempdbEntities())
                {
                    tde.pUpdCustomer(Int32.Parse(textBoxUpdateCustomerID.Text), textBoxUpdateCustomerName.Text);
                }
                textBoxUpdateCustomerID.Clear();
                textBoxUpdateCustomerName.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not update data");
            }
        }

    
    }
}
