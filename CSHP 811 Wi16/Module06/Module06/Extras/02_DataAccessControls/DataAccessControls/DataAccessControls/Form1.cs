using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataAccessControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Region' table. You can move, or remove it, as needed.
            this.regionTableAdapter.Fill(this.dataSet1.Region);

        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {   
            //Added this code by hand
            this.regionTableAdapter.Update(this.dataSet1);
        }


    }
}
