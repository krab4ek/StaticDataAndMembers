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
    }
}
