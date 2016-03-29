using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace Safety_System_HQN_Crawler
{
    class Program
    {
        /// <summary>
        /// read the hqn xml files from a directory and write the content to a 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //input a directory
            string input_directory = @"C:\Temp\";
            DirectoryInfo di = new System.IO.DirectoryInfo(input_directory);

            //for each XML file in the directory
            foreach (FileInfo xmlFile in di.GetFiles(".xml"))
            {

                //read the values associated with the input var_names
                //xmlFile.
                //write each value to the csv file, separate with commas

                //close the file
            }
        }

        private DataSet ExtractVarValues(string inputDirectory)
        {
            try
            {
                FileInfo xmlFilePath = new FileInfo(XMLFilePath);
                //open the file
                XDocument xdoc = XDocument.Load(xmlFilePath.FullName);

                //read the XML 
                //if it meets schema

                string columns = String.Empty;
                string values = String.Empty;

                foreach (var lmnt in xdoc.Root.Element("var").Elements())
                {
                    if (columns != String.Empty)
                    {
                        columns += ",";
                        values += ",";
                    }
                    columns += lmnt.Name;
                    values += "'" + lmnt.Value + "'";
                }
            }

            catch (Exception ex)
            {
                //writeExceptionToEventLog(ex);
                throw ex;
            }
            finally
            {
            }

        }

    }


}
