using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InheritanceAndPolymorphismDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Inheritance and objects
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Person objP1;
                /* You cannot make a person object when the class is marked abstract. */
                //objP1 = new Person();


                /* But, can you make a variable of the abstract class that points to a object? */
                objP1 = new Employee();
                //or
                objP1 = new Customer();

                //This connects the event to a method
                objP1.NameChanged += new EventHandler(objP1_NameChanged);

                //Set the properties
                objP1.Name = "Bob Smith";
                objP1.DOB = Convert.ToDateTime("01/01/1980");
                objP1.Gender = Gender.Male;

                //Use a method
                MessageBox.Show(objP1.GetData());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //an event handler
        void objP1_NameChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Note: the name has been changed!");
        }

        //a more typical way to create a customer object        
        private void button2_Click(object sender, EventArgs e)
        {
            Customer objC1 = new Customer();
            objC1.CustomerId = 1;
            objC1.Name = "Sue Jones";
            objC1.DOB = DateTime.Parse("1/1/1980");
            objC1.Gender = Gender.Female;

            MessageBox.Show(objC1.GetData());
        }

        //a more typical way to create employee objects       
        private void button3_Click(object sender, EventArgs e)
        {
            Employee objE1 = new Employee();
            objE1.EmployeeId = 1;
            objE1.Name = "Tim Thomas";
            objE1.DOB = DateTime.Parse("1/1/1980");
            objE1.Gender = Gender.Male;

            MessageBox.Show(objE1.GetData());

            Employee objE2 = new Employee(2, "Jill James", DateTime.Parse("1/2/1990"), Gender.Female);
            MessageBox.Show(objE2.GetData());
        }


        // Creating an array of objects with a parent class variable
        private void button4_Click(object sender, EventArgs e)
        {

            Customer objC1 = new Customer();
            objC1.CustomerId = 1;
            objC1.Name = "Sue Jones";
            objC1.DOB = DateTime.Parse("1/1/1980");
            objC1.Gender = Gender.Female;

            Employee objE1 = new Employee();
            objE1.EmployeeId = 1;
            objE1.Name = "Tim Thomas";
            objE1.DOB = DateTime.Parse("1/1/1980");
            objE1.Gender = Gender.Male;

            Person[] arrPersons = { objC1, objE1 };

            foreach (Person item in arrPersons)
            {
                MessageBox.Show(item.GetData());

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter objSW;
            objSW = new System.IO.StreamWriter("Data.txt");
            objSW.WriteLine("Bob,Smith,123 main street,Seattle,WA");
            objSW.Close();
        }

    }
}
