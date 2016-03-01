namespace WorkingWithLINQ
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
            this.buttonLINQAndArrays = new System.Windows.Forms.Button();
            this.buttonLINQAndObjects = new System.Windows.Forms.Button();
            this.buttonLINQToDataDrivenObjects = new System.Windows.Forms.Button();
            this.buttonLINQToDataSet = new System.Windows.Forms.Button();
            this.buttonLINQToSQL = new System.Windows.Forms.Button();
            this.buttonLINQToDataEntities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLINQAndArrays
            // 
            this.buttonLINQAndArrays.Location = new System.Drawing.Point(12, 12);
            this.buttonLINQAndArrays.Name = "buttonLINQAndArrays";
            this.buttonLINQAndArrays.Size = new System.Drawing.Size(260, 23);
            this.buttonLINQAndArrays.TabIndex = 0;
            this.buttonLINQAndArrays.Text = "LINQ to Arrays";
            this.buttonLINQAndArrays.UseVisualStyleBackColor = true;
            this.buttonLINQAndArrays.Click += new System.EventHandler(this.buttonLINQAndArrays_Click);
            // 
            // buttonLINQAndObjects
            // 
            this.buttonLINQAndObjects.Location = new System.Drawing.Point(13, 42);
            this.buttonLINQAndObjects.Name = "buttonLINQAndObjects";
            this.buttonLINQAndObjects.Size = new System.Drawing.Size(259, 23);
            this.buttonLINQAndObjects.TabIndex = 1;
            this.buttonLINQAndObjects.Text = "LINQ to Objects";
            this.buttonLINQAndObjects.UseVisualStyleBackColor = true;
            this.buttonLINQAndObjects.Click += new System.EventHandler(this.buttonLINQAndObjects_Click);
            // 
            // buttonLINQToDataDrivenObjects
            // 
            this.buttonLINQToDataDrivenObjects.Location = new System.Drawing.Point(13, 71);
            this.buttonLINQToDataDrivenObjects.Name = "buttonLINQToDataDrivenObjects";
            this.buttonLINQToDataDrivenObjects.Size = new System.Drawing.Size(259, 23);
            this.buttonLINQToDataDrivenObjects.TabIndex = 2;
            this.buttonLINQToDataDrivenObjects.Text = "LINQ To Data Driven Objects";
            this.buttonLINQToDataDrivenObjects.UseVisualStyleBackColor = true;
            this.buttonLINQToDataDrivenObjects.Click += new System.EventHandler(this.buttonLINQToDataDrivenObjects_Click);
            // 
            // buttonLINQToDataSet
            // 
            this.buttonLINQToDataSet.Location = new System.Drawing.Point(13, 101);
            this.buttonLINQToDataSet.Name = "buttonLINQToDataSet";
            this.buttonLINQToDataSet.Size = new System.Drawing.Size(259, 23);
            this.buttonLINQToDataSet.TabIndex = 3;
            this.buttonLINQToDataSet.Text = "LINQ to DataSets";
            this.buttonLINQToDataSet.UseVisualStyleBackColor = true;
            this.buttonLINQToDataSet.Click += new System.EventHandler(this.buttonLINQToDataSet_Click);
            // 
            // buttonLINQToSQL
            // 
            this.buttonLINQToSQL.Location = new System.Drawing.Point(13, 131);
            this.buttonLINQToSQL.Name = "buttonLINQToSQL";
            this.buttonLINQToSQL.Size = new System.Drawing.Size(259, 23);
            this.buttonLINQToSQL.TabIndex = 4;
            this.buttonLINQToSQL.Text = "LINQ to SQL";
            this.buttonLINQToSQL.UseVisualStyleBackColor = true;
            this.buttonLINQToSQL.Click += new System.EventHandler(this.buttonLINQToSQL_Click);
            // 
            // buttonLINQToDataEntities
            // 
            this.buttonLINQToDataEntities.Location = new System.Drawing.Point(13, 161);
            this.buttonLINQToDataEntities.Name = "buttonLINQToDataEntities";
            this.buttonLINQToDataEntities.Size = new System.Drawing.Size(259, 23);
            this.buttonLINQToDataEntities.TabIndex = 5;
            this.buttonLINQToDataEntities.Text = "LINQ to Data Entities";
            this.buttonLINQToDataEntities.UseVisualStyleBackColor = true;
            this.buttonLINQToDataEntities.Click += new System.EventHandler(this.buttonLINQToDataEntities_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.buttonLINQToDataEntities);
            this.Controls.Add(this.buttonLINQToSQL);
            this.Controls.Add(this.buttonLINQToDataSet);
            this.Controls.Add(this.buttonLINQToDataDrivenObjects);
            this.Controls.Add(this.buttonLINQAndObjects);
            this.Controls.Add(this.buttonLINQAndArrays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLINQAndArrays;
        private System.Windows.Forms.Button buttonLINQAndObjects;
        private System.Windows.Forms.Button buttonLINQToDataDrivenObjects;
        private System.Windows.Forms.Button buttonLINQToDataSet;
        private System.Windows.Forms.Button buttonLINQToSQL;
        private System.Windows.Forms.Button buttonLINQToDataEntities;
    }
}

