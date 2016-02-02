using System;

namespace MyDataStorageAndProcessing
{

    public class Task // This class primarily STORES data
    {
        string _TaskDescription;

        //In this type of class the properties are its focus
        public string TaskDescription //add validation and formatting code
        {
            get { return _TaskDescription; }
            set { _TaskDescription = value; }
        }

        public override string ToString()
        {
            return TaskDescription;
        }
    }
}
