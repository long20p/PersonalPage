﻿using PersonalPage.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalPage.Server.Models
{
    public class ArticleHeadline
    {
        public string UniqueId { get; set; }
        public string Title { get; set; }
        public string ContentBrief { get; set; }
        public string CreatedDate { get; set; }

        public static ArticleHeadline ToHeadline(Article article)
        {
            if (article == null) return null;

            return new ArticleHeadline
            {
                UniqueId = article.UniqueId,
                Title = article.Title,
                ContentBrief = article.ContentBrief,
                CreatedDate = article.CreatedDate.ToString("d MMMM yyyy")
            };
        }
    }
}
