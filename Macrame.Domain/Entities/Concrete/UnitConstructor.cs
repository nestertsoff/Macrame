namespace Macrame.Domain.Entities.Concrete
{
    using System;
    using System.Collections.Generic;

    using Macrame.Domain.Entities.Abstract;
    using Macrame.Domain.Entities.Concrete.Items;
    using Macrame.Domain.Entities.Concrete.Items.Additional;
    using Macrame.Domain.Entities.Concrete.Items.DateTime;
    using Macrame.Domain.Entities.Concrete.Items.Place;

    public class UnitConstructor : BaseEntity<Guid>
    {
        //public ICollection<CategoryItem> CategoryItems { get; set; }

        //public ICollection<ColorItem> ColorItems { get; set; }

        //public ICollection<DateTimeItem> DateTimeItems { get; set; }

        //public ICollection<ImageItem> ImageItems { get; set; }

        //public ICollection<LinkItem> LinkItems { get; set; }

        //public ICollection<LocationItem> LocationItems { get; set; }

        //public ICollection<MoneyItem> MoneyItems { get; set; }

        //public ICollection<PhoneNumberItem> PhoneNumberItems { get; set; }

        //public ICollection<RatingItem> RatingItems { get; set; }

        //public ICollection<TextItem> TextItems { get; set; }

        public ICollection<Item<Guid>> Items { get; set; }
    }
}