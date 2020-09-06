using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalPage.Persistence.Models
{
    public class Article : BaseEntity
    {
        public string UniqueId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ContentBrief { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
    }
}
