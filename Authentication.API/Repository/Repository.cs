using Authentication.API.Repository.Contracts;
using Authentication.API.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace Authentication.API.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountContext _context;
        public AccountRepository(AccountContext context) => _context = context;
        public async Task CreateAccount(Account account) => await _context.Accounts.AddAsync(account);

        public async Task DeleteAccount(int id)
        {
            var exsistAccount = await _context.Accounts.FirstOrDefaultAsync(x => x.Id == id);
            if (exsistAccount is not null)
            {
                _context.Remove(exsistAccount);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Account> GetAccount(int id) => await _context.Accounts.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<IEnumerable<Account>> GetAllAccounts(int id) => await _context.Accounts.ToListAsync();

        public async Task UpdateAccount(Account account)
        {
            var exsistAccount = await _context.Accounts.FirstOrDefaultAsync(x => x.Id == account.Id);
            if (exsistAccount is not null)
            {
                _context.Accounts.Update(account);
                await _context.SaveChangesAsync();
            }
        }
    }
}
