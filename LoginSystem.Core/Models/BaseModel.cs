﻿namespace LoginSystem.Core.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
