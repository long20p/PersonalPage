using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalPage.Persistence.Repositories;
using PersonalPage.Server.Models;

namespace PersonalPage.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleRepository articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<ArticleHeadline>> GetArticles()
        {
            var articles = await articleRepository.GetAll();
            return articles.Select(x => new ArticleHeadline { Title = x.Title, ContentBrief = x.ContentBrief, UniqueId = x.UniqueId });
        }
    }
}
