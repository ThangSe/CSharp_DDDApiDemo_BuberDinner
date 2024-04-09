using System.Linq.Expressions;

using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Common.Models;

using Microsoft.EntityFrameworkCore;

namespace BuberDinner.Infrastructure.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T>
    where T : class, IAggregateRoot
{
    private readonly BuberDinnerDbContext _dbContext;
    private DbSet<T> _dbSet;

    protected DbSet<T> DbSet
    {
        get => _dbSet ?? (_dbSet = _dbContext.Set<T>());
    }

    public GenericRepository(BuberDinnerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<T> GetAll()
    {
        return DbSet.ToList();
    }

    public T GetById(string id)
    {
        return DbSet.Find(id)!;
    }

    public void Update(T enity)
    {
        DbSet.Update(enity);
    }

    public void Delete(T enity)
    {
        DbSet.Remove(enity);
    }

    public IQueryable<T> List(Expression<Func<T, bool>> expression)
    {
        return DbSet.Where(expression);
    }

    public void Add(T entity)
    {
        DbSet.Add(entity);
    }
}