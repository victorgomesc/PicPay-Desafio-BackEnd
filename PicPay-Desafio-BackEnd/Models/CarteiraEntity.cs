using PicPay_Desafio_BackEnd.Models.Enum;

namespace PicPay_Desafio_BackEnd.Models;

public class CarteiraEntity {
    public int Id { get; set; }
    public required string NomeCompleto { get; set; }
    public required string CPFCNPJ { get; set; }
    public required string Email { get; set; }
    public required string Senha { get; set; }

    public UserType UserType { get; set; }

    public decimal SaldoConta { get; set; }
    
     private CarteiraEntity(){}

    public CarteiraEntity(string nomeCompleto, string cpfCnpj, string email, 
        string senha, UserType userType, decimal saldoConta = 0) 
        {
            NomeCompleto = nomeCompleto;
            CPFCNPJ = cpfCnpj;
            Email = email;
            Senha = senha;
            UserType = userType;
            SaldoConta = saldoConta;
        }

    public void DebitarSaldo(decimal valor)
    {
        SaldoConta -= valor;
    }

    public void CreditarSaldo(decimal valor)
    {
        SaldoConta += valor;
    }
}