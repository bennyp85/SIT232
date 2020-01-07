namespace BankAccounts
{
    class TermDeposit : Account
    {
        public TermDeposit(decimal balance, int term) : base(balance)
        {
            _Term = term;
        }

        private int _Term;
        public int Term { get; set; }

        public void CalculateInterest(double rate)
        {
            var result = (double) (Balance * (decimal) (1 + rate * _Term));
            _Balance = (decimal) result;
        }
        
        public void Deposit(decimal amount)
        {
            _Balance += amount;
        }

        public override string ToString()
        {
            string result;
            
            if(_Balance == 0)
                result = base.ToString() + " in term deposit";
            else
                result = base.ToString() + " in term deposit";

            return result;
        }
    }
}