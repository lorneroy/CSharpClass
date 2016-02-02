using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VendingMachine
{
    public partial class FormServiceNotes : Form
    {

        #region constructors

        public FormServiceNotes()
        {
            InitializeComponent();
        }

        #endregion

        #region methods
        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServiceNotesChild formChild = new FormServiceNotesChild();
            formChild.MdiParent = this;
            formChild.WindowState = FormWindowState.Maximized;
            formChild.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string noteRead = string.Empty;
            string fileName;

            DialogResult result;

            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                result = openFileDialog.ShowDialog();
                fileName = openFileDialog.FileName;
            }

            if (fileName != string.Empty)
            {
                //read the content of the file into a new service note
                //close the file
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {

                    try
                    {
                        StreamReader sr = new StreamReader(fs);
                        noteRead = sr.ReadToEnd();

                    }
                    catch (Exception)
                    {
                        throw new FileLoadException();
                    }

                }

                //open a service note
                FormServiceNotesChild formChild = new FormServiceNotesChild();
                formChild.MdiParent = this;
                formChild.WindowState = FormWindowState.Maximized;
                formChild.serviceNote = noteRead;
                formChild.Show();
                //?save that filename for the save dialog?

            }
            else 
            {
                //no file selected
                //throw new FileNotFoundException();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //file name returned by save file dialog
            string fileName = string.Empty;
            
            //save file dialog result
            DialogResult result;
            
            //note to write to file
            string note;

            //try to write the text of the currently active child to the selected file
            FormServiceNotesChild activeChild = (FormServiceNotesChild)this.ActiveMdiChild;


            note = activeChild.serviceNote;

            if (activeChild != null)
            {

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.CheckFileExists = false;
                    result = saveFileDialog.ShowDialog();
                    fileName = saveFileDialog.FileName;
                    
                }

                if (result == DialogResult.OK)
                {
                    if (fileName != string.Empty)
                    {
                        //try to write the content to the file
                        using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            using (StreamWriter sr = new StreamWriter(fs))
                            {
                                sr.Write(note);
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a note");
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null)
            {
                activeChild.Close();
            }
        }

        #endregion
    }
}
        