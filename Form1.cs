using System.Text.Json;
using System.IO;
namespace smartBudget
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Transport");
            cmbCategory.Items.Add("Shopping");
            cmbCategory.Items.Add("Bills");
            cmbCategory.Items.Add("Entertainment");
            cmbCategory.Items.Add("Salary");
            cmbCategory.Items.Add("Other");

            dgvTransactions.Columns.Add("Type", "Type");
            dgvTransactions.Columns.Add("Category", "Category");
            dgvTransactions.Columns.Add("Description", "Description");
            dgvTransactions.Columns.Add("Amount", "Amount");

            dgvTransactions.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;

            LoadTransactions();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than 0.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            Expense expense = new Expense(
    cmbCategory.Text,
    txtDescription.Text,
    amount
);

            dgvTransactions.Rows.Add(
                "Expense",
                expense.Category,
                expense.Description,
                expense.Amount
            );

            CalculateTotals();
            SaveTransactions();

            MessageBox.Show("Expense added successfully!");
        }

        private void CalculateTotals()
        {
            decimal totalIncome = 0;
            decimal totalExpense = 0;

            foreach (DataGridViewRow row in dgvTransactions.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string type = Convert.ToString(row.Cells[0].Value);

                decimal amount;

                decimal.TryParse(
                    Convert.ToString(row.Cells[3].Value),
                    out amount
                );

                if (type == "Income")
                {
                    totalIncome += amount;
                }
                else if (type == "Expense")
                {
                    totalExpense += amount;
                }
            }

            lblTotalIncome.Text =
                $"Total Income: ${totalIncome:F2}";

            lblTotalExpense.Text =
                $"Total Expense: ${totalExpense:F2}";

            lblBalance.Text =
                $"Balance: ${(totalIncome - totalExpense):F2}";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than 0.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            Income income = new Income(
     cmbCategory.Text,
     txtDescription.Text,
     amount
 );

            dgvTransactions.Rows.Add(
                "Income",
                income.Category,
                income.Description,
                income.Amount
            );

            CalculateTotals();
            SaveTransactions();

            MessageBox.Show("Income added successfully!");
        }
        private void SaveTransactions()
        {
            try
            {
                List<TransactionData> transactions = new List<TransactionData>();

                foreach (DataGridViewRow row in dgvTransactions.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    TransactionData transaction = new TransactionData();

                    transaction.Type = Convert.ToString(row.Cells[0].Value) ?? "";
                    transaction.Category = Convert.ToString(row.Cells[1].Value) ?? "";
                    transaction.Description = Convert.ToString(row.Cells[2].Value) ?? "";
                    transaction.Amount = Convert.ToDecimal(row.Cells[3].Value);

                    transactions.Add(transaction);
                }

                string json = JsonSerializer.Serialize(transactions);

                File.WriteAllText("transactions.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transactions: " + ex.Message);
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.CurrentRow != null &&
                !dgvTransactions.CurrentRow.IsNewRow)
            {
                dgvTransactions.Rows.Remove(dgvTransactions.CurrentRow);

                CalculateTotals();
                SaveTransactions();

                MessageBox.Show("Transaction deleted successfully!");

                MessageBox.Show("Transaction deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.");
            }
        }


        private void LoadTransactions()
        {
            try
            {
                if (!File.Exists("transactions.json"))
                    return;

                string json = File.ReadAllText("transactions.json");

                List<TransactionData>? transactions =
                    JsonSerializer.Deserialize<List<TransactionData>>(json);

                if (transactions == null)
                    return;

                foreach (TransactionData transaction in transactions)
                {
                    dgvTransactions.Rows.Add(
                        transaction.Type,
                        transaction.Category,
                        transaction.Description,
                        transaction.Amount
                    );
                }

                CalculateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }
        }
    }
}
        