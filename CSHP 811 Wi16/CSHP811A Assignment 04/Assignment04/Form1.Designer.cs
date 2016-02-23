namespace Assignment04
{
    partial class FormDataEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlPersons = new System.Windows.Forms.TabControl();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.buttonSaveToArray = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelEmployeeDOB = new System.Windows.Forms.Label();
            this.labelEmployeeGender = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeDOB = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeGender = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerDOB = new System.Windows.Forms.Label();
            this.labelCustomerGender = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerDOB = new System.Windows.Forms.TextBox();
            this.textBoxCustomerGender = new System.Windows.Forms.TextBox();
            this.tabControlPersons.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            this.tabPageEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPersons
            // 
            this.tabControlPersons.Controls.Add(this.tabPageCustomers);
            this.tabControlPersons.Controls.Add(this.tabPageEmployees);
            this.tabControlPersons.Location = new System.Drawing.Point(12, 38);
            this.tabControlPersons.Name = "tabControlPersons";
            this.tabControlPersons.SelectedIndex = 0;
            this.tabControlPersons.Size = new System.Drawing.Size(259, 209);
            this.tabControlPersons.TabIndex = 0;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.textBoxCustomerGender);
            this.tabPageCustomers.Controls.Add(this.textBoxCustomerDOB);
            this.tabPageCustomers.Controls.Add(this.textBoxCustomerName);
            this.tabPageCustomers.Controls.Add(this.textBoxCustomerID);
            this.tabPageCustomers.Controls.Add(this.labelCustomerGender);
            this.tabPageCustomers.Controls.Add(this.labelCustomerDOB);
            this.tabPageCustomers.Controls.Add(this.labelCustomerName);
            this.tabPageCustomers.Controls.Add(this.labelCustomerID);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(251, 183);
            this.tabPageCustomers.TabIndex = 0;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Controls.Add(this.textBoxEmployeeGender);
            this.tabPageEmployees.Controls.Add(this.textBoxEmployeeDOB);
            this.tabPageEmployees.Controls.Add(this.textBoxEmployeeName);
            this.tabPageEmployees.Controls.Add(this.textBoxEmployeeID);
            this.tabPageEmployees.Controls.Add(this.labelEmployeeGender);
            this.tabPageEmployees.Controls.Add(this.labelEmployeeDOB);
            this.tabPageEmployees.Controls.Add(this.labelEmployeeName);
            this.tabPageEmployees.Controls.Add(this.labelEmployeeID);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(251, 183);
            this.tabPageEmployees.TabIndex = 1;
            this.tabPageEmployees.Text = "Employees";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonSaveToArray
            // 
            this.buttonSaveToArray.Location = new System.Drawing.Point(12, 9);
            this.buttonSaveToArray.Name = "buttonSaveToArray";
            this.buttonSaveToArray.Size = new System.Drawing.Size(112, 23);
            this.buttonSaveToArray.TabIndex = 1;
            this.buttonSaveToArray.Text = "Save to Array";
            this.buttonSaveToArray.UseVisualStyleBackColor = true;
            this.buttonSaveToArray.Click += new System.EventHandler(this.buttonSaveToArray_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(16, 254);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveToFile.TabIndex = 2;
            this.buttonSaveToFile.Text = "Save to File";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Location = new System.Drawing.Point(56, 11);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(18, 13);
            this.labelEmployeeID.TabIndex = 0;
            this.labelEmployeeID.Text = "ID";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Location = new System.Drawing.Point(39, 38);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(35, 13);
            this.labelEmployeeName.TabIndex = 1;
            this.labelEmployeeName.Text = "Name";
            // 
            // labelEmployeeDOB
            // 
            this.labelEmployeeDOB.AutoSize = true;
            this.labelEmployeeDOB.Location = new System.Drawing.Point(8, 65);
            this.labelEmployeeDOB.Name = "labelEmployeeDOB";
            this.labelEmployeeDOB.Size = new System.Drawing.Size(66, 13);
            this.labelEmployeeDOB.TabIndex = 2;
            this.labelEmployeeDOB.Text = "Date of Birth";
            // 
            // labelEmployeeGender
            // 
            this.labelEmployeeGender.AutoSize = true;
            this.labelEmployeeGender.Location = new System.Drawing.Point(32, 92);
            this.labelEmployeeGender.Name = "labelEmployeeGender";
            this.labelEmployeeGender.Size = new System.Drawing.Size(42, 13);
            this.labelEmployeeGender.TabIndex = 3;
            this.labelEmployeeGender.Text = "Gender";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(80, 11);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmployeeID.TabIndex = 4;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(80, 38);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmployeeName.TabIndex = 5;
            // 
            // textBoxEmployeeDOB
            // 
            this.textBoxEmployeeDOB.Location = new System.Drawing.Point(80, 65);
            this.textBoxEmployeeDOB.Name = "textBoxEmployeeDOB";
            this.textBoxEmployeeDOB.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmployeeDOB.TabIndex = 6;
            // 
            // textBoxEmployeeGender
            // 
            this.textBoxEmployeeGender.Location = new System.Drawing.Point(80, 92);
            this.textBoxEmployeeGender.Name = "textBoxEmployeeGender";
            this.textBoxEmployeeGender.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmployeeGender.TabIndex = 7;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(55, 9);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(18, 13);
            this.labelCustomerID.TabIndex = 0;
            this.labelCustomerID.Text = "ID";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(38, 36);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(35, 13);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Name";
            this.labelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomerDOB
            // 
            this.labelCustomerDOB.AutoSize = true;
            this.labelCustomerDOB.Location = new System.Drawing.Point(7, 63);
            this.labelCustomerDOB.Name = "labelCustomerDOB";
            this.labelCustomerDOB.Size = new System.Drawing.Size(66, 13);
            this.labelCustomerDOB.TabIndex = 2;
            this.labelCustomerDOB.Text = "Date of Birth";
            // 
            // labelCustomerGender
            // 
            this.labelCustomerGender.AutoSize = true;
            this.labelCustomerGender.Location = new System.Drawing.Point(31, 90);
            this.labelCustomerGender.Name = "labelCustomerGender";
            this.labelCustomerGender.Size = new System.Drawing.Size(42, 13);
            this.labelCustomerGender.TabIndex = 3;
            this.labelCustomerGender.Text = "Gender";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(79, 6);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerID.TabIndex = 4;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(79, 33);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerName.TabIndex = 5;
            // 
            // textBoxCustomerDOB
            // 
            this.textBoxCustomerDOB.Location = new System.Drawing.Point(79, 60);
            this.textBoxCustomerDOB.Name = "textBoxCustomerDOB";
            this.textBoxCustomerDOB.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerDOB.TabIndex = 6;
            // 
            // textBoxCustomerGender
            // 
            this.textBoxCustomerGender.Location = new System.Drawing.Point(79, 87);
            this.textBoxCustomerGender.Name = "textBoxCustomerGender";
            this.textBoxCustomerGender.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerGender.TabIndex = 7;
            // 
            // FormDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonSaveToArray);
            this.Controls.Add(this.tabControlPersons);
            this.Name = "FormDataEntry";
            this.Text = "Data Entry Form";
            this.tabControlPersons.ResumeLayout(false);
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPersons;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.Button buttonSaveToArray;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.TextBox textBoxCustomerGender;
        private System.Windows.Forms.TextBox textBoxCustomerDOB;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label labelCustomerGender;
        private System.Windows.Forms.Label labelCustomerDOB;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.TextBox textBoxEmployeeGender;
        private System.Windows.Forms.TextBox textBoxEmployeeDOB;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Label labelEmployeeGender;
        private System.Windows.Forms.Label labelEmployeeDOB;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label labelEmployeeID;
    }
}

