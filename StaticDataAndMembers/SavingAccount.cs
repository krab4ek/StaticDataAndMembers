namespace StaticDataAndMembers
{
    internal class SavingAccount
    {
        public double currBalance;
        public static double currInterestRate = 0.04;
        public SavingAccount(double balance)
        {
            currBalance = balance;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }

        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        
    }
}
