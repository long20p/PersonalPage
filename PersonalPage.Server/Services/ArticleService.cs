using PersonalPage.Persistence.Models;
using PersonalPage.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPage.Server.Services
{
    public class ArticleService : IArticleService
    {
        private IArticleRepository articleRepository;
        private Random random;

        public ArticleService(IArticleRepository repository)
        {
            articleRepository = repository;
            random = new Random(DateTime.UtcNow.Millisecond);
        }

        public async Task CreateArticle(Article article)
        {
            article.UniqueId = GetUniqueId(article);
            article.CreatedDate = DateTime.UtcNow;
            await articleRepository.Add(article);
        }

        public async Task<IEnumerable<Article>> GetAllArticles()
        {
            return await articleRepository.GetAll();
        }

        public async Task<Article> GetArticle(string articleId)
        {
            return await articleRepository.GetSingle(x => x.UniqueId == articleId);
        }

        private string GetUniqueId(Article article)
        {
            var bytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(article.Title);
            var normalized = Encoding.UTF8.GetString(bytes).Replace(' ', '-').ToLower();
            normalized = normalized.Length > 50 ? normalized.Substring(0, 50) : normalized;
            var salt = random.Next(999, int.MaxValue);
            return $"{normalized}-{salt}";
        }
    }
}
