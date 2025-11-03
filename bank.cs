namespace Praktik_9
{
    internal class BankAccount
    {
        private string owner;
        private double balance;
        private bool accountValid;
        public BankAccount(string owner, double balance)
        {
            this.owner = owner;
            if (balance < 0)
            {
                Console.WriteLine("некоректное значение!");
                accountValid = false;
            }
            else
            {
                this.balance = balance;
                accountValid = true;
            }
        }

        public void Deposit(double money)
        {
            if (!accountValid)
            {
                return;
            }
            else if (money < 0)
            {
                Console.WriteLine("некоректное значение!");
                return;
            }
            balance += money;
            Console.WriteLine($"{owner}. баланс: {balance}");
        }
        public void Withdraw(double money)
        {
            if (!accountValid)
            {
                return;
            }
            else if (money < 0)
            {
                Console.WriteLine("некоректное значение!");
                return;
            }
            else if (money > balance)
            {
                Console.WriteLine("Недостаточно средств!");
                return;
            }
            balance -= money;
            Console.WriteLine($"{owner}, баланс: {balance}");
        }
    }
}
