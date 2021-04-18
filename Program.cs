using System;

namespace Bankproject
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Bankaccount("dev", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "mobile recharge");
            account.MakeWithdrawal(100, DateTime.Now, "groceries ");
            account.MakeWithdrawal(150, DateTime.Now, " recharger");
            account.MakeWithdrawal(40, DateTime.Now, "mobile recharge");
            account.MakeDeposit(100, DateTime.Now, "GST");
         
            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine(account.Balance);
        }
    }
}
