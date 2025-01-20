namespace PicPay_Desafio_BackEnd.Models;

public class TransferenciaEntity
{
    public Guid IdTransferencia { get; set; }

    public int SenderId { get; set; }
    public required CarteiraEntity Sender { get; set; }

    public int ReciverId { get; set; }
    public required CarteiraEntity Reciver { get; set; }
    public decimal Valor { get; set; }

    public TransferenciaEntity(int senderId, int reciverId, decimal valor)
    {
        IdTransferencia = Guid.NewGuid();
        SenderId = senderId;
        ReciverId = reciverId;
        Valor = valor;
    }

      private TransferenciaEntity(){}
}