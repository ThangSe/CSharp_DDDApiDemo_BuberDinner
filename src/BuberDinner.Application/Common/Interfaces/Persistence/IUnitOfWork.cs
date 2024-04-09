namespace BuberDinner.Application.Common.Interfaces.Persistence;

public interface IUnitOfWork
{
    void CreateTransaction();
    void Commit();
    void Rollback();
    void Save();
    Task<int> CommitAsync();
}
