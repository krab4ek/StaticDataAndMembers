namespace StaticDataAndMembers
{
    internal class SavingAccount
    {
        public double currBalance;
        public static double currInterestRate;
        public SavingAccount(double balance)
        {
            currBalance = balance;

        }
        static SavingAccount()
        {
            Console.WriteLine("Its sattic ctor!");
            currInterestRate = 0.04;
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
