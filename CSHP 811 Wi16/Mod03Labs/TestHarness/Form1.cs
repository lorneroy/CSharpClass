using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHarness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDataStorageAndProcessing.Task task = new MyDataStorageAndProcessing.Task();
            task.TaskDescription = "hello";

            MyDataStorageAndProcessing.FileProcessor fp = new MyDataStorageAndProcessing.FileProcessor();

            fp.SaveToFile(task.ToString());

            MessageBox.Show(task.ToString());


        }
    }
}
