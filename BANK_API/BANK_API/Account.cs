namespace BANK_API
{
    public static class Account
    {
        public static decimal Balance { get; set; }
        
        public static bool Deposit(decimal amount)
        {
            if (amount < 0)
                return false;


            Balance += amount;

            return true;
        }

        public static bool Withdraw(decimal amount)
        {
            if (Balance < amount)
                return false;

            Balance -= amount;

            return true;
        }
    }
}
