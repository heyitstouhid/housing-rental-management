namespace Housing01
{
    partial class RentlForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRentalList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMonthlyRent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbIsReturnDeposit = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnSelectTenant = new System.Windows.Forms.Button();
            this.btnSelectHouse = new System.Windows.Forms.Button();
            this.tbDepositPaid = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbTenantID = new System.Windows.Forms.TextBox();
            this.tbHouseID = new System.Windows.Forms.TextBox();
            this.tbRentalID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbValue);
            this.panel1.Controls.Add(this.cmbCondition);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(15, 382);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 76);
            this.panel1.TabIndex = 6;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(434, 28);
            this.tbValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(200, 28);
            this.tbValue.TabIndex = 4;
            // 
            // cmbCondition
            // 
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Location = new System.Drawing.Point(141, 30);
            this.cmbCondition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(180, 26);
            this.cmbCondition.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(730, 26);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(112, 34);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Query";
            this.btnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Value：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Condition：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRentalList);
            this.groupBox2.Location = new System.Drawing.Point(15, 477);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1315, 276);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rental List";
            // 
            // dgvRentalList
            // 
            this.dgvRentalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentalList.Location = new System.Drawing.Point(4, 25);
            this.dgvRentalList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRentalList.Name = "dgvRentalList";
            this.dgvRentalList.RowHeadersWidth = 62;
            this.dgvRentalList.RowTemplate.Height = 23;
            this.dgvRentalList.Size = new System.Drawing.Size(1307, 247);
            this.dgvRentalList.TabIndex = 0;
            this.dgvRentalList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRentalList_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMonthlyRent);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmbIsReturnDeposit);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnRent);
            this.groupBox1.Controls.Add(this.btnSelectTenant);
            this.groupBox1.Controls.Add(this.btnSelectHouse);
            this.groupBox1.Controls.Add(this.tbDepositPaid);
            this.groupBox1.Controls.Add(this.tbEndDate);
            this.groupBox1.Controls.Add(this.tbRemark);
            this.groupBox1.Controls.Add(this.tbStartDate);
            this.groupBox1.Controls.Add(this.tbTenantID);
            this.groupBox1.Controls.Add(this.tbHouseID);
            this.groupBox1.Controls.Add(this.tbRentalID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1318, 356);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental Registration";
            // 
            // tbMonthlyRent
            // 
            this.tbMonthlyRent.Location = new System.Drawing.Point(198, 233);
            this.tbMonthlyRent.Margin = new System.Windows.Forms.Padding(4);
            this.tbMonthlyRent.Name = "tbMonthlyRent";
            this.tbMonthlyRent.Size = new System.Drawing.Size(218, 28);
            this.tbMonthlyRent.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 235);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "MonthlyRent:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(425, 191);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(192, 28);
            this.dateTimePicker2.TabIndex = 33;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(423, 150);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 28);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbIsReturnDeposit
            // 
            this.cmbIsReturnDeposit.FormattingEnabled = true;
            this.cmbIsReturnDeposit.Location = new System.Drawing.Point(198, 314);
            this.cmbIsReturnDeposit.Name = "cmbIsReturnDeposit";
            this.cmbIsReturnDeposit.Size = new System.Drawing.Size(218, 26);
            this.cmbIsReturnDeposit.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1180, 298);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1060, 298);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(940, 298);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Modify";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(820, 298);
            this.btnRent.Margin = new System.Windows.Forms.Padding(4);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(112, 34);
            this.btnRent.TabIndex = 28;
            this.btnRent.Text = "Rent";
            this.btnRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnSelectTenant
            // 
            this.btnSelectTenant.Location = new System.Drawing.Point(363, 99);
            this.btnSelectTenant.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectTenant.Name = "btnSelectTenant";
            this.btnSelectTenant.Size = new System.Drawing.Size(66, 34);
            this.btnSelectTenant.TabIndex = 27;
            this.btnSelectTenant.Text = "...";
            this.btnSelectTenant.UseVisualStyleBackColor = true;
            this.btnSelectTenant.Click += new System.EventHandler(this.btnSelectTenant_Click);
            // 
            // btnSelectHouse
            // 
            this.btnSelectHouse.Location = new System.Drawing.Point(363, 63);
            this.btnSelectHouse.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectHouse.Name = "btnSelectHouse";
            this.btnSelectHouse.Size = new System.Drawing.Size(66, 34);
            this.btnSelectHouse.TabIndex = 26;
            this.btnSelectHouse.Text = "...";
            this.btnSelectHouse.UseVisualStyleBackColor = true;
            this.btnSelectHouse.Click += new System.EventHandler(this.btnSelectHouse_Click);
            // 
            // tbDepositPaid
            // 
            this.tbDepositPaid.Location = new System.Drawing.Point(198, 269);
            this.tbDepositPaid.Margin = new System.Windows.Forms.Padding(4);
            this.tbDepositPaid.Name = "tbDepositPaid";
            this.tbDepositPaid.Size = new System.Drawing.Size(218, 28);
            this.tbDepositPaid.TabIndex = 24;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(198, 189);
            this.tbEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(218, 28);
            this.tbEndDate.TabIndex = 25;
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(738, 99);
            this.tbRemark.Margin = new System.Windows.Forms.Padding(4);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(554, 184);
            this.tbRemark.TabIndex = 23;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(198, 147);
            this.tbStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(218, 28);
            this.tbStartDate.TabIndex = 22;
            // 
            // tbTenantID
            // 
            this.tbTenantID.Location = new System.Drawing.Point(198, 101);
            this.tbTenantID.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenantID.Name = "tbTenantID";
            this.tbTenantID.Size = new System.Drawing.Size(148, 28);
            this.tbTenantID.TabIndex = 21;
            // 
            // tbHouseID
            // 
            this.tbHouseID.Location = new System.Drawing.Point(198, 65);
            this.tbHouseID.Margin = new System.Windows.Forms.Padding(4);
            this.tbHouseID.Name = "tbHouseID";
            this.tbHouseID.Size = new System.Drawing.Size(148, 28);
            this.tbHouseID.TabIndex = 20;
            // 
            // tbRentalID
            // 
            this.tbRentalID.Location = new System.Drawing.Point(198, 25);
            this.tbRentalID.Margin = new System.Windows.Forms.Padding(4);
            this.tbRentalID.Name = "tbRentalID";
            this.tbRentalID.Size = new System.Drawing.Size(148, 28);
            this.tbRentalID.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 314);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "IsReturnDeposit:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(735, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Remark:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "DepositPaid:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "StartDate：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "TenantID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "EndDate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "HouseID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "RentalID:";
            // 
            // RentlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 764);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "RentlForm";
            this.Text = "RentForm";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRentalList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbIsReturnDeposit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnSelectTenant;
        private System.Windows.Forms.Button btnSelectHouse;
        private System.Windows.Forms.TextBox tbDepositPaid;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbTenantID;
        private System.Windows.Forms.TextBox tbHouseID;
        private System.Windows.Forms.TextBox tbRentalID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMonthlyRent;
        private System.Windows.Forms.Label label11;
    }
}