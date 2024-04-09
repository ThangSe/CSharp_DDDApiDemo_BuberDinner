using System.Linq.Expressions;

using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Application.Common.Interfaces.Persistence;
public interface IGenericRepository<T> where T : IAggregateRoot
{
    IEnumerable<T> GetAll();
    T GetById(string id);
    void Add(T entity);
    void Update(T enity);
    void Delete(T enity);
    IQueryable<T> List(Expression<Func<T, bool>> expression);
}