using System;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace API.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Product?> CreateAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();

        var created = await _context.Products
            .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
            .FirstOrDefaultAsync(p => p.ProductId == product.ProductId);

        return created;
    }
    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _context.Products
            .FirstOrDefaultAsync(p => p.ProductId == id);
    }
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products
            .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
            .ToListAsync();
    }
    public void Update(Product product)
    {
        _context.Products.Update(product);
    }
    public void Delete(Product product)
    {
        _context.Products.Remove(product);
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

}

