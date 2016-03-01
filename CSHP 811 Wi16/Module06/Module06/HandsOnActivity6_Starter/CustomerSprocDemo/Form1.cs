using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Added these
using System.Data.SqlClient;

namespace CustomerSprocDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsCustomerData_Click(object sender, EventArgs e)
        {
            //Connect to DB
            //Make a connection object
            SqlConnection objCon = new SqlConnection();
            objCon.ConnectionString = "integrated security=SSPI;data source=\".\";persist security info=False;initial catalog=TempDB";

            //Issue the SQL Command
            //Make a command object
            SqlCommand objCmd = new SqlCommand();
            objCmd.Connection = objCon;
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.CommandText = "pInsCustomer";

            //Make an Input param for CustomerId
            SqlParameter objCustomerId = new SqlParameter();
            objCustomerId.Direction = ParameterDirection.Input;
            objCustomerId.DbType = DbType.Int32;
            objCustomerId.ParameterName = "@CustomerId";
            objCustomerId.Value = Convert.ToInt32(textBoxInsCustomerId.Text); 
            objCmd.Parameters.Add(objCustomerId);
            //add to Command object parameters

            //Make an Input param for CustomerName
            SqlParameter objCustomerName = new SqlParameter();
            objCustomerName.Direction = ParameterDirection.Input;
            objCustomerName.DbType = DbType.String;
            objCustomerName.Size = 100;
            objCustomerName.ParameterName = "@CustomerName";
            objCustomerName.Value = textBoxInsCustomerName.Text; 
            objCmd.Parameters.Add(objCustomerName);
            //add to Command object parameters

            //Make an Input param for Return Code
            SqlParameter objRC = new SqlParameter();
            objRC.Direction = ParameterDirection.ReturnValue;
            objRC.DbType = DbType.Int32;
            objRC.ParameterName = "@RC";
            objCmd.Parameters.Add(objRC);
            //add to Command object parameters

            //Execute the code
            try
            {
                objCon.Open();
              int intRows = objCmd.ExecuteNonQuery();

                //Process any Results
              string strMessage = "Number of rows affected: " + Convert.ToString(intRows);
              strMessage += "\n\r Return Code: " + Convert.ToString(objCmd.Parameters["@RC"].Value );
              MessageBox.Show(strMessage);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            finally
            { 
                //Cleanup code
                objCon.Close();
            }


        }
    }
}









