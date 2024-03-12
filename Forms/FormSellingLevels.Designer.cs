namespace T21.Forms
{
    partial class FormSellingLevels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSellingLevels));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelSellingLevelName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxDefault = new System.Windows.Forms.CheckBox();
            this.labelMinimumMargin = new System.Windows.Forms.Label();
            this.textBoxMinimumMargin = new System.Windows.Forms.TextBox();
            this.textBoxSuggestedMargin = new System.Windows.Forms.TextBox();
            this.labelSuggestedMargin = new System.Windows.Forms.Label();
            this.checkBoxVATInclusive = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
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
            this.toolStrip.Location = new System.Drawing.Point(0, 269);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(551, 74);
            this.toolStrip.TabIndex = 44;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 74);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 74);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 74);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 74);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 74);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(41, 15);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(35, 13);
            this.labelCode.TabIndex = 45;
            this.labelCode.Text = "Code:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(82, 12);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(63, 20);
            this.textBoxCode.TabIndex = 46;
            // 
            // labelSellingLevelName
            // 
            this.labelSellingLevelName.AutoSize = true;
            this.labelSellingLevelName.Location = new System.Drawing.Point(161, 15);
            this.labelSellingLevelName.Name = "labelSellingLevelName";
            this.labelSellingLevelName.Size = new System.Drawing.Size(63, 13);
            this.labelSellingLevelName.TabIndex = 47;
            this.labelSellingLevelName.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(230, 12);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(198, 20);
            this.textBoxDescription.TabIndex = 48;
            // 
            // checkBoxDefault
            // 
            this.checkBoxDefault.AutoSize = true;
            this.checkBoxDefault.Location = new System.Drawing.Point(444, 14);
            this.checkBoxDefault.Name = "checkBoxDefault";
            this.checkBoxDefault.Size = new System.Drawing.Size(60, 17);
            this.checkBoxDefault.TabIndex = 49;
            this.checkBoxDefault.Text = "Default";
            this.checkBoxDefault.UseVisualStyleBackColor = true;
            // 
            // labelMinimumMargin
            // 
            this.labelMinimumMargin.AutoSize = true;
            this.labelMinimumMargin.Location = new System.Drawing.Point(14, 51);
            this.labelMinimumMargin.Name = "labelMinimumMargin";
            this.labelMinimumMargin.Size = new System.Drawing.Size(73, 13);
            this.labelMinimumMargin.TabIndex = 50;
            this.labelMinimumMargin.Text = "Min Margin %:";
            // 
            // textBoxMinimumMargin
            // 
            this.textBoxMinimumMargin.Location = new System.Drawing.Point(93, 48);
            this.textBoxMinimumMargin.Name = "textBoxMinimumMargin";
            this.textBoxMinimumMargin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinimumMargin.TabIndex = 51;
            this.textBoxMinimumMargin.Click += new System.EventHandler(this.textBoxMinimumMargin_Click);
            this.textBoxMinimumMargin.Enter += new System.EventHandler(this.textBoxMinimumMargin_Enter);
            this.textBoxMinimumMargin.Leave += new System.EventHandler(this.textBoxMinimumMargin_Leave);
            // 
            // textBoxSuggestedMargin
            // 
            this.textBoxSuggestedMargin.Location = new System.Drawing.Point(322, 48);
            this.textBoxSuggestedMargin.Name = "textBoxSuggestedMargin";
            this.textBoxSuggestedMargin.Size = new System.Drawing.Size(100, 20);
            this.textBoxSuggestedMargin.TabIndex = 53;
            this.textBoxSuggestedMargin.Click += new System.EventHandler(this.textBoxSuggestedMargin_Click);
            this.textBoxSuggestedMargin.Enter += new System.EventHandler(this.textBoxSuggestedMargin_Enter);
            this.textBoxSuggestedMargin.Leave += new System.EventHandler(this.textBoxSuggestedMargin_Leave);
            // 
            // labelSuggestedMargin
            // 
            this.labelSuggestedMargin.AutoSize = true;
            this.labelSuggestedMargin.Location = new System.Drawing.Point(209, 51);
            this.labelSuggestedMargin.Name = "labelSuggestedMargin";
            this.labelSuggestedMargin.Size = new System.Drawing.Size(107, 13);
            this.labelSuggestedMargin.TabIndex = 52;
            this.labelSuggestedMargin.Text = "Suggested Margin %:";
            // 
            // checkBoxVATInclusive
            // 
            this.checkBoxVATInclusive.AutoSize = true;
            this.checkBoxVATInclusive.Location = new System.Drawing.Point(438, 51);
            this.checkBoxVATInclusive.Name = "checkBoxVATInclusive";
            this.checkBoxVATInclusive.Size = new System.Drawing.Size(92, 17);
            this.checkBoxVATInclusive.TabIndex = 54;
            this.checkBoxVATInclusive.Text = "VAT Inclusive";
            this.checkBoxVATInclusive.UseVisualStyleBackColor = true;
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
            this.dataGridView.Location = new System.Drawing.Point(12, 84);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 18;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(527, 172);
            this.dataGridView.TabIndex = 55;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
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
            // FormSellingLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 343);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.checkBoxVATInclusive);
            this.Controls.Add(this.textBoxSuggestedMargin);
            this.Controls.Add(this.labelSuggestedMargin);
            this.Controls.Add(this.textBoxMinimumMargin);
            this.Controls.Add(this.labelMinimumMargin);
            this.Controls.Add(this.checkBoxDefault);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelSellingLevelName);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSellingLevels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling Levels";
            this.Load += new System.EventHandler(this.FormSellingLevels_Load);
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
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelSellingLevelName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxDefault;
        private System.Windows.Forms.Label labelMinimumMargin;
        private System.Windows.Forms.TextBox textBoxMinimumMargin;
        private System.Windows.Forms.TextBox textBoxSuggestedMargin;
        private System.Windows.Forms.Label labelSuggestedMargin;
        private System.Windows.Forms.CheckBox checkBoxVATInclusive;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}