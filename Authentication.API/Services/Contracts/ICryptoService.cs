using Authentication.API.Models.ModelsDto;
using Authentication.API.Repository.Entity;

namespace Authentication.API.Services.Contracts
{
    public interface ICryptoService
    {
        Task<string> HashPassword(AccountDto password);

        Task<bool> Verify(AccountDto password, Account hashedPassword);
    }
}
