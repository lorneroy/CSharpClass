using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EntityFrameworkUIWindows
{
    public partial class Form1 : Form
    {

        EntityFrameworkDemosProcessor.EntityFrameworkDemosEntities objContext;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonBindProductsData_Click(object sender, EventArgs e)
        {
            //Force the Context object to get fresh data!
            objContext = new EntityFrameworkDemosProcessor.EntityFrameworkDemosEntities();
            dataGridView1.DataSource = objContext.Products;
        }

        private void buttonSaveToDB_Click(object sender, EventArgs e)
        {
            try
            {
                objContext.SaveChanges();
                MessageBox.Show("Changes Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonBindCustomersData_Click(object sender, EventArgs e)
        {
            //Force the Context object to get fresh data!
            objContext = new EntityFrameworkDemosProcessor.EntityFrameworkDemosEntities();
            dataGridView2.DataSource = objContext.vCustomers ;
            //dataGridView2.Refresh(); You do not need to refresh the GridView manually!
        }

        private void buttonSaveToCustomers_Click(object sender, EventArgs e)
        {
            if (radioButtonIns.Checked == true)
            {
                //Insert with a Stored Procedure
                objContext.pInsCustomer(int.Parse(textBoxID.Text), textBoxName.Text);
                MessageBox.Show("Now check to see if the new row was added!");
            }
            else if (radioButtonUpd.Checked == true)
            {
                //Update with a Stored Procedure
                objContext.pUpdateCustomer(int.Parse(textBoxID.Text), textBoxName.Text);
                MessageBox.Show("Now check to see if the row was modified!");
            }
            else if (radioButtonDel.Checked == true)
            {
                //Delete with a Stored Procedure
                objContext.pDelCustomer(int.Parse(textBoxID.Text));
                MessageBox.Show("Now check to see if the row was deleted!");
            }
            else
            {
                MessageBox.Show("Please choose to Insert, Update, or Delete the row");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            objContext.Dispose();
        }

    }
}
