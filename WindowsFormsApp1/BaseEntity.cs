using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker
{
    public class BaseEntity
    {
        public int Id { get; }
        protected BaseEntity(int id) => Id = id;
    }
}
