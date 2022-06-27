using StaticDataAndMembers;

Console.WriteLine("***** Fun with Static Data *****\n");
SavingAccount s1 = new SavingAccount(50);
s1.currBalance = 79;
Console.WriteLine($"Interest rate is: {SavingAccount.GetInterestRate()}");

SavingAccount.SetInterestRate(0.08);

Console.WriteLine($"Interest rate is: {SavingAccount.GetInterestRate()}");
SavingAccount s2 = new SavingAccount(100);
Console.WriteLine($"Interest rate is: {SavingAccount.GetInterestRate()}");

SavingAccount s3 = new SavingAccount(1000.75);
Console.WriteLine($"Interest rate is: {SavingAccount.GetInterestRate()}");


Console.ReadLine();