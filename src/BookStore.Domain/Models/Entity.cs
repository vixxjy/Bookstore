using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Models
{
    public abstract class Entity
    {
        //difference between an abstract and interface class: abstract could contain logics while interface are just methods or properties defined
        public int Id { get; set; }
    }
}
