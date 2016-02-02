using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class FormServiceNotesChild : Form
    {
        public string serviceNote
        {
            get 
            {
                 return textBoxServiceNote.Text;
            }
            set
            {
                textBoxServiceNote.Text = value; 
            }
        }

        public FormServiceNotesChild()
        {
            InitializeComponent();
            //this.MdiParent = FormServiceNotes;
        }
    }
}
