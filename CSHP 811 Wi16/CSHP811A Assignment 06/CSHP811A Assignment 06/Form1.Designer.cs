namespace CSHP811A_Assignment_06
{
    partial class FormDBQuery
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
            this.tabControlQueries = new System.Windows.Forms.TabControl();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.textBoxInsertCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxInsertCustomerID = new System.Windows.Forms.TextBox();
            this.buttonInsertCustomer = new System.Windows.Forms.Button();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelDeleteCustomerID = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDeleteCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxUpdateCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxUpdateCustomerID = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSelectedData = new System.Windows.Forms.TextBox();
            this.tabControlQueries.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            this.tabPageInsert.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlQueries
            // 
            this.tabControlQueries.Controls.Add(this.tabPageSelect);
            this.tabControlQueries.Controls.Add(this.tabPageInsert);
            this.tabControlQueries.Controls.Add(this.tabPageUpdate);
            this.tabControlQueries.Controls.Add(this.tabPageDelete);
            this.tabControlQueries.Location = new System.Drawing.Point(13, 13);
            this.tabControlQueries.Name = "tabControlQueries";
            this.tabControlQueries.SelectedIndex = 0;
            this.tabControlQueries.Size = new System.Drawing.Size(259, 237);
            this.tabControlQueries.TabIndex = 0;
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.textBoxSelectedData);
            this.tabPageSelect.Controls.Add(this.buttonSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(251, 211);
            this.tabPageSelect.TabIndex = 0;
            this.tabPageSelect.Text = "Select";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.Controls.Add(this.textBoxInsertCustomerName);
            this.tabPageInsert.Controls.Add(this.textBoxInsertCustomerID);
            this.tabPageInsert.Controls.Add(this.buttonInsertCustomer);
            this.tabPageInsert.Controls.Add(this.labelCustomerName);
            this.tabPageInsert.Controls.Add(this.labelCustomerID);
            this.tabPageInsert.Location = new System.Drawing.Point(4, 22);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(251, 211);
            this.tabPageInsert.TabIndex = 1;
            this.tabPageInsert.Text = "Insert";
            this.tabPageInsert.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomerName
            // 
            this.textBoxInsertCustomerName.Location = new System.Drawing.Point(92, 41);
            this.textBoxInsertCustomerName.Name = "textBoxCustomerName";
            this.textBoxInsertCustomerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsertCustomerName.TabIndex = 4;
            // 
            // textBoxCustomerID
            // 
            this.textBoxInsertCustomerID.Location = new System.Drawing.Point(92, 15);
            this.textBoxInsertCustomerID.Name = "textBoxCustomerID";
            this.textBoxInsertCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsertCustomerID.TabIndex = 3;
            // 
            // buttonInsertCustomer
            // 
            this.buttonInsertCustomer.Location = new System.Drawing.Point(10, 81);
            this.buttonInsertCustomer.Name = "buttonInsertCustomer";
            this.buttonInsertCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertCustomer.TabIndex = 2;
            this.buttonInsertCustomer.Text = "Insert";
            this.buttonInsertCustomer.UseVisualStyleBackColor = true;
            this.buttonInsertCustomer.Click += new System.EventHandler(this.buttonInsertCustomer_Click);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(7, 44);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(82, 13);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(7, 18);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(65, 13);
            this.labelCustomerID.TabIndex = 0;
            this.labelCustomerID.Text = "Customer ID";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateCustomerName);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateCustomerID);
            this.tabPageUpdate.Controls.Add(this.buttonUpdate);
            this.tabPageUpdate.Controls.Add(this.label1);
            this.tabPageUpdate.Controls.Add(this.label2);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(251, 211);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.textBoxDeleteCustomerID);
            this.tabPageDelete.Controls.Add(this.buttonDelete);
            this.tabPageDelete.Controls.Add(this.labelDeleteCustomerID);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelete.Size = new System.Drawing.Size(251, 211);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Delete";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(7, 7);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelDeleteCustomerID
            // 
            this.labelDeleteCustomerID.AutoSize = true;
            this.labelDeleteCustomerID.Location = new System.Drawing.Point(7, 9);
            this.labelDeleteCustomerID.Name = "labelDeleteCustomerID";
            this.labelDeleteCustomerID.Size = new System.Drawing.Size(65, 13);
            this.labelDeleteCustomerID.TabIndex = 0;
            this.labelDeleteCustomerID.Text = "Customer ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(10, 38);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDeleteCustomerID
            // 
            this.textBoxDeleteCustomerID.Location = new System.Drawing.Point(78, 6);
            this.textBoxDeleteCustomerID.Name = "textBoxDeleteCustomerID";
            this.textBoxDeleteCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeleteCustomerID.TabIndex = 2;
            // 
            // textBoxUpdateCustomerName
            // 
            this.textBoxUpdateCustomerName.Location = new System.Drawing.Point(119, 41);
            this.textBoxUpdateCustomerName.Name = "textBoxUpdateCustomerName";
            this.textBoxUpdateCustomerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateCustomerName.TabIndex = 9;
            // 
            // textBoxUpdateCustomerID
            // 
            this.textBoxUpdateCustomerID.Location = new System.Drawing.Point(119, 15);
            this.textBoxUpdateCustomerID.Name = "textBoxUpdateCustomerID";
            this.textBoxUpdateCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateCustomerID.TabIndex = 8;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(9, 81);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer ID";
            // 
            // textBoxSelectedData
            // 
            this.textBoxSelectedData.Location = new System.Drawing.Point(7, 37);
            this.textBoxSelectedData.Multiline = true;
            this.textBoxSelectedData.Name = "textBoxSelectedData";
            this.textBoxSelectedData.ReadOnly = true;
            this.textBoxSelectedData.Size = new System.Drawing.Size(238, 168);
            this.textBoxSelectedData.TabIndex = 1;
            // 
            // FormDBQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControlQueries);
            this.Name = "FormDBQuery";
            this.Text = "Database Query";
            this.tabControlQueries.ResumeLayout(false);
            this.tabPageSelect.ResumeLayout(false);
            this.tabPageSelect.PerformLayout();
            this.tabPageInsert.ResumeLayout(false);
            this.tabPageInsert.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlQueries;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.TextBox textBoxInsertCustomerName;
        private System.Windows.Forms.TextBox textBoxInsertCustomerID;
        private System.Windows.Forms.Button buttonInsertCustomer;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxDeleteCustomerID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelDeleteCustomerID;
        private System.Windows.Forms.TextBox textBoxSelectedData;
        private System.Windows.Forms.TextBox textBoxUpdateCustomerName;
        private System.Windows.Forms.TextBox textBoxUpdateCustomerID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

