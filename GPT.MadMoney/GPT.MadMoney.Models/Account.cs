namespace GPT.MadMoney.Models
{
    public class Account
    {
        public string AccountType { get; set; }

        public int AccountId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal CurrentTotalAmount { get; set; }

        public decimal ChangeAmount { get; set; }

        public decimal NewTotalAmount { get; set; }
    }
}