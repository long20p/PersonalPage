using PersonalPage.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalPage.Server.Models
{
    public class ArticleModel
    {
        public string UniqueId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ContentBrief { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
        public string CreatedDate { get; set; }

        public static ArticleModel ToModel(Article article)
        {
            if (article == null) return null;

            return new ArticleModel
            {
                UniqueId = article.UniqueId,
                Title = article.Title,
                Content = article.Content,
                ContentBrief = article.ContentBrief,
                Category = article.Category,
                Tags = article.Tags,
                CreatedDate = article.CreatedDate.ToString("f")
            };
        }
    }
}
