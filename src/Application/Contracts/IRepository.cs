using System.Linq.Expressions;

namespace Application.Contracts;

/// <summary>
/// Repository contract
/// </summary>
/// <typeparam name="T">Entity type</typeparam>
public interface IRepository<T>
{
    Task<T> GetByPredicateAsync(Expression<Func<T, bool>> predicate, CancellationToken token = default);
    
    Task AddAsync(T model, CancellationToken token = default);
    
    void Remove(T model);

    Task SaveChangesAsync(CancellationToken token = default);
}
