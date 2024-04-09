using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.MenuAggregate;
using BuberDinner.Infrastructure.Persistence.UnitOfWork;

using Microsoft.EntityFrameworkCore;

namespace BuberDinner.Infrastructure.Persistence.Repositories;

public class MenuRepository : GenericRepository<Menu>, IMenuRepository
{
    public MenuRepository(BuberDinnerDbContext dbContext)
        : base(dbContext)
    {
    }

    public void AddAsync(Menu menu)
    {
        this.Add(menu);
        //_dbContext.Add(menu);
        //_dbContext.SaveChanges();
    }
}