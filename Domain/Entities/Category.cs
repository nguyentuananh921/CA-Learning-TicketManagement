using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Category : AuditableEntity
    {
        //Properties come here
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
