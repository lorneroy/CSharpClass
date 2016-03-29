
using System;
using System.Collections.Generic;

namespace EmployeeProjectHours
{
    class EmployeeRepository : IEmployeeRepository
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties
        public IEnumerable<IEmployee> List
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region constructors

        public EmployeeRepository()
        {

        }
        #endregion

        #region methods

        public void Add(IEmployee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEmployee entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEmployee entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        #endregion

    }

    class ProjectRepository : IProjectRepository
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties

        public IEnumerable<IProject> List
        {
            get { throw new NotImplementedException(); }
        }


        #endregion

        #region constructors

        public ProjectRepository()
        {

        }
        #endregion

        #region methods

        public void Add(IProject entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IProject entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IProject entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    class EmployeeProjectHoursRepository : IEmployeeProjectHoursRepository
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties
        public IEnumerable<IEmployeeProjectHours> List
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region constructors

        public EmployeeProjectHoursRepository()
        {

        }
        #endregion

        #region methods


        public void Add(IEmployeeProjectHours entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEmployeeProjectHours entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEmployeeProjectHours entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
        #endregion

    }


    class ThisYearDateLookup : IThisYearDateLookup
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties
        public IEnumerable<IThisYearDate> List
        {
            get { throw new NotImplementedException(); }
        }
        #endregion

        #region constructors

        public ThisYearDateLookup()
        {

        }
        #endregion

        #region methods

        #endregion

    }


    class ValidHourEntriesLookup : IValidHourEntriesLookup
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties
        public IEnumerable<IValidHourEntries> List
        {
            get { throw new NotImplementedException(); }
        }
        #endregion

        #region constructors

        public ValidHourEntriesLookup()
        {

        }
        #endregion

        #region methods


        #endregion



    }

}
