using System;

class CreateAccount
{
    // Test Harness
    static void Main() 
    {
        BankAccount acc1, acc2, acc3, acc4;

        acc1 = new BankAccount();
        acc2 = new BankAccount(AccountType.Deposit);
        acc3 = new BankAccount(100);
        acc4 = new BankAccount(AccountType.Deposit, 500);

        acc1.Deposit(100);
        acc1.Withdraw(50);
        acc1.Deposit(75);
        acc1.Withdraw(50);
        acc1.Withdraw(30);
        acc1.Deposit(40);
        acc1.Deposit(200);
        acc1.Withdraw(250);
        acc1.Deposit(25);

        acc2.Deposit(1000);
        acc2.Withdraw(500);
        acc2.Deposit(750);
        acc2.Withdraw(500);
        acc2.Withdraw(300);
        acc2.Deposit(400);
        acc2.Deposit(2000);
        acc2.Withdraw(2500);
        acc2.Deposit(250);

        acc3.Deposit(1050);
        acc3.Withdraw(550);
        acc3.Deposit(750);
        acc3.Withdraw(550);
        acc3.Withdraw(350);
        acc3.Deposit(450);
        acc3.Deposit(2050);
        acc3.Withdraw(2550);
        acc3.Deposit(2550);

        acc4.Deposit(600);
        acc4.Withdraw(545);
        acc4.Deposit(734);
        acc4.Withdraw(35);
        acc4.Withdraw(457);
        acc4.Deposit(577);
        acc4.Deposit(2023);
        acc4.Withdraw(2122);
        acc4.Deposit(290);

        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);
        Console.ReadKey();
    }

    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}", acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
        Console.WriteLine("Transactions:");

        foreach (BankTransaction tran in acc.Transactions())
        {
            Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
        }
        Console.WriteLine();
    }
}
