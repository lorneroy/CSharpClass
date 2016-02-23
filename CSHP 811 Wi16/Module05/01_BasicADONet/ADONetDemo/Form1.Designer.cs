namespace ADO2008Demo
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
            this.buttonConnections = new System.Windows.Forms.Button();
            this.buttonCommands = new System.Windows.Forms.Button();
            this.buttonCmdWithSprocs = new System.Windows.Forms.Button();
            this.buttonSprocWithParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnections
            // 
            this.buttonConnections.Location = new System.Drawing.Point(9, 11);
            this.buttonConnections.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnections.Name = "buttonConnections";
            this.buttonConnections.Size = new System.Drawing.Size(206, 29);
            this.buttonConnections.TabIndex = 0;
            this.buttonConnections.Text = "Connections";
            this.buttonConnections.UseVisualStyleBackColor = true;
            this.buttonConnections.Click += new System.EventHandler(this.buttonConnections_Click);
            // 
            // buttonCommands
            // 
            this.buttonCommands.Location = new System.Drawing.Point(9, 47);
            this.buttonCommands.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCommands.Name = "buttonCommands";
            this.buttonCommands.Size = new System.Drawing.Size(206, 29);
            this.buttonCommands.TabIndex = 1;
            this.buttonCommands.Text = "Commands";
            this.buttonCommands.UseVisualStyleBackColor = true;
            this.buttonCommands.Click += new System.EventHandler(this.buttonCommands_Click);
            // 
            // buttonCmdWithSprocs
            // 
            this.buttonCmdWithSprocs.Location = new System.Drawing.Point(12, 83);
            this.buttonCmdWithSprocs.Name = "buttonCmdWithSprocs";
            this.buttonCmdWithSprocs.Size = new System.Drawing.Size(203, 29);
            this.buttonCmdWithSprocs.TabIndex = 4;
            this.buttonCmdWithSprocs.Text = "Stored Procedures";
            this.buttonCmdWithSprocs.UseVisualStyleBackColor = true;
            this.buttonCmdWithSprocs.Click += new System.EventHandler(this.buttonCmdWithSprocs_Click);
            // 
            // buttonSprocWithParams
            // 
            this.buttonSprocWithParams.Location = new System.Drawing.Point(12, 119);
            this.buttonSprocWithParams.Name = "buttonSprocWithParams";
            this.buttonSprocWithParams.Size = new System.Drawing.Size(203, 29);
            this.buttonSprocWithParams.TabIndex = 4;
            this.buttonSprocWithParams.Text = "Stored Procedures with Parameters";
            this.buttonSprocWithParams.UseVisualStyleBackColor = true;
            this.buttonSprocWithParams.Click += new System.EventHandler(this.buttonSprocWithParams_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 155);
            this.Controls.Add(this.buttonSprocWithParams);
            this.Controls.Add(this.buttonCmdWithSprocs);
            this.Controls.Add(this.buttonCommands);
            this.Controls.Add(this.buttonConnections);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnections;
        private System.Windows.Forms.Button buttonCommands;
        private System.Windows.Forms.Button buttonCmdWithSprocs;
        private System.Windows.Forms.Button buttonSprocWithParams;
    }
}

