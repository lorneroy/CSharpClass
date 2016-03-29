using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Data.Entity.Core.Objects;

namespace DataAccessLayer
{
    public class Employee : IEmployeeRepository
    {
        #region fields

        IEnumerable<Employee> objEmployees = new List<Employee>();
        int objEmployeeID;
        string objEmployeeName;

        #endregion

        #region properties

        public IEnumerable<Employee> Employees
        {
            get
            {
                return objEmployees;
            }
            set
            {
              objEmployees = value ;
            }
        }

        public int EmployeeID
        {
            get
            {
                return objEmployeeID;
            }
            set
            {
              objEmployeeID = value ;
            }
        }

        public string EmployeeName
        {
            get
            {
                return objEmployeeName;
            }
            set
            {
              objEmployeeName = value ;
            }
        }

        #endregion

        #region methods

        public int InsEmployee(string EmployeeName, out int NewRowID)
        {
            return ADONetOption(EmployeeName, out NewRowID);
            //return EFOption(EmployeeName, out NewRowID);
        }

        private static int ADONetOption(string EmployeeName, out int NewRowID)
        {
            //Set up the variables
            int intRC = 0; //Used to trap the Stored Procedure's return code

            //Create a Connection object using my custom connection factory
            System.Data.SqlClient.SqlConnection objCon = new ADOConnectionFactory().Connection;

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new EmployeesParameterFactory(EmployeeName: EmployeeName);  
          
            //Create and configure an ADO.NET command object 
            System.Data.SqlClient.SqlCommand objCmd = new SqlCommand("", objCon);
            objCmd.Parameters.Add(objParams.Parameters["RC"]);
            objCmd.Parameters.Add(objParams.Parameters["EmployeeName"]);
            objCmd.Parameters.Add(objParams.Parameters["NewRowID"]);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.CommandText = "pInsEmployees";

            try
            {
                objCmd.Connection.Open();
                objCmd.ExecuteNonQuery();

                //Get the new row ID created by the table's Identity feature
                if (objParams.Parameters["NewRowID"].Value is DBNull)
                { NewRowID = 0; } //if the insert has failed, then set this to an arbitrary number
                else { NewRowID = (int)objParams.Parameters["NewRowID"].Value; } //else send it back as output

                //Trap or return the Stored Procedure's return code
                intRC = (int)objParams.Parameters["RC"].Value;
                if (intRC < 0)
                { throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString()); }

                objCmd.Connection.Close();
            }
            catch (Exception) { throw; }
            return intRC;
        }

        //private static int EFOption(string EmployeeName, out int NewRowID)
        //{

        //    //Set up the variables
        //    int intRC = 0; //Used to trap the Stored Procedure's return code

        //    //Create a Connection object using Entity Framework (EF)
        //    IObjectContextAdapter Context = new EFDbContext();

        //    //Set up the parameters using my custom parameter factory
        //    IParameterFactory objParams = new EmployeesParameterFactory(EmployeeName: EmployeeName);
        //    //-- Change the RC parameter from ReturnValue to Output, since the EF does not support ReturnValue (Crazy!)
        //    objParams.Parmeters["RC"].Direction = ParameterDirection.Output; 

        //    //Create and configure an ADO.NET command object 
        //    //-- Create a SQL command string
        //    string strSQLCode = @"Exec @RC = pInsEmployees" +
        //                        " @EmployeeName = '" + objParams.Parmeters["EmployeeName"] + "'" + // Don't forget the SINGLE Quotes!!!
        //                        ",@NewRowID = @NewRowID out;";
        //    //configure the command object and execute it
        //    try
        //    {
        //        Context.ObjectContext.ExecuteStoreCommand(strSQLCode
        //                                                    , objParams.Parmeters["RC"]
        //                                                    , objParams.Parmeters["EmployeeName"]
        //                                                    , objParams.Parmeters["NewRowID"]
        //                                                    );

        //        //Get the new row ID created by the table's Identity feature
        //        if (objParams.Parmeters["NewRowID"].Value is DBNull)
        //        { NewRowID = 0; } //if the insert has failed, then set this to an arbitrary number
        //        else { NewRowID = (int)objParams.Parmeters["NewRowID"].Value; } //else send it back as output

