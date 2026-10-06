namespace smartBudget
{
    public abstract class Transaction
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public Transaction(string category, string description, decimal amount)
        {
            Category = category;
            Description = description;
            Amount = amount;
        }

        public abstract string GetTransactionType();
    }
}