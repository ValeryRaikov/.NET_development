
namespace bankAccountsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OwnerLbl = new System.Windows.Forms.Label();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.OwnerTxt = new System.Windows.Forms.TextBox();
            this.AmountNum = new System.Windows.Forms.NumericUpDown();
            this.BankAccountsGrid = new System.Windows.Forms.DataGridView();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.WithdrwaBtn = new System.Windows.Forms.Button();
            this.CreateAccountBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccountsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OwnerLbl
            // 
            this.OwnerLbl.AutoSize = true;
            this.OwnerLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnerLbl.Location = new System.Drawing.Point(37, 56);
            this.OwnerLbl.Name = "OwnerLbl";
            this.OwnerLbl.Size = new System.Drawing.Size(81, 31);
            this.OwnerLbl.TabIndex = 0;
            this.OwnerLbl.Text = "Owner";
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountLbl.Location = new System.Drawing.Point(22, 259);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(96, 31);
            this.AmountLbl.TabIndex = 1;
            this.AmountLbl.Text = "Amount";
            // 
            // OwnerTxt
            // 
            this.OwnerTxt.Location = new System.Drawing.Point(134, 56);
            this.OwnerTxt.Name = "OwnerTxt";
            this.OwnerTxt.Size = new System.Drawing.Size(205, 27);
            this.OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            this.AmountNum.Location = new System.Drawing.Point(134, 263);
            this.AmountNum.Name = "AmountNum";
            this.AmountNum.Size = new System.Drawing.Size(150, 27);
            this.AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            this.BankAccountsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BankAccountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankAccountsGrid.Location = new System.Drawing.Point(391, 56);
            this.BankAccountsGrid.Name = "BankAccountsGrid";
            this.BankAccountsGrid.RowHeadersWidth = 51;
            this.BankAccountsGrid.RowTemplate.Height = 29;
            this.BankAccountsGrid.Size = new System.Drawing.Size(371, 240);
            this.BankAccountsGrid.TabIndex = 4;
            // 
            // DepositBtn
            // 
            this.DepositBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositBtn.Location = new System.Drawing.Point(391, 302);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(168, 44);
            this.DepositBtn.TabIndex = 5;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = true;
            // 
            // WithdrwaBtn
            // 
            this.WithdrwaBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrwaBtn.Location = new System.Drawing.Point(596, 302);
            this.WithdrwaBtn.Name = "WithdrwaBtn";
            this.WithdrwaBtn.Size = new System.Drawing.Size(166, 44);
            this.WithdrwaBtn.TabIndex = 6;
            this.WithdrwaBtn.Text = "Withdraw";
            this.WithdrwaBtn.UseVisualStyleBackColor = true;
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateAccountBtn.Location = new System.Drawing.Point(134, 90);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(205, 48);
            this.CreateAccountBtn.TabIndex = 7;
            this.CreateAccountBtn.Text = "Create Account";
            this.CreateAccountBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.WithdrwaBtn);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.BankAccountsGrid);
            this.Controls.Add(this.AmountNum);
            this.Controls.Add(this.OwnerTxt);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.OwnerLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccountsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OwnerLbl;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.TextBox OwnerTxt;
        private System.Windows.Forms.NumericUpDown AmountNum;
        private System.Windows.Forms.DataGridView BankAccountsGrid;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button WithdrwaBtn;
        private System.Windows.Forms.Button CreateAccountBtn;
    }
}

