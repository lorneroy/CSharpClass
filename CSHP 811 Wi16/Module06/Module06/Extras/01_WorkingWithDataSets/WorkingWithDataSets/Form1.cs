using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//added these
using System.Data.SqlClient;

namespace WorkingWithDataSets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strConn = @"Data Source=.;Initial Catalog = Master; Integrated Security=True;";
        string strSqlCom = @"Select database_id, name from Sys.databases";

        //Using an Array List with a Collection of Rows
        class CustomDbDataRow { public int DatabaseId; public string DatabaseName; public int RowState;}
        // RowState { 0 = Original, 1 = inserted; 2 = updated, 3 = deleted}

        private void button1_Click(object sender, EventArgs e)
        {
            #region Build a ArrayList to hold the data
            //Using an "Generic" ArrayList which is un-typed
            System.Collections.ArrayList objAL = new System.Collections.ArrayList();
            #endregion

            #region Fill with Data
            SqlConnection objCon = new SqlConnection(strConn);
            SqlCommand objCmd = new SqlCommand(strSqlCom, objCon);
            objCon.Open();
            SqlDataReader objDR = objCmd.ExecuteReader();

            while (objDR.Read())
            {
                CustomDbDataRow objRow = new CustomDbDataRow();
                objRow.DatabaseId = (int)objDR["database_id"];
                objRow.DatabaseName = (string)objDR["name"];
                objRow.RowState = 0;
                objAL.Add(objRow);
            }
            objCon.Close();
            #endregion

            #region Work with the Data
            ShowArrayListData(objAL);

            CustomDbDataRow objNewRow = new CustomDbDataRow();
            objNewRow.DatabaseId = -1;
            objNewRow.DatabaseName = "TestDB";
            objNewRow.RowState = 1;
            objAL.Add(objNewRow);
            ShowArrayListData(objAL);

            ((CustomDbDataRow)objAL[objAL.Count - 1]).DatabaseName = "DemoDB";
            ((CustomDbDataRow)objAL[objAL.Count - 1]).RowState = 2;
            ShowArrayListData(objAL);

            ((CustomDbDataRow)objAL[objAL.Count - 1]).RowState = 3;
            ShowArrayListData(objAL);
            #endregion
        }

        //Using a Un-Typed Dataset;
        private void button2_Click(object sender, EventArgs e)
        {
            #region Build a DataSet to hold the data
            DataSet objDS = new DataSet();

            //Tables are made up of an collection of columns.
            DataTable objDTDatabases = new DataTable("Databases");
            DataColumn objDCDatabaseId = new DataColumn("DatabaseId", typeof(int));
            DataColumn objDCDatabaseName = new DataColumn("DatabaseName", typeof(string));
            objDTDatabases.Columns.Add(objDCDatabaseId);
            objDTDatabases.Columns.Add(objDCDatabaseName);
            //RowState is not needed!

            objDS.Tables.Add(objDTDatabases);

            //This is use to for a number of task such as finding a particular row.
            DataColumn[] objPK = { objDCDatabaseId };
            objDTDatabases.PrimaryKey = objPK;

            #endregion

            #region Fill with data
            SqlConnection objCon = new SqlConnection(strConn);
            SqlCommand objCmd = new SqlCommand(strSqlCom, objCon);
            objCon.Open();
            SqlDataReader objDR = objCmd.ExecuteReader();

            while (objDR.Read())
            {   //To add a row, you have to know it's collection of columns; NewRow() gives that info.
                DataRow objRow = objDTDatabases.NewRow();
                objRow["DatabaseId"] = (int)objDR["database_id"];
                objRow["DatabaseName"] = (string)objDR["name"];
                //objRow.RowState = 0; not needed
                objDTDatabases.Rows.Add(objRow);
            }
            objCon.Close();
            #endregion

            #region Work with the data
            //Note: This code changes things in the DataSet and NOT the Database.
            ShowDataSetData(objDTDatabases);
            objDTDatabases.AcceptChanges(); //Resets Status

            //Add a row
            DataRow objNewRow = objDTDatabases.NewRow();
            objNewRow["DatabaseId"] = -1;
            objNewRow["DatabaseName"] = "TestDB";
            //objRow.RowState = 0; not needed
            objDTDatabases.Rows.Add(objNewRow);

            ShowDataSetData(objDTDatabases);
            objDTDatabases.AcceptChanges(); //Resets Status

            //Update a row
            DataRow objUpdRow = objDTDatabases.Rows.Find(-1);
            objUpdRow["DatabaseName"] = "DemoDB";

            ShowDataSetData(objDTDatabases);
            objDTDatabases.AcceptChanges(); //Resets Status

            //Delete a row
            DataRow objDelRow = objDTDatabases.Rows.Find(-1);
            objDelRow.Delete();
            ShowDataSetData(objDTDatabases);
            // objDTDatabases.AcceptChanges(); //Resets Status

            #endregion
        }

        //Using a Typed Dataset;
        private void button3_Click(object sender, EventArgs e)
        {
            #region Build a DataSet to hold the data
            TypedDataSetForDBInfo objDS = new TypedDataSetForDBInfo();

            /* ALL OF THIS IS DONE FOR ME! WHOO HOO!
                DataTable objDTDatabases = new DataTable("Databases");
                DataColumn objDCDatabaseId = new DataColumn("DatabaseId", typeof(int));
                DataColumn objDCDatabaseName = new DataColumn("DatabaseName", typeof(string));
                objDTDatabases.Columns.Add(objDCDatabaseId);
                objDTDatabases.Columns.Add(objDCDatabaseName);
                //RowState is not needed!
                objDS.Tables.Add(objDTDatabases);
                DataColumn[] objPK = { objDCDatabaseId };
                objDTDatabases.PrimaryKey = objPK;
             */
            #endregion

            #region Fill with data
            SqlConnection objCon = new SqlConnection(strConn);
            SqlCommand objCmd = new SqlCommand(strSqlCom, objCon);

            //Using an "Generic" ArrayList which is un-typed
            objCon.Open();
            SqlDataReader objDR = objCmd.ExecuteReader();

            //Adding a reference variable with the same name as I used in 
            //the last section so I can just reuse the same code...
            DataTable objDTDatabases = objDS.DataTableDBInfo;


            while (objDR.Read())
            {
                DataRow objRow = objDTDatabases.NewRow();
                objRow["DatabaseId"] = (int)objDR["database_id"];
                objRow["DatabaseName"] = (string)objDR["name"];
                //objRow.RowState = 0; not needed
                objDTDatabases.Rows.Add(objRow);
            }
            objCon.Close();
            #endregion

            #region Work with the data
            //
            ShowDataSetData(objDTDatabases);
            objDTDatabases.AcceptChanges(); //Resets Status

            //Add a row
            DataRow objNewRow = objDTDatabases.NewRow();
            objNewRow["DatabaseId"] = -1;
            objNewRow["DatabaseName"] = "TestDB";
            //objRow.RowState = 0; not needed
            objDTDatabases.Rows.Add(objNewRow);

            ShowDataSetData(objDTDatabases);
            objDTDatabases.AcceptChanges(); //Resets Status

            //Update a row
            DataRow objUpdRow = objDTDatabases.Rows.Find(-1);
            objUpdRow["DatabaseName"] = "DemoDB";

            ShowDataSetData(objDTDatabases);
            objDTDatabases.AcceptChanges(); //Resets Status

            //Delete a row
            DataRow objDelRow = objDTDatabases.Rows.Find(-1);
            objDelRow.Delete();
            ShowDataSetData(objDTDatabases);
            // objDTDatabases.AcceptChanges(); //Resets Status

            #endregion
        }

        //Automatically with a DataAdapter
        private void button4_Click(object sender, EventArgs e)
        {
            #region Build a DataSet to hold the data
            DataSet objDS = new DataSet();

            #region Stuff we dont need
            /**** ALL OF THIS IS DONE FOR ME! WHOO HOO! ****
                DataTable objDTDatabases = new DataTable("Databases");
                DataColumn objDCDatabaseId = new DataColumn("DatabaseId", typeof(int));
                DataColumn objDCDatabaseName = new DataColumn("DatabaseName", typeof(string));
                objDTDatabases.Columns.Add(objDCDatabaseId);
                objDTDatabases.Columns.Add(objDCDatabaseName);
                //RowState is not needed!
                objDS.Tables.Add(objDTDatabases);
                DataColumn[] objPK = { objDCDatabaseId };
                objDTDatabases.PrimaryKey = objPK;
             ********************************************/

            #endregion
            #endregion

            #region Fill with data
            SqlConnection objCon = new SqlConnection(strConn);

            #region More Stuff we dont need
            /**** Now we don't need this section either! ****
    
            SqlCommand objCmd = new SqlCommand(strSqlCom, objCon);
             
            //Using an "Generic" ArrayList which is un-typed
            objCon.Open();
            SqlDataReader objDR = objCmd.ExecuteReader();

            //Adding a reference variable with the same name as I used in 
            //the last section so I can just reuse the same code...
            DataTable objDTDatabases = objDS.DataTableDBInfo;


            while (objDR.Read())
            {
                DataRow objRow = objDTDatabases.NewRow();
                objRow["DatabaseId"] = (int)objDR["database_id"];
                objRow["DatabaseName"] = (string)objDR["name"];
                //objRow.RowState = 0; not needed
                objDTDatabases.Rows.Add(objRow);
            }
            objCon.Close();
             
             *********************************************/

            #endregion

            SqlDataAdapter objDA = new SqlDataAdapter(strSqlCom, objCon);
            objDA.Fill(objDS, "DataTableDBInfo");

            #endregion

            #region Work with the data

            //Adding a reference variable with the same name as I used in 
            //the last section so I can just reuse the same code...
            DataTable objDTDatabases = objDS.Tables[0];

            ShowDataSetData(objDTDatabases);
            objDTDatabases.AcceptChanges(); //Resets Status

            //Add a row
            DataRow objNewRow = objDTDatabases.NewRow();
            objNewRow["database_id"] = -1;
            objNewRow["name"] = "TestDB";
            //objRow.RowState = 0; not needed
            objDTDatabases.Rows.Add(objNewRow);

            ShowDataSetData(objDTDatabases);
            objDTDatabases.AcceptChanges(); //Resets Status

            //Update a row
            //Oops, we need to add a PK to this Untyped DataSet if we want to update!
            DataColumn[] objPK = { objDS.Tables[0].Columns[0] };
            objDTDatabases.PrimaryKey = objPK;

            DataRow objUpdRow = objDTDatabases.Rows.Find(-1);
            objUpdRow["name"] = "DemoDB";

            ShowDataSetData(objDTDatabases);
            objDTDatabases.AcceptChanges(); //Resets Status

            //Delete a row
            DataRow objDelRow = objDTDatabases.Rows.Find(-1);
            objDelRow.Delete();
            ShowDataSetData(objDTDatabases);
            // objDTDatabases.AcceptChanges(); //Resets Status

            #endregion
        }

        //Using Data Binding to display data.
        private void button5_Click(object sender, EventArgs e)
        {
            #region Build a DataSet and fill it with data
            DataSet objDS = new DataSet();
            SqlConnection objCon = new SqlConnection(strConn);
            SqlDataAdapter objDA = new SqlDataAdapter(strSqlCom, objCon);
            objDA.Fill(objDS, "DataTableDBInfo");
            #endregion

            #region Use DataBinding to attach it to my controls.
            dataGridView1.DataSource = objDS.Tables["DataTableDBInfo"];

            comboBox1.DataSource = objDS.Tables["DataTableDBInfo"];
            comboBox1.DisplayMember = "name";

            listBox1.DataSource = objDS.Tables["DataTableDBInfo"];
            listBox1.DisplayMember = "name";

            //public Binding(string propertyName, object dataSource, string dataMember)
            Binding objB1 = new Binding("Text", objDS.Tables["DataTableDBInfo"], "database_id");
            textBox1.DataBindings.Add(objB1);

            Binding objB2 = new Binding("Text", objDS.Tables["DataTableDBInfo"], "name");
            textBox2.DataBindings.Add(objB2);
            #endregion
        }


        #region Accessing the Data Methods

        private static void ShowArrayListData(System.Collections.ArrayList objAL)
        {
            foreach (object item in objAL)
            {
                Console.WriteLine("id = {0}; name = {1}; state = {2}  ",
                    ((CustomDbDataRow)item).DatabaseId,
                    ((CustomDbDataRow)item).DatabaseName,
                    ((CustomDbDataRow)item).RowState);
            }
            Console.WriteLine("*******************************");
        }

        private static void ShowDataSetData(DataTable objTable)
        {
            // This wont work! Why?  => foreach (object item in objTable ) {         }

            for (int i = 0; i < objTable.Rows.Count; i++)
            {
                try
                {
                    Console.WriteLine("id = {0}; name = {1}; state = {2}  ",
                                                (int)objTable.Rows[i][0],
                                                (string)objTable.Rows[i][1],
                                                objTable.Rows[i].RowState.ToString()
                                               );
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    DataView objDV = objTable.DefaultView;
                    objDV.RowStateFilter = DataViewRowState.Deleted;
                    Console.WriteLine("Rows Flagged for Deletion = {0}  ", objDV.Count.ToString());
                    foreach (DataRowView item in objDV)
                    {
                        Console.WriteLine("Id = {0}; Name= {1}",
                                            item[0].ToString(),
                                            item[1].ToString()
                                          );
                    }
                }
            }
            Console.WriteLine("*******************************");
        }

        #endregion


    }//End of class Form1

}
