namespace Macrame.Infrastructure.Repositories.Abstract
{
    using System;
    using System.Collections.Generic;

    using Macrame.Domain.Entities.Abstract;

    public interface IRepository<TEntity, in TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        void Create(TEntity item);

        void Delete(TPrimaryKey id);

        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);

        IEnumerable<TEntity> Get();

        TEntity Get(TPrimaryKey id);

        void Update(TEntity item);
    }
}