namespace CarAttempt3
{
    partial class frmCars
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVehicleRegNo = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.lblDateRegistered = new System.Windows.Forms.Label();
            this.lblRentalPerDay = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txtVehicleRegNo = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.txtDateRegistered = new System.Windows.Forms.TextBox();
            this.txtRentalPerDay = new System.Windows.Forms.TextBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtCurrentRecord = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(205, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(354, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bowman Car Hire";
            // 
            // lblVehicleRegNo
            // 
            this.lblVehicleRegNo.AutoSize = true;
            this.lblVehicleRegNo.Location = new System.Drawing.Point(78, 125);
            this.lblVehicleRegNo.Name = "lblVehicleRegNo";
            this.lblVehicleRegNo.Size = new System.Drawing.Size(188, 17);
            this.lblVehicleRegNo.TabIndex = 1;
            this.lblVehicleRegNo.Text = "Vehicle Registration Number";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(78, 181);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(42, 17);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make";
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(78, 237);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(83, 17);
            this.lblEngineSize.TabIndex = 3;
            this.lblEngineSize.Text = "Engine Size";
            // 
            // lblDateRegistered
            // 
            this.lblDateRegistered.AutoSize = true;
            this.lblDateRegistered.Location = new System.Drawing.Point(78, 293);
            this.lblDateRegistered.Name = "lblDateRegistered";
            this.lblDateRegistered.Size = new System.Drawing.Size(111, 17);
            this.lblDateRegistered.TabIndex = 4;
            this.lblDateRegistered.Text = "Date Registered";
            // 
            // lblRentalPerDay
            // 
            this.lblRentalPerDay.AutoSize = true;
            this.lblRentalPerDay.Location = new System.Drawing.Point(78, 349);
            this.lblRentalPerDay.Name = "lblRentalPerDay";
            this.lblRentalPerDay.Size = new System.Drawing.Size(104, 17);
            this.lblRentalPerDay.TabIndex = 5;
            this.lblRentalPerDay.Text = "Rental Per Day";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(78, 405);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(65, 17);
            this.lblAvailable.TabIndex = 6;
            this.lblAvailable.Text = "Available";
            // 
            // txtVehicleRegNo
            // 
            this.txtVehicleRegNo.Location = new System.Drawing.Point(327, 125);
            this.txtVehicleRegNo.Name = "txtVehicleRegNo";
            this.txtVehicleRegNo.Size = new System.Drawing.Size(130, 22);
            this.txtVehicleRegNo.TabIndex = 7;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(327, 176);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(153, 22);
            this.txtMake.TabIndex = 8;
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.Location = new System.Drawing.Point(327, 234);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(100, 22);
            this.txtEngineSize.TabIndex = 9;
            // 
            // txtDateRegistered
            // 
            this.txtDateRegistered.Location = new System.Drawing.Point(327, 288);
            this.txtDateRegistered.Name = "txtDateRegistered";
            this.txtDateRegistered.Size = new System.Drawing.Size(100, 22);
            this.txtDateRegistered.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtDateRegistered, "Enter Date in the format DD-MM-YYYY.");
            // 
            // txtRentalPerDay
            // 
            this.txtRentalPerDay.Location = new System.Drawing.Point(327, 346);
            this.txtRentalPerDay.Name = "txtRentalPerDay";
            this.txtRentalPerDay.Size = new System.Drawing.Size(100, 22);
            this.txtRentalPerDay.TabIndex = 11;
            this.txtRentalPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(327, 401);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(18, 17);
            this.chkAvailable.TabIndex = 12;
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(652, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 50);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Update";
            this.toolTip1.SetToolTip(this.btnUpdate, "This edits the current record.");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(652, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 50);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(652, 301);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 50);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "&Search";
            this.toolTip1.SetToolTip(this.btnSearch, "This will bring up a new window for filtering results.");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(652, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 50);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(652, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 50);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(652, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 50);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(51, 505);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(111, 50);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(168, 505);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(111, 50);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(429, 505);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 50);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(546, 505);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(111, 50);
            this.btnLast.TabIndex = 22;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtCurrentRecord
            // 
            this.txtCurrentRecord.Location = new System.Drawing.Point(289, 519);
            this.txtCurrentRecord.Name = "txtCurrentRecord";
            this.txtCurrentRecord.Size = new System.Drawing.Size(130, 22);
            this.txtCurrentRecord.TabIndex = 23;
            this.txtCurrentRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 570);
            this.Controls.Add(this.txtCurrentRecord);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.txtRentalPerDay);
            this.Controls.Add(this.txtDateRegistered);
            this.Controls.Add(this.txtEngineSize);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtVehicleRegNo);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblRentalPerDay);
            this.Controls.Add(this.lblDateRegistered);
            this.Controls.Add(this.lblEngineSize);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblVehicleRegNo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCars";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCars_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVehicleRegNo;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.Label lblDateRegistered;
        private System.Windows.Forms.Label lblRentalPerDay;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txtVehicleRegNo;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.TextBox txtDateRegistered;
        private System.Windows.Forms.TextBox txtRentalPerDay;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtCurrentRecord;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

