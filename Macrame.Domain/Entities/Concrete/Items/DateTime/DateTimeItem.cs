namespace Macrame.Domain.Entities.Concrete.Items.DateTime
{
    using System;

    using Macrame.Domain.Entities.Abstract;

    public class DateTimeItem : Item<Guid>
    {
        public DateTime BeginDate { get; set; }

        public DateTime BeginTime { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime EndTime { get; set; }
    }
}