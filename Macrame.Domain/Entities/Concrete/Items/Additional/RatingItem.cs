namespace Macrame.Domain.Entities.Concrete.Items.Additional
{
    using System;

    using Macrame.Domain.Entities.Abstract;
    using Macrame.Domain.Entities.Concrete.Enums;

    public class RatingItem : Item<Guid>
    {
        public RatingTypeItemType Type { get; set; }

        public int Value { get; set; }
    }
}