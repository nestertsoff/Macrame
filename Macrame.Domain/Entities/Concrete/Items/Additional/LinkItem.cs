namespace Macrame.Domain.Entities.Concrete.Items.Additional
{
    using System;

    using Macrame.Domain.Entities.Abstract;

    public class LinkItem : Item<Guid>
    {
        public string Description { get; set; }

        public string Link { get; set; }
    }
}