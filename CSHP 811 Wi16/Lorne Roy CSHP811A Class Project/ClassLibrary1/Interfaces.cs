using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProjectHours
{

    /// <summary>
    /// interface provides lookup data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ILookup<T> where T : class
    {
        IEnumerable<T> List { get; }
    }

    /// <summary>
    /// interface provides repository access
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IRepository<T> where T : class
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Save();
    }

    /// <summary>
    /// interface representing an employee
    /// </summary>
    interface IEmployee
    {
        String EmployeeName { get; set; }
    }

    /// <summary>
    /// interface representing a project
    /// </summary>
    interface IProject
    {
        string ProjectName { get; set; }
        string ProjectDescription { get; set; }
    }

    /// <summary>
    /// inteface representing an entry for employee project hours
    /// </summary>
    interface IEmployeeProjectHours : IProject, IEmployee
    {
        DateTime Date { get; set; }
        decimal Hours { get; set; }
    }

    /// <summary>
    /// interface representing a date entry
    /// </summary>
    interface IThisYearDate
    {
        string Date { get; set; }
    }

    /// <summary>
    /// interface representing a valid hour entry
    /// </summary>
    interface IValidHourEntries
    {
        string TimePeriod { get; set; }
    }

    /// <summary>
    /// interface for Employee Repository
    /// </summary>
    interface IEmployeeRepository : IRepository<IEmployee>
    { }

    /// <summary>
    /// interface for Project Repository
    /// </summary>
    interface IProjectRepository : IRepository<IProject>
    { }

    /// <summary>
    /// interface for Employee Project Hours Repository
    /// </summary>
    interface IEmployeeProjectHoursRepository : IRepository<IEmployeeProjectHours>
    { }

    /// <summary>
    /// interface for This Year Date Lookup
    /// </summary>
    interface IThisYearDateLookup : ILookup<IThisYearDate>
    { }

    /// <summary>
    /// interface for Valid Hour Entries Lookup
    /// </summary>
    interface IValidHourEntriesLookup : ILookup<IValidHourEntries>
    { }


}
