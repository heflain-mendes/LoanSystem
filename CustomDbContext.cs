using LoanSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanSystem.Models;
using System.Net;
using LoanSystem.Configuration;

namespace LoanSystem;
public class CustomDbContext : DbContext
{
    private DbSet<Loan>? Loans { get; set; }
    private DbSet<Customer>? Customers { get; set; }
    private DbSet<Book>? Books { get; set; }
    private DbSet<Address>? Addresses { get; set; }
    private DbSet<LoanBook>? LoanBooks { get; set; }

    public CustomDbContext() : base() { }
    public CustomDbContext(DbContextOptions<CustomDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured) return;

        optionsBuilder.UseNpgsql("Host=localhost;Port=5430;Database=LoanBook;User Id=postgres;Password=password;");
    }
}

