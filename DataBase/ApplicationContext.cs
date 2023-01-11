using Microsoft.EntityFrameworkCore;
using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp {
    public class ApplicationContext : DbContext {
        public DbSet<UserModel> Users { get; set; } = null!;
        public DbSet<MessageModel> Messages { get; set; } = null!;

        public ApplicationContext() {

            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=Ultima57");
        }
    }
}
