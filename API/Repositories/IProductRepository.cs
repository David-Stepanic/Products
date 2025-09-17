using System;
using Models.Entities;

namespace API.Repositories;

public interface IProductRepository
{
    Task<Product?> CreateAsync(Product product);
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    void Update(Product product);
    void Delete(Product product);
    Task SaveChangesAsync();

}
