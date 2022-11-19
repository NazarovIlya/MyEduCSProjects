using Microsoft.EntityFrameworkCore;
using ORM_PostgresQL_CS;

public class StorageContext : DbContext
{
    string dbName;
    public StorageContext(string dbName)
    {
        this.dbName = dbName;
    }
    public DbSet<Worker> Workers_t { get; set; }

    protected override void OnConfiguring(
      DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString =
        @"Host={0}; Username={1}; Password={2};Database={3}";
        optionsBuilder.UseNpgsql(
         String.Format(connectionString,
         Config.Host,
         Config.DdUser,
         Config.Password,
         dbName
         ));
    }
}
