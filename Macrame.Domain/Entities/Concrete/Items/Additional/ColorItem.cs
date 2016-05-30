namespace Macrame.Domain.Entities.Concrete.Items.Additional
{
    using System;

    using Macrame.Domain.Entities.Abstract;

    public class ColorItem : Item<Guid>
    {
        public byte Blue { get; set; }

        public byte Green { get; set; }

        public string Name { get; set; }

        public byte Red { get; set; }
    }
}