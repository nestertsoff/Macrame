namespace Macrame.Domain.Entities.Concrete.Items.Additional
{
    using System;

    using Macrame.Domain.Entities.Abstract;
    using Macrame.Domain.Entities.Concrete.Enums;

    public class ImageItem : Item<Guid>
    {
        public byte[] Image { get; set; }

        public ImageItemSizeType Size { get; set; }

        public ImageItemType Type { get; set; }
    }
}