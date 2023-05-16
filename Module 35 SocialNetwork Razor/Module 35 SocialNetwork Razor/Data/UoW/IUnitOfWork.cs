using Module_35_SocialNetwork_Razor.Data.Repository;
using System;

namespace Module_35_SocialNetwork_Razor.Data.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges(bool ensureAutoHistory = false);

        IRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = true) where TEntity : class;

    }
}
