namespace T21.Forms
{
    partial class FormCurrencyCodes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurrencyCodes));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMakeDefault = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.labelLocalCurrencyCode = new System.Windows.Forms.Label();
            this.textBoxLocalCurrencyCode = new System.Windows.Forms.TextBox();
            this.labelLocalCurrencyName = new System.Windows.Forms.Label();
            this.labelLocalCurrencyPerc = new System.Windows.Forms.Label();
            this.labelDetailsToUpdate = new System.Windows.Forms.Label();
            this.labelCurrencyCode = new System.Windows.Forms.Label();
            this.textBoxCurrencyCode = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelSymbolCode = new System.Windows.Forms.Label();
            this.comboBoxSymbol = new System.Windows.Forms.ComboBox();
            this.labelFixedOrVariable = new System.Windows.Forms.Label();
            this.comboBoxFixedOrVariable = new System.Windows.Forms.ComboBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.labelPercentage1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFixedOrVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripButton1,
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.toolStripButtonMakeDefault,
            this.toolStripSeparator5});
            this.toolStrip.Location = new System.Drawing.Point(0, 376);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(488, 74);
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
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::T21.Properties.Resources.bin;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 71);
            this.toolStripButton1.Text = "Delete";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 74);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 74);
            // 
            // toolStripButtonMakeDefault
            // 
            this.toolStripButtonMakeDefault.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonMakeDefault.AutoSize = false;
            this.toolStripButtonMakeDefault.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonMakeDefault.Image = global::T21.Properties.Resources.help;
            this.toolStripButtonMakeDefault.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonMakeDefault.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonMakeDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMakeDefault.Name = "toolStripButtonMakeDefault";
            this.toolStripButtonMakeDefault.Size = new System.Drawing.Size(55, 71);
            this.toolStripButtonMakeDefault.Text = "Default";
            this.toolStripButtonMakeDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonMakeDefault.Click += new System.EventHandler(this.toolStripButtonMakeDefault_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 74);
            // 
            // labelLocalCurrencyCode
            // 
            this.labelLocalCurrencyCode.AutoSize = true;
            this.labelLocalCurrencyCode.Location = new System.Drawing.Point(18, 12);
            this.labelLocalCurrencyCode.Name = "labelLocalCurrencyCode";
            this.labelLocalCurrencyCode.Size = new System.Drawing.Size(81, 13);
            this.labelLocalCurrencyCode.TabIndex = 44;
            this.labelLocalCurrencyCode.Text = "Local Currency:";
            // 
            // textBoxLocalCurrencyCode
            // 
            this.textBoxLocalCurrencyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLocalCurrencyCode.Enabled = false;
            this.textBoxLocalCurrencyCode.Location = new System.Drawing.Point(105, 9);
            this.textBoxLocalCurrencyCode.Name = "textBoxLocalCurrencyCode";
            this.textBoxLocalCurrencyCode.ReadOnly = true;
            this.textBoxLocalCurrencyCode.Size = new System.Drawing.Size(70, 20);
            this.textBoxLocalCurrencyCode.TabIndex = 45;
            this.textBoxLocalCurrencyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLocalCurrencyName
            // 
            this.labelLocalCurrencyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLocalCurrencyName.Location = new System.Drawing.Point(181, 9);
            this.labelLocalCurrencyName.Name = "labelLocalCurrencyName";
            this.labelLocalCurrencyName.Size = new System.Drawing.Size(151, 20);
            this.labelLocalCurrencyName.TabIndex = 46;
            this.labelLocalCurrencyName.Text = "Loc Curr Name";
            this.labelLocalCurrencyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLocalCurrencyPerc
            // 
            this.labelLocalCurrencyPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLocalCurrencyPerc.Location = new System.Drawing.Point(338, 9);
            this.labelLocalCurrencyPerc.Name = "labelLocalCurrencyPerc";
            this.labelLocalCurrencyPerc.Size = new System.Drawing.Size(117, 20);
            this.labelLocalCurrencyPerc.TabIndex = 47;
            this.labelLocalCurrencyPerc.Text = "Loc Curr Perc";
            this.labelLocalCurrencyPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDetailsToUpdate
            // 
            this.labelDetailsToUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelDetailsToUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailsToUpdate.ForeColor = System.Drawing.Color.White;
            this.labelDetailsToUpdate.Location = new System.Drawing.Point(12, 40);
            this.labelDetailsToUpdate.Name = "labelDetailsToUpdate";
            this.labelDetailsToUpdate.Size = new System.Drawing.Size(464, 14);
            this.labelDetailsToUpdate.TabIndex = 48;
            this.labelDetailsToUpdate.Text = "Details To Update";
            // 
            // labelCurrencyCode
            // 
            this.labelCurrencyCode.AutoSize = true;
            this.labelCurrencyCode.Location = new System.Drawing.Point(30, 70);
            this.labelCurrencyCode.Name = "labelCurrencyCode";
            this.labelCurrencyCode.Size = new System.Drawing.Size(80, 13);
            this.labelCurrencyCode.TabIndex = 49;
            this.labelCurrencyCode.Text = "Currency Code:";
            // 
            // textBoxCurrencyCode
            // 
            this.textBoxCurrencyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCurrencyCode.Location = new System.Drawing.Point(116, 67);
            this.textBoxCurrencyCode.Name = "textBoxCurrencyCode";
            this.textBoxCurrencyCode.Size = new System.Drawing.Size(71, 20);
            this.textBoxCurrencyCode.TabIndex = 50;
            this.textBoxCurrencyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(198, 70);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 51;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(267, 67);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescription.TabIndex = 52;
            // 
            // labelSymbolCode
            // 
            this.labelSymbolCode.AutoSize = true;
            this.labelSymbolCode.Location = new System.Drawing.Point(66, 106);
            this.labelSymbolCode.Name = "labelSymbolCode";
            this.labelSymbolCode.Size = new System.Drawing.Size(44, 13);
            this.labelSymbolCode.TabIndex = 53;
            this.labelSymbolCode.Text = "Symbol:";
            // 
            // comboBoxSymbol
            // 
            this.comboBoxSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSymbol.FormattingEnabled = true;
            this.comboBoxSymbol.Items.AddRange(new object[] {
            "£",
            "$",
            "€"});
            this.comboBoxSymbol.Location = new System.Drawing.Point(117, 103);
            this.comboBoxSymbol.Name = "comboBoxSymbol";
            this.comboBoxSymbol.Size = new System.Drawing.Size(70, 21);
            this.comboBoxSymbol.TabIndex = 54;
            // 
            // labelFixedOrVariable
            // 
            this.labelFixedOrVariable.AutoSize = true;
            this.labelFixedOrVariable.Location = new System.Drawing.Point(22, 143);
            this.labelFixedOrVariable.Name = "labelFixedOrVariable";
            this.labelFixedOrVariable.Size = new System.Drawing.Size(88, 13);
            this.labelFixedOrVariable.TabIndex = 55;
            this.labelFixedOrVariable.Text = "Fixed or Variable:";
            // 
            // comboBoxFixedOrVariable
            // 
            this.comboBoxFixedOrVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFixedOrVariable.FormattingEnabled = true;
            this.comboBoxFixedOrVariable.Items.AddRange(new object[] {
            "Fixed",
            "Variable"});
            this.comboBoxFixedOrVariable.Location = new System.Drawing.Point(116, 140);
            this.comboBoxFixedOrVariable.Name = "comboBoxFixedOrVariable";
            this.comboBoxFixedOrVariable.Size = new System.Drawing.Size(102, 21);
            this.comboBoxFixedOrVariable.TabIndex = 56;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(228, 143);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(33, 13);
            this.labelRate.TabIndex = 57;
            this.labelRate.Text = "Rate:";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(267, 140);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(81, 20);
            this.textBoxRate.TabIndex = 58;
            this.textBoxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxRate.Click += new System.EventHandler(this.textBoxRate_Click);
            this.textBoxRate.Enter += new System.EventHandler(this.textBoxRate_Enter);
            this.textBoxRate.Leave += new System.EventHandler(this.textBoxRate_Leave);
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Location = new System.Drawing.Point(461, 13);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(15, 13);
            this.labelPercentage.TabIndex = 59;
            this.labelPercentage.Text = "%";
            // 
            // labelPercentage1
            // 
            this.labelPercentage1.AutoSize = true;
            this.labelPercentage1.Location = new System.Drawing.Point(354, 143);
            this.labelPercentage1.Name = "labelPercentage1";
            this.labelPercentage1.Size = new System.Drawing.Size(15, 13);
            this.labelPercentage1.TabIndex = 60;
            this.labelPercentage1.Text = "%";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCode,
            this.ColumnSymbol,
            this.ColumnDescription,
            this.ColumnFixedOrVariable,
            this.ColumnRate});
            this.dataGridView.Location = new System.Drawing.Point(12, 178);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Info;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView.RowTemplate.Height = 18;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(464, 185);
            this.dataGridView.TabIndex = 61;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // ColumnCode
            // 
            this.ColumnCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnCode.HeaderText = "Code";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
            this.ColumnCode.Width = 60;
            // 
            // ColumnSymbol
            // 
            this.ColumnSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnSymbol.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnSymbol.HeaderText = "Symbol";
            this.ColumnSymbol.Name = "ColumnSymbol";
            this.ColumnSymbol.ReadOnly = true;
            this.ColumnSymbol.Width = 60;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnDescription.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            // 
            // ColumnFixedOrVariable
            // 
            this.ColumnFixedOrVariable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnFixedOrVariable.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnFixedOrVariable.HeaderText = "Fixed/Variable";
            this.ColumnFixedOrVariable.Name = "ColumnFixedOrVariable";
            this.ColumnFixedOrVariable.ReadOnly = true;
            // 
            // ColumnRate
            // 
            this.ColumnRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnRate.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnRate.HeaderText = "Rate %";
            this.ColumnRate.Name = "ColumnRate";
            this.ColumnRate.ReadOnly = true;
            this.ColumnRate.Width = 80;
            // 
            // FormCurrencyCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelPercentage1);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.comboBoxFixedOrVariable);
            this.Controls.Add(this.labelFixedOrVariable);
            this.Controls.Add(this.comboBoxSymbol);
            this.Controls.Add(this.labelSymbolCode);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxCurrencyCode);
            this.Controls.Add(this.labelCurrencyCode);
            this.Controls.Add(this.labelDetailsToUpdate);
            this.Controls.Add(this.labelLocalCurrencyPerc);
            this.Controls.Add(this.labelLocalCurrencyName);
            this.Controls.Add(this.textBoxLocalCurrencyCode);
            this.Controls.Add(this.labelLocalCurrencyCode);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCurrencyCodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Codes";
            this.Load += new System.EventHandler(this.FormCurrencyCodes_Load);
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
        private System.Windows.Forms.Label labelLocalCurrencyCode;
        private System.Windows.Forms.TextBox textBoxLocalCurrencyCode;
        private System.Windows.Forms.Label labelLocalCurrencyName;
        private System.Windows.Forms.Label labelLocalCurrencyPerc;
        private System.Windows.Forms.Label labelDetailsToUpdate;
        private System.Windows.Forms.Label labelCurrencyCode;
        private System.Windows.Forms.TextBox textBoxCurrencyCode;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelSymbolCode;
        private System.Windows.Forms.ComboBox comboBoxSymbol;
        private System.Windows.Forms.Label labelFixedOrVariable;
        private System.Windows.Forms.ComboBox comboBoxFixedOrVariable;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Label labelPercentage1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFixedOrVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRate;
        private System.Windows.Forms.ToolStripButton toolStripButtonMakeDefault;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}