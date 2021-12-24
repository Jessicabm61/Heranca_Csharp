
namespace Exercício13.Entities
{
    class Account
    {
        public int Number { get; private set; } //private não permite alterar em nenhuma outra classe
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //protected permite alterar em subclasses

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



namespace Exercício13.Entities
{
    class BusinessAccount : Account //  ": Account" Informa que a classe business Account é a herança da classe Accounnt
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() //Construtor vazio permite criar um objeto sem passar os dados
        {
        }

        /*Ao invés de criar um construtor repetindo todas as variáveis da classe Account conforme abaixo é possível somente
        * acionar o contrutor da Classe Account utilizando base()
        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
        {
        Number = number;
        Holder = holder;
        Balance = balance;
        LoanLimit = loanLimit;
        }*/

        public BusinessAccount(int number, string holder, double balance, double loanLimit) :
        base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
                Balance += amount;
        }
    }
}
