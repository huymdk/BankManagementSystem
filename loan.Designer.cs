namespace BankManagement
{
    partial class loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblADMin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InterestDate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.txtLoanType = new System.Windows.Forms.TextBox();
            this.LoanType = new System.Windows.Forms.Label();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLoan = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblADMin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 69);
            this.panel1.TabIndex = 3;
            // 
            // lblADMin
            // 
            this.lblADMin.AutoSize = true;
            this.lblADMin.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblADMin.Location = new System.Drawing.Point(468, 9);
            this.lblADMin.Name = "lblADMin";
            this.lblADMin.Size = new System.Drawing.Size(98, 39);
            this.lblADMin.TabIndex = 2;
            this.lblADMin.Text = "Loan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtInterestRate);
            this.panel2.Controls.Add(this.dtpLoanDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.InterestDate);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.Amount);
            this.panel2.Controls.Add(this.txtLoanType);
            this.panel2.Controls.Add(this.LoanType);
            this.panel2.Controls.Add(this.txtLoanID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(45, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 357);
            this.panel2.TabIndex = 4;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(174, 164);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(347, 22);
            this.txtInterestRate.TabIndex = 22;
            this.txtInterestRate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInterestRate_KeyUp);
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.CalendarFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoanDate.Location = new System.Drawing.Point(174, 205);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(347, 22);
            this.dtpLoanDate.TabIndex = 21;
            this.dtpLoanDate.ValueChanged += new System.EventHandler(this.dtpLoanDate_ValueChanged);
            this.dtpLoanDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpLoanDate_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Customer_Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(421, 297);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 46);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(290, 297);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 46);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(157, 297);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 46);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(37, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 46);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(174, 249);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(347, 22);
            this.txtCustomerName.TabIndex = 13;
            this.txtCustomerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loan_Date:";
            // 
            // InterestDate
            // 
            this.InterestDate.AutoSize = true;
            this.InterestDate.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestDate.Location = new System.Drawing.Point(13, 163);
            this.InterestDate.Name = "InterestDate";
            this.InterestDate.Size = new System.Drawing.Size(127, 21);
            this.InterestDate.TabIndex = 10;
            this.InterestDate.Text = "Interest_Date:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(177, 119);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(347, 22);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyUp);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(13, 118);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(78, 21);
            this.Amount.TabIndex = 8;
            this.Amount.Text = "Amount:";
            // 
            // txtLoanType
            // 
            this.txtLoanType.Location = new System.Drawing.Point(177, 74);
            this.txtLoanType.Name = "txtLoanType";
            this.txtLoanType.Size = new System.Drawing.Size(347, 22);
            this.txtLoanType.TabIndex = 7;
            this.txtLoanType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLoanType_KeyUp);
            // 
            // LoanType
            // 
            this.LoanType.AutoSize = true;
            this.LoanType.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanType.Location = new System.Drawing.Point(13, 73);
            this.LoanType.Name = "LoanType";
            this.LoanType.Size = new System.Drawing.Size(102, 21);
            this.LoanType.TabIndex = 6;
            this.LoanType.Text = "Loan_Type:";
            // 
            // txtLoanID
            // 
            this.txtLoanID.Location = new System.Drawing.Point(177, 30);
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(347, 22);
            this.txtLoanID.TabIndex = 5;
            this.txtLoanID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLoanID_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "LoanID:";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(599, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 357);
            this.panel3.TabIndex = 5;
            // 
            // dgvLoan
            // 
            this.dgvLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoan.Location = new System.Drawing.Point(45, 483);
            this.dgvLoan.Name = "dgvLoan";
            this.dgvLoan.RowHeadersWidth = 51;
            this.dgvLoan.RowTemplate.Height = 24;
            this.dgvLoan.Size = new System.Drawing.Size(1023, 177);
            this.dgvLoan.TabIndex = 6;
            // 
            // loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1100, 672);
            this.Controls.Add(this.dgvLoan);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "loan";
            this.Text = "loan";
            this.Load += new System.EventHandler(this.loan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblADMin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label InterestDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox txtLoanType;
        private System.Windows.Forms.Label LoanType;
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvLoan;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.Label label6;
    }
}