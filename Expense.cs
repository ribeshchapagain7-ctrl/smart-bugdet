namespace smartBudget
{
    public class Expense : Transaction
    {
        public Expense(string category, string description, decimal amount)
            : base(category, description, amount)
        {
        }

        public override string GetTransactionType()
        {
            return "Expense";
        }
    }
}