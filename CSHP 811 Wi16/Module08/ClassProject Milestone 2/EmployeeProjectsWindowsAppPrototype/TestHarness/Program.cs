using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Employee Test");
            TestEmployee();

            Console.WriteLine();
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
            
            Console.WriteLine("Begin Project Test");
            TestProject();

            Console.WriteLine();
            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Begin EmployeeProjectHour Test");
            TestEmployeeProjectHour();

            Console.WriteLine();
            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Begin ThisYearsDate Test");
            TestThisYearsDate();

            Console.WriteLine();
            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Begin ValidHourEntry Test");
            TestValidHourEntry();

            Console.WriteLine();
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
        }

        static void TestEmployee()
        {
            DataAccessLayer.Employee objE = new DataAccessLayer.Employee();
            int NewID, RC;
            RC = objE.InsEmployee("test", out NewID);
            Console.WriteLine("RC: {0} and NewID: {1}", RC, NewID);

            foreach (Employee empl in objE.SelEmployee())
            {
                Console.WriteLine("Employee ID: {0}, Employee Name: {1}", empl.EmployeeID, empl.EmployeeName);
            }

            RC = objE.UpdEmployee(NewID, "test2");

            Console.WriteLine("RC: {0} on update call", RC);

            foreach (Employee empl in objE.SelEmployee())
            {
                Console.WriteLine("Employee ID: {0}, Employee Name: {1}", empl.EmployeeID, empl.EmployeeName);
            }

            RC = objE.DelEmployee(NewID);

            Console.WriteLine("RC: {0} on delete call", RC);

            foreach (Employee empl in objE.SelEmployee())
            {
                Console.WriteLine("Employee ID: {0}, Employee Name: {1}", empl.EmployeeID, empl.EmployeeName);
            }

        }

        static void TestProject()
        {
            DataAccessLayer.Project objP = new DataAccessLayer.Project();
            int NewID, RC;
            RC = objP.InsProject("testName", "testDescription", out NewID);
            Console.WriteLine("RC: {0} and NewID: {1}", RC, NewID);

            foreach (Project prjt in objP.SelProjects())
            {
                Console.WriteLine("Project ID: {0}, Project Name: {1}, Project Description: {2}", prjt.ProjectID, prjt.ProjectName, prjt.ProjectDescription);
            }

            RC = objP.UpdProject(NewID, "testname2", "testDescription2");

            Console.WriteLine("RC: {0} on update call", RC);

            foreach (Project prjt in objP.SelProjects())
            {
                Console.WriteLine("Project ID: {0}, Project Name: {1}, Project Description: {2}", prjt.ProjectID, prjt.ProjectName, prjt.ProjectDescription);
            }

            RC = objP.DelProject(NewID);

            Console.WriteLine("RC: {0} on delete call", RC);

            foreach (Project prjt in objP.SelProjects())
            {
                Console.WriteLine("Project ID: {0}, Project Name: {1}, Project Description: {2}", prjt.ProjectID, prjt.ProjectName, prjt.ProjectDescription);
            }

        }

        static void TestEmployeeProjectHour()
        {
            DataAccessLayer.EmployeeProjectHour objEph = new DataAccessLayer.EmployeeProjectHour();
            int RC;
            DateTime dt = DateTime.Now;
            int newEmployeeID;
            int newProjectID;


            foreach (EmployeeProjectHour prjt in objEph.SelEmployeeProjectHours())
            {
                Console.WriteLine("Employee ID: {0}, Employee Name {1}, Project ID: {2}, Project Name: {3}, Date: {4}, Hours: {5}", prjt.EmployeeID, prjt.EmployeeName, prjt.ProjectID, prjt.ProjectName, prjt.Date, prjt.Hours);
            }

            //create an employee and a project to insert
            Employee objEmpl = new Employee();
            objEmpl.InsEmployee("bob dobalina",out newEmployeeID);

            Project objProj = new Project();
            objProj.InsProject("recording","", out newProjectID);

            RC = objEph.InsEmployeeProjectHours(newEmployeeID, newProjectID, dt, 42); 

            Console.WriteLine();
            Console.WriteLine("RC: {0}", RC);

            foreach (EmployeeProjectHour prjt in objEph.SelEmployeeProjectHours())
            {
                Console.WriteLine("Employee ID: {0}, Employee Name {1}, Project ID: {2}, Project Name: {3}, Date: {4}, Hours: {5}", prjt.EmployeeID, prjt.EmployeeName, prjt.ProjectID, prjt.ProjectName, prjt.Date, prjt.Hours);
            }

            RC = objEph.UpdEmployeeProjectHours(newEmployeeID, newProjectID, dt, 104); 

            Console.WriteLine();
            Console.WriteLine("RC: {0}", RC);

            foreach (EmployeeProjectHour prjt in objEph.SelEmployeeProjectHours())
            {
                Console.WriteLine("Employee ID: {0}, Employee Name {1}, Project ID: {2}, Project Name: {3}, Date: {4}, Hours: {5}", prjt.EmployeeID, prjt.EmployeeName, prjt.ProjectID, prjt.ProjectName, prjt.Date, prjt.Hours);
            }

            RC = objEph.DelEmployeeProjectHours(newEmployeeID, newProjectID, dt); 

            Console.WriteLine();
            Console.WriteLine("RC: {0}", RC);

            foreach (EmployeeProjectHour prjt in objEph.SelEmployeeProjectHours())
            {
                Console.WriteLine("Employee ID: {0}, Employee Name {1}, Project ID: {2}, Project Name: {3}, Date: {4}, Hours: {5}", prjt.EmployeeID, prjt.EmployeeName, prjt.ProjectID, prjt.ProjectName, prjt.Date, prjt.Hours);
            }

            objEmpl.DelEmployee(newEmployeeID);
            objProj.DelProject(newProjectID);

        }

        static void TestThisYearsDate()
        {
            int intRC;
            ThisYearsDate objTyd = new ThisYearsDate();


            foreach (ThisYearsDate tyd in objTyd.SelThisYearsDates())
            {
                Console.WriteLine("Date ID: {0}, Date Name {1}", tyd.DateID, tyd.DateName);
            }

        }

        static void TestValidHourEntry()
        {
            int intRC;
            ValidHourEntry objVhe = new ValidHourEntry();

            foreach (ValidHourEntry vhe in objVhe.SelValidHourEntries())
            {
                Console.WriteLine("Time Period ID: {0}, Time Period {1}", vhe.TimePeriodID, vhe.TimePeriod);
            }
        }
    }
}
