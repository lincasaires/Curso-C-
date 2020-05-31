
namespace Heranca.Entities
{

     class SavingsAccount : Account 
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate / 100;
        }

        //Sobrescrevendo função Withdraw originalmente em Account.cs
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
