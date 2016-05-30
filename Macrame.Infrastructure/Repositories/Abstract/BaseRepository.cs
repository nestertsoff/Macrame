namespace Macrame.Infrastructure.Repositories.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    using Macrame.Domain.Entities.Abstract;
    using Macrame.Infrastructure.Context.Abstract;

    public abstract class BaseRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        private readonly IContext db;

        protected BaseRepository(IContext db)
        {
            this.db = db;
        }

        public virtual void Create(TEntity item)
        {
            db.Entry(item).State = EntityState.Added;
        }

        public virtual void Delete(TPrimaryKey id)
        {
            db.Entry(Get(id)).State = EntityState.Deleted;
        }

        public virtual IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return db.Set<TEntity, TPrimaryKey>().Where(predicate).ToList();
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return db.Set<TEntity, TPrimaryKey>();
        }

        public virtual TEntity Get(TPrimaryKey id)
        {
            return db.Set<TEntity, TPrimaryKey>().Find(id);
        }

        public virtual void Update(TEntity item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}