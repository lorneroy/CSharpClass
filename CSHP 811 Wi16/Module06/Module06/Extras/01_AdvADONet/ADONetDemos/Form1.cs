using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADONetDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //This shows that you CAN force a click event in code at RUNTIME if you need to...
            buttonSetConnectionString_Click(buttonSetConnectionString, new EventArgs());
        }


        string strConnection; //, strOdbcConnection, strOledbConnection, strSQLConnection;
        private void buttonSetConnectionString_Click(object sender, EventArgs e)
        {

            /**** This section just shows some common connection strings ****/ 

            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a connection type");
            }
            else
            {
                if (listBox1.SelectedItem.ToString() == "ODBC")
                {
                    // For anything not covered by OleDB because it is really Old
                    // System.Data.Odbc.OdbcConnection objOdbcCon;
                    strConnection = @"Driver={SQL Server};server=(local)\SQLExpress;trusted_connection=Yes;database=tempdb";
                }
                else if (listBox1.SelectedItem.ToString() == "OleDB")
                {
                    // For anything not covered by SQLConnection
                    // System.Data.OleDb.OleDbConnection objOleCon;
                    strConnection = @"Provider=SQLOLEDB;Data Source=(local);Integrated Security=SSPI;Initial Catalog=tempdb";
                }
                else if (listBox1.SelectedItem.ToString() == "SqlClient")
                {
                    // For SQL 7.0, 2000, 2005, and 2008...
                    // System.Data.SqlClient.SqlConnection objSQLCon;
                    strConnection = @"Data Source=(local)\SQLExpress;Initial Catalog=tempdb;Integrated Security=True";
                }

                MessageBox.Show(strConnection);

            }

        }

        private void buttonInfoMessage_Click(object sender, EventArgs e)
        {

            /**** Create this Store Procedure in the tempdb database first ****
                        Create Proc TestInfoMessage
                        as
                        Print 'Using a Print Statement'
                        RaisError('RaisError in Stored Procedures', 9, 1)
            ****************************************************/

            //1. Make a Connection
            System.Data.OleDb.OleDbConnection objOleCon = new System.Data.OleDb.OleDbConnection();
            objOleCon.ConnectionString = strConnection;
            objOleCon.Open();

            objOleCon.InfoMessage += new System.Data.OleDb.OleDbInfoMessageEventHandler(objOleCon_InfoMessage);

            //2. Issue a Command
            System.Data.OleDb.OleDbCommand objCmd;
            objCmd = new System.Data.OleDb.OleDbCommand("Raiserror('Typical Message Goes Here', 9, 1)", objOleCon);
            objCmd.ExecuteNonQuery();
            objCmd = new System.Data.OleDb.OleDbCommand("Exec TestInfoMessage", objOleCon); //This executes the stored procedure.
            objCmd.ExecuteNonQuery();

            //3. Process the Results
            /** No Results at this time **/

            //4. Clean up code
            objOleCon.Close();
        }

        void objOleCon_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        #region Command Tasks Demo Code

        private void buttonCommand_Click(object sender, EventArgs e)
        {

            //1. Make a Connection
            System.Data.OleDb.OleDbConnection objOleCon;
            objOleCon = new System.Data.OleDb.OleDbConnection();
            objOleCon.ConnectionString = strConnection;
            objOleCon.Open();
            objOleCon.ChangeDatabase("Northwind"); //We will use the Northwind database for this demo...

            //2. Issue a Command
            System.Data.OleDb.OleDbCommand objCmd;
            objCmd = new System.Data.OleDb.OleDbCommand();
            objCmd.Connection = objOleCon;
            objCmd.CommandType = CommandType.Text;//Not normally typed out since Text is the default anyway

            //3. Process the Results
            //When you don't need results back, like these two examples, use ExecuteNonQuery()
            objCmd.CommandText = "Insert Into MyTable Values(1, 'SomeData')";
            objCmd.CommandText = "Raiserror('Error Level 11 to 25 are Caught by Try-Catch', 15, 1)";
            try
            {
                objCmd.ExecuteNonQuery(); // Ex. Inserts, Updates, Deletes SQL commands
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //When you want a single value back use ExecuteScalar()
            objCmd.CommandText = "Select Count(*) From Products";//Your SQL Code
            int intResult = (int)objCmd.ExecuteScalar(); //Ex. Capture returning Integer data
            // string strResult = (string)objCmd.ExecuteScalar(); //Ex. Capture returning Varchar(50) data
            MessageBox.Show("Number of Products: " + intResult.ToString());

            //When you want multiple results back
            objCmd.CommandText = "Select ProductName From Products"; //Your SQL Code
            System.Data.OleDb.OleDbDataReader objDR; //Class used to process multiple results
            objDR = objCmd.ExecuteReader();

            MessageBox.Show(string.Format("FieldCount: {0}, RecordsAffected: {1} ", objDR.FieldCount, objDR.RecordsAffected));
            objDR.Close();

            //You can also submit multiple queries and get multiple result SETS back
            objCmd.CommandText = @"Select ProductName From Products  ; 
                                                 Select OrderId, ProductId From [Order Details]"; //Your SQL Code
            objDR = objCmd.ExecuteReader();

            MessageBox.Show(string.Format("FieldCount: {0}", objDR.FieldCount));
            objDR.Read();
            objDR.NextResult();
            objDR.Read();
            MessageBox.Show(string.Format("FieldCount: {0}", objDR.FieldCount));
            objDR.Close();

            //4. Clean up code
            objOleCon.Close();
        }

        private void buttonParameters_Click(object sender, EventArgs e)
        {

            /****************************************************
             * NOTE: You must create a stored procedure using the code 
             * found in the PrameterDemoCode.sql file before you can run this!
             ****************************************************/

            //1. Make a Connection
            System.Data.OleDb.OleDbConnection objOleCon;
            objOleCon = new System.Data.OleDb.OleDbConnection();
            objOleCon.ConnectionString = strConnection;
            objOleCon.Open();
            objOleCon.ChangeDatabase("TempDB"); //Since the previous demos used Northwind we need this command.

            //2. Issue a Command
            System.Data.OleDb.OleDbCommand objCmd;
            objCmd = new System.Data.OleDb.OleDbCommand();
            objCmd.Connection = objOleCon;
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.CommandText = "DivideDemo";

            //2.1 Create and Add Parameters before you execute the Sproc.

            #region Input Parameters
            System.Data.OleDb.OleDbParameter objP1 = new System.Data.OleDb.OleDbParameter();
            objP1.Direction = ParameterDirection.Input;
            objP1.DbType = DbType.Double;
            objP1.ParameterName = "@p1";
            objP1.Value = Convert.ToDouble(textBox1.Text);

            System.Data.OleDb.OleDbParameter objP2 = new System.Data.OleDb.OleDbParameter();
            objP2.Direction = ParameterDirection.Input;
            objP2.DbType = DbType.Double;
            objP2.ParameterName = "@p2";
            objP2.Value = Convert.ToDouble(textBox2.Text); ;
            #endregion

            #region Output Parameter
            System.Data.OleDb.OleDbParameter objAnswer = new System.Data.OleDb.OleDbParameter();
            objAnswer.Direction = ParameterDirection.Output;
            objAnswer.DbType = DbType.Double;
            objAnswer.ParameterName = "@answer";
            #endregion

            #region Return Code
            System.Data.OleDb.OleDbParameter objRC = new System.Data.OleDb.OleDbParameter();
            objRC.Direction = ParameterDirection.ReturnValue;
            objRC.DbType = DbType.Int32;
            objRC.ParameterName = "@RC";
            #endregion

            //Now, add all to the Parameter Collection
            /*
             * NOTE: The order of the parameters used to call the Stored Procedure is Positional! 
             * So, if the Store Procedure's parameter list looks like this... 
             * 
             *       Create Proc DivideDemo( @p1 float, @p2 float, @answer float out ) 
             *       
             * And, you execute the Store Procedure in SQL with the following code...
             * 
             *        Exec @RC = DivideDemo 4, 3, @Value out;
             *   
             *Then the Return Code parameter *MUST* be added first, followed by @p1 parameter, 
             * @p2, and @answer, to the Parameters Collection like this....
             *
             */

            objCmd.Parameters.Add(objRC); //1st
            objCmd.Parameters.Add(objP2); //2nd
            objCmd.Parameters.Add(objP1);  //3rd
            objCmd.Parameters.Add(objAnswer);//4th

            /*NOTE: Start a SQL Profiler Trace and show students how the command is submitted */

            //3. Process the Results            
            try
            {
                object objSelectData = objCmd.ExecuteScalar(); //Use this when there is a Select that selects a single value in the sproc.
                MessageBox.Show("Select data: " + Convert.ToString(objSelectData));
                MessageBox.Show("Output data: " + objCmd.Parameters["@answer"].Value.ToString());
                MessageBox.Show("Return Value data: " + objCmd.Parameters["@RC"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //4. Clean up code
            objOleCon.Close();

        }

        #endregion

        #region Result Tasks Demo Code

        private void buttonDataReader_Click(object sender, EventArgs e)
        {

            //1. Make a Connection
            System.Data.OleDb.OleDbConnection objOleCon;
            objOleCon = new System.Data.OleDb.OleDbConnection();
            objOleCon.ConnectionString = strConnection;
            objOleCon.Open();
            objOleCon.ChangeDatabase("Northwind");//We will use the Northwind database for this demo...

            //2. Issue a Command
            System.Data.OleDb.OleDbCommand objCmd;
            objCmd = new System.Data.OleDb.OleDbCommand();
            objCmd.Connection = objOleCon;
            objCmd.CommandText = "Select * From Region";//Your SQL Code

            //3. Process the Results 
            //When you want multiple results back
            System.Data.OleDb.OleDbDataReader objDR; //Class used to process multiple results
            objDR = objCmd.ExecuteReader();

            string strData = "";
            while (objDR.Read())
            {
                strData += objDR[0] + " , " + objDR["RegionDescription"] + "\n";
                comboBox1.Items.Add(objDR["RegionDescription"]);
            }
            MessageBox.Show(strData);
            comboBox1.SelectedIndex = 0;


            //4. Clean up code            
            objDR.Close();
            objOleCon.Close();

        }

        private void buttonDataAdapter_Click(object sender, EventArgs e)
        {
            //1. Make a Connection
            System.Data.OleDb.OleDbConnection objOleCon;
            objOleCon = new System.Data.OleDb.OleDbConnection();
            objOleCon.ConnectionString = strConnection;
            objOleCon.Open();
            objOleCon.ChangeDatabase("Northwind");//We will use the Northwind database for this demo...

            //2. Issue a Command
            System.Data.OleDb.OleDbCommand objCmd;
            objCmd = new System.Data.OleDb.OleDbCommand();
            objCmd.Connection = objOleCon;
            objCmd.CommandText = "Select * From Region";//Your SQL Code

            //3. Process the Results 
            System.Data.DataSet objDS = new DataSet();
            System.Data.OleDb.OleDbDataAdapter objDA = new System.Data.OleDb.OleDbDataAdapter();
            objDA.SelectCommand = objCmd;
            objDA.InsertCommand = null;
            objDA.UpdateCommand = null;
            objDA.DeleteCommand = null;

            objDA.Fill(objDS, "Regions");

            if (objDS.Tables["Regions"].Rows.Count > 0)
            {
                string strData = "";
                System.Data.DataTableReader objDTR = objDS.CreateDataReader(objDS.Tables[0]);
                while (objDTR.Read())
                {
                    strData += objDTR[0] + " , " + objDTR["RegionDescription"] + "\n";
                    // comboBox1.Items.Add(objDR["RegionDescription"]); // Not Needed
                }
                MessageBox.Show(strData);

                //Bind the Results to Windows Form controls
                comboBox2.DataSource = objDS.Tables["Regions"];
                comboBox2.DisplayMember = "RegionDescription";
                comboBox2.SelectedIndex = 0;

            }

            //4. Clean up code   
            objOleCon.Close();
        }

        class Car
        {
            public string Color;
            public string Model;
        }

        private void buttonDataSet_Click(object sender, EventArgs e)
        {

            System.Data.DataSet objDS = new DataSet();
            objDS.DataSetName = "ProgramData";

            System.Data.DataTable objDT1 = new DataTable();
            objDT1.TableName = "Cars";
            objDS.Tables.Add(objDT1);

            System.Data.DataColumn objCol1 = new DataColumn();
            objCol1.ColumnName = "CarId";
            objCol1.AutoIncrement = true;
            objCol1.Unique = true;
            objCol1.DataType = typeof(Int32);
            objDT1.Columns.Add(objCol1);

            System.Data.DataColumn objCol2 = new DataColumn("Color", typeof(string));
            objDT1.Columns.Add(objCol2);

            objDT1.Columns.Add(new DataColumn("Model", typeof(string)));

            System.Data.DataRow objRow;

            objRow = objDT1.NewRow();
            objRow["Color"] = "Red";
            objRow["Model"] = "2Door";
            objDT1.Rows.Add(objRow);

            objRow = objDT1.NewRow();
            objRow["Color"] = "Blue";
            objRow["Model"] = "4Door";
            objDT1.Rows.Add(objRow);

            string strData = "";
            System.Data.DataTableReader objDTR = objDS.CreateDataReader(objDS.Tables["Cars"]);
            while (objDTR.Read())
            {
                strData += Convert.ToString(objDTR["CarId"]) + " , " + objDTR["Color"] + " , " + objDTR["Model"] + "\n";
            }
            //Show the Results
            MessageBox.Show(strData);

            //Bind the Results to Windows Form controls
            comboBox3.DataSource = objDS.Tables["Cars"];
            comboBox3.DisplayMember = "Color";
            comboBox3.SelectedIndex = 0;

            //Save the Results
            objDS.WriteXml("SavedData.txt");

            //Retrieve the Results
            objDS.Clear();
            objDS.ReadXml("SavedData.txt");

            strData = "";
            objDTR = objDS.CreateDataReader(objDS.Tables["Cars"]);
            while (objDTR.Read())
            {
                strData += Convert.ToString(objDTR["CarId"]) + " , " + objDTR["Color"] + " , " + objDTR["Model"] + "\n";
            }

            MessageBox.Show(strData);

        }

        #endregion

    }
}
