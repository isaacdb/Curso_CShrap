using Exercicio1.Exceptions;

namespace Exercicio1.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public decimal Balance { get; private set; }
        public decimal WithdrawLimit { get; set; }

        public Account(int number, string holder, decimal balance, decimal withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > WithdrawLimit)
                throw new MyExceptions("The amaunt exceeds withdraw limit.");
            if (amount > Balance)
                throw new MyExceptions("Not enough balance");
            Balance -= amount;
        }
    }
}
