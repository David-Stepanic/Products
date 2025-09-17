using System;

namespace API.Repositories;

public interface IUnitOfWork : IDisposable
{
    IProductRepository Products { get; }
    Task SaveChangesAsync();
}
