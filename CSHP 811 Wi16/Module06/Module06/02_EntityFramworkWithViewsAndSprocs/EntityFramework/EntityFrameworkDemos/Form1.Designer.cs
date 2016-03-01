namespace EntityFrameworkUIWindows
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSaveToDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBindProductsData = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonSaveToCustomers = new System.Windows.Forms.Button();
            this.radioButtonIns = new System.Windows.Forms.RadioButton();
            this.radioButtonUpd = new System.Windows.Forms.RadioButton();
            this.radioButtonDel = new System.Windows.Forms.RadioButton();
            this.buttonBindCustomersData = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 235);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSaveToDB);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonBindProductsData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Direct to Table (Not Recommend)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSaveToDB
            // 
            this.buttonSaveToDB.Location = new System.Drawing.Point(171, 172);
            this.buttonSaveToDB.Name = "buttonSaveToDB";
            this.buttonSaveToDB.Size = new System.Drawing.Size(182, 23);
            this.buttonSaveToDB.TabIndex = 3;
            this.buttonSaveToDB.Text = "Save Changes To Database";
            this.buttonSaveToDB.UseVisualStyleBackColor = true;
            this.buttonSaveToDB.Click += new System.EventHandler(this.buttonSaveToDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(EntityFrameworkDemosProcessor.Product);
            // 
            // buttonBindProductsData
            // 
            this.buttonBindProductsData.Location = new System.Drawing.Point(17, 172);
            this.buttonBindProductsData.Name = "buttonBindProductsData";
            this.buttonBindProductsData.Size = new System.Drawing.Size(147, 23);
            this.buttonBindProductsData.TabIndex = 1;
            this.buttonBindProductsData.Text = "Bind Products Data";
            this.buttonBindProductsData.UseVisualStyleBackColor = true;
            this.buttonBindProductsData.Click += new System.EventHandler(this.buttonBindProductsData_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonBindCustomersData);
            this.tabPage2.Controls.Add(this.radioButtonDel);
            this.tabPage2.Controls.Add(this.radioButtonUpd);
            this.tabPage2.Controls.Add(this.radioButtonIns);
            this.tabPage2.Controls.Add(this.buttonSaveToCustomers);
            this.tabPage2.Controls.Add(this.labelName);
            this.tabPage2.Controls.Add(this.textBoxName);
            this.tabPage2.Controls.Add(this.textBoxID);
            this.tabPage2.Controls.Add(this.labelID);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "With Abstraction Objects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vCustomerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(247, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // vCustomerBindingSource
            // 
            this.vCustomerBindingSource.DataSource = typeof(EntityFrameworkDemosProcessor.vCustomer);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(276, 17);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID: ";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(318, 17);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(168, 20);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(318, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(276, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // buttonSaveToCustomers
            // 
            this.buttonSaveToCustomers.Location = new System.Drawing.Point(279, 102);
            this.buttonSaveToCustomers.Name = "buttonSaveToCustomers";
            this.buttonSaveToCustomers.Size = new System.Drawing.Size(207, 23);
            this.buttonSaveToCustomers.TabIndex = 5;
            this.buttonSaveToCustomers.Text = "Save To Customers";
            this.buttonSaveToCustomers.UseVisualStyleBackColor = true;
            this.buttonSaveToCustomers.Click += new System.EventHandler(this.buttonSaveToCustomers_Click);
            // 
            // radioButtonIns
            // 
            this.radioButtonIns.AutoSize = true;
            this.radioButtonIns.Location = new System.Drawing.Point(290, 70);
            this.radioButtonIns.Name = "radioButtonIns";
            this.radioButtonIns.Size = new System.Drawing.Size(51, 17);
            this.radioButtonIns.TabIndex = 6;
            this.radioButtonIns.TabStop = true;
            this.radioButtonIns.Text = "Insert";
            this.radioButtonIns.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpd
            // 
            this.radioButtonUpd.AutoSize = true;
            this.radioButtonUpd.Location = new System.Drawing.Point(347, 70);
            this.radioButtonUpd.Name = "radioButtonUpd";
            this.radioButtonUpd.Size = new System.Drawing.Size(60, 17);
            this.radioButtonUpd.TabIndex = 7;
            this.radioButtonUpd.TabStop = true;
            this.radioButtonUpd.Text = "Update";
            this.radioButtonUpd.UseVisualStyleBackColor = true;
            // 
            // radioButtonDel
            // 
            this.radioButtonDel.AutoSize = true;
            this.radioButtonDel.Location = new System.Drawing.Point(413, 70);
            this.radioButtonDel.Name = "radioButtonDel";
            this.radioButtonDel.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDel.TabIndex = 8;
            this.radioButtonDel.TabStop = true;
            this.radioButtonDel.Text = "Delete";
            this.radioButtonDel.UseVisualStyleBackColor = true;
            // 
            // buttonBindCustomersData
            // 
            this.buttonBindCustomersData.Location = new System.Drawing.Point(6, 173);
            this.buttonBindCustomersData.Name = "buttonBindCustomersData";
            this.buttonBindCustomersData.Size = new System.Drawing.Size(247, 23);
            this.buttonBindCustomersData.TabIndex = 9;
            this.buttonBindCustomersData.Text = "Bind Customers Data";
            this.buttonBindCustomersData.UseVisualStyleBackColor = true;
            this.buttonBindCustomersData.Click += new System.EventHandler(this.buttonBindCustomersData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 284);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonBindProductsData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSaveToDB;
        private System.Windows.Forms.Button buttonSaveToCustomers;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vCustomerBindingSource;
        private System.Windows.Forms.RadioButton radioButtonDel;
        private System.Windows.Forms.RadioButton radioButtonUpd;
        private System.Windows.Forms.RadioButton radioButtonIns;
        private System.Windows.Forms.Button buttonBindCustomersData;
    }
}