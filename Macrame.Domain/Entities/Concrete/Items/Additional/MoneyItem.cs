namespace Macrame.Domain.Entities.Concrete.Items.Additional
{
    using System;

    using Macrame.Domain.Entities.Abstract;
    using Macrame.Domain.Entities.Concrete.Enums;

    public class MoneyItem : Item<Guid>
    {
        public CurrencyItemType Currency { get; set; }
    }
}