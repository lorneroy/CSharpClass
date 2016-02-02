namespace VendingMachine
{
    partial class VendingMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendingMachine));
            this.labelGeneralMessage = new System.Windows.Forms.Label();
            this.labelExactChange = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.pictureBoxOrange = new System.Windows.Forms.PictureBox();
            this.pictureBoxLemon = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegular = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonLemon = new System.Windows.Forms.Button();
            this.buttonRegular = new System.Windows.Forms.Button();
            this.buttonHalfDollar = new System.Windows.Forms.Button();
            this.buttonQuarter = new System.Windows.Forms.Button();
            this.buttonDime = new System.Windows.Forms.Button();
            this.buttonNickel = new System.Windows.Forms.Button();
            this.tabControlOperationMode = new System.Windows.Forms.TabControl();
            this.tabPageVend = new System.Windows.Forms.TabPage();
            this.tabPageService = new System.Windows.Forms.TabPage();
            this.buttonServiceNotes = new System.Windows.Forms.Button();
            this.groupBoxRackControl = new System.Windows.Forms.GroupBox();
            this.listViewInventory = new System.Windows.Forms.ListView();
            this.buttonRefill = new System.Windows.Forms.Button();
            this.groupBoxCoinControls = new System.Windows.Forms.GroupBox();
            this.listViewCoinBoxLocked = new System.Windows.Forms.ListView();
            this.buttonEmptyCoinBox = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxSnackDetails = new System.Windows.Forms.TextBox();
            this.buttonStockSnacks = new System.Windows.Forms.Button();
            this.listBoxSnacks = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegular)).BeginInit();
            this.tabControlOperationMode.SuspendLayout();
            this.tabPageVend.SuspendLayout();
            this.tabPageService.SuspendLayout();
            this.groupBoxRackControl.SuspendLayout();
            this.groupBoxCoinControls.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGeneralMessage
            // 
            this.labelGeneralMessage.AutoSize = true;
            this.labelGeneralMessage.Location = new System.Drawing.Point(18, 32);
            this.labelGeneralMessage.Name = "labelGeneralMessage";
            this.labelGeneralMessage.Size = new System.Drawing.Size(35, 13);
            this.labelGeneralMessage.TabIndex = 0;
            this.labelGeneralMessage.Text = "label1";
            // 
            // labelExactChange
            // 
            this.labelExactChange.AutoSize = true;
            this.labelExactChange.Location = new System.Drawing.Point(18, 51);
            this.labelExactChange.Name = "labelExactChange";
            this.labelExactChange.Size = new System.Drawing.Size(35, 13);
            this.labelExactChange.TabIndex = 1;
            this.labelExactChange.Text = "label2";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(18, 68);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(35, 13);
            this.labelCredit.TabIndex = 2;
            this.labelCredit.Text = "label3";
            // 
            // pictureBoxOrange
            // 
            this.pictureBoxOrange.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrange.Image")));
            this.pictureBoxOrange.Location = new System.Drawing.Point(146, 18);
            this.pictureBoxOrange.Name = "pictureBoxOrange";
            this.pictureBoxOrange.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrange.TabIndex = 3;
            this.pictureBoxOrange.TabStop = false;
            // 
            // pictureBoxLemon
            // 
            this.pictureBoxLemon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLemon.Image")));
            this.pictureBoxLemon.Location = new System.Drawing.Point(146, 124);
            this.pictureBoxLemon.Name = "pictureBoxLemon";
            this.pictureBoxLemon.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLemon.TabIndex = 4;
            this.pictureBoxLemon.TabStop = false;
            // 
            // pictureBoxRegular
            // 
            this.pictureBoxRegular.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegular.Image")));
            this.pictureBoxRegular.Location = new System.Drawing.Point(146, 228);
            this.pictureBoxRegular.Name = "pictureBoxRegular";
            this.pictureBoxRegular.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxRegular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegular.TabIndex = 5;
            this.pictureBoxRegular.TabStop = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(13, 246);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.Location = new System.Drawing.Point(264, 54);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(75, 23);
            this.buttonOrange.TabIndex = 7;
            this.buttonOrange.Text = "Orange";
            this.buttonOrange.UseVisualStyleBackColor = true;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonLemon
            // 
            this.buttonLemon.Location = new System.Drawing.Point(264, 164);
            this.buttonLemon.Name = "buttonLemon";
            this.buttonLemon.Size = new System.Drawing.Size(75, 23);
            this.buttonLemon.TabIndex = 8;
            this.buttonLemon.Text = "Lemon";
            this.buttonLemon.UseVisualStyleBackColor = true;
            this.buttonLemon.Click += new System.EventHandler(this.buttonLemon_Click);
            // 
            // buttonRegular
            // 
            this.buttonRegular.Location = new System.Drawing.Point(264, 258);
            this.buttonRegular.Name = "buttonRegular";
            this.buttonRegular.Size = new System.Drawing.Size(75, 23);
            this.buttonRegular.TabIndex = 9;
            this.buttonRegular.Text = "Regular";
            this.buttonRegular.UseVisualStyleBackColor = true;
            this.buttonRegular.Click += new System.EventHandler(this.buttonRegular_Click);
            // 
            // buttonHalfDollar
            // 
            this.buttonHalfDollar.Location = new System.Drawing.Point(17, 109);
            this.buttonHalfDollar.Name = "buttonHalfDollar";
            this.buttonHalfDollar.Size = new System.Drawing.Size(75, 23);
            this.buttonHalfDollar.TabIndex = 10;
            this.buttonHalfDollar.Text = "Half Dollar";
            this.buttonHalfDollar.UseVisualStyleBackColor = true;
            this.buttonHalfDollar.Click += new System.EventHandler(this.buttonHalfDollar_Click);
            // 
            // buttonQuarter
            // 
            this.buttonQuarter.Location = new System.Drawing.Point(17, 139);
            this.buttonQuarter.Name = "buttonQuarter";
            this.buttonQuarter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuarter.TabIndex = 11;
            this.buttonQuarter.Text = "Quarter";
            this.buttonQuarter.UseVisualStyleBackColor = true;
            this.buttonQuarter.Click += new System.EventHandler(this.buttonQuarter_Click);
            // 
            // buttonDime
            // 
            this.buttonDime.Location = new System.Drawing.Point(17, 169);
            this.buttonDime.Name = "buttonDime";
            this.buttonDime.Size = new System.Drawing.Size(75, 23);
            this.buttonDime.TabIndex = 12;
            this.buttonDime.Text = "Dime";
            this.buttonDime.UseVisualStyleBackColor = true;
            this.buttonDime.Click += new System.EventHandler(this.buttonDime_Click);
            // 
            // buttonNickel
            // 
            this.buttonNickel.Location = new System.Drawing.Point(17, 199);
            this.buttonNickel.Name = "buttonNickel";
            this.buttonNickel.Size = new System.Drawing.Size(75, 23);
            this.buttonNickel.TabIndex = 13;
            this.buttonNickel.Text = "Nickel";
            this.buttonNickel.UseVisualStyleBackColor = true;
            this.buttonNickel.Click += new System.EventHandler(this.buttonNickel_Click);
            // 
            // tabControlOperationMode
            // 
            this.tabControlOperationMode.Controls.Add(this.tabPageVend);
            this.tabControlOperationMode.Controls.Add(this.tabPageService);
            this.tabControlOperationMode.Controls.Add(this.tabPage1);
            this.tabControlOperationMode.Location = new System.Drawing.Point(12, 12);
            this.tabControlOperationMode.Name = "tabControlOperationMode";
            this.tabControlOperationMode.SelectedIndex = 0;
            this.tabControlOperationMode.Size = new System.Drawing.Size(603, 379);
            this.tabControlOperationMode.TabIndex = 14;
            this.tabControlOperationMode.Click += new System.EventHandler(this.tabControlOperationMode_Click);
            // 
            // tabPageVend
            // 
            this.tabPageVend.Controls.Add(this.labelGeneralMessage);
            this.tabPageVend.Controls.Add(this.buttonRegular);
            this.tabPageVend.Controls.Add(this.buttonNickel);
            this.tabPageVend.Controls.Add(this.buttonLemon);
            this.tabPageVend.Controls.Add(this.labelExactChange);
            this.tabPageVend.Controls.Add(this.buttonOrange);
            this.tabPageVend.Controls.Add(this.buttonDime);
            this.tabPageVend.Controls.Add(this.pictureBoxRegular);
            this.tabPageVend.Controls.Add(this.labelCredit);
            this.tabPageVend.Controls.Add(this.pictureBoxLemon);
            this.tabPageVend.Controls.Add(this.buttonQuarter);
            this.tabPageVend.Controls.Add(this.pictureBoxOrange);
            this.tabPageVend.Controls.Add(this.buttonReturn);
            this.tabPageVend.Controls.Add(this.buttonHalfDollar);
            this.tabPageVend.Location = new System.Drawing.Point(4, 22);
            this.tabPageVend.Name = "tabPageVend";
            this.tabPageVend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVend.Size = new System.Drawing.Size(595, 353);
            this.tabPageVend.TabIndex = 0;
            this.tabPageVend.Text = "Vend";
            this.tabPageVend.UseVisualStyleBackColor = true;
            // 
            // tabPageService
            // 
            this.tabPageService.Controls.Add(this.buttonServiceNotes);
            this.tabPageService.Controls.Add(this.groupBoxRackControl);
            this.tabPageService.Controls.Add(this.groupBoxCoinControls);
            this.tabPageService.Location = new System.Drawing.Point(4, 22);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageService.Size = new System.Drawing.Size(595, 353);
            this.tabPageService.TabIndex = 1;
            this.tabPageService.Text = "Service";
            this.tabPageService.UseVisualStyleBackColor = true;
            // 
            // buttonServiceNotes
            // 
            this.buttonServiceNotes.Location = new System.Drawing.Point(23, 261);
            this.buttonServiceNotes.Name = "buttonServiceNotes";
            this.buttonServiceNotes.Size = new System.Drawing.Size(96, 22);
            this.buttonServiceNotes.TabIndex = 6;
            this.buttonServiceNotes.Text = "Service Notes";
            this.buttonServiceNotes.UseVisualStyleBackColor = true;
            this.buttonServiceNotes.Click += new System.EventHandler(this.buttonServiceNotes_Click);
            // 
            // groupBoxRackControl
            // 
            this.groupBoxRackControl.Controls.Add(this.listViewInventory);
            this.groupBoxRackControl.Controls.Add(this.buttonRefill);
            this.groupBoxRackControl.Location = new System.Drawing.Point(8, 6);
            this.groupBoxRackControl.Name = "groupBoxRackControl";
            this.groupBoxRackControl.Size = new System.Drawing.Size(154, 236);
            this.groupBoxRackControl.TabIndex = 5;
            this.groupBoxRackControl.TabStop = false;
            this.groupBoxRackControl.Text = "Rack Controls";
            // 
            // listViewInventory
            // 
            this.listViewInventory.Location = new System.Drawing.Point(15, 19);
            this.listViewInventory.Name = "listViewInventory";
            this.listViewInventory.Size = new System.Drawing.Size(121, 175);
            this.listViewInventory.TabIndex = 0;
            this.listViewInventory.UseCompatibleStateImageBehavior = false;
            // 
            // buttonRefill
            // 
            this.buttonRefill.Location = new System.Drawing.Point(15, 200);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(121, 23);
            this.buttonRefill.TabIndex = 1;
            this.buttonRefill.Text = "refill can rack";
            this.buttonRefill.UseVisualStyleBackColor = true;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click);
            // 
            // groupBoxCoinControls
            // 
            this.groupBoxCoinControls.Controls.Add(this.listViewCoinBoxLocked);
            this.groupBoxCoinControls.Controls.Add(this.buttonEmptyCoinBox);
            this.groupBoxCoinControls.Location = new System.Drawing.Point(178, 6);
            this.groupBoxCoinControls.Name = "groupBoxCoinControls";
            this.groupBoxCoinControls.Size = new System.Drawing.Size(224, 235);
            this.groupBoxCoinControls.TabIndex = 4;
            this.groupBoxCoinControls.TabStop = false;
            this.groupBoxCoinControls.Text = "Coin Box Controls";
            // 
            // listViewCoinBoxLocked
            // 
            this.listViewCoinBoxLocked.Location = new System.Drawing.Point(18, 20);
            this.listViewCoinBoxLocked.Name = "listViewCoinBoxLocked";
            this.listViewCoinBoxLocked.Size = new System.Drawing.Size(200, 175);
            this.listViewCoinBoxLocked.TabIndex = 2;
            this.listViewCoinBoxLocked.UseCompatibleStateImageBehavior = false;
            // 
            // buttonEmptyCoinBox
            // 
            this.buttonEmptyCoinBox.Location = new System.Drawing.Point(18, 201);
            this.buttonEmptyCoinBox.Name = "buttonEmptyCoinBox";
            this.buttonEmptyCoinBox.Size = new System.Drawing.Size(200, 23);
            this.buttonEmptyCoinBox.TabIndex = 3;
            this.buttonEmptyCoinBox.Text = "empty coinbox";
            this.buttonEmptyCoinBox.UseVisualStyleBackColor = true;
            this.buttonEmptyCoinBox.Click += new System.EventHandler(this.buttonEmptyCoinBox_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxSnacks);
            this.tabPage1.Controls.Add(this.buttonStockSnacks);
            this.tabPage1.Controls.Add(this.textBoxSnackDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 353);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPageSnacks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxSnackDetails
            // 
            this.textBoxSnackDetails.Location = new System.Drawing.Point(264, 20);
            this.textBoxSnackDetails.Multiline = true;
            this.textBoxSnackDetails.Name = "textBoxSnackDetails";
            this.textBoxSnackDetails.Size = new System.Drawing.Size(257, 95);
            this.textBoxSnackDetails.TabIndex = 1;
            // 
            // buttonStockSnacks
            // 
            this.buttonStockSnacks.Location = new System.Drawing.Point(17, 312);
            this.buttonStockSnacks.Name = "buttonStockSnacks";
            this.buttonStockSnacks.Size = new System.Drawing.Size(161, 23);
            this.buttonStockSnacks.TabIndex = 2;
            this.buttonStockSnacks.Text = "Stock Snacks";
            this.buttonStockSnacks.UseVisualStyleBackColor = true;
            this.buttonStockSnacks.Click += new System.EventHandler(this.buttonStockSnacks_Click);
            // 
            // listBoxSnacks
            // 
            this.listBoxSnacks.FormattingEnabled = true;
            this.listBoxSnacks.Location = new System.Drawing.Point(17, 16);
            this.listBoxSnacks.Name = "listBoxSnacks";
            this.listBoxSnacks.Size = new System.Drawing.Size(161, 290);
            this.listBoxSnacks.TabIndex = 3;
            this.listBoxSnacks.SelectedIndexChanged += new System.EventHandler(this.listBoxSnacks_SelectedIndexChanged);
            // 
            // VendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 403);
            this.Controls.Add(this.tabControlOperationMode);
            this.Name = "VendingMachine";
            this.Text = "Vending Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegular)).EndInit();
            this.tabControlOperationMode.ResumeLayout(false);
            this.tabPageVend.ResumeLayout(false);
            this.tabPageVend.PerformLayout();
            this.tabPageService.ResumeLayout(false);
            this.groupBoxRackControl.ResumeLayout(false);
            this.groupBoxCoinControls.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelGeneralMessage;
        private System.Windows.Forms.Label labelExactChange;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.PictureBox pictureBoxOrange;
        private System.Windows.Forms.PictureBox pictureBoxLemon;
        private System.Windows.Forms.PictureBox pictureBoxRegular;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonLemon;
        private System.Windows.Forms.Button buttonRegular;
        private System.Windows.Forms.Button buttonHalfDollar;
        private System.Windows.Forms.Button buttonQuarter;
        private System.Windows.Forms.Button buttonDime;
        private System.Windows.Forms.Button buttonNickel;
        private System.Windows.Forms.TabControl tabControlOperationMode;
        private System.Windows.Forms.TabPage tabPageVend;
        private System.Windows.Forms.TabPage tabPageService;
        private System.Windows.Forms.GroupBox groupBoxRackControl;
        private System.Windows.Forms.ListView listViewInventory;
        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.GroupBox groupBoxCoinControls;
        private System.Windows.Forms.ListView listViewCoinBoxLocked;
        private System.Windows.Forms.Button buttonEmptyCoinBox;
        private System.Windows.Forms.Button buttonServiceNotes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonStockSnacks;
        private System.Windows.Forms.TextBox textBoxSnackDetails;
        private System.Windows.Forms.ListBox listBoxSnacks;
    }
}

