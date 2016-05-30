﻿namespace Macrame.Domain.Entities.Abstract
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}