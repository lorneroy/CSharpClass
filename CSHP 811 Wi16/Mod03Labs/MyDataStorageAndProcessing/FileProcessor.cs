using System;

namespace MyDataStorageAndProcessing
{
    public class FileProcessor // This class primarily PROCESSES data
    {
        string _Data;

        public string Data //add validation and formatting code
        {
            get { return _Data; }
            set { _Data = value; }
        }

        //In this type of class the methods are its focus
        public void SaveToFile(string Data)
        {
            try
            {
                this.Data = Data;

                System.IO.StreamWriter objSW;
                objSW = new System.IO.StreamWriter("Data.txt");
                objSW.WriteLine(this.Data);
                objSW.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
