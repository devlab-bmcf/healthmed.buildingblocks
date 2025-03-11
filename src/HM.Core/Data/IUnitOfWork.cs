namespace HM.Core.Data;

public interface IUnitOfWork
{
    Task<bool> Commit();
}