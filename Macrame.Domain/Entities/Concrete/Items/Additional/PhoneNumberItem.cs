namespace Macrame.Domain.Entities.Concrete.Items.Additional
{
    using System;

    using Macrame.Domain.Entities.Abstract;
    using Macrame.Domain.Entities.Concrete.Enums;

    public class PhoneNumberItem : Item<Guid>
    {
        public int CountryCode { get; set; }

        public int Number { get; set; }

        public PhoneNumberItemType Type { get; set; }
    }
}