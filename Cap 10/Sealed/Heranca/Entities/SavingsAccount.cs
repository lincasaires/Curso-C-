
namespace Heranca.Entities
{
    //sealed: evita que a classe SavingsAccount seja herdada (Ganho de performance)
     sealed class SavingsAccount : Account 
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

        //Selando método; Funciona apenas em métodos sobrescritos; Não pode ser sobrescrito em outra função
        public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
