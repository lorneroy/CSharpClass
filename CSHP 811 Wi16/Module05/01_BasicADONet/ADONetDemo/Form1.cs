using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO2008Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnections_Click(object sender, EventArgs e)
        {
            SqlConnection objCon = new SqlConnection();

            /** option 1: The "HardCoded" way **/
            objCon.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog = DB1; Integrated Security=True;";

            /** option 2: The "Before .Net v2.0" way**/
            objCon.ConnectionString = ConfigurationSettings.AppSettings["Conn2"];

            /** option 3: The "Common" way  (Note: You must have a reference to the System.Configuration .dll) **/
            objCon.ConnectionString = ConfigurationManager.ConnectionStrings["Conn3"].ConnectionString;

            objCon.StateChange += new StateChangeEventHandler(objCon_StateChange);
            try
            {
                objCon.Open();
                objCon.ChangeDatabase("Northwind");
                MessageBox.Show("Database is now: " + objCon.Database);

            }
            finally
            {
                objCon.Close();
            }
            MessageBox.Show("Database state after Close(): " + objCon.State.ToString());
        }

        public void objCon_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            MessageBox.Show("Connection state changed event: " + e.CurrentState.ToString());
        }



        private void buttonCommands_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(Local);Initial Catalog = Master; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "Select name, database_id from Sys.databases";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[0]);  // Gets the name Column  
                            Console.WriteLine(reader["database_id"]);    //Get the Database_id column
                        }
                    }//end while
                }//end using
            }//end using
        }



        private void buttonCmdWithSprocs_Click(object sender, EventArgs e)
        {
            /* SQL Code Needed ...
                Create Proc GetCompanyContacts
                as
                Select CompanyName, ContactName 
                from Customers
             
                GO
                -- Runs with this command
                Exec GetCompanyContacts
             */

            //Notice that this code is different then the last example, but it still works just fine. 
            //There are lots of ways to write this ADO.NET code!
            System.Data.SqlClient.SqlConnection objCon;
            objCon = new System.Data.SqlClient.SqlConnection();
            objCon.ConnectionString = @"Data Source=(local);Initial Catalog = Northwind; Integrated Security=True;";

            objCon.Open();

            SqlCommand objCmd = new SqlCommand();

            objCmd.Connection = objCon;
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.CommandText = "GetCompanyContacts";

            //objCmd.CommandType = CommandType.Text;
            //objCmd.CommandText = "Select CompanyName, ContactName from Customers";

            SqlDataReader objDR = objCmd.ExecuteReader();

            //Process the Results
            while (objDR.Read())
            {
                Console.WriteLine(objDR[0] + ": " + objDR[1]);
            }

            objCon.Close();
        }


        private void buttonSprocWithParams_Click(object sender, EventArgs e)
        {

            /* SQL Code Needed ...
                Create Proc GetCompanyContactsWithParams
                 ( @SearchWord varchar(100) )
                as
                Select CompanyName, ContactName 
                from Customers 
                         Where CompanyName Like '%' + @SearchWord + '%'
                GO
                -- Runs with this command
                Exec GetCompanyContactsWithParams @SearchWord = 'z'
           */

            System.Data.SqlClient.SqlConnection objCon;
            objCon = new System.Data.SqlClient.SqlConnection();
            objCon.ConnectionString = @"Data Source=(local);Initial Catalog = Northwind; Integrated Security=True;";

            objCon.Open();

            System.Data.SqlClient.SqlCommand objCmd;
            objCmd = new System.Data.SqlClient.SqlCommand();

            objCmd.Connection = objCon;
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.CommandText = "GetCompanyContactsWithParams";

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = ParameterDirection.Input;
            objP1.ParameterName = "@SearchWord";
            objP1.SqlDbType = SqlDbType.VarChar;
            objP1.Size = 100;
            objP1.Value = "zz";

            objCmd.Parameters.Add(objP1);

            System.Data.SqlClient.SqlDataReader objDR
                   = objCmd.ExecuteReader();

            //Process the Results
            while (objDR.Read())
            {
                Console.WriteLine(objDR[0] + ": " + objDR[1]);
            }

            objCon.Close();

        }


      }
}
