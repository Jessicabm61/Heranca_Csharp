
namespace Exercício13.Entities
{
    class BusinessAccount : Account //  ": Account" Informa que a classe business Account é a herança da classe Accounnt
    {
        public double LoanLimit { get; set; }
    
       public BusinessAccount() //Construtor vazio permite criar um objeto sem passar os dados
        {
        } 
    
        
       public BusinessAccount ()
    }
}
