namespace DelegatesAndEventsDemos
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
            this.buttonUsingADelegate = new System.Windows.Forms.Button();
            this.buttonMulticasting = new System.Windows.Forms.Button();
            this.buttonAsyncFireAndForget = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAsyncPolling = new System.Windows.Forms.Button();
            this.buttonWaitForCompletion = new System.Windows.Forms.Button();
            this.buttonCompletionNotification = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPickupData = new System.Windows.Forms.Button();
            this.buttonDelgatesAndEvents = new System.Windows.Forms.Button();
            this.buttonUsingAnnonymousMethods = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUsingADelegate
            // 
            this.buttonUsingADelegate.Location = new System.Drawing.Point(10, 18);
            this.buttonUsingADelegate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUsingADelegate.Name = "buttonUsingADelegate";
            this.buttonUsingADelegate.Size = new System.Drawing.Size(219, 19);
            this.buttonUsingADelegate.TabIndex = 0;
            this.buttonUsingADelegate.Text = "Using A Delegate";
            this.buttonUsingADelegate.UseVisualStyleBackColor = true;
            this.buttonUsingADelegate.Click += new System.EventHandler(this.buttonUsingADelegate_Click);
            // 
            // buttonMulticasting
            // 
            this.buttonMulticasting.Location = new System.Drawing.Point(10, 41);
            this.buttonMulticasting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMulticasting.Name = "buttonMulticasting";
            this.buttonMulticasting.Size = new System.Drawing.Size(218, 19);
            this.buttonMulticasting.TabIndex = 2;
            this.buttonMulticasting.Text = "Multicasting";
            this.buttonMulticasting.UseVisualStyleBackColor = true;
            this.buttonMulticasting.Click += new System.EventHandler(this.buttonMulticasting_Click);
            // 
            // buttonAsyncFireAndForget
            // 
            this.buttonAsyncFireAndForget.Location = new System.Drawing.Point(14, 124);
            this.buttonAsyncFireAndForget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAsyncFireAndForget.Name = "buttonAsyncFireAndForget";
            this.buttonAsyncFireAndForget.Size = new System.Drawing.Size(192, 19);
            this.buttonAsyncFireAndForget.TabIndex = 3;
            this.buttonAsyncFireAndForget.Text = "Async Fire and Forget";
            this.buttonAsyncFireAndForget.UseVisualStyleBackColor = true;
            this.buttonAsyncFireAndForget.Click += new System.EventHandler(this.buttonAsyncFireAndForget_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 98);
            this.label1.TabIndex = 4;
            this.label1.Text = "There are four patterns to call a delegate Asynchronously: \r\n\r\n *Fire and Forget " +
                "\r\n *Polling \r\n *Waiting for Completion \r\n *Completion Notification";
            // 
            // buttonAsyncPolling
            // 
            this.buttonAsyncPolling.Location = new System.Drawing.Point(14, 146);
            this.buttonAsyncPolling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAsyncPolling.Name = "buttonAsyncPolling";
            this.buttonAsyncPolling.Size = new System.Drawing.Size(192, 19);
            this.buttonAsyncPolling.TabIndex = 5;
            this.buttonAsyncPolling.Text = "Async Polling";
            this.buttonAsyncPolling.UseVisualStyleBackColor = true;
            this.buttonAsyncPolling.Click += new System.EventHandler(this.buttonAsyncPolling_Click);
            // 
            // buttonWaitForCompletion
            // 
            this.buttonWaitForCompletion.Location = new System.Drawing.Point(14, 169);
            this.buttonWaitForCompletion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonWaitForCompletion.Name = "buttonWaitForCompletion";
            this.buttonWaitForCompletion.Size = new System.Drawing.Size(192, 19);
            this.buttonWaitForCompletion.TabIndex = 6;
            this.buttonWaitForCompletion.Text = "Wait For Completion";
            this.buttonWaitForCompletion.UseVisualStyleBackColor = true;
            this.buttonWaitForCompletion.Click += new System.EventHandler(this.buttonWaitForCompletion_Click);
            // 
            // buttonCompletionNotification
            // 
            this.buttonCompletionNotification.Location = new System.Drawing.Point(13, 192);
            this.buttonCompletionNotification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCompletionNotification.Name = "buttonCompletionNotification";
            this.buttonCompletionNotification.Size = new System.Drawing.Size(193, 19);
            this.buttonCompletionNotification.TabIndex = 7;
            this.buttonCompletionNotification.Text = "Completion Notification";
            this.buttonCompletionNotification.UseVisualStyleBackColor = true;
            this.buttonCompletionNotification.Click += new System.EventHandler(this.buttonCompletionNotification_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.buttonPickupData);
            this.groupBox1.Controls.Add(this.buttonCompletionNotification);
            this.groupBox1.Controls.Add(this.buttonAsyncFireAndForget);
            this.groupBox1.Controls.Add(this.buttonWaitForCompletion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAsyncPolling);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(218, 236);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delegates are automaticlly Asynchronous";
            // 
            // buttonPickupData
            // 
            this.buttonPickupData.Location = new System.Drawing.Point(112, 215);
            this.buttonPickupData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPickupData.Name = "buttonPickupData";
            this.buttonPickupData.Size = new System.Drawing.Size(94, 19);
            this.buttonPickupData.TabIndex = 8;
            this.buttonPickupData.Text = "Pickup Data";
            this.buttonPickupData.UseVisualStyleBackColor = true;
            this.buttonPickupData.Click += new System.EventHandler(this.buttonPickupData_Click);
            // 
            // buttonDelgatesAndEvents
            // 
            this.buttonDelgatesAndEvents.Location = new System.Drawing.Point(10, 307);
            this.buttonDelgatesAndEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelgatesAndEvents.Name = "buttonDelgatesAndEvents";
            this.buttonDelgatesAndEvents.Size = new System.Drawing.Size(218, 23);
            this.buttonDelgatesAndEvents.TabIndex = 9;
            this.buttonDelgatesAndEvents.Text = "Delegates And Events";
            this.buttonDelgatesAndEvents.UseVisualStyleBackColor = true;
            this.buttonDelgatesAndEvents.Click += new System.EventHandler(this.buttonDelgatesAndEvents_Click);
            // 
            // buttonUsingAnnonymousMethods
            // 
            this.buttonUsingAnnonymousMethods.Location = new System.Drawing.Point(10, 332);
            this.buttonUsingAnnonymousMethods.Name = "buttonUsingAnnonymousMethods";
            this.buttonUsingAnnonymousMethods.Size = new System.Drawing.Size(218, 23);
            this.buttonUsingAnnonymousMethods.TabIndex = 10;
            this.buttonUsingAnnonymousMethods.Text = "Delegates with Annonymous Methods";
            this.buttonUsingAnnonymousMethods.UseVisualStyleBackColor = true;
            this.buttonUsingAnnonymousMethods.Click += new System.EventHandler(this.buttonUsingAnnonymousMethods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 419);
            this.Controls.Add(this.buttonUsingAnnonymousMethods);
            this.Controls.Add(this.buttonDelgatesAndEvents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMulticasting);
            this.Controls.Add(this.buttonUsingADelegate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUsingADelegate;
        private System.Windows.Forms.Button buttonMulticasting;
        private System.Windows.Forms.Button buttonAsyncFireAndForget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAsyncPolling;
        private System.Windows.Forms.Button buttonWaitForCompletion;
        private System.Windows.Forms.Button buttonCompletionNotification;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPickupData;
        private System.Windows.Forms.Button buttonDelgatesAndEvents;
        private System.Windows.Forms.Button buttonUsingAnnonymousMethods;
    }
}