        //        //Trap or return the Stored Procedure's return code
        //        intRC = (int)objParams.Parmeters["RC"].Value;
        //        if (intRC < 0)
        //        { throw new Exception("Error reported in Stored Procedure: " + objParams.Parmeters["RC"].Value.ToString()); }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return intRC;
        //}

        public int UpdEmployee(int EmployeeID, string EmployeeName)
        {
            //Set up the variables
            int intRC = 0; //Used to trap the Stored Procedure's return code

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new EmployeesParameterFactory(EmployeeID, EmployeeName);

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        //add parameters to procedure   
                        sqlCommand.Parameters.Add(objParams.Parameters["RC"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["EmployeeID"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["EmployeeName"]);

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pUpdEmployees";

                        sqlCommand.ExecuteNonQuery();

                        //Trap or return the Stored Procedure's return code
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        { 
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString()); 
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return intRC;
        }

        public int DelEmployee(int EmployeeID)
        {
            //Set up the variables
            int intRC = 0; //Used to trap the Stored Procedure's return code

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new EmployeesParameterFactory(EmployeeID);

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        //add parameters to procedure   
                        sqlCommand.Parameters.Add(objParams.Parameters["RC"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["EmployeeID"]);

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pDelEmployees";

                        sqlCommand.ExecuteNonQuery();

                        //Trap or return the Stored Procedure's return code
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return intRC;
        }

        public IEnumerable<Employee> SelEmployee()
        {
            //Set up the variables
            int intRC = 0;
            SqlDataReader dr;
            List<Employee> retVal = new List<Employee>();
            
            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new EmployeesParameterFactory();

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        sqlCommand.Parameters.Add((objParams.Parameters["RC"]));

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pSelEmployees";

                        dr = sqlCommand.ExecuteReader();

                        while (dr.Read())
                        {
                            Employee empl = new Employee();
                            empl.EmployeeID = (int) dr["EmployeeID"];
                            empl.EmployeeName = (string) dr["EmployeeName"];
                            retVal.Add(empl);
                        }
                        dr.Close();

                        //check the return code for errors
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return retVal;
        }

        #endregion

    }

    public class Project: IProjectRepository
    {

        #region fields
        IEnumerable<Project> _projects = new List<Project>();

        int _projectID;

        string _projectName;

        string _projectDescription;

        #endregion

        #region properties

        public IEnumerable<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }

        public int ProjectID
        {
            get { return _projectID; }
            set { _projectID = value; }
        }

        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        public string ProjectDescription
        {
            get { return _projectDescription; }
            set { _projectDescription = value; }
        }

        #endregion

        #region methods
        public int InsProject(string ProjectName, string ProjectDescription, out int NewRowID)
        {
            //Set up the variables
            int intRC = 0; //Used to trap the Stored Procedure's return code

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new ProjectsParameterFactory(ProjectName : ProjectName, ProjectDescription: ProjectDescription);

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        //add parameters to procedure   
                        sqlCommand.Parameters.Add(objParams.Parameters["RC"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["ProjectName"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["ProjectDescription"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["NewRowID"]);

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pInsProjects";

                        sqlCommand.ExecuteNonQuery();

                        //Get the new row ID created by the table's Identity feature
                        if (objParams.Parameters["NewRowID"].Value is DBNull)
                        { NewRowID = 0; } //if the insert has failed, then set this to an arbitrary number
                        else { NewRowID = (int)objParams.Parameters["NewRowID"].Value; } //else send it back as output

                        //Trap or return the Stored Procedure's return code
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return intRC;
        }

        public int UpdProject(int ProjectID, string ProjectName, string ProjectDescription)
        {
            //Set up the variables
            int intRC = 0; //Used to trap the Stored Procedure's return code

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new ProjectsParameterFactory(ProjectID, ProjectName, ProjectDescription);

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        //add parameters to procedure   
                        sqlCommand.Parameters.Add(objParams.Parameters["RC"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["ProjectID"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["ProjectName"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["ProjectDescription"]);

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pUpdProjects";

                        sqlCommand.ExecuteNonQuery();

                        //Trap or return the Stored Procedure's return code
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return intRC;
        }

        public int DelProject(int ProjectID)
        {
            //Set up the variables
            int intRC = 0; //Used to trap the Stored Procedure's return code

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new ProjectsParameterFactory(ProjectID);

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        //add parameters to procedure   
                        sqlCommand.Parameters.Add(objParams.Parameters["RC"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["ProjectID"]);

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pDelProjects";

                        sqlCommand.ExecuteNonQuery();

                        //Trap or return the Stored Procedure's return code
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return intRC;
        }

        public IEnumerable<Project> SelProjects()
        {
            //Set up the variables
            int intRC = 0;
            SqlDataReader dr;
            List<Project> retVal = new List<Project>();

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new ProjectsParameterFactory();

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        sqlCommand.Parameters.Add((objParams.Parameters["RC"]));

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pSelProjects";

                        dr = sqlCommand.ExecuteReader();

                        while (dr.Read())
                        {
                            Project prjt = new Project();
                            prjt.ProjectID = (int)dr["ProjectID"];
                            prjt.ProjectName = (string)dr["ProjectName"];
                            prjt.ProjectDescription = (string)dr["ProjectDescription"];
                            retVal.Add(prjt);
                        }
                        dr.Close();

                        //check the return code for errors
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return retVal;
        }

        #endregion
    }

    public class EmployeeProjectHour: IEmployeeProjectHourRepository
    {

        #region fields
        IEnumerable<EmployeeProjectHour> _employeeProjectHours = new List<EmployeeProjectHour>();

        int _employeeID;

        DateTime _date;

        int _projectID;

        decimal _hours;

        string _employeeName;

        string _projectName;

        #endregion

        #region properties

        public IEnumerable<EmployeeProjectHour> EmployeeProjectHours
        {
            get { return _employeeProjectHours; }
            set { _employeeProjectHours = value; }
        }

        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int ProjectID
        {
            get { return _projectID; }
            set { _projectID = value; }
        }

        public decimal Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        #endregion

        #region methods
        public int InsEmployeeProjectHours(int EmployeeID, int ProjectID, DateTime Date, decimal Hours)
        {
            //Set up the variables
            int intRC = 0; //Used to trap the Stored Procedure's return code

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new EmployeeProjectHourParameterFactory(EmployeeID, String.Empty ,ProjectID,String.Empty , Date,Hours);

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        //add parameters to procedure   
                        sqlCommand.Parameters.Add(objParams.Parameters["RC"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["EmployeeID"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["ProjectID"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["Date"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["Hours"]);

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pInsEmployeeProjectHours";

                        sqlCommand.ExecuteNonQuery();

                        //Trap or return the Stored Procedure's return code
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return intRC;
        }

        public int UpdEmployeeProjectHours(int EmployeeID, int ProjectID, DateTime Date, decimal Hours)
        {
            //Set up the variables
            int intRC = 0; //Used to trap the Stored Procedure's return code

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new EmployeeProjectHourParameterFactory(EmployeeID, String.Empty, ProjectID, String.Empty, Date, Hours);

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        //add parameters to procedure   
                        sqlCommand.Parameters.Add(objParams.Parameters["RC"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["EmployeeID"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["ProjectID"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["Date"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["Hours"]);

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pUpdEmployeeProjectHours";

                        sqlCommand.ExecuteNonQuery();

                        //Trap or return the Stored Procedure's return code
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return intRC;
        }

        public int DelEmployeeProjectHours(int EmployeeID, int ProjectID, DateTime Date)
        {
            //Set up the variables
            int intRC = 0; //Used to trap the Stored Procedure's return code

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new EmployeeProjectHourParameterFactory(EmployeeID, String.Empty, ProjectID, String.Empty, Date, 0);

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        //add parameters to procedure   
                        sqlCommand.Parameters.Add(objParams.Parameters["RC"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["EmployeeID"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["ProjectID"]);
                        sqlCommand.Parameters.Add(objParams.Parameters["Date"]);

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pDelEmployeeProjectHours";

                        sqlCommand.ExecuteNonQuery();

                        //Trap or return the Stored Procedure's return code
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return intRC;
        }

        public IEnumerable<EmployeeProjectHour> SelEmployeeProjectHours()
        {
            //Set up the variables
            int intRC = 0;
            SqlDataReader dr;
            List<EmployeeProjectHour> retVal = new List<EmployeeProjectHour>();

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new EmployeeProjectHourParameterFactory(0, String.Empty, 0, String.Empty, DateTime.Now, 0);

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        sqlCommand.Parameters.Add((objParams.Parameters["RC"]));

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pSelEmployeeProjectHours";

                        dr = sqlCommand.ExecuteReader();

                        while (dr.Read())
                        {
                            EmployeeProjectHour eph = new EmployeeProjectHour();
                            eph.EmployeeID = (int)dr["EmployeeID"];
                            eph.EmployeeName = (string)dr["EmployeeName"];
                            eph.ProjectID = (int)dr["ProjectID"];
                            eph.ProjectName = (string)dr["ProjectName"]; 
                            eph.Date = (DateTime)dr["Date"];
                            eph.Hours = (decimal)dr["Hours"];
                            retVal.Add(eph);
                        }
                        dr.Close();

                        //check the return code for errors
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return retVal;
        }

        #endregion
    }

    public class ThisYearsDate: IThisYearsDateRepository
    {
        #region fields

        IEnumerable<ThisYearsDate> _thisYearsDates = new List<ThisYearsDate>();

        int _dateID;
        string _dateName;

        #endregion

        #region properties
        public IEnumerable<ThisYearsDate> ThisYearsDates
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int DateID
        {
            get
            {
                return _dateID;
            }
            set
            {
                _dateID = value;
            }
        }

        public string DateName
        {
            get
            {
                return _dateName;
            }
            set
            {
                _dateName = value;
            }
        }

        #endregion

        #region methods
        public IEnumerable<ThisYearsDate> SelThisYearsDates()
        {
            //Set up the variables
            int intRC = 0;
            SqlDataReader dr;
            List<ThisYearsDate> retVal = new List<ThisYearsDate>();

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new ThisYearsDateParameterFactory();

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        sqlCommand.Parameters.Add((objParams.Parameters["RC"]));

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pSelThisYearsDates";

                        dr = sqlCommand.ExecuteReader();

                        while (dr.Read())
                        {
                            ThisYearsDate tyd = new ThisYearsDate();
                            tyd._dateID = (int)dr["dateID"];
                            tyd._dateName = (string)dr["dateName"];
                            retVal.Add(tyd);
                        }

                        dr.Close();

                        //check the return code for errors
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return retVal;
        }

        #endregion
    }

    public class ValidHourEntry : IValidHourEntryRepository
    {
        #region fields
        IEnumerable<ValidHourEntry> _validHourEntries = new List<ValidHourEntry>();

        int _timePeriodID;

        string _timePeriod;

        #endregion

        #region properties

        public IEnumerable<ValidHourEntry> ValidHourEntries
        {
            get
            {
                return _validHourEntries;
            }
            set
            {
                _validHourEntries = value;
            }
        }

        public int TimePeriodID
        {
            get
            {
                return _timePeriodID;
            }
            set
            {
                _timePeriodID = value;
            }
        }

        public string TimePeriod
        {
            get
            {
                return _timePeriod;
            }
            set
            {
                _timePeriod = value;
            }
        }

        #endregion

        #region methods

        public IEnumerable<ValidHourEntry> SelValidHourEntries()
        {
            //Set up the variables
            int intRC = 0;
            SqlDataReader dr;
            List<ValidHourEntry> retVal = new List<ValidHourEntry>();

            //Set up the parameters using my custom parameter factory
            IParameterFactory objParams = new ValidHourEntryParameterFactory();

            try
            {
                using (SqlConnection sqlConnection = new ADOConnectionFactory().Connection)
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {

                        sqlCommand.Connection = sqlConnection;

                        sqlCommand.Parameters.Add((objParams.Parameters["RC"]));

                        //call stored procedure to insert record
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pSelValidHours";

                        dr = sqlCommand.ExecuteReader();

                        while (dr.Read())
                        {
                            ValidHourEntry vhe = new ValidHourEntry();
                            vhe.TimePeriodID = (int)dr["TimePeriodID"];
                            vhe.TimePeriod = (string)dr["TimePeriod"];
                            retVal.Add(vhe);
                        }
                        dr.Close();

                        //check the return code for errors
                        intRC = (int)objParams.Parameters["RC"].Value;
                        if (intRC < 0)
                        {
                            throw new Exception("Error reported in Stored Procedure: " + objParams.Parameters["RC"].Value.ToString());
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return retVal;
        }

        #endregion
    }
}
