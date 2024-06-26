using ChainOfResponsibility;
using System.Security;

ATMWithdrawChain atm = new ATMWithdrawChain();

while (true)
{
    Console.WriteLine("Enter the amount to withdraw:");
    int amount = Convert.ToInt32(Console.ReadLine());
    if (amount % 50 != 0)
    {
        Console.WriteLine("Tutar 50'nin katı olmalıdır.");
        return;
    }
    atm.c1.withdraw(new Currency(amount));
}
