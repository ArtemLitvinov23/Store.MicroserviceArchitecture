namespace Authentication.API.Repository.Entity
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime Created { get; set; }

        public Account()
        {
            Created = DateTime.UtcNow;
        }
    }
}
