using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//ADDED THESE
using EntityFrameworkDemosProcessor;

namespace EntityFrameworkUIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EntityFrameworkDemosProcessor.EntityFrameworkDemosEntities objContext = new EntityFrameworkDemosEntities())
            { /* NOTE YOU MUST ADD a reference to the System.Data.Entity.dll before this will work in a Console application  */

                //Select From a Table
                Console.WriteLine("Select From a Table");
                var objProducts = from p in objContext.Products
                                  select p;
                foreach (var row in objProducts)
                {
                    Console.WriteLine("The ID: {0}, Name: {1}, Price {2};", row.ProductID, row.ProductName, row.ProductPrice);
                }

                //Select From a View
                Console.WriteLine("Select From a View");
                var objVProducts = from p in objContext.vProducts
                                   select p;
                foreach (var row in objVProducts)
                {
                    Console.WriteLine("The ID: {0}, Name: {1}, Price {2};", row.ProductID, row.ProductName, row.ProductPrice);
                }

                //Select From a complex Reporting View
                Console.WriteLine("Select From a complex Reporting View");
                var objvRptProducts = objContext.vRptOrdersByProducts;
                foreach (var row in objvRptProducts)
                {
                    Console.WriteLine("The Customer: {0}, Product: {1}, Date:{2};", row.CustomerName, row.ProductName, row.OrderDate);
                }

                //Inserting Directly to table (Not Recommended)
                Console.WriteLine("Inserting Directly to table (Not Recommended)");
                try
                {
                    objContext.Products.AddObject(new Product() { ProductID = 300, ProductName = "ProdC", ProductPrice = 9.99M });
                    objContext.SaveChanges(); //This code send the change to the actual database
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Now check to see if the new row was added!"); Console.ReadLine();

                //Insert with a Stored Procedure
                Console.WriteLine("Insert with a Stored Procedure");
                objContext.pInsCustomer(3,"Tim Tomas");
                Console.WriteLine("Now check to see if the new row was added!"); Console.ReadLine();

                //Update with a Stored Procedure
                Console.WriteLine("Update with a Stored Procedure");
                objContext.pUpdateCustomer(3,"Tim Thomas");
                Console.WriteLine("Now check to see if the row was modified!"); Console.ReadLine();

                //Delete with a Stored Procedure
                Console.WriteLine("Update with a Stored Procedure");
                objContext.pDelCustomer(3);
                Console.WriteLine("Now check to see if the row was deleted!"); Console.ReadLine();

            }
      }
    }
}
