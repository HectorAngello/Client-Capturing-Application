using Microsoft.EntityFrameworkCore;
using ClientManagementLibrary.Models;
using ClientCaptureApp.Models;


namespace ClientAnalyticsApp.data
{
    public class ClientDbContext : DbContext
    {
        public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }  // Represents the Clients table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Client>().HasKey(c => c.Id);
        }

    }
}
