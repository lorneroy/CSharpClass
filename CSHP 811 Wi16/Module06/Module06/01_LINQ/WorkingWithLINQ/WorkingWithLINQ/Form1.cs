using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WorkingWithLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


#region LINQ to Arrays
private void buttonLINQAndArrays_Click(object sender, EventArgs e)
{
    Console.WriteLine("\n*** LINQ with an Array ***");

    // create an integer array
    int[] intValues = { 4, 8, 5, 2, 9, 0, 3, 7, 1, 6 };

    // Traditional approach has you specify how to process data from the array
    Console.Write("\n Traditional approach:  ");
    int intTrdFilteredData = 0;
    foreach (int element in intValues)
    {
        if (element == (4 + 2))
        {
            intTrdFilteredData = element;
        }
    }
    Console.Write(intTrdFilteredData);

    // LINQ approach, lets .Net create the filter code for you
    Console.Write("\n LINQ approach: ");
    var intLinqFiltered = // This returns an IEnumerable compatible object!
        from value in intValues
        where value == (4 + 2)
        select value;
    foreach (var element in intLinqFiltered)
    {
        Console.Write(" {0}", element);
    }


    /*** Additional Examples of that would take much more code to write without LINQ ***/
    Console.Write("\n LINQ approach with ORDERBY: ");
    var sorted =
        from value in intValues
        orderby value //Ordering results
        select value;
    foreach (var element in sorted)
        Console.Write(" {0}", element);

    Console.Write("\n LINQ approach with WHERE and ORDERBY: ");
    var sortAndFilter =
        from value in intValues
        where value < 4
        orderby value descending
        select value;
    foreach (var element in sortAndFilter)
        Console.Write(" {0}", element);

    Console.WriteLine("\n **************************************");
}
#endregion

#region LINQ to Objects

/* Make a class for the demo (See Customer.cs File)
    * 
class Customer
{
    private int intID;
    private string strName;

    public int ID
    {
        get { return intID; }
        set { intID = value; }
    }
    public string Name
    {
        get { return strName; }
        set { strName = value; }
    }

    public Customer(int ID, string Name) { this.ID = ID; this.Name = Name; }
    public override string ToString() { return ID.ToString() + "," + Name; }
}
    * 
    */
