using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CSHP811A_Assignment_06
{
    class CustomerDBController : ICustomerDBController
    {
        #region constants
        #endregion

        #region fields

        private string _connectionString;


        #endregion

        #region properties

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        #endregion

        #region constructors

        public CustomerDBController(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        #endregion

        #region methods

        public void Insert(int CustomerID, string CustomerName)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {

                    sqlCommand.Connection = sqlConnection;

                    //call stored procedure to insert record
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "pInsCustomer";

                    //add parameters to procedure
                    sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));
                    sqlCommand.Parameters.Add(new SqlParameter("@CustomerName", CustomerName));

                    sqlCommand.ExecuteNonQuery();

                }
            }
        }

        public string Select()
        {
            StringBuilder retVal = new StringBuilder();
            
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {

                    sqlCommand.Connection = sqlConnection;

                    //call stored procedure to insert record
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "pSelCustomer";

                    SqlDataReader sdr = sqlCommand.ExecuteReader();
                    while (sdr.Read())
                    {
                        retVal.AppendLine(sdr["CustomerId"] + ", " + sdr["CustomerName"]);
                    }
                }
            }
            return retVal.ToString();
        }

        public void Update(int CustomerID, string NewCustomerName)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {

                    sqlCommand.Connection = sqlConnection;

                    //call stored procedure to insert record
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "pUpdCustomer";

                    //add parameters to procedure
                    sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));
                    sqlCommand.Parameters.Add(new SqlParameter("@NewCustomerName", NewCustomerName));

                    sqlCommand.ExecuteNonQuery();

                }
            }
        }

        public void Delete(int CustomerID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {

                    sqlCommand.Connection = sqlConnection;

                    //call stored procedure to insert record
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "pDelCustomer";

                    //add parameters to procedure
                    sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));

                    sqlCommand.ExecuteNonQuery();

                }
            }
        }

        #endregion

    }
}
