using BuberDinner.Domain.MenuAggregate;

namespace BuberDinner.Application.Common.Interfaces.Persistence;

public interface IMenuRepository : IGenericRepository<Menu>

{
    void AddAsync(Menu menu);
}