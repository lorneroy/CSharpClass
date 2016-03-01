using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP811A_Assignment_06
{
    interface ICustomerDBController
    {

        string ConnectionString
        {
            get;
            set;
        }

        string Select();

        void Insert(int CustomerID, string CustomerName);

        void Update(int CustomerID, string NewCustomerName);

        void Delete(int CustomerID);

    }
}
