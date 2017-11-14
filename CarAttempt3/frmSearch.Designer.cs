namespace CarAttempt3
{
    partial class frmSearch
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
            this.components = new System.ComponentModel.Container();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.hireDataSet = new CarAttempt3.HireDataSet();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarTableAdapter = new CarAttempt3.HireDataSetTableAdapters.tblCarTableAdapter();
            this.vehicleRegNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegisteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.cboOperator);
            this.grpBox.Controls.Add(this.cboField);
            this.grpBox.Controls.Add(this.txtValue);
            this.grpBox.Controls.Add(this.lblValue);
            this.grpBox.Controls.Add(this.lblOperator);
            this.grpBox.Controls.Add(this.lblField);
            this.grpBox.Location = new System.Drawing.Point(12, 40);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(622, 112);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(212, 61);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(121, 24);
            this.cboOperator.TabIndex = 5;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(50, 61);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 24);
            this.cboField.TabIndex = 4;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(411, 61);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 22);
            this.txtValue.TabIndex = 3;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(408, 34);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(44, 17);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(209, 34);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(65, 17);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "Operator";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(47, 34);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(38, 17);
            this.lblField.TabIndex = 0;
            this.lblField.Text = "Field";
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AutoGenerateColumns = false;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleRegNoDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.engineSizeDataGridViewTextBoxColumn,
            this.dateRegisteredDataGridViewTextBoxColumn,
            this.rentalPerDayDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn});
            this.dgvSearchResults.DataSource = this.tblCarBindingSource;
            this.dgvSearchResults.Location = new System.Drawing.Point(12, 170);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.RowTemplate.Height = 24;
            this.dgvSearchResults.Size = new System.Drawing.Size(804, 209);
            this.dgvSearchResults.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(666, 44);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(119, 51);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(666, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 51);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "HireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarBindingSource
            // 
            this.tblCarBindingSource.DataMember = "tblCar";
            this.tblCarBindingSource.DataSource = this.hireDataSet;
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleRegNoDataGridViewTextBoxColumn
            // 
            this.vehicleRegNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleRegNo";
            this.vehicleRegNoDataGridViewTextBoxColumn.HeaderText = "VehicleRegNo";
            this.vehicleRegNoDataGridViewTextBoxColumn.Name = "vehicleRegNoDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // engineSizeDataGridViewTextBoxColumn
            // 
            this.engineSizeDataGridViewTextBoxColumn.DataPropertyName = "EngineSize";
            this.engineSizeDataGridViewTextBoxColumn.HeaderText = "EngineSize";
            this.engineSizeDataGridViewTextBoxColumn.Name = "engineSizeDataGridViewTextBoxColumn";
            // 
            // dateRegisteredDataGridViewTextBoxColumn
            // 
            this.dateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.HeaderText = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.Name = "dateRegisteredDataGridViewTextBoxColumn";
            // 
            // rentalPerDayDataGridViewTextBoxColumn
            // 
            this.rentalPerDayDataGridViewTextBoxColumn.DataPropertyName = "RentalPerDay";
            this.rentalPerDayDataGridViewTextBoxColumn.HeaderText = "RentalPerDay";
            this.rentalPerDayDataGridViewTextBoxColumn.Name = "rentalPerDayDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewCheckBoxColumn
            // 
            this.availableDataGridViewCheckBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewCheckBoxColumn.HeaderText = "Available";
            this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 391);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.grpBox);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private HireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegisteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalPerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
    }
}