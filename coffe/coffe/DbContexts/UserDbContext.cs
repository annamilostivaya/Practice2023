using coffe.Models;
using Microsoft.EntityFrameworkCore;

namespace coffe.DbContexts;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> contextOptions) : base(contextOptions)
    {

    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlite("Data source = coffe.db");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<User>().HasKey(p => p.id);
        modelBuilder.Entity<Order>().HasKey(p => p.id);
        modelBuilder.Entity<Good>().HasKey(p => p.id);




        modelBuilder.Entity<Order>().HasOne(p => p.User).WithMany(p => p.Orders);
        modelBuilder.Entity<Order>().HasOne(p=>p.Good).WithMany(p => p.Orders);



        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Good> Goods { get; set; }


}