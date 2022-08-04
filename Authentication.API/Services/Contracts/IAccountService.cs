using Authentication.API.Models.ModelsDto;

namespace Authentication.API.Services.Contracts
{
    public interface IAccountService
    {
        Task Registration(AccountDto accountDto);

        Task<string> Login(AccountDto accountDto);
    }
}
