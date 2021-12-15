
namespace Exercício13.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account() //Construtor vazio permite criar um objeto sem passar os dados
        {
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Witdraw (double amount)
        {
            Balance -= amount; //Subtrai uma quantia do saldo atual "saque"
        }

        public void Deposit(double amount)
        {
            Balance += amount; //Soma uma quantia do saldo atual "depósito"
        }
    }
}
