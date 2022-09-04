using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Persistence;

public class DatabaseContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Contract> Contracts { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) 
    : base(options)
    {
        
    }

    protected override void  OnModelCreating (ModelBuilder builder) {
        builder.Entity<Person>(tabela => {
            tabela.HasKey(e => e.Id);
            tabela
                .HasMany(e => e.Contracts)
                .WithOne()
                .HasForeignKey(c => c.PersonId);
        });

        builder.Entity<Contract>(tabela => {
            tabela.HasKey(e => e.Id);
        });
    }
}