namespace Macrame.Domain.Entities.Concrete.Items.Place
{
    using System;

    using Macrame.Domain.Entities.Abstract;

    public class LocationItem : Item<Guid>
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}