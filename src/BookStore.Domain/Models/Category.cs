using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        //category - book relationship; category could have many books
        public IEnumerable<Book> Books { get; set; }
    }
}
