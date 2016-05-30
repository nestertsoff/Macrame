namespace Macrame.Domain.Entities.Abstract
{
    using System.Collections.Generic;

    using Macrame.Domain.Entities.Concrete;

    public class Item<TPrimaryKey> : BaseEntity<TPrimaryKey>
    {
        public ICollection<UnitConstructor> Constructors { get; set; }
    }
}