namespace Macrame.Domain.Entities.Concrete.Items.Additional
{
    using System;
    using System.Collections.Generic;

    using Macrame.Domain.Entities.Abstract;

    public class CategoryItem : Item<Guid>
    {
        public IEnumerable<string> Categories { get; set; }

        public string Name { get; set; }
    }
}