namespace smartBudget
{
    public class Income : Transaction
    {
        public Income(string category, string description, decimal amount)
            : base(category, description, amount)
        {
        }

        public override string GetTransactionType()
        {
            return "Income";
        }
    }
}