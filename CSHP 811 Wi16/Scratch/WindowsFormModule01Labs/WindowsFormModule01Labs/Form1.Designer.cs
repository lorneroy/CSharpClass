namespace WindowsFormModule01Labs
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
            this.radioButtonRetail = new System.Windows.Forms.RadioButton();
            this.radioButtonWholeSale = new System.Windows.Forms.RadioButton();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButtonRetail
            // 
            this.radioButtonRetail.AutoSize = true;
            this.radioButtonRetail.Location = new System.Drawing.Point(34, 42);
            this.radioButtonRetail.Name = "radioButtonRetail";
            this.radioButtonRetail.Size = new System.Drawing.Size(52, 17);
            this.radioButtonRetail.TabIndex = 0;
            this.radioButtonRetail.TabStop = true;
            this.radioButtonRetail.Text = "Retail";
            this.radioButtonRetail.UseVisualStyleBackColor = true;
            this.radioButtonRetail.CheckedChanged += new System.EventHandler(this.radioButtonRetail_CheckedChanged);
            // 
            // radioButtonWholeSale
            // 
            this.radioButtonWholeSale.AutoSize = true;
            this.radioButtonWholeSale.Location = new System.Drawing.Point(33, 74);
            this.radioButtonWholeSale.Name = "radioButtonWholeSale";
            this.radioButtonWholeSale.Size = new System.Drawing.Size(75, 17);
            this.radioButtonWholeSale.TabIndex = 1;
            this.radioButtonWholeSale.TabStop = true;
            this.radioButtonWholeSale.Text = "Wholesale";
            this.radioButtonWholeSale.UseVisualStyleBackColor = true;
            this.radioButtonWholeSale.CheckedChanged += new System.EventHandler(this.radioButtonWholeSale_CheckedChanged);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(47, 153);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplay.TabIndex = 2;
            this.buttonDisplay.Text = "button";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.radioButtonWholeSale);
            this.Controls.Add(this.radioButtonRetail);
            this.Name = "Form1";
            this.Text = "Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRetail;
        private System.Windows.Forms.RadioButton radioButtonWholeSale;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

