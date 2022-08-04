using Authentication.API.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace Authentication.API.Repository
{
    public class AccountContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; } = null!;
        public AccountContext(DbContextOptions<AccountContext> options):base(options){}

    }
}
