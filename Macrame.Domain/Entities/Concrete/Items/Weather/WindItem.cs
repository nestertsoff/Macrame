namespace Macrame.Domain.Entities.Concrete.Items.Weather
{
    using System;

    using Macrame.Domain.Entities.Abstract;
    using Macrame.Domain.Entities.Concrete.Enums;

    public class WindItem : Item<Guid>
    {
        public float Speed { get; set; }

        public WindDirectionType WindDirectionType { get; set; }
    }
}