//Use LINQ to work with objects made from the Customer class
private void buttonLINQAndObjects_Click(object sender, EventArgs e)
{

    Console.WriteLine("\n *** LINQ with Objects ***");

    // Make an array of customers
    Customer[] arrCustomers = { new Customer(1, "Bob"), new Customer(2, "Sue"), new Customer(3, "Tim") };

    // Traditional approach has you specify how to process data from the array
    Console.Write("\n Traditional approach:  ");
    foreach (var element in arrCustomers)
    { Console.Write(element.ToString() + " "); }

    // LINQ approach
    var objCust =
        from c in arrCustomers
        select c;
    Console.Write("\n LINQ approach: ");
    foreach (var element in objCust) { Console.Write(element + " "); }

    /*** Additional Examples of that would take much more code to write  ***/
    // filter in a LINQ query
    var objOnlySue =
        from c in arrCustomers
        where c.Name == "Sue"
        select c;
    Console.Write("\n LINQ approach Filtered Data: ");
    foreach (var element in objOnlySue) { Console.Write(element); }

    // order the customer by name with LINQ
    var objNamesSorted =
        from c in arrCustomers
        orderby c.Name descending
        select c;
    Console.Write("\n LINQ approach Sorted Data: ");
    foreach (var element in objNamesSorted) { Console.Write(element.ToString() + " "); }


    //This example uses LINQ to select, or "Project", first and last names into an ANNOYMOUS type 
    // (Something that we see a lot in more advanced examples!)

    var objIDsNamesAndMore =
        from c in arrCustomers //The next line of code creates an ANNOYMOUS type, using properties you dictate.
        select new { c.ID, ANameProperty = c.Name, StaticData = "a", DynamicData = DateTime.Now };

    // Display ANNOYMOUS type data
    Console.WriteLine("\n  ANNOYMOUS type data:");
    foreach (var element in objIDsNamesAndMore) { Console.Write(element.ToString() + "\n"); }

    Console.WriteLine("\n**************************************");
}
#endregion

        #region LINQ to Data Driven Objects

        /* You will need to run this code in SQL Server for the next demos. (See DatabaseCode.sql File)
          
          Use TempDB
          Create Table Customers (ID int, Name nVarChar(50));
          Insert into Customers Values (1,'Bob'), (2,'Sue'),(3,'Tim')
          
         */
        private void buttonLINQToDataDrivenObjects_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n *** LINQ To a Data Driven Object ***");

            System.Data.SqlClient.SqlConnection objCon = null;
            System.Data.SqlClient.SqlCommand objCmd = null;
            System.Data.SqlClient.SqlDataReader objDR = null;

            try
            {
                objCon = new System.Data.SqlClient.SqlConnection("Data Source=(local);Initial Catalog=tempdb;Integrated Security=True");
                objCmd = new System.Data.SqlClient.SqlCommand("Select ID, Name From Customers", objCon);

                objCon.Open();
                objDR = objCmd.ExecuteReader();

                List<Customer> lstCustomers = new List<Customer>();
                while (objDR.Read() == true)
                {
                    Customer c = new Customer((int)objDR["ID"], (string)objDR["Name"]);
                    lstCustomers.Add(c);
                }

                #region Same code as in the last demo!
                // Traditional approach has you specify how to process data from the array
                Console.Write("\n Traditional approach:  ");
                foreach (var element in lstCustomers)
                { Console.Write(element.ToString() + " "); }

                // LINQ approach
                var objCust =
                   from c in lstCustomers
                   select c;
                Console.Write("\n LINQ approach: ");
                foreach (var element in objCust) { Console.Write(element + " "); }

                /*** Additional Examples of that would take much more code to write  ***/
                // filter in a LINQ query
                var objOnlySue =
                   from c in lstCustomers
                   where c.Name == "Sue"
                   select c;
                Console.Write("\n LINQ approach Filtered Data: ");
                foreach (var element in objOnlySue) { Console.Write(element); }

                // order the customer by name with LINQ
                var objNamesSorted =
                   from c in lstCustomers
                   orderby c.Name descending
                   select c;
                Console.Write("\n LINQ approach Sorted Data: ");
                foreach (var element in objNamesSorted) { Console.Write(element.ToString() + " "); }


                //This example uses LINQ to select, or "Project", first and last names into an ANNOYMOUS type 
                // (Something that we see a lot in more advanced examples!)

                var objIDsNamesAndMore =
                   from c in lstCustomers //The next line of code creates an ANNOYMOUS type, using properties you dictate.
                   select new { c.ID, ANameProperty = c.Name, StaticData = "a", DynamicData = DateTime.Now };

                // Display ANNOYMOUS type data
                Console.WriteLine("\n  ANNOYMOUS type data:");
                foreach (var element in objIDsNamesAndMore) { Console.Write(element.ToString() + "\n"); }

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                objDR.Close();
                objCon.Close();
            }

            Console.WriteLine("\n**************************************");
        }
        #endregion

        #region LINQ to DataSet Objects

        /* You will need to run code in SQL Server for the next demos. (See DatabaseCode.sql File) */
        private void buttonLINQToDataSet_Click(object sender, EventArgs e)
        {

            Console.WriteLine("\n *** LINQ To a DataSet Object ***");

            System.Data.SqlClient.SqlConnection objCon = null;
            System.Data.SqlClient.SqlCommand objCmd = null;
            //System.Data.SqlClient.SqlDataReader objDR = null;
            System.Data.SqlClient.SqlDataAdapter objDA = null;
            System.Data.DataSet objDS = null;

            try
            {
                objCon = new System.Data.SqlClient.SqlConnection("Data Source=(local);Initial Catalog=tempdb;Integrated Security=True");
                objCmd = new System.Data.SqlClient.SqlCommand("Select ID, Name From Customers", objCon);
                objDA = new System.Data.SqlClient.SqlDataAdapter(objCmd);
                objDS = new DataSet();

                //We do not need this code now...
                //objCon.Open();
                //objDR = objCmd.ExecuteReader();
                //List<Customer> lstCustomers = new List<Customer>();
                //while (objDR.Read() == true)
                //{
                //    Customer objRow = new Customer((int)objDR["ID"], (string)objDR["Name"]);
                //    lstCustomers.Add(objRow);
                //}

                //instead we use this code...
                objDA.Fill(objDS, "Customers");
                DataTable objDT = objDS.Tables["Customers"];

                Console.Write("\n Traditional approach:  ");
                // Traditional approach has you specify how to process data from the array
                foreach (var element in objDT.AsEnumerable())
                {
                    Console.Write(element["ID"].ToString() + "," + element["Name"].ToString() + " ");
                }

                // LINQ approach
                var objCustomers = from c in objDT.AsEnumerable()
                                   select c;
                Console.Write("\n LINQ approach: ");
                foreach (var element in objCustomers)
                {
                    Console.Write(element.Field<int>("ID").ToString() + "," + element.Field<string>("Name").ToString() + " ");
                }

                /*** Additional Examples of that would take much more code to write  ***/

                // filter in a LINQ query
                var objOnlySue = from c in objDT.AsEnumerable()
                                 where c.Field<string>("Name") == "Sue"
                                 select new { ID = c.Field<int>("ID"), Name = c.Field<string>("Name") };
                Console.Write("\n LINQ approach Filtered Data: ");
                foreach (var element in objOnlySue)
                {
                    Console.Write(element.ID.ToString() + "," + element.Name.ToString() + " ");
                }

                // order the customer by name with LINQ
                var objNamesSorted = from c in objDT.AsEnumerable()
                                     orderby c.Field<string>("Name") descending
                                     select new { ID = c.Field<int>("ID"), Name = c.Field<string>("Name") };
                Console.Write("\n LINQ approach Sorted Data: ");
                foreach (var element in objNamesSorted)
                {
                    Console.Write(element.ID.ToString() + "," + element.Name.ToString() + " ");
                }


                // LINQ approach (using an ANNOYMOUS type)
                var objIDsNamesAndMore = from c in objDT.AsEnumerable()
                                         select new { ID = c.Field<int>("ID"), Name = c.Field<string>("Name"), StaticData = "a", DynamicData = DateTime.Now };
                Console.WriteLine("\n  ANNOYMOUS type data:");
                foreach (var element in objIDsNamesAndMore) { Console.Write(element.ToString() + "\n"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //objDR.Close();
                //objCon.Close();
            }

            Console.WriteLine("\n**************************************");
        }

        #endregion

#region LINQ to Microsoft SQL Server objects
private void buttonLINQToSQL_Click(object sender, EventArgs e)
{
    Console.WriteLine("\n *** LINQ To a SQL ***");
    LinqToSQLDemoDataContext objDataContext = new LinqToSQLDemoDataContext();

    Console.Write("\n Traditional approach:  ");
    // Traditional approach has you specify how to process data from the array
    foreach (var element in objDataContext.CustomerEntities.AsEnumerable())
    {
        Console.Write(element.ID.ToString() + "," + element.Name.ToString() + " ");
    }

    // LINQ approach
    var objCustomers = from c in objDataContext.CustomerEntities.AsEnumerable()
                        select c;
    Console.Write("\n LINQ approach: ");
    foreach (var element in objCustomers)
    {
        Console.Write(element.ID.ToString() + "," + element.Name.ToString() + " ");
    }

    /*** Additional Examples of that would take much more code to write  ***/

    // filter in a LINQ query
    var objOnlySue = from c in objDataContext.CustomerEntities.AsEnumerable()
                        where c.Name == "Sue"
                        select new { ID = c.ID, Name = c.Name };
    Console.Write("\n LINQ approach Filtered Data: ");
    foreach (var element in objOnlySue)
    {
        Console.Write(element.ID.ToString() + "," + element.Name.ToString() + " ");
    }

    // order the customer by name with LINQ
    var objNamesSorted = from c in objDataContext.CustomerEntities.AsEnumerable()
                            orderby c.Name descending
                            select new { ID = c.ID, Name = c.Name };
    Console.Write("\n LINQ approach Sorted Data: ");
    foreach (var element in objNamesSorted)
    {
        Console.Write(element.ID.ToString() + "," + element.Name.ToString() + " ");
    }


    // LINQ approach (using an ANNOYMOUS type)
    var objIDsNamesAndMore = from c in objDataContext.CustomerEntities.AsEnumerable()
                                select new { ID = c.ID, Name = c.Name, StaticData = "a", DynamicData = DateTime.Now };
    Console.WriteLine("\n  ANNOYMOUS type data:");
    foreach (var element in objIDsNamesAndMore) { Console.Write(element.ToString() + "\n"); }

    Console.WriteLine("\n**************************************");
} 
#endregion

#region LINQ to Many Vendor's SQL Server objects
private void buttonLINQToDataEntities_Click(object sender, EventArgs e)
{
    Console.WriteLine("\n *** LINQ To a Data Entity ***");

    using (tempdbEntities objContext = new tempdbEntities())
    {

        Console.Write("\n Traditional approach:  ");
        // Traditional approach has you specify how to process data from the array
        foreach (var element in objContext.EntityModelCustomers.AsEnumerable())
        {
            Console.Write(element.ID.ToString() + "," + element.Name.ToString() + " ");
        }


        // LINQ approach
        var objCustomers = from c in objContext.EntityModelCustomers.AsEnumerable()
                            select c;
        Console.Write("\n LINQ approach: ");
        foreach (var element in objCustomers)
        {
            Console.Write(element.ID.ToString() + "," + element.Name.ToString() + " ");
        }

        /*** Additional Examples of that would take much more code to write  ***/

        // filter in a LINQ query
        var objOnlySue = from c in objContext.EntityModelCustomers.AsEnumerable()
                            where c.Name == "Sue"
                            select new { ID = c.ID, Name = c.Name };
        Console.Write("\n LINQ approach Filtered Data: ");
        foreach (var element in objOnlySue)
        {
            Console.Write(element.ID.ToString() + "," + element.Name.ToString() + " ");
        }

        // order the customer by name with LINQ
        var objNamesSorted = from c in objContext.EntityModelCustomers.AsEnumerable()
                                orderby c.Name descending
                                select new { ID = c.ID, Name = c.Name };
        Console.Write("\n LINQ approach Sorted Data: ");
        foreach (var element in objNamesSorted)
        {
            Console.Write(element.ID.ToString() + "," + element.Name.ToString() + " ");
        }


        // LINQ approach (using an ANNOYMOUS type)
        var objIDsNamesAndMore = from c in objContext.EntityModelCustomers.AsEnumerable()
                                    select new { ID = c.ID, Name = c.Name, StaticData = "a", DynamicData = DateTime.Now };
        Console.WriteLine("\n  ANNOYMOUS type data:");
        foreach (var element in objIDsNamesAndMore) { Console.Write(element.ToString() + "\n"); }

        Console.WriteLine("\n**************************************");
    }
} 
#endregion

    }

}
