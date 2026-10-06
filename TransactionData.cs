namespace smartBudget
{
    public class TransactionData
    {
        public string Type { get; set; } = "";
        public string Category { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Amount { get; set; }
    }
}