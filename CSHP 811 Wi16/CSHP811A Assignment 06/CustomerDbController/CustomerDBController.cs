using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CustomerDbController
{
    class CustomerDBController : ICustomerDBController
    {
        #region constants
        #endregion

        #region fields

        #endregion

        #region properties


        #endregion

        #region constructors

        public CustomerDBController()
        {
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

        DataTable Select()
        {
            DataTable retVal = new DataTable();
            using (tempdbEntities tde = new tempdbEntities())
            {
                retVal = tde.pSelCustomer();

            }

            return retVal;
        }

        public var Select()
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
