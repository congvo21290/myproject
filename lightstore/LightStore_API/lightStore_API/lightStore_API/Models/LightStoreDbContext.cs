using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lightStore_API.Models
{
  public class LightStoreDbContext: DbContext
  {
    public LightStoreDbContext(DbContextOptions<LightStoreDbContext> options)
           : base(options)
    {
    }

    public DbSet<Category> Categorys { get; set; }

    public DbSet<Product> Products { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Category>().ToTable("Category");
      modelBuilder.Entity<Product>().ToTable("Product");
    }
  }
}
