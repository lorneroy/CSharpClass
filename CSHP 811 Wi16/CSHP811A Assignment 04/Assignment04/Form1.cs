using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment04
{
    public partial class FormDataEntry : Form
    {

        private List<Person> _persons;

        public FormDataEntry()
        {
            InitializeComponent();

            //create person array
            //Person[] Persons = new Person[];
            _persons = new List<Person>();
        }

        private void buttonSaveToArray_Click(object sender, EventArgs e)
        {
            //add the person in the active tab to the array
            if (tabControlPersons.SelectedTab == tabPageCustomers)
            {
                Customer customer = new Customer();
                customer.CustomerId = Int32.Parse(textBoxCustomerID.Text);
                customer.Name = textBoxCustomerName.Text;
                customer.DOB = DateTime.Parse(textBoxCustomerDOB.Text);
                customer.Gender = (Gender)Enum.Parse(typeof(Gender),textBoxCustomerGender.Text);

                _persons.Add(customer);

            }
            else if (tabControlPersons.SelectedTab == tabPageEmployees)
            {
                Employee employee = new Employee();
                employee.EmployeeId = Int32.Parse(textBoxEmployeeID.Text);
                employee.Name = textBoxEmployeeName.Text;
                employee.DOB = DateTime.Parse(textBoxEmployeeDOB.Text);
                employee.Gender = (Gender)Enum.Parse(typeof(Gender),textBoxEmployeeGender.Text);

                _persons.Add(employee);
            }
            else
            {
                //uh oh!
                throw new Exception("unexpected tab page selection");
            }
            //clear the fields
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            string DataFilePath;

            //open a dialog box to select a text file
            OpenFileDialog dataFileDialog = new OpenFileDialog();

            dataFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            dataFileDialog.FilterIndex = 1;
            dataFileDialog.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult result = dataFileDialog.ShowDialog();

            // Process input if the user clicked OK.
            if (result == DialogResult.OK)
            {
                DataFilePath = dataFileDialog.FileName;

                //save the person array to a file
                FileAccess fa = new FileAccess(DataFilePath);

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //foreach person in persons
                foreach (Person person in _persons)
                {
                    sb.AppendLine(person.GetData());
                }
                fa.SaveToFile(sb.ToString());


            }
        }
    }
}
