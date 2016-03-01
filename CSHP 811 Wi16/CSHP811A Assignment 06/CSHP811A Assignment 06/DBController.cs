using CustomerDbController;
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

            using (tempdbEntities tde = new tempdbEntities())
            {
                tde.pInsCustomer(CustomerID, CustomerName);
            }
        }

        public string Select()
        {
            StringBuilder retVal = new StringBuilder();

            using (tempdbEntities tde = new tempdbEntities())
            {
                var results = tde.pSelCustomer();
                foreach (var item in results)
                {
                    retVal.AppendLine(item.CustomerId + ", " + item.CustomerName);
                }
            }

            return retVal.ToString();
        }

        public void Update(int CustomerID, string NewCustomerName)
        {
            using (tempdbEntities tde = new tempdbEntities())
            {
                tde.pUpdCustomer(CustomerID, NewCustomerName);
            }
        }

        public void Delete(int CustomerID)
        {
            using (tempdbEntities tde = new tempdbEntities())
            {
                tde.pDelCustomer(CustomerID);
            }
        }

        #endregion

    }
}
