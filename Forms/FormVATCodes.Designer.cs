namespace T21.Forms
{
    partial class FormVATCodes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVATCodes));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxVATRate = new System.Windows.Forms.TextBox();
            this.labelVATRate = new System.Windows.Forms.Label();
            this.labelEECMember = new System.Windows.Forms.Label();
            this.comboBoxEECMember = new System.Windows.Forms.ComboBox();
            this.labelEECTaxRate = new System.Windows.Forms.Label();
            this.textBoxEECTaxRate = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButtonExit,
            this.toolStripSeparator2,
            this.toolStripButtonOK,
            this.toolStripSeparator4,
            this.toolStripButtonCancel,
            this.toolStripSeparator3,
            this.toolStripButtonDelete,
            this.toolStripSeparator5});
            this.toolStrip.Location = new System.Drawing.Point(0, 303);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(569, 74);
            this.toolStrip.TabIndex = 43;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 74);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 74);
            // 
            // toolStripButtonOK
            // 
            this.toolStripButtonOK.AutoSize = false;
            this.toolStripButtonOK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonOK.Image = global::T21.Properties.Resources.submit;
            this.toolStripButtonOK.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonOK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOK.Name = "toolStripButtonOK";
            this.toolStripButtonOK.Size = new System.Drawing.Size(55, 71);
            this.toolStripButtonOK.Text = "OK";
            this.toolStripButtonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonOK.Click += new System.EventHandler(this.toolStripButtonOK_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 74);
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
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(49, 15);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(35, 13);
            this.labelCode.TabIndex = 44;
            this.labelCode.Text = "Code:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCode.Location = new System.Drawing.Point(90, 12);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(58, 20);
            this.textBoxCode.TabIndex = 45;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(164, 15);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 46;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(233, 12);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(154, 20);
            this.textBoxDescription.TabIndex = 47;
            // 
            // textBoxVATRate
            // 
            this.textBoxVATRate.Location = new System.Drawing.Point(466, 12);
            this.textBoxVATRate.Name = "textBoxVATRate";
            this.textBoxVATRate.Size = new System.Drawing.Size(77, 20);
            this.textBoxVATRate.TabIndex = 49;
            this.textBoxVATRate.Leave += new System.EventHandler(this.textBoxVATRate_Leave);
            // 
            // labelVATRate
            // 
            this.labelVATRate.AutoSize = true;
            this.labelVATRate.Location = new System.Drawing.Point(403, 15);
            this.labelVATRate.Name = "labelVATRate";
            this.labelVATRate.Size = new System.Drawing.Size(57, 13);
            this.labelVATRate.TabIndex = 48;
            this.labelVATRate.Text = "VAT Rate:";
            // 
            // labelEECMember
            // 
            this.labelEECMember.AutoSize = true;
            this.labelEECMember.Location = new System.Drawing.Point(12, 51);
            this.labelEECMember.Name = "labelEECMember";
            this.labelEECMember.Size = new System.Drawing.Size(72, 13);
            this.labelEECMember.TabIndex = 50;
            this.labelEECMember.Text = "EEC Member:";
            // 
            // comboBoxEECMember
            // 
            this.comboBoxEECMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEECMember.FormattingEnabled = true;
            this.comboBoxEECMember.Location = new System.Drawing.Point(90, 48);
            this.comboBoxEECMember.Name = "comboBoxEECMember";
            this.comboBoxEECMember.Size = new System.Drawing.Size(58, 21);
            this.comboBoxEECMember.TabIndex = 51;
            // 
            // labelEECTaxRate
            // 
            this.labelEECTaxRate.AutoSize = true;
            this.labelEECTaxRate.Location = new System.Drawing.Point(164, 51);
            this.labelEECTaxRate.Name = "labelEECTaxRate";
            this.labelEECTaxRate.Size = new System.Drawing.Size(78, 13);
            this.labelEECTaxRate.TabIndex = 52;
            this.labelEECTaxRate.Text = "EEC Tax Rate:";
            // 
            // textBoxEECTaxRate
            // 
            this.textBoxEECTaxRate.Location = new System.Drawing.Point(248, 48);
            this.textBoxEECTaxRate.Name = "textBoxEECTaxRate";
            this.textBoxEECTaxRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxEECTaxRate.TabIndex = 53;
            this.textBoxEECTaxRate.Leave += new System.EventHandler(this.textBoxEECTaxRate_Leave);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(12, 85);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 18;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(545, 205);
            this.dataGridView.TabIndex = 54;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.AutoSize = false;
            this.toolStripButtonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonDelete.Image = global::T21.Properties.Resources.bin;
            this.toolStripButtonDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(55, 71);
            this.toolStripButtonDelete.Text = "Delete";
            this.toolStripButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 74);
            // 
            // FormVATCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 377);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxEECTaxRate);
            this.Controls.Add(this.labelEECTaxRate);
            this.Controls.Add(this.comboBoxEECMember);
            this.Controls.Add(this.labelEECMember);
            this.Controls.Add(this.textBoxVATRate);
            this.Controls.Add(this.labelVATRate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVATCodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAT Codes";
            this.Load += new System.EventHandler(this.FormVATCodes_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonOK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxVATRate;
        private System.Windows.Forms.Label labelVATRate;
        private System.Windows.Forms.Label labelEECMember;
        private System.Windows.Forms.ComboBox comboBoxEECMember;
        private System.Windows.Forms.Label labelEECTaxRate;
        private System.Windows.Forms.TextBox textBoxEECTaxRate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}