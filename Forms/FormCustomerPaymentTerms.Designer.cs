namespace T21.Forms
{
    partial class FormCustomerPaymentTerms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerPaymentTerms));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDaysFromInvDate = new System.Windows.Forms.Label();
            this.textBoxDaysFromInvDate = new System.Windows.Forms.TextBox();
            this.textBoxDaysFromMonthEnd = new System.Windows.Forms.TextBox();
            this.labelDaysFromMonthEnd = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
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
            this.toolStrip.TabIndex = 45;
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
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(68, 15);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(35, 13);
            this.labelCode.TabIndex = 46;
            this.labelCode.Text = "Code:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(109, 12);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(81, 20);
            this.textBoxCode.TabIndex = 47;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(275, 12);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(211, 20);
            this.textBoxDescription.TabIndex = 49;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(206, 15);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 48;
            this.labelDescription.Text = "Description:";
            // 
            // labelDaysFromInvDate
            // 
            this.labelDaysFromInvDate.AutoSize = true;
            this.labelDaysFromInvDate.Location = new System.Drawing.Point(71, 51);
            this.labelDaysFromInvDate.Name = "labelDaysFromInvDate";
            this.labelDaysFromInvDate.Size = new System.Drawing.Size(124, 13);
            this.labelDaysFromInvDate.TabIndex = 50;
            this.labelDaysFromInvDate.Text = "Days From Invoice Date:";
            // 
            // textBoxDaysFromInvDate
            // 
            this.textBoxDaysFromInvDate.Location = new System.Drawing.Point(201, 48);
            this.textBoxDaysFromInvDate.Name = "textBoxDaysFromInvDate";
            this.textBoxDaysFromInvDate.Size = new System.Drawing.Size(69, 20);
            this.textBoxDaysFromInvDate.TabIndex = 51;
            this.textBoxDaysFromInvDate.Enter += new System.EventHandler(this.textBoxDaysFromInvDate_Enter);
            this.textBoxDaysFromInvDate.Leave += new System.EventHandler(this.textBoxDaysFromInvDate_Leave);
            // 
            // textBoxDaysFromMonthEnd
            // 
            this.textBoxDaysFromMonthEnd.Location = new System.Drawing.Point(407, 48);
            this.textBoxDaysFromMonthEnd.Name = "textBoxDaysFromMonthEnd";
            this.textBoxDaysFromMonthEnd.Size = new System.Drawing.Size(69, 20);
            this.textBoxDaysFromMonthEnd.TabIndex = 53;
            this.textBoxDaysFromMonthEnd.Enter += new System.EventHandler(this.textBoxDaysFromMonthEnd_Enter);
            this.textBoxDaysFromMonthEnd.Leave += new System.EventHandler(this.textBoxDaysFromMonthEnd_Leave);
            // 
            // labelDaysFromMonthEnd
            // 
            this.labelDaysFromMonthEnd.AutoSize = true;
            this.labelDaysFromMonthEnd.Location = new System.Drawing.Point(286, 51);
            this.labelDaysFromMonthEnd.Name = "labelDaysFromMonthEnd";
            this.labelDaysFromMonthEnd.Size = new System.Drawing.Size(115, 13);
            this.labelDaysFromMonthEnd.TabIndex = 52;
            this.labelDaysFromMonthEnd.Text = "Days From Month End:";
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
            this.dataGridView.TabIndex = 56;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // FormCustomerPaymentTerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 343);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxDaysFromMonthEnd);
            this.Controls.Add(this.labelDaysFromMonthEnd);
            this.Controls.Add(this.textBoxDaysFromInvDate);
            this.Controls.Add(this.labelDaysFromInvDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCustomerPaymentTerms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Payment Terms";
            this.Load += new System.EventHandler(this.FormCustomerPaymentTerms_Load);
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
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDaysFromInvDate;
        private System.Windows.Forms.TextBox textBoxDaysFromInvDate;
        private System.Windows.Forms.TextBox textBoxDaysFromMonthEnd;
        private System.Windows.Forms.Label labelDaysFromMonthEnd;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}