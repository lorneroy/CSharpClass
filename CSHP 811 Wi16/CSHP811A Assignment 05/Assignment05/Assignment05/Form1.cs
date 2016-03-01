using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment05
{
    public partial class FormPersonEntry : Form
    {

        #region fields

        //connection string for database access
        string connectionString;

        #endregion

        #region constructors
        public FormPersonEntry()
        {
            InitializeComponent();

            //read the connection string from app.config
            connectionString = ConfigurationManager.ConnectionStrings["Assignment05"].ConnectionString;

        }

        #endregion

        #region methods

        //insert the data from the form into the database
        private void buttonInsertData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        
                        sqlCommand.Connection = sqlConnection;

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "usp_insert_person";


                        //add parameters to procedure
                        sqlCommand.Parameters.Add( new SqlParameter("@FirstName", textBoxFirstName.Text));
                        sqlCommand.Parameters.Add( new SqlParameter("@LastName", textBoxLastName.Text));
                        sqlCommand.Parameters.Add( new SqlParameter("@PhoneNumber", textBoxPhoneNumber.Text));


                        sqlCommand.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error connecting to database");
            }
        }

        #endregion
    }
}
