﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Models
{
    public class Book : Entity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public DateTime PublishDate { get; set; }
        public int CategoryId { get; set; }

        // book - category relationship: each book belongs to a category
        public Category Category { get; set; }
    }
}