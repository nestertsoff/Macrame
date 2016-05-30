namespace Macrame.Domain.Entities.Concrete.Items.Additional
{
    using System;

    using Macrame.Domain.Entities.Abstract;

    public class TextItem : Item<Guid>
    {
        public string Text { get; set; }
    }
}