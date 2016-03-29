namespace AnonymousTypesMethodsAndLambdas
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
            this.buttonUsingStandardMethods = new System.Windows.Forms.Button();
            this.buttonUsingDelegates = new System.Windows.Forms.Button();
            this.buttonUsingAnnonymousMethods = new System.Windows.Forms.Button();
            this.buttonUsingLambdas = new System.Windows.Forms.Button();
            this.groupBoxMethods = new System.Windows.Forms.GroupBox();
            this.groupBoxTypes = new System.Windows.Forms.GroupBox();
            this.buttonUsingAnnonymousTypes = new System.Windows.Forms.Button();
            this.buttonUsingStandardTypes = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonExtentionMethods = new System.Windows.Forms.Button();
            this.groupBoxMethods.SuspendLayout();
            this.groupBoxTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUsingStandardMethods
            // 
            this.buttonUsingStandardMethods.Location = new System.Drawing.Point(16, 53);
            this.buttonUsingStandardMethods.Name = "buttonUsingStandardMethods";
            this.buttonUsingStandardMethods.Size = new System.Drawing.Size(180, 23);
            this.buttonUsingStandardMethods.TabIndex = 0;
            this.buttonUsingStandardMethods.Text = "Using Standard Methods";
            this.buttonUsingStandardMethods.UseVisualStyleBackColor = true;
            this.buttonUsingStandardMethods.Click += new System.EventHandler(this.buttonUsingStandardMethods_Click);
            // 
            // buttonUsingDelegates
            // 
            this.buttonUsingDelegates.Location = new System.Drawing.Point(16, 82);
            this.buttonUsingDelegates.Name = "buttonUsingDelegates";
            this.buttonUsingDelegates.Size = new System.Drawing.Size(180, 23);
            this.buttonUsingDelegates.TabIndex = 1;
            this.buttonUsingDelegates.Text = "Using Delegates";
            this.buttonUsingDelegates.UseVisualStyleBackColor = true;
            this.buttonUsingDelegates.Click += new System.EventHandler(this.buttonUsingDelegates_Click);
            // 
            // buttonUsingAnnonymousMethods
            // 
            this.buttonUsingAnnonymousMethods.Location = new System.Drawing.Point(16, 111);
            this.buttonUsingAnnonymousMethods.Name = "buttonUsingAnnonymousMethods";
            this.buttonUsingAnnonymousMethods.Size = new System.Drawing.Size(180, 23);
            this.buttonUsingAnnonymousMethods.TabIndex = 2;
            this.buttonUsingAnnonymousMethods.Text = "Using Annonymous Methods";
            this.buttonUsingAnnonymousMethods.UseVisualStyleBackColor = true;
            this.buttonUsingAnnonymousMethods.Click += new System.EventHandler(this.buttonUsingAnnonymousMethods_Click);
            // 
            // buttonUsingLambdas
            // 
            this.buttonUsingLambdas.Location = new System.Drawing.Point(16, 140);
            this.buttonUsingLambdas.Name = "buttonUsingLambdas";
            this.buttonUsingLambdas.Size = new System.Drawing.Size(180, 23);
            this.buttonUsingLambdas.TabIndex = 3;
            this.buttonUsingLambdas.Text = "Using Lambdas";
            this.buttonUsingLambdas.UseVisualStyleBackColor = true;
            this.buttonUsingLambdas.Click += new System.EventHandler(this.buttonUsingLambdas_Click);
            // 
            // groupBoxMethods
            // 
            this.groupBoxMethods.Controls.Add(this.buttonExtentionMethods);
            this.groupBoxMethods.Controls.Add(this.buttonUsingStandardMethods);
            this.groupBoxMethods.Controls.Add(this.textBoxNumber);
            this.groupBoxMethods.Controls.Add(this.buttonUsingLambdas);
            this.groupBoxMethods.Controls.Add(this.labelNumber);
            this.groupBoxMethods.Controls.Add(this.buttonUsingDelegates);
            this.groupBoxMethods.Controls.Add(this.buttonUsingAnnonymousMethods);
            this.groupBoxMethods.Location = new System.Drawing.Point(21, 161);
            this.groupBoxMethods.Name = "groupBoxMethods";
            this.groupBoxMethods.Size = new System.Drawing.Size(220, 241);
            this.groupBoxMethods.TabIndex = 4;
            this.groupBoxMethods.TabStop = false;
            this.groupBoxMethods.Text = "Methods";
            // 
            // groupBoxTypes
            // 
            this.groupBoxTypes.Controls.Add(this.buttonUsingAnnonymousTypes);
            this.groupBoxTypes.Controls.Add(this.buttonUsingStandardTypes);
            this.groupBoxTypes.Location = new System.Drawing.Point(21, 42);
            this.groupBoxTypes.Name = "groupBoxTypes";
            this.groupBoxTypes.Size = new System.Drawing.Size(220, 96);
            this.groupBoxTypes.TabIndex = 5;
            this.groupBoxTypes.TabStop = false;
            this.groupBoxTypes.Text = "Types";
            // 
            // buttonUsingAnnonymousTypes
            // 
            this.buttonUsingAnnonymousTypes.Location = new System.Drawing.Point(16, 49);
            this.buttonUsingAnnonymousTypes.Name = "buttonUsingAnnonymousTypes";
            this.buttonUsingAnnonymousTypes.Size = new System.Drawing.Size(180, 23);
            this.buttonUsingAnnonymousTypes.TabIndex = 1;
            this.buttonUsingAnnonymousTypes.Text = "Using Annonymous Types";
            this.buttonUsingAnnonymousTypes.UseVisualStyleBackColor = true;
            this.buttonUsingAnnonymousTypes.Click += new System.EventHandler(this.buttonUsingAnnonymousTypes_Click);
            // 
            // buttonUsingStandardTypes
            // 
            this.buttonUsingStandardTypes.Location = new System.Drawing.Point(16, 20);
            this.buttonUsingStandardTypes.Name = "buttonUsingStandardTypes";
            this.buttonUsingStandardTypes.Size = new System.Drawing.Size(180, 23);
            this.buttonUsingStandardTypes.TabIndex = 0;
            this.buttonUsingStandardTypes.Text = "UsingStandardTypes";
            this.buttonUsingStandardTypes.UseVisualStyleBackColor = true;
            this.buttonUsingStandardTypes.Click += new System.EventHandler(this.buttonUsingStandardTypes_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(13, 27);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(81, 13);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "Enter a Number";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(100, 27);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(96, 20);
            this.textBoxNumber.TabIndex = 7;
            this.textBoxNumber.Text = "5";
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(0, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(100, 23);
            this.labelResult.TabIndex = 0;
            // 
            // buttonExtentionMethods
            // 
            this.buttonExtentionMethods.Location = new System.Drawing.Point(16, 170);
            this.buttonExtentionMethods.Name = "buttonExtentionMethods";
            this.buttonExtentionMethods.Size = new System.Drawing.Size(180, 23);
            this.buttonExtentionMethods.TabIndex = 8;
            this.buttonExtentionMethods.Text = "Exetention Methods";
            this.buttonExtentionMethods.UseVisualStyleBackColor = true;
            this.buttonExtentionMethods.Click += new System.EventHandler(this.buttonExtentionMethods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 428);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.groupBoxTypes);
            this.Controls.Add(this.groupBoxMethods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMethods.ResumeLayout(false);
            this.groupBoxMethods.PerformLayout();
            this.groupBoxTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUsingStandardMethods;
        private System.Windows.Forms.Button buttonUsingDelegates;
        private System.Windows.Forms.Button buttonUsingAnnonymousMethods;
        private System.Windows.Forms.Button buttonUsingLambdas;
        private System.Windows.Forms.GroupBox groupBoxMethods;
        private System.Windows.Forms.GroupBox groupBoxTypes;
        private System.Windows.Forms.Button buttonUsingAnnonymousTypes;
        private System.Windows.Forms.Button buttonUsingStandardTypes;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonExtentionMethods;
    }
}

