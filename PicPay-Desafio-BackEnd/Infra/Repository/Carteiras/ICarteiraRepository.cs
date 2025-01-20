using PicPay_Desafio_BackEnd.Models;

namespace PicPay_Desafio_BackEnd.Infra.Repository.Carteiras;

public interface ICarteiraRepository
{
    Task AddAsync(CarteiraEntity carteira);
    Task UpdateAsync(CarteiraEntity carteira);
    Task<CarteiraEntity?> GetByCpfCnpj(string cpfCnpj, string email);
    Task<CarteiraEntity?> GetById(int id);
    Task CommitAsync();
}