namespace BankLoan
{
    partial class frmBankLoan
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
            this.gbCreateLoan = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rbShortTerm = new System.Windows.Forms.RadioButton();
            this.rbLongTerm = new System.Windows.Forms.RadioButton();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbManageLoan = new System.Windows.Forms.GroupBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblTermAmount = new System.Windows.Forms.Label();
            this.lblAfterPayment = new System.Windows.Forms.Label();
            this.lblAfterInterest = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.gbCreateLoan.SuspendLayout();
            this.gbManageLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreateLoan
            // 
            this.gbCreateLoan.BackColor = System.Drawing.Color.Fuchsia;
            this.gbCreateLoan.Controls.Add(this.btnClear);
            this.gbCreateLoan.Controls.Add(this.btnCreateLoan);
            this.gbCreateLoan.Controls.Add(this.rbLongTerm);
            this.gbCreateLoan.Controls.Add(this.rbShortTerm);
            this.gbCreateLoan.Controls.Add(this.txtAmount);
            this.gbCreateLoan.Controls.Add(this.txtName);
            this.gbCreateLoan.Controls.Add(this.lblType);
            this.gbCreateLoan.Controls.Add(this.lblAmount);
            this.gbCreateLoan.Controls.Add(this.lblName);
            this.gbCreateLoan.Location = new System.Drawing.Point(119, 65);
            this.gbCreateLoan.Name = "gbCreateLoan";
            this.gbCreateLoan.Size = new System.Drawing.Size(573, 152);
            this.gbCreateLoan.TabIndex = 0;
            this.gbCreateLoan.TabStop = false;
            this.gbCreateLoan.Text = "Create Loan";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(23, 56);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 20);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(23, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(309, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(116, 56);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(309, 26);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbShortTerm
            // 
            this.rbShortTerm.AutoSize = true;
            this.rbShortTerm.Location = new System.Drawing.Point(116, 90);
            this.rbShortTerm.Name = "rbShortTerm";
            this.rbShortTerm.Size = new System.Drawing.Size(153, 24);
            this.rbShortTerm.TabIndex = 5;
            this.rbShortTerm.TabStop = true;
            this.rbShortTerm.Text = "Short Term Loan";
            this.rbShortTerm.UseVisualStyleBackColor = true;
            // 
            // rbLongTerm
            // 
            this.rbLongTerm.AutoSize = true;
            this.rbLongTerm.Location = new System.Drawing.Point(275, 88);
            this.rbLongTerm.Name = "rbLongTerm";
            this.rbLongTerm.Size = new System.Drawing.Size(150, 24);
            this.rbLongTerm.TabIndex = 6;
            this.rbLongTerm.TabStop = true;
            this.rbLongTerm.Text = "Long Term Loan";
            this.rbLongTerm.UseVisualStyleBackColor = true;
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(464, 25);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(103, 51);
            this.btnCreateLoan.TabIndex = 7;
            this.btnCreateLoan.Text = "Create Loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(464, 88);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 51);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbManageLoan
            // 
            this.gbManageLoan.BackColor = System.Drawing.Color.Fuchsia;
            this.gbManageLoan.Controls.Add(this.btnExit);
            this.gbManageLoan.Controls.Add(this.btnMakePayment);
            this.gbManageLoan.Controls.Add(this.lblAfterInterest);
            this.gbManageLoan.Controls.Add(this.lblAfterPayment);
            this.gbManageLoan.Controls.Add(this.lblTermAmount);
            this.gbManageLoan.Controls.Add(this.lblName2);
            this.gbManageLoan.Location = new System.Drawing.Point(119, 245);
            this.gbManageLoan.Name = "gbManageLoan";
            this.gbManageLoan.Size = new System.Drawing.Size(573, 193);
            this.gbManageLoan.TabIndex = 1;
            this.gbManageLoan.TabStop = false;
            this.gbManageLoan.Text = "Manage Loan";
            // 
            // lblName2
            // 
            this.lblName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblName2.Location = new System.Drawing.Point(19, 35);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(389, 23);
            this.lblName2.TabIndex = 1;
            // 
            // lblTermAmount
            // 
            this.lblTermAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTermAmount.Location = new System.Drawing.Point(19, 72);
            this.lblTermAmount.Name = "lblTermAmount";
            this.lblTermAmount.Size = new System.Drawing.Size(389, 23);
            this.lblTermAmount.TabIndex = 2;
            // 
            // lblAfterPayment
            // 
            this.lblAfterPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAfterPayment.Location = new System.Drawing.Point(19, 113);
            this.lblAfterPayment.Name = "lblAfterPayment";
            this.lblAfterPayment.Size = new System.Drawing.Size(389, 23);
            this.lblAfterPayment.TabIndex = 3;
            // 
            // lblAfterInterest
            // 
            this.lblAfterInterest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAfterInterest.Location = new System.Drawing.Point(19, 150);
            this.lblAfterInterest.Name = "lblAfterInterest";
            this.lblAfterInterest.Size = new System.Drawing.Size(389, 23);
            this.lblAfterInterest.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(414, 92);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 51);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(414, 35);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(103, 51);
            this.btnMakePayment.TabIndex = 0;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // frmBankLoan
            // 
            this.AcceptButton = this.btnCreateLoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbManageLoan);
            this.Controls.Add(this.gbCreateLoan);
            this.Name = "frmBankLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Loan";
            this.gbCreateLoan.ResumeLayout(false);
            this.gbCreateLoan.PerformLayout();
            this.gbManageLoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreateLoan;
        private System.Windows.Forms.RadioButton rbLongTerm;
        private System.Windows.Forms.RadioButton rbShortTerm;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.GroupBox gbManageLoan;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblAfterInterest;
        private System.Windows.Forms.Label lblAfterPayment;
        private System.Windows.Forms.Label lblTermAmount;
    }
}

