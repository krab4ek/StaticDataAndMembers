using StaticDataAndMembers;

Console.WriteLine("***** Fun with Static Data *****\n");
SavingAccount s1 = new SavingAccount(50);
SavingAccount s2 = new SavingAccount(100);

Console.WriteLine($"Interest rate is: {SavingAccount.GetInterestRate()}");

SavingAccount s3 = new SavingAccount(1000.75);
Console.WriteLine($"Interest rate is: {SavingAccount.GetInterestRate()}");


Console.ReadLine();