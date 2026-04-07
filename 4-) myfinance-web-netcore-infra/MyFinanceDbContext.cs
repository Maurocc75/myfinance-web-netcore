
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using myfinance_web_netcore_domain.Entities;
using myfinance_web_netcore_infra;



namespace myfinance_web_netcore_infra;


public class MyFinanceDbContext : DbContext
{
    public DbSet<PlanoConta> PlanoConta { get; set; }
 
    public DbSet<Transacao> Transacao { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 

    // optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=myfinance;Trusted_Connection=True;Enclypt=False;TrustServerCertificate=False;");
     optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=myfinance;Trusted_Connection=True;TrustServerCertificate=True;");
    // optionsBuilder.UseSqlServer("server=MAUROCC75N/mauro/SQLEXPRESS;database=myfinance;trusted_connection=False;");


    }
        
    
    
    }

    
    
