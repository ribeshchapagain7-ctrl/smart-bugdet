namespace smartBudget
{
    partial class MainFrom
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            btnAddExpense = new Button();
            btnAddIncome = new Button();
            dgvTransactions = new DataGridView();
            btnDelete = new Button();
            lblTotalExpense = new Label();
            lblBalance = new Label();
            lblTotalIncome = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 30);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(275, 54);
            label2.TabIndex = 1;
            label2.Text = "SmartBudget";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 102);
            label1.Name = "label1";
            label1.Size = new Size(187, 54);
            label1.TabIndex = 2;
            label1.Text = "Amount:";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 172);
            label3.Name = "label3";
            label3.Size = new Size(208, 54);
            label3.TabIndex = 3;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 240);
            label4.Name = "label4";
            label4.Size = new Size(250, 54);
            label4.TabIndex = 4;
            label4.Text = "Description:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(356, 102);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(205, 61);
            txtAmount.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(420, 240);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(207, 61);
            txtDescription.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Food", "Transportation", "Rent", "Shopping", "Bills", "Entertainment", "Others" });
            cmbCategory.Location = new Point(379, 172);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(222, 62);
            cmbCategory.TabIndex = 7;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(180, 329);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(308, 64);
            btnAddExpense.TabIndex = 8;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // btnAddIncome
            // 
            btnAddIncome.Location = new Point(769, 329);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(295, 64);
            btnAddIncome.TabIndex = 9;
            btnAddIncome.Text = "Add Income";
            btnAddIncome.UseVisualStyleBackColor = true;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(274, 413);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.Size = new Size(665, 225);
            dgvTransactions.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(180, 657);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(339, 64);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteSelected_Click;
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.AutoSize = true;
            lblTotalExpense.Location = new Point(165, 811);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(405, 54);
            lblTotalExpense.TabIndex = 14;
            lblTotalExpense.Text = "Total Expense: $0.00";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(165, 865);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(294, 54);
            lblBalance.TabIndex = 15;
            lblBalance.Text = "Balance: $0.00";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Location = new Point(171, 757);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(390, 54);
            lblTotalIncome.TabIndex = 16;
            lblTotalIncome.Text = "Total Income: $0.00";
            lblTotalIncome.Click += label8_Click;
            // 
            // MainFrom
            // 
            AutoScaleDimensions = new SizeF(24F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 972);
            Controls.Add(lblTotalIncome);
            Controls.Add(lblBalance);
            Controls.Add(lblTotalExpense);
            Controls.Add(btnDelete);
            Controls.Add(dgvTransactions);
            Controls.Add(btnAddIncome);
            Controls.Add(btnAddExpense);
            Controls.Add(cmbCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "MainFrom";
            Text = "SmartBudget - Personal Budget Tracker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private ComboBox cmbCategory;
        private Button btnAddExpense;
        private Button btnAddIncome;
        private DataGridView dgvTransactions;
        private Button btnDelete;
        private Label lblTotalExpense;
        private Label lblBalance;
        private Label lblTotalIncome;
    }
}
