using BuberDinner.Application.Common.Interfaces.Persistence;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace BuberDinner.Infrastructure.Persistence.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private BuberDinnerDbContext _dbContext;
    private string _errorMessage = string.Empty;
    private IDbContextTransaction _objTran;
    public UnitOfWork(BuberDinnerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void CreateTransaction()
    {
        _objTran = _dbContext.Database.BeginTransaction();
    }
    public void Commit()
    {
        _objTran.Commit();
    }


    public void Rollback()
    {
        _objTran.Rollback();
        _objTran.Dispose();
    }

    public void Save()
    {
        try
        {
            _dbContext.SaveChanges();
        }
        catch (DbUpdateException dbEx)
        {
            _errorMessage = dbEx.Message;
            throw new Exception(_errorMessage, dbEx);
        }
    }

    public Task<int> CommitAsync()
    {
        return _dbContext.SaveChangesAsync();
    }
}