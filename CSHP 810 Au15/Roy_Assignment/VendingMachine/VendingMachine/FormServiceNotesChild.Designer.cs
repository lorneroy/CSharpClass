namespace VendingMachine
{
    partial class FormServiceNotesChild
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
            this.textBoxServiceNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxServiceNote
            // 
            this.textBoxServiceNote.Location = new System.Drawing.Point(13, 13);
            this.textBoxServiceNote.Multiline = true;
            this.textBoxServiceNote.Name = "textBoxServiceNote";
            this.textBoxServiceNote.Size = new System.Drawing.Size(259, 237);
            this.textBoxServiceNote.TabIndex = 0;
            // 
            // FormServiceNotesChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxServiceNote);
            this.Name = "FormServiceNotesChild";
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServiceNote;
    }
}