namespace Macrame.Infrastructure.Context.Abstract
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Macrame.Domain.Entities.Abstract;

    public interface IContext
    {
        void Dispose();

        DbEntityEntry Entry(object entity);

        int SaveChanges();

        IDbSet<TEntity> Set<TEntity, TPrimaryKey>() where TEntity : class, IEntity<TPrimaryKey>;
    }
}