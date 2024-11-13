using Microsoft.EntityFrameworkCore;

namespace BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB.Models
{
    public class UserAuthContext : DbContext
    {
        public UserAuthContext(DbContextOptions<UserAuthContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=192.168.200.35;userid=user03;password=97965;database=user03", ServerVersion.Parse("10.3.39-mariadb"));
            base.OnConfiguring(optionsBuilder);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int IsBlocked { get; set; }
        public int FailedLoginAttempts { get; set; }
    }
}