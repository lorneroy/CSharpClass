using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccessLayer;
using System.Collections;

namespace EmployeeProjectsManager
{
    public partial class FormManager : Form
    {

        #region fields
        List<EmployeeProjectHour> eph;
        EmployeeProjectHour objEPH;

        List<Employee> listEmployee;
        Employee empl;

        List<Project> listProject;
        Project prjt;
        #endregion

        #region constructors
        public FormManager()
        {
            InitializeComponent();

            eph = new List<EmployeeProjectHour>();
            objEPH = new EmployeeProjectHour();

            listEmployee = new List<Employee>();
            empl = new Employee();

            listProject = new List<Project>();
            prjt = new Project();

        }

        #endregion

        #region methods

        #region menu controls

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshEphControls();
        }

        private void aboutEmployeeProjectsManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Project Form" + Environment.NewLine + "Lorne Roy" + Environment.NewLine + "Class Project, Winter 2016");
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manual mn = new Manual();
            mn.Show();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //select the employee project hour tab
            tabControlDataEntry.SelectedTab = tabPageEPH;
            //select the add radio button
            radioButtonEphAdd.Select();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //select the employee project hour tab
            tabControlDataEntry.SelectedTab = tabPageEPH;
            //select the update radio button
            radioButtonEphChng.Select();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //select the employee project hour tab
            tabControlDataEntry.SelectedTab = tabPageEPH;
            //select the delete radio button
            radioButtonEphDel.Select();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //select the employee tab
            tabControlDataEntry.SelectedTab = tabPageE;
            //select the radio button
            radioButtonEmplAdd.Select();

        }

        private void changeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //select the employee tab
            tabControlDataEntry.SelectedTab = tabPageE;
            //select the radio button
            radioButtonEmplChng.Select();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //select the employee tab
            tabControlDataEntry.SelectedTab = tabPageE;
            //select the radio button
            radioButtonEmplDel.Select();
        }

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //select the project tab
            tabControlDataEntry.SelectedTab = tabPageP;
            //select the radio button
            radioButtonProjAdd.Select();
        }

        private void changeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //select the project tab
            tabControlDataEntry.SelectedTab = tabPageP;
            //select the radio button
            radioButtonProjChng.Select();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //select the project tab
            tabControlDataEntry.SelectedTab = tabPageP;
            //select the radio button
            radioButtonProjDel.Select();
        }


        #endregion


        #region tabPageEph Controls

        private void tabPageEPH_Enter(object sender, EventArgs e)
        {

            refreshEphControls();

        }

        //private void radioButtonEphAdd_CheckedChanged(object sender, EventArgs e)
        //{
        //    //show or hide controls based on selection
        //    if (radioButtonEphAdd.Checked)
        //    {
        //        comboBoxEphEmployeeId.Visible = true;
        //        comboBoxEphProjectId.Visible = true;
        //        comboBoxEphHours.Visible = true;
        //        dateTimePickerEph.Visible = true;

        //    }
        //}

        //private void radioButtonEphChng_CheckedChanged(object sender, EventArgs e)
        //{
        //    //show or hide controls based on selection
        //    if (radioButtonEphChng.Checked)
        //    {
        //        comboBoxEphEmployeeId.Visible = true;
        //        comboBoxEphProjectId.Visible = true;
        //        comboBoxEphHours.Visible = true;
        //        dateTimePickerEph.Visible = true;

        //    }
        //}

        //private void radioButtonEphDel_CheckedChanged(object sender, EventArgs e)
        //{
        //    //show or hide controls based on selection
        //    if (radioButtonEphDel.Checked)
        //    {
        //        comboBoxEphEmployeeId.Visible = true;
        //        comboBoxEphProjectId.Visible = true;
        //        comboBoxEphHours.Visible = false;
        //        dateTimePickerEph.Visible = true;

        //    }
        //}

        private void dataGridViewEPH_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEPH.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewEPH.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewEPH.Rows[selectedrowindex];

                comboBoxEphEmployeeId.Text = Convert.ToString(selectedRow.Cells["EmployeeID"].Value);

                comboBoxEphProjectId.Text = Convert.ToString(selectedRow.Cells["ProjectID"].Value);

                comboBoxEphHours.Text = Convert.ToString(selectedRow.Cells["Hours"].Value);

                dateTimePickerEph.Value = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
            }
        }

        private void buttonEphApply_Click(object sender, EventArgs e)
        {
            try
            {

                int employeeID = Convert.ToInt32(comboBoxEphEmployeeId.Text);
                int projectID = Convert.ToInt32(comboBoxEphProjectId.Text);
                DateTime dt = dateTimePickerEph.Value;
                decimal hours = Convert.ToDecimal(comboBoxEphHours.Text);

                if (radioButtonEphAdd.Checked)
                {
                    objEPH.InsEmployeeProjectHour(employeeID, projectID, dt, hours);
                }
                else if (radioButtonEphChng.Checked)
                {
                    objEPH.UpdEmployeeProjectHour(employeeID, projectID, dt, hours);
                }
                else if (radioButtonEphDel.Checked)
                {
                    objEPH.DelEmployeeProjectHour(employeeID, projectID, dt);
                }
                else
                {
                    //do nothing
                }
                refreshEphControls();

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void refreshEphControls()
        {
            try
            {

            eph = objEPH.SelEmployeeProjectHour().ToList();
            dataGridViewEPH.DataSource = eph;

            comboBoxEphEmployeeId.DataSource = eph;// eph.Select(x => x.EmployeeID).Distinct(); ;
            comboBoxEphEmployeeId.DisplayMember = "EmployeeID";

            comboBoxEphProjectId.DataSource = eph;
            comboBoxEphProjectId.DisplayMember = "ProjectID";

            comboBoxEphHours.DataSource = new ValidHourEntry().SelValidHourEntries().ToList();
            comboBoxEphHours.DisplayMember = "TimePeriod";

            }
            catch (Exception)
            {
                MessageBox.Show("Error Refreshing Data");
            }
        }

        #endregion

        #region tabPageE controls

        private void tabPageE_Enter(object sender, EventArgs e)
        {
            refreshEmplControls();
            
        }

        //private void dataGridViewE_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dataGridViewE.SelectedCells.Count > 0)
        //    {
        //        int selectedRowIndex = dataGridViewE.SelectedCells[0].RowIndex;

        //        DataGridViewRow selectedRow = dataGridViewE.Rows[selectedRowIndex];

        //        comboBoxEmplId.Text = Convert.ToString(selectedRow.Cells["EmployeeID"].Value);

        //        comboBoxEmployeeName.Text = Convert.ToString(selectedRow.Cells["EmployeeName"].Value);
        //    }

        //}

        private void buttonEmplApply_Click(object sender, EventArgs e)
        {
            try
            {

                int employeeID = Convert.ToInt32(comboBoxEmplId.Text);
                string employeeName = comboBoxEmployeeName.Text;

                if (radioButtonEmplAdd.Checked)
                {
                    empl.InsEmployee(comboBoxEmployeeName.Text, out employeeID);
                }
                else if (radioButtonEmplChng.Checked)
                {
                    empl.UpdEmployee(employeeID, employeeName);
                }
                else if (radioButtonEmplDel.Checked)
                {
                    empl.DelEmployee(employeeID);
                }
                else
                {
                    //do nothing
                }
                refreshEmplControls();

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void refreshEmplControls()
        {

            try
            {

                listEmployee = empl.SelEmployee().ToList();
                dataGridViewE.DataSource = listEmployee;

                comboBoxEmplId.DataSource = listEmployee;
                comboBoxEmplId.DisplayMember = "EmployeeID";

                comboBoxEmployeeName.DataSource = listEmployee;
                comboBoxEmployeeName.DisplayMember = "EmployeeName";

            }
            catch (Exception)
            {
                MessageBox.Show("Error Refreshing Data");
            }
        }


        #endregion

        #region tabPageP controls

        private void tabPageP_Enter(object sender, EventArgs e)
        {
            refreshProjectControls();

        }

        private void refreshProjectControls()
        {
            try
            {
                listProject = prjt.SelProject().ToList();
                dataGridViewP.DataSource = listProject;

                comboBoxProjectID.DataSource = listProject;
                comboBoxProjectID.DisplayMember = "ProjectID";

                comboBoxProjectName.DataSource = listProject;
                comboBoxProjectName.DisplayMember = "ProjectName";

                comboBoxProjectDescription.DataSource = listProject;
                comboBoxProjectDescription.DisplayMember = "ProjectDescription";
            }
            catch (Exception)
            {
                MessageBox.Show("Error Refreshing Data");
            }

        
        }

        private void buttonProjApply_Click(object sender, EventArgs e)
        {
            try
            {

                int projectID = Convert.ToInt32(comboBoxProjectID.Text);
                string projectName = comboBoxProjectName.Text;
                string projectDescription = comboBoxProjectDescription.Text;

                if (radioButtonProjAdd.Checked)
                {
                    prjt.InsProject(projectName,projectDescription,out projectID);
                }
                else if (radioButtonProjChng.Checked)
                {
                    prjt.UpdProject(projectID, projectName, projectDescription);
                }
                else if (radioButtonProjDel.Checked)
                {
                    prjt.DelProject(projectID);
                }
                else
                {
                    //do nothing
                }
                refreshProjectControls();

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        #endregion

        //private void dataGridViewP_SelectionChanged(object sender, EventArgs e)
        //{

        //}




        #endregion

    }
}
