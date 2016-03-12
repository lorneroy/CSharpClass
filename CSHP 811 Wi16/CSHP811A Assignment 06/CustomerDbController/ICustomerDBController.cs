using System;
using System.Data;

namespace CustomerDbController

{
    interface ICustomerDBController
    {
        int EmployeeID;

        tempdbEntities Select();

        void Insert(int CustomerID, string CustomerName);

        void Update(int CustomerID, string NewCustomerName);

        void Delete(int CustomerID);

    }
}
