using Authentication.API.Models.ModelsDto;
using Authentication.API.Services.Contracts;

namespace Authentication.API.Services
{
    public class AccountService : IAccountService
    {
        public Task<string> Login(AccountDto accountDto)
        {
            throw new NotImplementedException();
        }

        public Task Registration(AccountDto accountDto)
        {
            throw new NotImplementedException();
        }
    }
}
