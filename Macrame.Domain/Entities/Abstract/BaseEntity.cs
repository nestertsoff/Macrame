namespace Macrame.Domain.Entities.Abstract
{
    public abstract class BaseEntity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}