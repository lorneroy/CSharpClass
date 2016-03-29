//For EF and ADO.NET
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System;

namespace DataAccessLayer
{
    public interface IParameterFactory
    {
        Dictionary<string, SqlParameter> Parameters { get; set; }
    }

    public abstract class ParameterFactory : IParameterFactory
    {
        public ParameterFactory()
        {
            objParmeters = new Dictionary<string, SqlParameter>();
            SqlParameter objNewRowID = new SqlParameter("@NewRowID", SqlDbType.Int);
            objNewRowID.Direction = ParameterDirection.Output; //Needed since Output is not default
            Parameters.Add("NewRowID", objNewRowID);

            SqlParameter objRC = new SqlParameter("@RC", SqlDbType.Int);
            //objRC.Direction = ParameterDirection.ReturnValue; EF does not support ReturnValue directly
            objRC.Direction = ParameterDirection.ReturnValue; //But you can use Output!
            Parameters.Add("RC", objRC);
        }

        private Dictionary<string, SqlParameter> objParmeters;
        public Dictionary<string, SqlParameter> Parameters
        {
            get
            {
                return objParmeters;
            }
            set
            {
                objParmeters = value;
            }
        }
    }

    public class EmployeesParameterFactory : ParameterFactory, IParameterFactory
    {
        //Employees
        public EmployeesParameterFactory(int EmployeeID = 0, string EmployeeName = "")
        {
            SqlParameter objEmployeeID = new SqlParameter();
            objEmployeeID.Direction = ParameterDirection.Input; //Note: Input is the default
            objEmployeeID.ParameterName = "@EmployeeID"; //The name must match the SQL argument's name!
            objEmployeeID.SqlDbType = SqlDbType.Int; // The data type must match what is in the database!
            objEmployeeID.Value = EmployeeID; // Value you want to pass in
            this.Parameters.Add("EmployeeID", objEmployeeID);

            SqlParameter objEmployeeName = new SqlParameter("@EmployeeName", EmployeeName);
            objEmployeeName.SqlDbType = SqlDbType.NVarChar;
            objEmployeeName.Size = 100;
            objEmployeeName.Value = EmployeeName;
            this.Parameters.Add("EmployeeName", objEmployeeName);

        }
    }//end class

    public class ProjectsParameterFactory : ParameterFactory, IParameterFactory
    {
        public ProjectsParameterFactory(int ProjectID = 0, string ProjectName = "", string ProjectDescription = "")
        {
            SqlParameter objProjectID = new SqlParameter();
            objProjectID.Direction = ParameterDirection.Input; //Note: Input is the default
            objProjectID.ParameterName = "@ProjectID"; //The name must match the SQL argument's name!
            objProjectID.SqlDbType = SqlDbType.Int; // The data type must match what is in the database!
            objProjectID.Value = ProjectID; // Value you want to pass in
            this.Parameters.Add("ProjectID", objProjectID);


            SqlParameter objProjectName = new SqlParameter("@ProjectName", ProjectName);
            objProjectName.SqlDbType = SqlDbType.NVarChar;
            objProjectName.Size = 100;
            objProjectName.Value = ProjectName;
            this.Parameters.Add("ProjectName", objProjectName);


            SqlParameter objProjectDescription = new SqlParameter("@ProjectDescription", ProjectDescription);
            objProjectDescription.SqlDbType = SqlDbType.NVarChar;
            objProjectDescription.Size = 5000;
            objProjectDescription.Value = ProjectDescription;
            this.Parameters.Add("ProjectDescription", objProjectDescription);
        }
    }

    public class EmployeeProjectHourParameterFactory: ParameterFactory, IParameterFactory
    {
        public EmployeeProjectHourParameterFactory(int EmployeeID, string EmployeeName, int ProjectID , string ProjectName , DateTime Date , decimal Hours )
        {
            //            dbo.EmployeeProjectHours.[Date],
            //dbo.Employees.EmployeeID, 			 
            //dbo.Employees.EmployeeName,
            //dbo.Projects.ProjectID, 			 
            //dbo.Projects.ProjectName, 
            //dbo.EmployeeProjectHours.Hours

            SqlParameter objEmployeeID = new SqlParameter();
            objEmployeeID.Direction = ParameterDirection.Input; //Note: Input is the default
            objEmployeeID.ParameterName = "@EmployeeID"; //The name must match the SQL argument's name!
            objEmployeeID.SqlDbType = SqlDbType.Int; // The data type must match what is in the database!
            objEmployeeID.Value = EmployeeID; // Value you want to pass in
            this.Parameters.Add("EmployeeID", objEmployeeID);
            
            SqlParameter objEmployeeName = new SqlParameter("@EmployeeName", EmployeeName);
            objEmployeeName.SqlDbType = SqlDbType.NVarChar;
            objEmployeeName.Size = 100;
            objEmployeeName.Value = EmployeeName;
            this.Parameters.Add("EmployeeName", objEmployeeName);

            SqlParameter objProjectID = new SqlParameter();
            objProjectID.Direction = ParameterDirection.Input; //Note: Input is the default
            objProjectID.ParameterName = "@ProjectID"; //The name must match the SQL argument's name!
            objProjectID.SqlDbType = SqlDbType.Int; // The data type must match what is in the database!
            objProjectID.Value = ProjectID; // Value you want to pass in
            this.Parameters.Add("ProjectID", objProjectID);

            SqlParameter objProjectName = new SqlParameter("@ProjectName", ProjectName);
            objProjectName.SqlDbType = SqlDbType.NVarChar;
            objProjectName.Size = 100;
            objProjectName.Value = ProjectName;
            this.Parameters.Add("ProjectName", objProjectName);

            SqlParameter objDate = new SqlParameter();
            objDate.Direction = ParameterDirection.Input; //Note: Input is the default
            objDate.ParameterName = "@Date"; //The name must match the SQL argument's name!
            objDate.SqlDbType = SqlDbType.DateTime; // The data type must match what is in the database!
            objDate.Value = Date; // Value you want to pass in
            this.Parameters.Add("Date", objDate);

            SqlParameter objHours = new SqlParameter();
            objHours.Direction = ParameterDirection.Input; //Note: Input is the default
            objHours.ParameterName = "@Hours"; //The name must match the SQL argument's name!
            objHours.SqlDbType = SqlDbType.Decimal; // The data type must match what is in the database!
            objHours.Value = Hours; // Value you want to pass in
            this.Parameters.Add("Hours", objHours);

        }
    }

    public class ThisYearsDateParameterFactory: ParameterFactory, IParameterFactory
    {
        public ThisYearsDateParameterFactory() { }
    }

    public class ValidHourEntryParameterFactory: ParameterFactory, IParameterFactory
    {
        public ValidHourEntryParameterFactory() { }
    }
}//end namespace
