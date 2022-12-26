using System.Linq.Expressions;
using Application.Contracts;
using Domain.Base;
using Infrastructure.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class SqlServerRepository<T> : IRepository<T> where T : Entity<int>
{
    private readonly CarDbContext carDbContext;
    private readonly DbSet<T> dbSet;

    public SqlServerRepository(CarDbContext carDbContext)
    {
        ArgumentNullException.ThrowIfNull(carDbContext, nameof(carDbContext));
        
        this.carDbContext = carDbContext;
        dbSet = carDbContext.Set<T>();
    }

    public async Task<T> GetByPredicateAsync(
        Expression<Func<T, bool>> predicate,
        CancellationToken token = default)
        => await dbSet
            .Where(predicate)
            .FirstOrDefaultAsync(token);

    public async Task AddAsync(T model, CancellationToken token = default)
        => await dbSet.AddAsync(model, token);

    public void Remove(T model) => dbSet.Remove(model);

    public async Task SaveChangesAsync(CancellationToken token = default)
        => await carDbContext.SaveChangesAsync(token);
}
