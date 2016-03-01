namespace CustomerSprocDemo
{
    partial class Form1
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
            this.labelInsCustomerId = new System.Windows.Forms.Label();
            this.labelInsCustomerName = new System.Windows.Forms.Label();
            this.textBoxInsCustomerId = new System.Windows.Forms.TextBox();
            this.textBoxInsCustomerName = new System.Windows.Forms.TextBox();
            this.buttonInsCustomerData = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInsCustomerId
            // 
            this.labelInsCustomerId.AutoSize = true;
            this.labelInsCustomerId.Location = new System.Drawing.Point(32, 17);
            this.labelInsCustomerId.Name = "labelInsCustomerId";
            this.labelInsCustomerId.Size = new System.Drawing.Size(63, 13);
            this.labelInsCustomerId.TabIndex = 0;
            this.labelInsCustomerId.Text = "Customer Id";
            this.labelInsCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInsCustomerName
            // 
            this.labelInsCustomerName.AutoSize = true;
            this.labelInsCustomerName.Location = new System.Drawing.Point(13, 41);
            this.labelInsCustomerName.Name = "labelInsCustomerName";
            this.labelInsCustomerName.Size = new System.Drawing.Size(82, 13);
            this.labelInsCustomerName.TabIndex = 1;
            this.labelInsCustomerName.Text = "Customer Name";
            this.labelInsCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxInsCustomerId
            // 
            this.textBoxInsCustomerId.Location = new System.Drawing.Point(101, 14);
            this.textBoxInsCustomerId.Name = "textBoxInsCustomerId";
            this.textBoxInsCustomerId.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsCustomerId.TabIndex = 2;
            // 
            // textBoxInsCustomerName
            // 
            this.textBoxInsCustomerName.Location = new System.Drawing.Point(101, 40);
            this.textBoxInsCustomerName.Name = "textBoxInsCustomerName";
            this.textBoxInsCustomerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsCustomerName.TabIndex = 3;
            // 
            // buttonInsCustomerData
            // 
            this.buttonInsCustomerData.Location = new System.Drawing.Point(20, 77);
            this.buttonInsCustomerData.Name = "buttonInsCustomerData";
            this.buttonInsCustomerData.Size = new System.Drawing.Size(181, 23);
            this.buttonInsCustomerData.TabIndex = 4;
            this.buttonInsCustomerData.Text = "Insert Customer Data";
            this.buttonInsCustomerData.UseVisualStyleBackColor = true;
            this.buttonInsCustomerData.Click += new System.EventHandler(this.buttonInsCustomerData_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSelect);
            this.tabControl1.Controls.Add(this.tabPageInsert);
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Controls.Add(this.tabPageDelete);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(277, 228);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(269, 202);
            this.tabPageSelect.TabIndex = 3;
            this.tabPageSelect.Text = "Select";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.Controls.Add(this.buttonInsCustomerData);
            this.tabPageInsert.Controls.Add(this.textBoxInsCustomerName);
            this.tabPageInsert.Controls.Add(this.labelInsCustomerId);
            this.tabPageInsert.Controls.Add(this.textBoxInsCustomerId);
            this.tabPageInsert.Controls.Add(this.labelInsCustomerName);
            this.tabPageInsert.Location = new System.Drawing.Point(4, 22);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(269, 202);
            this.tabPageInsert.TabIndex = 0;
            this.tabPageInsert.Text = "Insert";
            this.tabPageInsert.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(269, 202);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "Update";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelete.Size = new System.Drawing.Size(269, 202);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "Delete";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 266);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageInsert.ResumeLayout(false);
            this.tabPageInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInsCustomerId;
        private System.Windows.Forms.Label labelInsCustomerName;
        private System.Windows.Forms.TextBox textBoxInsCustomerId;
        private System.Windows.Forms.TextBox textBoxInsCustomerName;
        private System.Windows.Forms.Button buttonInsCustomerData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.TabPage tabPageSelect;
    }
}

