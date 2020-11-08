using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalPage.Server.Models;
using PersonalPage.Server.Services;

namespace PersonalPage.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleService articleService;

        public ArticleController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<ArticleHeadline>> GetArticles()
        {
            var articles = await articleService.GetAllArticles();
            return articles.Select(x => new ArticleHeadline { Title = x.Title, ContentBrief = x.ContentBrief, UniqueId = x.UniqueId });
        }
    }
}
