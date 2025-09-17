using System;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace API;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategories> ProductCategories { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ProductCategories>()
            .ToTable("ProductCategories")
            .HasKey(pc => new { pc.ProductId, pc.CategoryId });

        builder.Entity<ProductCategories>()
            .HasOne(pc => pc.Product)
            .WithMany(p => p.ProductCategories)
            .HasForeignKey(pc => pc.ProductId);

        builder.Entity<ProductCategories>()
            .HasOne(pc => pc.Category)
            .WithMany(c => c.ProductCategories)
            .HasForeignKey(pc => pc.CategoryId);
    }
}
