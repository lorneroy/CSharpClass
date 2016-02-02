namespace CSHP811A_Assignment_03
{
    partial class FormCalculator
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCalculator = new System.Windows.Forms.TabPage();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonDecimalPoint = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCalcDisplay = new System.Windows.Forms.TextBox();
            this.textBoxPreviousEntry = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.buttonChangeFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageCalculator.SuspendLayout();
            this.tabPageFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCalculator);
            this.tabControlMain.Controls.Add(this.tabPageFile);
            this.tabControlMain.Location = new System.Drawing.Point(7, 9);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(222, 201);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageCalculator
            // 
            this.tabPageCalculator.Controls.Add(this.buttonSave);
            this.tabPageCalculator.Controls.Add(this.buttonSign);
            this.tabPageCalculator.Controls.Add(this.buttonClear);
            this.tabPageCalculator.Controls.Add(this.buttonEquals);
            this.tabPageCalculator.Controls.Add(this.buttonDecimalPoint);
            this.tabPageCalculator.Controls.Add(this.buttonPlus);
            this.tabPageCalculator.Controls.Add(this.buttonMinus);
            this.tabPageCalculator.Controls.Add(this.buttonMultiply);
            this.tabPageCalculator.Controls.Add(this.buttonDivide);
            this.tabPageCalculator.Controls.Add(this.button9);
            this.tabPageCalculator.Controls.Add(this.button8);
            this.tabPageCalculator.Controls.Add(this.button7);
            this.tabPageCalculator.Controls.Add(this.button6);
            this.tabPageCalculator.Controls.Add(this.button5);
            this.tabPageCalculator.Controls.Add(this.button4);
            this.tabPageCalculator.Controls.Add(this.button3);
            this.tabPageCalculator.Controls.Add(this.button2);
            this.tabPageCalculator.Controls.Add(this.button1);
            this.tabPageCalculator.Controls.Add(this.textBoxCalcDisplay);
            this.tabPageCalculator.Controls.Add(this.textBoxPreviousEntry);
            this.tabPageCalculator.Controls.Add(this.button0);
            this.tabPageCalculator.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalculator.Name = "tabPageCalculator";
            this.tabPageCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalculator.Size = new System.Drawing.Size(214, 175);
            this.tabPageCalculator.TabIndex = 0;
            this.tabPageCalculator.Text = "Calculator";
            this.tabPageCalculator.UseVisualStyleBackColor = true;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(166, 111);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(36, 24);
            this.buttonSign.TabIndex = 38;
            this.buttonSign.Text = "+/-";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(166, 81);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(36, 24);
            this.buttonClear.TabIndex = 37;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(166, 141);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(36, 24);
            this.buttonEquals.TabIndex = 36;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonDecimalPoint
            // 
            this.buttonDecimalPoint.Location = new System.Drawing.Point(86, 141);
            this.buttonDecimalPoint.Name = "buttonDecimalPoint";
            this.buttonDecimalPoint.Size = new System.Drawing.Size(36, 24);
            this.buttonDecimalPoint.TabIndex = 35;
            this.buttonDecimalPoint.Text = ".";
            this.buttonDecimalPoint.UseVisualStyleBackColor = true;
            this.buttonDecimalPoint.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(126, 141);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(36, 24);
            this.buttonPlus.TabIndex = 34;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(126, 111);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(36, 24);
            this.buttonMinus.TabIndex = 33;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(126, 81);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(36, 24);
            this.buttonMultiply.TabIndex = 32;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(126, 51);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(36, 24);
            this.buttonDivide.TabIndex = 31;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(86, 51);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 24);
            this.button9.TabIndex = 30;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(46, 51);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 24);
            this.button8.TabIndex = 29;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 51);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 24);
            this.button7.TabIndex = 28;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(86, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 24);
            this.button6.TabIndex = 27;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 24);
            this.button5.TabIndex = 26;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 24);
            this.button4.TabIndex = 25;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 24);
            this.button3.TabIndex = 24;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 24);
            this.button2.TabIndex = 23;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 24);
            this.button1.TabIndex = 22;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // textBoxCalcDisplay
            // 
            this.textBoxCalcDisplay.Location = new System.Drawing.Point(6, 25);
            this.textBoxCalcDisplay.Name = "textBoxCalcDisplay";
            this.textBoxCalcDisplay.Size = new System.Drawing.Size(200, 20);
            this.textBoxCalcDisplay.TabIndex = 21;
            this.textBoxCalcDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPreviousEntry
            // 
            this.textBoxPreviousEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPreviousEntry.Location = new System.Drawing.Point(6, 6);
            this.textBoxPreviousEntry.Name = "textBoxPreviousEntry";
            this.textBoxPreviousEntry.ReadOnly = true;
            this.textBoxPreviousEntry.Size = new System.Drawing.Size(200, 13);
            this.textBoxPreviousEntry.TabIndex = 20;
            this.textBoxPreviousEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(6, 142);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 23);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // tabPageFile
            // 
            this.tabPageFile.Controls.Add(this.buttonChangeFile);
            this.tabPageFile.Controls.Add(this.textBoxFilePath);
            this.tabPageFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFile.Size = new System.Drawing.Size(208, 175);
            this.tabPageFile.TabIndex = 1;
            this.tabPageFile.Text = "File";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // buttonChangeFile
            // 
            this.buttonChangeFile.Location = new System.Drawing.Point(7, 34);
            this.buttonChangeFile.Name = "buttonChangeFile";
            this.buttonChangeFile.Size = new System.Drawing.Size(106, 23);
            this.buttonChangeFile.TabIndex = 1;
            this.buttonChangeFile.Text = "Change File Path";
            this.buttonChangeFile.UseVisualStyleBackColor = true;
            this.buttonChangeFile.Click += new System.EventHandler(this.buttonChangeFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(7, 7);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(201, 20);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(166, 51);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(36, 24);
            this.buttonSave.TabIndex = 39;
            this.buttonSave.Text = "S";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 217);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormCalculator";
            this.Text = "FormCalculator";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCalculator.ResumeLayout(false);
            this.tabPageCalculator.PerformLayout();
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCalculator;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonDecimalPoint;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCalcDisplay;
        private System.Windows.Forms.TextBox textBoxPreviousEntry;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.TabPage tabPageFile;
        private System.Windows.Forms.Button buttonChangeFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonSave;
    }
}