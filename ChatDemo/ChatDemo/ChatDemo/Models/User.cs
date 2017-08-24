﻿using ChatDemo.Data;
using System;
using SQLite;
namespace ChatDemo.Models
{
    public class BaseEntity : IEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime CreatedOnUtc
        {
            get; set;
        }

        public DateTime UpdatedOnUtc
        {
            get; set;
        }    

        public BaseEntity()
        {
            CreatedOnUtc = DateTime.UtcNow;
            UpdatedOnUtc = DateTime.UtcNow;
        }
    }

    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Name { get; set; }
    }
}
