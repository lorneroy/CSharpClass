using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoDB"].ConnectionString;

            using(SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                using (SqlCommand command = connect.CreateCommand())
                {
                    string commandtext = "insert into Names (Name) Values ('"+textBox1.Text+"');";
                    //string commandtext = "insert into Names (Name) Values ('jim');";
                    command.CommandText = commandtext;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
