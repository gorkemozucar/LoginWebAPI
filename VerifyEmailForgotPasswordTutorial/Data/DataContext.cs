

namespace VerifyEmailForgotPasswordTutorial.Data
{
    public class DbContext : DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Server=.\\SQLExpress;Database=userdb;Trusted_Connection=true;");
        }

        public DbSet<User> Users => Set<User>();
    }
}
