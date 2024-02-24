namespace T21.Forms
{
    partial class FormBranchFileMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBranchFileMaintenance));
            this.listBoxBranches = new System.Windows.Forms.ListBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSubmit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.textBoxFaxNumber = new System.Windows.Forms.TextBox();
            this.labelFaxNumber = new System.Windows.Forms.Label();
            this.textBoxTelephoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxPostCode = new System.Windows.Forms.TextBox();
            this.labelPostCode = new System.Windows.Forms.Label();
            this.textBoxAddress5 = new System.Windows.Forms.TextBox();
            this.textBoxAddress4 = new System.Windows.Forms.TextBox();
            this.textBoxAddress3 = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.labelTelephoneNumber = new System.Windows.Forms.Label();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxBranchName = new System.Windows.Forms.TextBox();
            this.labelBranchName = new System.Windows.Forms.Label();
            this.textBoxCustomerAccNumber = new System.Windows.Forms.TextBox();
            this.labelCustomerNumber = new System.Windows.Forms.Label();
            this.textBoxSupplierNumber = new System.Windows.Forms.TextBox();
            this.labelSupplierNumber = new System.Windows.Forms.Label();
            this.labelSelectCompany = new System.Windows.Forms.Label();
            this.comboBoxSelectCompany = new System.Windows.Forms.ComboBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.labelInvoiceMessage = new System.Windows.Forms.Label();
            this.textBoxInvoiceMessage = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
            this.panelAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxBranches
            // 
            this.listBoxBranches.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxBranches.FormattingEnabled = true;
            this.listBoxBranches.Location = new System.Drawing.Point(12, 6);
            this.listBoxBranches.Name = "listBoxBranches";
            this.listBoxBranches.Size = new System.Drawing.Size(157, 381);
            this.listBoxBranches.TabIndex = 41;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 74);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 74);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 74);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButtonExit,
            this.toolStripSeparator2,
            this.toolStripButtonSubmit,
            this.toolStripSeparator4,
            this.toolStripButtonCancel,
            this.toolStripSeparator3});
            this.toolStrip.Location = new System.Drawing.Point(0, 394);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(583, 74);
            this.toolStrip.TabIndex = 40;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.AutoSize = false;
            this.toolStripButtonExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonExit.Image = global::T21.Properties.Resources.exit;
            this.toolStripButtonExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(55, 71);
            this.toolStripButtonExit.Text = "Exit";
            this.toolStripButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // toolStripButtonSubmit
            // 
            this.toolStripButtonSubmit.AutoSize = false;
            this.toolStripButtonSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSubmit.Image = global::T21.Properties.Resources.submit;
            this.toolStripButtonSubmit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonSubmit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSubmit.Name = "toolStripButtonSubmit";
            this.toolStripButtonSubmit.Size = new System.Drawing.Size(55, 71);
            this.toolStripButtonSubmit.Text = "Submit";
            this.toolStripButtonSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSubmit.Click += new System.EventHandler(this.toolStripButtonSubmit_Click);
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.AutoSize = false;
            this.toolStripButtonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonCancel.Image = global::T21.Properties.Resources.cancel;
            this.toolStripButtonCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(55, 71);
            this.toolStripButtonCancel.Text = "Cancel";
            this.toolStripButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonCancel.Click += new System.EventHandler(this.toolStripButtonCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 74);
            // 
            // textBoxFaxNumber
            // 
            this.textBoxFaxNumber.Location = new System.Drawing.Point(303, 183);
            this.textBoxFaxNumber.Name = "textBoxFaxNumber";
            this.textBoxFaxNumber.Size = new System.Drawing.Size(173, 20);
            this.textBoxFaxNumber.TabIndex = 35;
            // 
            // labelFaxNumber
            // 
            this.labelFaxNumber.AutoSize = true;
            this.labelFaxNumber.Location = new System.Drawing.Point(230, 186);
            this.labelFaxNumber.Name = "labelFaxNumber";
            this.labelFaxNumber.Size = new System.Drawing.Size(67, 13);
            this.labelFaxNumber.TabIndex = 34;
            this.labelFaxNumber.Text = "Fax Number:";
            // 
            // textBoxTelephoneNumber
            // 
            this.textBoxTelephoneNumber.Location = new System.Drawing.Point(303, 156);
            this.textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
            this.textBoxTelephoneNumber.Size = new System.Drawing.Size(173, 20);
            this.textBoxTelephoneNumber.TabIndex = 33;
            // 
            // textBoxPostCode
            // 
            this.textBoxPostCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPostCode.Location = new System.Drawing.Point(303, 129);
            this.textBoxPostCode.Name = "textBoxPostCode";
            this.textBoxPostCode.Size = new System.Drawing.Size(99, 20);
            this.textBoxPostCode.TabIndex = 31;
            // 
            // labelPostCode
            // 
            this.labelPostCode.AutoSize = true;
            this.labelPostCode.Location = new System.Drawing.Point(238, 132);
            this.labelPostCode.Name = "labelPostCode";
            this.labelPostCode.Size = new System.Drawing.Size(59, 13);
            this.labelPostCode.TabIndex = 30;
            this.labelPostCode.Text = "Post Code:";
            // 
            // textBoxAddress5
            // 
            this.textBoxAddress5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress5.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAddress5.Location = new System.Drawing.Point(0, 52);
            this.textBoxAddress5.Name = "textBoxAddress5";
            this.textBoxAddress5.Size = new System.Drawing.Size(250, 13);
            this.textBoxAddress5.TabIndex = 11;
            // 
            // textBoxAddress4
            // 
            this.textBoxAddress4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress4.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAddress4.Location = new System.Drawing.Point(0, 39);
            this.textBoxAddress4.Name = "textBoxAddress4";
            this.textBoxAddress4.Size = new System.Drawing.Size(250, 13);
            this.textBoxAddress4.TabIndex = 10;
            // 
            // textBoxAddress3
            // 
            this.textBoxAddress3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAddress3.Location = new System.Drawing.Point(0, 26);
            this.textBoxAddress3.Name = "textBoxAddress3";
            this.textBoxAddress3.Size = new System.Drawing.Size(250, 13);
            this.textBoxAddress3.TabIndex = 9;
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAddress2.Location = new System.Drawing.Point(0, 13);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(250, 13);
            this.textBoxAddress2.TabIndex = 8;
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAddress1.Location = new System.Drawing.Point(0, 0);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(250, 13);
            this.textBoxAddress1.TabIndex = 7;
            // 
            // labelTelephoneNumber
            // 
            this.labelTelephoneNumber.AutoSize = true;
            this.labelTelephoneNumber.Location = new System.Drawing.Point(196, 159);
            this.labelTelephoneNumber.Name = "labelTelephoneNumber";
            this.labelTelephoneNumber.Size = new System.Drawing.Size(101, 13);
            this.labelTelephoneNumber.TabIndex = 32;
            this.labelTelephoneNumber.Text = "Telephone Number:";
            // 
            // panelAddress
            // 
            this.panelAddress.BackColor = System.Drawing.Color.White;
            this.panelAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddress.Controls.Add(this.textBoxAddress5);
            this.panelAddress.Controls.Add(this.textBoxAddress4);
            this.panelAddress.Controls.Add(this.textBoxAddress3);
            this.panelAddress.Controls.Add(this.textBoxAddress2);
            this.panelAddress.Controls.Add(this.textBoxAddress1);
            this.panelAddress.Location = new System.Drawing.Point(303, 49);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(252, 74);
            this.panelAddress.TabIndex = 29;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(249, 50);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 28;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxBranchName
            // 
            this.textBoxBranchName.Location = new System.Drawing.Point(303, 22);
            this.textBoxBranchName.Name = "textBoxBranchName";
            this.textBoxBranchName.Size = new System.Drawing.Size(208, 20);
            this.textBoxBranchName.TabIndex = 27;
            // 
            // labelBranchName
            // 
            this.labelBranchName.AutoSize = true;
            this.labelBranchName.Location = new System.Drawing.Point(222, 25);
            this.labelBranchName.Name = "labelBranchName";
            this.labelBranchName.Size = new System.Drawing.Size(75, 13);
            this.labelBranchName.TabIndex = 26;
            this.labelBranchName.Text = "Branch Name:";
            // 
            // textBoxCustomerAccNumber
            // 
            this.textBoxCustomerAccNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCustomerAccNumber.Location = new System.Drawing.Point(303, 209);
            this.textBoxCustomerAccNumber.Name = "textBoxCustomerAccNumber";
            this.textBoxCustomerAccNumber.Size = new System.Drawing.Size(99, 20);
            this.textBoxCustomerAccNumber.TabIndex = 43;
            // 
            // labelCustomerNumber
            // 
            this.labelCustomerNumber.AutoSize = true;
            this.labelCustomerNumber.Location = new System.Drawing.Point(203, 212);
            this.labelCustomerNumber.Name = "labelCustomerNumber";
            this.labelCustomerNumber.Size = new System.Drawing.Size(94, 13);
            this.labelCustomerNumber.TabIndex = 42;
            this.labelCustomerNumber.Text = "Customer Number:";
            // 
            // textBoxSupplierNumber
            // 
            this.textBoxSupplierNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSupplierNumber.Location = new System.Drawing.Point(303, 235);
            this.textBoxSupplierNumber.Name = "textBoxSupplierNumber";
            this.textBoxSupplierNumber.Size = new System.Drawing.Size(99, 20);
            this.textBoxSupplierNumber.TabIndex = 45;
            // 
            // labelSupplierNumber
            // 
            this.labelSupplierNumber.AutoSize = true;
            this.labelSupplierNumber.Location = new System.Drawing.Point(209, 238);
            this.labelSupplierNumber.Name = "labelSupplierNumber";
            this.labelSupplierNumber.Size = new System.Drawing.Size(88, 13);
            this.labelSupplierNumber.TabIndex = 44;
            this.labelSupplierNumber.Text = "Supplier Number:";
            // 
            // labelSelectCompany
            // 
            this.labelSelectCompany.AutoSize = true;
            this.labelSelectCompany.Location = new System.Drawing.Point(209, 264);
            this.labelSelectCompany.Name = "labelSelectCompany";
            this.labelSelectCompany.Size = new System.Drawing.Size(87, 13);
            this.labelSelectCompany.TabIndex = 46;
            this.labelSelectCompany.Text = "Select Company:";
            // 
            // comboBoxSelectCompany
            // 
            this.comboBoxSelectCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCompany.FormattingEnabled = true;
            this.comboBoxSelectCompany.Location = new System.Drawing.Point(303, 261);
            this.comboBoxSelectCompany.Name = "comboBoxSelectCompany";
            this.comboBoxSelectCompany.Size = new System.Drawing.Size(208, 21);
            this.comboBoxSelectCompany.TabIndex = 47;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(408, 212);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(79, 13);
            this.labelCustomerName.TabIndex = 48;
            this.labelCustomerName.Text = "CustomerName";
            this.labelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(408, 238);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(73, 13);
            this.labelSupplierName.TabIndex = 49;
            this.labelSupplierName.Text = "SupplierName";
            this.labelSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInvoiceMessage
            // 
            this.labelInvoiceMessage.AutoSize = true;
            this.labelInvoiceMessage.Location = new System.Drawing.Point(206, 291);
            this.labelInvoiceMessage.Name = "labelInvoiceMessage";
            this.labelInvoiceMessage.Size = new System.Drawing.Size(91, 13);
            this.labelInvoiceMessage.TabIndex = 50;
            this.labelInvoiceMessage.Text = "Invoice Message:";
            // 
            // textBoxInvoiceMessage
            // 
            this.textBoxInvoiceMessage.Location = new System.Drawing.Point(303, 288);
            this.textBoxInvoiceMessage.Multiline = true;
            this.textBoxInvoiceMessage.Name = "textBoxInvoiceMessage";
            this.textBoxInvoiceMessage.Size = new System.Drawing.Size(252, 99);
            this.textBoxInvoiceMessage.TabIndex = 51;
            // 
            // FormBranchFileMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 468);
            this.Controls.Add(this.textBoxInvoiceMessage);
            this.Controls.Add(this.labelInvoiceMessage);
            this.Controls.Add(this.labelSupplierName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.comboBoxSelectCompany);
            this.Controls.Add(this.labelSelectCompany);
            this.Controls.Add(this.textBoxSupplierNumber);
            this.Controls.Add(this.labelSupplierNumber);
            this.Controls.Add(this.textBoxCustomerAccNumber);
            this.Controls.Add(this.labelCustomerNumber);
            this.Controls.Add(this.listBoxBranches);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.textBoxFaxNumber);
            this.Controls.Add(this.labelFaxNumber);
            this.Controls.Add(this.textBoxTelephoneNumber);
            this.Controls.Add(this.textBoxPostCode);
            this.Controls.Add(this.labelPostCode);
            this.Controls.Add(this.labelTelephoneNumber);
            this.Controls.Add(this.panelAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxBranchName);
            this.Controls.Add(this.labelBranchName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBranchFileMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch File Maintenance";
            this.Load += new System.EventHandler(this.FormBranchFileMaintenance_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelAddress.ResumeLayout(false);
            this.panelAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBranches;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonSubmit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox textBoxFaxNumber;
        private System.Windows.Forms.Label labelFaxNumber;
        private System.Windows.Forms.TextBox textBoxTelephoneNumber;
        private System.Windows.Forms.TextBox textBoxPostCode;
        private System.Windows.Forms.Label labelPostCode;
        private System.Windows.Forms.TextBox textBoxAddress5;
        private System.Windows.Forms.TextBox textBoxAddress4;
        private System.Windows.Forms.TextBox textBoxAddress3;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Label labelTelephoneNumber;
        private System.Windows.Forms.Panel panelAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxBranchName;
        private System.Windows.Forms.Label labelBranchName;
        private System.Windows.Forms.TextBox textBoxCustomerAccNumber;
        private System.Windows.Forms.Label labelCustomerNumber;
        private System.Windows.Forms.TextBox textBoxSupplierNumber;
        private System.Windows.Forms.Label labelSupplierNumber;
        private System.Windows.Forms.Label labelSelectCompany;
        private System.Windows.Forms.ComboBox comboBoxSelectCompany;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.Label labelInvoiceMessage;
        private System.Windows.Forms.TextBox textBoxInvoiceMessage;
    }
}