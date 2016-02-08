using System;

namespace FileAccess
{
    public class FileAccess
    {
        #region fields
        string _filePath;

        #endregion

        #region properties

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        #endregion

        #region constructors

        public FileAccess(string filePath)
        {
            FilePath = filePath;
        }

        #endregion

        #region methods

        
        public void SaveToFile(string Data)
        {
            try
            {
                System.IO.StreamWriter objSW;
                objSW = new System.IO.StreamWriter(FilePath);
                objSW.WriteLine(Data);
                objSW.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}
