using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalPage.Persistence.Models
{
    public class Category : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
