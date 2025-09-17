using System;

namespace API.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private ProductRepository? _productRepository;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    public IProductRepository Products => _productRepository ??= new ProductRepository(_context);
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}
