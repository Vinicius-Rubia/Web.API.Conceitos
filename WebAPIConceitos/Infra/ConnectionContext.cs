using Microsoft.EntityFrameworkCore;
using WebAPIConceitos.Model;

namespace WebAPIConceitos.Infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;Database=employee;" +
                "User id=postgres;" +
                "Password=Qbafvs98!;");
    }
}
