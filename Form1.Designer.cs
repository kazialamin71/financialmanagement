namespace financialManagement
{
    partial class form_welcome
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
            this.btn_income = new System.Windows.Forms.Button();
            this.btn_expense = new System.Windows.Forms.Button();
            this.btn_payer = new System.Windows.Forms.Button();
            this.btn_payee = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_income
            // 
            this.btn_income.Location = new System.Drawing.Point(258, 47);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(349, 49);
            this.btn_income.TabIndex = 0;
            this.btn_income.Text = "Add Income";
            this.btn_income.UseVisualStyleBackColor = true;
            this.btn_income.Click += new System.EventHandler(this.btn_income_Click);
            // 
            // btn_expense
            // 
            this.btn_expense.Location = new System.Drawing.Point(258, 122);
            this.btn_expense.Name = "btn_expense";
            this.btn_expense.Size = new System.Drawing.Size(349, 49);
            this.btn_expense.TabIndex = 1;
            this.btn_expense.Text = "Add Expense";
            this.btn_expense.UseVisualStyleBackColor = true;
            // 
            // btn_payer
            // 
            this.btn_payer.Location = new System.Drawing.Point(258, 193);
            this.btn_payer.Name = "btn_payer";
            this.btn_payer.Size = new System.Drawing.Size(349, 49);
            this.btn_payer.TabIndex = 2;
            this.btn_payer.Text = "Add Payer";
            this.btn_payer.UseVisualStyleBackColor = true;
            this.btn_payer.Click += new System.EventHandler(this.btn_payer_Click);
            // 
            // btn_payee
            // 
            this.btn_payee.Location = new System.Drawing.Point(258, 266);
            this.btn_payee.Name = "btn_payee";
            this.btn_payee.Size = new System.Drawing.Size(349, 49);
            this.btn_payee.TabIndex = 3;
            this.btn_payee.Text = "Add Payee";
            this.btn_payee.UseVisualStyleBackColor = true;
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(258, 336);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(349, 49);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            // 
            // form_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_payee);
            this.Controls.Add(this.btn_payer);
            this.Controls.Add(this.btn_expense);
            this.Controls.Add(this.btn_income);
            this.Name = "form_welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_income;
        private System.Windows.Forms.Button btn_expense;
        private System.Windows.Forms.Button btn_payer;
        private System.Windows.Forms.Button btn_payee;
        private System.Windows.Forms.Button btn_report;
    }
}

