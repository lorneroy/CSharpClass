using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP811A_Assignment_06
{
    public partial class FormDBQuery : Form
    {
        #region fields
        private ICustomerDBController _customerDBController;

        #endregion


        public FormDBQuery()
        {
            InitializeComponent();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Assignment06"].ConnectionString;

            _customerDBController = new CustomerDBController(connectionString);
        }

        private void buttonInsertCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                _customerDBController.Insert(Int32.Parse(textBoxInsertCustomerID.Text), textBoxInsertCustomerName.Text);
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
                textBoxSelectedData.Text = _customerDBController.Select();
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
                _customerDBController.Delete(Int32.Parse(textBoxDeleteCustomerID.Text));
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
                _customerDBController.Update(Int32.Parse(textBoxUpdateCustomerID.Text), textBoxUpdateCustomerName.Text);
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
