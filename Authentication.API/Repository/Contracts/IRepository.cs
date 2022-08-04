using Authentication.API.Repository.Entity;

namespace Authentication.API.Repository.Contracts
{
    public interface IAccountRepository
    {
        Task<Account> GetAccount(int id);
        Task<IEnumerable<Account>> GetAllAccounts(int id);
        Task CreateAccount(Account account);
        Task UpdateAccount(Account account);
        Task DeleteAccount(int id);

    }
}
