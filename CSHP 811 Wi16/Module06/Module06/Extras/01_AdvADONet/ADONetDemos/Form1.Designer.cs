namespace ADONetDemos
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
            this.buttonCommand = new System.Windows.Forms.Button();
            this.buttonDataReader = new System.Windows.Forms.Button();
            this.buttonDataAdapter = new System.Windows.Forms.Button();
            this.buttonDataSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonParameters = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetConnectionString = new System.Windows.Forms.Button();
            this.buttonInfoMessage = new System.Windows.Forms.Button();
            this.groupBoxConnections = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxCommands = new System.Windows.Forms.GroupBox();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxConnections.SuspendLayout();
            this.groupBoxCommands.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(22, 19);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(267, 23);
            this.buttonCommand.TabIndex = 1;
            this.buttonCommand.Text = "Command";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // buttonDataReader
            // 
            this.buttonDataReader.Location = new System.Drawing.Point(21, 19);
            this.buttonDataReader.Name = "buttonDataReader";
            this.buttonDataReader.Size = new System.Drawing.Size(167, 23);
            this.buttonDataReader.TabIndex = 2;
            this.buttonDataReader.Text = "DataReader";
            this.buttonDataReader.UseVisualStyleBackColor = true;
            this.buttonDataReader.Click += new System.EventHandler(this.buttonDataReader_Click);
            // 
            // buttonDataAdapter
            // 
            this.buttonDataAdapter.Location = new System.Drawing.Point(21, 81);
            this.buttonDataAdapter.Name = "buttonDataAdapter";
            this.buttonDataAdapter.Size = new System.Drawing.Size(167, 23);
            this.buttonDataAdapter.TabIndex = 3;
            this.buttonDataAdapter.Text = "DataAdapter";
            this.buttonDataAdapter.UseVisualStyleBackColor = true;
            this.buttonDataAdapter.Click += new System.EventHandler(this.buttonDataAdapter_Click);
            // 
            // buttonDataSet
            // 
            this.buttonDataSet.Location = new System.Drawing.Point(21, 110);
            this.buttonDataSet.Name = "buttonDataSet";
            this.buttonDataSet.Size = new System.Drawing.Size(167, 23);
            this.buttonDataSet.TabIndex = 4;
            this.buttonDataSet.Text = "DataSet";
            this.buttonDataSet.UseVisualStyleBackColor = true;
            this.buttonDataSet.Click += new System.EventHandler(this.buttonDataSet_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note: You use the DataReader or the DataAdapter but not both.";
            // 
            // buttonParameters
            // 
            this.buttonParameters.Location = new System.Drawing.Point(22, 48);
            this.buttonParameters.Name = "buttonParameters";
            this.buttonParameters.Size = new System.Drawing.Size(267, 23);
            this.buttonParameters.TabIndex = 6;
            this.buttonParameters.Text = "Parameters";
            this.buttonParameters.UseVisualStyleBackColor = true;
            this.buttonParameters.Click += new System.EventHandler(this.buttonParameters_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "4";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // buttonSetConnectionString
            // 
            this.buttonSetConnectionString.Location = new System.Drawing.Point(18, 60);
            this.buttonSetConnectionString.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetConnectionString.Name = "buttonSetConnectionString";
            this.buttonSetConnectionString.Size = new System.Drawing.Size(189, 24);
            this.buttonSetConnectionString.TabIndex = 10;
            this.buttonSetConnectionString.Text = "Set Connection String";
            this.buttonSetConnectionString.UseVisualStyleBackColor = true;
            this.buttonSetConnectionString.Click += new System.EventHandler(this.buttonSetConnectionString_Click);
            // 
            // buttonInfoMessage
            // 
            this.buttonInfoMessage.Location = new System.Drawing.Point(18, 89);
            this.buttonInfoMessage.Name = "buttonInfoMessage";
            this.buttonInfoMessage.Size = new System.Drawing.Size(266, 23);
            this.buttonInfoMessage.TabIndex = 0;
            this.buttonInfoMessage.Text = "Info Messages";
            this.buttonInfoMessage.UseVisualStyleBackColor = true;
            this.buttonInfoMessage.Click += new System.EventHandler(this.buttonInfoMessage_Click);
            // 
            // groupBoxConnections
            // 
            this.groupBoxConnections.Controls.Add(this.listBox1);
            this.groupBoxConnections.Controls.Add(this.buttonInfoMessage);
            this.groupBoxConnections.Controls.Add(this.buttonSetConnectionString);
            this.groupBoxConnections.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnections.Name = "groupBoxConnections";
            this.groupBoxConnections.Size = new System.Drawing.Size(328, 134);
            this.groupBoxConnections.TabIndex = 15;
            this.groupBoxConnections.TabStop = false;
            this.groupBoxConnections.Text = "Make a Connection Tasks";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "ODBC",
            "OleDB",
            "SqlClient"});
            this.listBox1.Location = new System.Drawing.Point(217, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(67, 43);
            this.listBox1.TabIndex = 15;
            // 
            // groupBoxCommands
            // 
            this.groupBoxCommands.Controls.Add(this.buttonCommand);
            this.groupBoxCommands.Controls.Add(this.buttonParameters);
            this.groupBoxCommands.Controls.Add(this.textBox1);
            this.groupBoxCommands.Controls.Add(this.label2);
            this.groupBoxCommands.Controls.Add(this.textBox2);
            this.groupBoxCommands.Location = new System.Drawing.Point(8, 165);
            this.groupBoxCommands.Name = "groupBoxCommands";
            this.groupBoxCommands.Size = new System.Drawing.Size(332, 127);
            this.groupBoxCommands.TabIndex = 15;
            this.groupBoxCommands.TabStop = false;
            this.groupBoxCommands.Text = "Issue a Command Tasks";
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.comboBox3);
            this.groupBoxResults.Controls.Add(this.comboBox2);
            this.groupBoxResults.Controls.Add(this.comboBox1);
            this.groupBoxResults.Controls.Add(this.buttonDataReader);
            this.groupBoxResults.Controls.Add(this.buttonDataAdapter);
            this.groupBoxResults.Controls.Add(this.buttonDataSet);
            this.groupBoxResults.Controls.Add(this.label1);
            this.groupBoxResults.Location = new System.Drawing.Point(8, 312);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(332, 145);
            this.groupBoxResults.TabIndex = 16;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Process the Results Tasks";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(195, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(195, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 469);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.groupBoxCommands);
            this.Controls.Add(this.groupBoxConnections);
            this.Name = "Form1";
            this.Text = "ADO.Net Demo";
            this.groupBoxConnections.ResumeLayout(false);
            this.groupBoxCommands.ResumeLayout(false);
            this.groupBoxCommands.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Button buttonDataReader;
        private System.Windows.Forms.Button buttonDataAdapter;
        private System.Windows.Forms.Button buttonDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonParameters;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSetConnectionString;
        private System.Windows.Forms.Button buttonInfoMessage;
        private System.Windows.Forms.GroupBox groupBoxConnections;
        private System.Windows.Forms.GroupBox groupBoxCommands;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

